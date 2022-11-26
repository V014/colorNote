using System.Windows.Forms;
using System;
using System.Drawing;
using System.Globalization;

namespace colorNote
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection();
        // check current date and time
        private string currentDate = DateTime.Today.ToString("d");
        int month, year;
        //private readonly MaterialSkinManager materialSkinManager;
        public Home()
        {
            InitializeComponent();
            updateDate();
        }
        // what happens when the application loads
        private void Home_Load(object sender, EventArgs e)
        {
            displayDays();
            // check current mood
            if (checkMood() != "")
            {
                // set the style according to the mood
                setStyle(checkMood());
            }
        }
        // sets the style of the application according to the mood
        private void setStyle(string mood)
        {
            switch (mood)
            {
                case "Very Bad":
                    this.Style = MetroFramework.MetroColorStyle.Red;
                    datePicker.Style = MetroFramework.MetroColorStyle.Red;
                    lbl_monthYear.ForeColor = Color.Crimson;
                    lbl_mood.ForeColor = Color.Crimson;
                    lbl_mood.Text = "Very Bad";
                    break;
                case "Bad":
                    this.Style = MetroFramework.MetroColorStyle.Orange;
                    datePicker.Style = MetroFramework.MetroColorStyle.Orange;
                    lbl_monthYear.ForeColor = Color.FromArgb(243, 119, 53);
                    lbl_mood.ForeColor = Color.FromArgb(243, 119, 53);
                    lbl_mood.Text = "Bad";
                    break;
                case "Ok":
                    this.Style = MetroFramework.MetroColorStyle.Yellow;
                    datePicker.Style = MetroFramework.MetroColorStyle.Yellow;
                    lbl_monthYear.ForeColor = Color.FromArgb(255, 196, 37);
                    lbl_mood.ForeColor = Color.FromArgb(255, 196, 37);
                    lbl_mood.Text = "Ok";
                    break;
                case "Good":
                    this.Style = MetroFramework.MetroColorStyle.Green;
                    datePicker.Style = MetroFramework.MetroColorStyle.Green;
                    lbl_monthYear.ForeColor = Color.MediumSeaGreen;
                    lbl_mood.ForeColor = Color.MediumSeaGreen;
                    lbl_mood.Text = "Good";
                    break;
                case "Very Good":
                    this.Style = MetroFramework.MetroColorStyle.Blue;
                    datePicker.Style = MetroFramework.MetroColorStyle.Blue;
                    lbl_monthYear.ForeColor = Color.FromArgb(21, 101, 192);
                    lbl_mood.ForeColor = Color.FromArgb(21, 101, 192);
                    lbl_mood.Text = "Very Good";
                    break;
                default:
                    this.Style = MetroFramework.MetroColorStyle.Silver;
                    datePicker.Style = MetroFramework.MetroColorStyle.Silver;
                    lbl_monthYear.ForeColor = Color.White;
                    lbl_mood.ForeColor = Color.White;
                    lbl_mood.Text = "Default";
                    break;
            }
        }
        // displays the days according to the calendar
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_monthYear.Text = monthname + " " + year;
            // get first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);
            // get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            // covert the start of the month to integer
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            // applies bank days to calendar
            for (int i = 1; i < daysoftheweek; i++)
            {
                Blanks blanks = new Blanks();
                panel_day.Controls.Add(blanks);
            }
            // applies days to calendar
            for(int i = 1; i <= days; i++)
            {
                Days day = new Days();
                day.days(i);
                panel_day.Controls.Add(day);
                if (checkMood() != "")
                {
                    day.panel_color.BackColor = Color.Crimson;
                }
            }
        }
        // updates the session and returns nothing
        void updateDate()
        {
            // update date
            string cmd = $"UPDATE Session SET Date = '{currentDate}' WHERE id = 1";
            Connection.ExecuteQuery(cmd);
        }
        // pull the mood of the day
        private string checkMood()
        {
            string mood = con.ReadString($"SELECT Mood FROM Records WHERE date = '{currentDate}'");
            return mood;
        }
        // takes in the mood and date to record
        private void record(string mood, string selectedDate)
        {
            // check to see if the user has already recorded.
            string session = con.ReadString($"SELECT Mood FROM Records WHERE date = '{selectedDate}'");
            try
            {
                if (session != "")
                {
                    string cmd = $"UPDATE Records SET Mood = '{mood}' WHERE date = '{selectedDate}'";
                    Connection.ExecuteQuery(cmd);
                }
                else
                {
                    string cmd = $"INSERT INTO Records(Date, Mood) VALUES('{selectedDate}', '{mood}')";
                    Connection.ExecuteQuery(cmd);
                }
                lbl_mood.Text = mood;
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to record!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // reactions to user clicks
        private void redBtn_Click(object sender, System.EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Red;
            datePicker.Style = MetroFramework.MetroColorStyle.Red;
            record("Very Bad", datePicker.Text);
            lbl_mood.ForeColor = Color.Crimson;
            lbl_monthYear.ForeColor = Color.Crimson;
            this.Refresh();
        }
        private void orangeBtn_Click(object sender, System.EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Orange;
            datePicker.Style = MetroFramework.MetroColorStyle.Orange;
            record("Bad", datePicker.Text);
            lbl_mood.ForeColor = Color.FromArgb(239, 108, 0);
            lbl_monthYear.ForeColor = Color.FromArgb(239, 108, 0);
            this.Refresh();
        }
        private void yellowBtn_Click(object sender, System.EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            datePicker.Style = MetroFramework.MetroColorStyle.Yellow;
            record("Ok", datePicker.Text);
            lbl_mood.ForeColor = Color.Yellow;
            lbl_monthYear.ForeColor = Color.Yellow;
            this.Refresh();
        }
        private void greenBtn_Click(object sender, System.EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Green;
            datePicker.Style = MetroFramework.MetroColorStyle.Green;
            record("Good", datePicker.Text);
            lbl_mood.ForeColor = Color.MediumSeaGreen;
            lbl_monthYear.ForeColor = Color.MediumSeaGreen;
            this.Refresh();
        }
        private void blueBtn_Click(object sender, System.EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Blue;
            record("Very Good", datePicker.Text);
            lbl_mood.ForeColor = Color.FromArgb(0, 174, 219);
            lbl_monthYear.ForeColor = Color.FromArgb(0, 174, 219);
            this.Refresh();
        }
        private void default_btn_Click(object sender, EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Silver;
            datePicker.Style = MetroFramework.MetroColorStyle.Silver;
            record("Default", currentDate);
            lbl_mood.ForeColor = Color.Silver;
            lbl_monthYear.ForeColor = Color.Silver;
            this.Refresh();
        }
        // pulls data from that specific date
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            string mood = con.ReadString($"SELECT Mood FROM Records WHERE Date = '{datePicker.Text}'");
            if(mood != "")
            {
                // set the style according to the mood
                setStyle(mood);
            }
            else
            {
                this.Style = MetroFramework.MetroColorStyle.Silver;
                datePicker.Style = MetroFramework.MetroColorStyle.Silver;
                lbl_monthYear.ForeColor = Color.White;
                lbl_mood.ForeColor = Color.White;
                lbl_mood.Text = "Default";
            }
        }
        // button back click
        private void button_back_Click(object sender, EventArgs e)
        {
            panel_day.Controls.Clear();
            // decrement month to go to previous month
            month--;
            // display the month and year
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_monthYear.Text = monthname + " " + year;
            // get first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);
            // get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            // covert the start of the month to integer
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            // applies bank days to calendar
            for (int i = 1; i < daysoftheweek; i++)
            {
                Blanks blanks = new Blanks();
                panel_day.Controls.Add(blanks);
            }
            // applies days to calendar
            for (int i = 1; i <= days; i++)
            {
                Days day = new Days();
                day.days(i);
                panel_day.Controls.Add(day);
            }
        }
        // button next click
        private void button_next_Click(object sender, EventArgs e)
        {
            panel_day.Controls.Clear();
            month++;
            // display the month and year
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_monthYear.Text = monthname + " " + year;
            // get first day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);
            // get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            // covert the start of the month to integer
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            // applies bank days to calendar
            for (int i = 1; i < daysoftheweek; i++)
            {
                Blanks blanks = new Blanks();
                panel_day.Controls.Add(blanks);
            }
            // applies days to calendar
            for (int i = 1; i <= days; i++)
            {
                Days day = new Days();
                day.days(i);
                panel_day.Controls.Add(day);
            }
        }
    }
}
