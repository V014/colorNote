using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;

namespace colorNote
{
    public partial class Home : MaterialForm
    {
        // check current date and time
        private string currentDate = DateTime.Today.ToString("d");
        private readonly MaterialSkinManager materialSkinManager;
        public Home()
        {
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            // update session time
            updateDate();
            // check current mood
            if(checkMood() != "")
            {
                lbl_mood.Text = checkMood();
                setTheme(checkMood());
            }
            
        }
        // updates the session and returns nothing
        void updateDate()
        {
            // update date
            string cmd = "UPDATE Session SET Date = '" + currentDate + "' WHERE id = 1";
            Connection.ExecuteQuery(cmd);
        }
        // pull the mood of the day
        private string checkMood()
        {
            string cmd = "SELECT Mood FROM Records WHERE date = '" + currentDate + "'";
            string mood = Connection.ReadString(cmd);
            return mood;
        }
        // sets the theme of the ui
        private void setTheme(string mood)
        {
            switch (mood)
            {
                case "Very Bad":
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
                    lbl_note.ForeColor = Color.White;
                    lbl_mood.ForeColor = Color.FromArgb(198, 40, 40);
                    lbl_mood.Text = "Very Bad";
                    break;
                case "Bad":
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.BLACK);
                    lbl_note.ForeColor = Color.FromArgb(37, 37, 39);
                    lbl_mood.ForeColor = Color.FromArgb(239, 108, 0);
                    lbl_mood.Text = "Bad";
                    break;
                case "Ok":
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow800, Primary.Yellow900, Primary.Yellow500, Accent.Yellow200, TextShade.BLACK);
                    lbl_note.ForeColor = Color.FromArgb(37, 37, 39);
                    lbl_mood.ForeColor = Color.FromArgb(249, 168, 37);
                    lbl_mood.Text = "Ok";
                    break;
                case "Good":
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
                    lbl_note.ForeColor = Color.White;
                    lbl_mood.ForeColor = Color.FromArgb(46, 125, 50);
                    lbl_mood.Text = "Good";
                    break;
                case "Very Good":
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
                    lbl_note.ForeColor = Color.White;
                    lbl_mood.ForeColor = Color.FromArgb(21, 101, 192);
                    lbl_mood.Text = "Very Good";
                    break;
                default:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    lbl_note.ForeColor = Color.White;
                    lbl_mood.ForeColor = Color.FromArgb(55, 71, 79);
                    lbl_mood.Text = "Default";
                    break;
            }
        }
        // takes in the mood and date to record
        private void record(string mood, string selectedDate)
        {
            // check to see if the user has already recorded.
            string checkSession = "SELECT Mood FROM Records WHERE date = '" + selectedDate + "'";
            string session = Connection.ReadString(checkSession);
            try
            {
                if (session != "")
                {
                    string cmd = "UPDATE Records SET Mood = '" + mood + "' WHERE date = '" + selectedDate + "'";
                    Connection.ExecuteQuery(cmd);
                }
                else
                {
                    string cmd = "INSERT INTO Records(Date, Mood) VALUES('" + selectedDate + "', '" + mood + "')";
                    Connection.ExecuteQuery(cmd);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to record!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // reactions to user clicks
        private void redBtn_Click(object sender, System.EventArgs e)
        {
            record("Very Bad", datePicker.Text);
            setTheme("Very Bad");
        }

        private void orangeBtn_Click(object sender, System.EventArgs e)
        {
            record("Bad", datePicker.Text);
            setTheme("Bad");
        }

        private void yellowBtn_Click(object sender, System.EventArgs e)
        {
            record("Ok", datePicker.Text);
            setTheme("Ok");
        }

        private void greenBtn_Click(object sender, System.EventArgs e)
        {
            record("Good", datePicker.Text);
            setTheme("Good");
        }

        private void blueBtn_Click(object sender, System.EventArgs e)
        {
            record("Very Good", datePicker.Text);
            setTheme("Very Good");
        }

        private void default_btn_Click(object sender, EventArgs e)
        {

            record("Default", currentDate);
            setTheme("Default");
        }
        // pulls data from that specific date
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            string cmd = "SELECT Mood FROM Records WHERE Date = '" + datePicker.Text + "'";
            string mood = Connection.ReadString(cmd);
            if(mood == "")
            {
                setTheme("Default");
            }
            else
            {
                setTheme(mood);
                record(mood, datePicker.Text);
            }
            
        }
    }
}
