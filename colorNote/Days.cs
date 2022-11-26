using System;
using System.Windows.Forms;

namespace colorNote
{
    public partial class Days : UserControl
    {
        public Days()
        {
            InitializeComponent();
        }

        private void Days_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            button_day.Text = numday + "";
        }
    }
}
