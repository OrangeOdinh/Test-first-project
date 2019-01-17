using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class Form3 : Form
    {
        #region properties
        private int Hour_DN;
        private int Min_DN;
        private int Sec_DN;
        private bool flagDG = false;
        #endregion

        #region methods
        public Form3()
        {
            InitializeComponent();
        }

        private void tbHour_DG_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(tbHour_DG.Text) < 0)
                {
                    MessageBox.Show("Nhập chính xác số giờ!!!");
                }
                else
                {
                    Hour_DN = Convert.ToInt32(tbHour_DG.Text);
                    lbHour_DG.Text = Hour_DN.ToString("D2");
                }
            }
        }

        private void tbMin_DG_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(tbMin_DG.Text) <= 0 || Convert.ToInt32(tbMin_DG.Text) >= 59)
                {
                    MessageBox.Show("Nhập chính xác số phút!!!");
                }
                else
                {
                    Min_DN = Convert.ToInt32(tbMin_DG.Text);
                    lbMin_DG.Text = Min_DN.ToString("D2");
                }
            }
        }

        private void tbSec_DN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(tbSec_DG.Text) <= 0 || Convert.ToInt32(tbSec_DG.Text) >= 59)
                {
                    MessageBox.Show("Nhập chính xác số giây!!!");
                }
                else
                {
                    Sec_DN = Convert.ToInt32(tbSec_DG.Text);
                    lbSec_DG.Text = Sec_DN.ToString("D2");
                }
            }
        }

        private void btStart_DG_Click(object sender, EventArgs e)
        {
            if (tbSec_DG.Text == "")
            {
                Sec_DN = 0;
            }
            if (tbMin_DG.Text == "")
            {
                Min_DN = 0;
            }
            if (tbHour_DG.Text == "")
            {
                Hour_DN = 0;
            }
            timer_DG.Start();
            flagDG = true;
        }

        private void btStop_DG_Click(object sender, EventArgs e)
        {
            timer_DG.Stop();
            flagDG = false;
        }

        private void btReset_DG_Click(object sender, EventArgs e)
        {
            if(flagDG == true)
            {
                timer_DG.Stop();
            }

            tbHour_DG.Text = "";
            tbMin_DG.Text = "";
            tbSec_DG.Text = "";
            lbSec_DG.Text = "00";
            lbMin_DG.Text = "00";
            lbHour_DG.Text = "00";
            Hour_DN = 0;
            Min_DN = 0;
            Sec_DN = 0;
        }

        private void btReturn_DG_Click(object sender, EventArgs e)
        {

            if (tbHour_DG.Text == "")
            {
                Hour_DN = 0;
                lbHour_DG.Text = "00";
            }
            else
            {
                Hour_DN = Convert.ToInt32(tbHour_DG.Text);
                lbHour_DG.Text = Hour_DN.ToString("D2");
            }
            if (tbMin_DG.Text == "")
            {
                Min_DN = 0;
                lbMin_DG.Text = "00";
            }
            else
            {
                Min_DN = Convert.ToInt32(tbMin_DG.Text);
                lbMin_DG.Text = Min_DN.ToString("D2");
            }
            if (tbSec_DG.Text == "")
            {
                Sec_DN = 0;
                tbSec_DG.Text = "00";
            }
            else
            {
                Sec_DN = Convert.ToInt32(tbSec_DG.Text);
                lbMin_DG.Text = Sec_DN.ToString("D2");
            }
        }

        private void timer_DG_Tick(object sender, EventArgs e)
        {

            if (Sec_DN > 0)
            {
                Sec_DN--;
                lbSec_DG.Text = Sec_DN.ToString("D2");
            }
            else
            {

                if (Min_DN > 0)
                {
                    Min_DN--;
                    lbMin_DG.Text = Min_DN.ToString("D2");
                    Sec_DN = 59;
                    lbSec_DG.Text = Sec_DN.ToString("D2");
                }
                else
                {
                    if (Hour_DN > 0)
                    {
                        Sec_DN = 59;
                        lbSec_DG.Text = Sec_DN.ToString("D2");
                        Min_DN = 59;
                        lbMin_DG.Text = Min_DN.ToString("D2");
                        Hour_DN--;
                        lbHour_DG.Text = Hour_DN.ToString("D2");
                    }
                    else
                    {
                        System.Media.SoundPlayer player =
                        new System.Media.SoundPlayer("Ambao.wav");
                        player.Play();
                        timer_DG.Stop();
                    }
                }

            }
        }
        #endregion
    }
}
