using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace DiscordTimestamp
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private int lastValidHour;
        private int lastValidMinute;
        private int lastDropdownIndex;
        private DateTime UnixEpoch;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            DateTime rightNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0, DateTimeKind.Local);
            UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            string pattern = @"^(?<openAMPM>\s*t+\s*)? " +
                         @"(?(openAMPM) h+(?<nonHours>[^ht]+)$ " +
                         @"| \s*h+(?<nonHours>[^ht]+)\s*t+)";

            if (!Regex.IsMatch(CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern, pattern, RegexOptions.IgnorePatternWhitespace))
            {
                //24 hour time
                lastValidHour = rightNow.Hour;
                MeridianBox.SelectedIndex = 2;
            }
            else if (rightNow.Hour == 0)
            {
                lastValidHour = rightNow.Hour + 12;
                MeridianBox.SelectedIndex = 0;
            }
            else if(rightNow.Hour < 13)
            {
                lastValidHour = rightNow.Hour;
                MeridianBox.SelectedIndex = 0;
            }
            else
            {
                lastValidHour = rightNow.Hour - 12;
                MeridianBox.SelectedIndex = 1;
            }
            lastValidMinute = rightNow.Minute;

            lastDropdownIndex = MeridianBox.SelectedIndex;

            HourBox.Text = lastValidHour.ToString();
            MinuteBox.Text = lastValidMinute.ToString("00");

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
            if (!int.TryParse(MinuteBox.Text, out int minute) || minute < 0 || minute > 59)
            {
                MessageBox.Show("Minute value is not valid.", "Error", MessageBoxButtons.OK);
                return;
            }


            int hour;
            if (!int.TryParse(HourBox.Text, out int textBoxHour))
            {
                MessageBox.Show("Hour value is not valid.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (MeridianBox.SelectedIndex == 2)
            {
                if (textBoxHour < 0 || textBoxHour > 23)
                {
                    MessageBox.Show("Hour value is not valid.", "Error", MessageBoxButtons.OK);
                    return;
                }
                hour = textBoxHour;
            }
            else
            {
                if (textBoxHour < 1 || textBoxHour > 12)
                {
                    MessageBox.Show("Hour value is not valid.", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (MeridianBox.SelectedIndex == 0)
                {
                    hour = textBoxHour % 12;
                }
                else if (textBoxHour == 12)
                {
                    hour = textBoxHour;
                }
                else
                {
                    hour = textBoxHour + 12;
                }
            }
            DateTime result = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, hour, minute, 0, DateTimeKind.Local).ToUniversalTime();
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

        private void HourBox_Enter(object sender, EventArgs e)
        {
            HourBox.SelectAll();
        }

        private void HourBox_Click(object sender, EventArgs e)
        {
            HourBox.SelectAll();
        }

        private void MinuteBox_Enter(object sender, EventArgs e)
        {
            MinuteBox.SelectAll();
        }

        private void MinuteBox_Click(object sender, EventArgs e)
        {
            MinuteBox.SelectAll();
        }

        private void HourBox_TextChanged(object sender, EventArgs e)
        {
            if(HourBox.Text.Length == 0)
            {
                lastValidHour = 0;
            }
            else if (int.TryParse(HourBox.Text, out int result))
            {
                lastValidHour = result;
            }
            else
            {
                HourBox.Text = lastValidHour.ToString();
            }
        }

        private void MinuteBox_TextChanged(object sender, EventArgs e)
        {
            if (MinuteBox.Text.Length == 0)
            {
                lastValidMinute = 0;
            }
            else if (int.TryParse(MinuteBox.Text, out int result))
            {
                lastValidMinute = result;
            }
            else
            {
                MinuteBox.Text = lastValidMinute.ToString();
            }
        }
    }
}
