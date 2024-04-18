using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordTimestamp
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private int lastValidHour;
        private int lastValidMinute;
        private DateTime UnixEpoch;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            DateTime rightNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0, DateTimeKind.Local);
            UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            if (rightNow.Hour == 0)
            {
                lastValidHour = rightNow.Hour + 12;
            }else if(rightNow.Hour < 13)
            {
                lastValidHour = rightNow.Hour;
            }
            else
            {
                lastValidHour = rightNow.Hour - 12;
            }
            lastValidMinute = rightNow.Minute;

            HourBox.Text = lastValidHour.ToString();
            MinuteBox.Text = lastValidMinute.ToString("00");
            MeridianBox.SelectedIndex = (rightNow.Hour / 12);

            dateTimePicker.Value = rightNow;

            Point mousePosition = Cursor.Position;

            this.Location = new Point(mousePosition.X, MousePosition.Y - this.Height);
        }

        private void IncludeDateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (IncludeDateCheckbox.Checked)
            {
                ActiveForm.Height = 168;
                dateTimePicker.Enabled = true;
            }
            else
            {
                ActiveForm.Height = 116;
                dateTimePicker.Enabled = false;
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            int hour = 0;
            int textBoxHour = int.Parse(HourBox.Text);
            if (MeridianBox.SelectedIndex == 0)
            {
                hour = textBoxHour % 12;
            }
            else if(textBoxHour == 12)
            {
                hour = textBoxHour;
            }
            else
            {
                hour = textBoxHour + 12;
            }
            DateTime result = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, hour, int.Parse(MinuteBox.Text), 0, DateTimeKind.Local).ToUniversalTime();
            int numberOfSeconds = (int) (result.Subtract(UnixEpoch).TotalSeconds);

            string clipboardString = "<t:" + numberOfSeconds.ToString();
            if (IncludeDateCheckbox.Checked)
            {
                clipboardString += ":F>";
            }
            else
            {
                clipboardString += ":t>";
            }
            Clipboard.SetDataObject(clipboardString);
        }

        private void HourBox_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            if(!int.TryParse(HourBox.Text, out result) || result < 1 || result > 12)
            {
                HourBox.Text = lastValidHour.ToString();
            }
            else
            {
                lastValidHour = result;
            }
        }

        private void MinuteBox_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            if (!int.TryParse(MinuteBox.Text, out result) || result < 0 || result > 59)
            {
                MinuteBox.Text = lastValidMinute.ToString();
            }
            else
            {
                lastValidMinute = result;
            }
        }
    }
}
