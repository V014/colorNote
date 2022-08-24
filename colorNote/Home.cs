using System.Windows.Forms;
using System;
using System.Drawing;
using System.Globalization;

namespace colorNote
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        // check current date and time
        private string currentDate = DateTime.Today.ToString("d");
        int month, year;
        //private readonly MaterialSkinManager materialSkinManager;
        public Home()
        {
            InitializeComponent();
            updateDate();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            displayDays();
            // check current mood
            if (checkMood() != "")
            {
                lbl_mood.Text = checkMood();
                //setTheme(checkMood());
            }
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label_month_year.Text = monthname + " " + year;
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
            //setTheme("Very Bad");
        }

        private void orangeBtn_Click(object sender, System.EventArgs e)
        {
            record("Bad", datePicker.Text);
            //setTheme("Bad");
        }

        private void yellowBtn_Click(object sender, System.EventArgs e)
        {
            record("Ok", datePicker.Text);
            //setTheme("Ok");
        }

        private void greenBtn_Click(object sender, System.EventArgs e)
        {
            record("Good", datePicker.Text);
            //setTheme("Good");
        }

        private void blueBtn_Click(object sender, System.EventArgs e)
        {
            record("Very Good", datePicker.Text);
            //setTheme("Very Good");
        }

        private void default_btn_Click(object sender, EventArgs e)
        {

            record("Default", currentDate);
            //setTheme("Default");
        }
        // pulls data from that specific date
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            string cmd = "SELECT Mood FROM Records WHERE Date = '" + datePicker.Text + "'";
            string mood = Connection.ReadString(cmd);
            if(mood == "")
            {
                //setTheme("Default");
            }
            else
            {
                //setTheme(mood);
                record(mood, datePicker.Text);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            panel_day.Controls.Clear();
            // decrement month to go to previous month
            month--;
            // display the month and year
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label_month_year.Text = monthname + " " + year;
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

        private void button_next_Click(object sender, EventArgs e)
        {
            panel_day.Controls.Clear();
            month++;
            // display the month and year
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label_month_year.Text = monthname + " " + year;
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
