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
    public partial class Form2 : Form
    {
        #region properties
        private bool fstart;
        private int Hour_BG;
        private int Min_BG;
        private int Sec_BG;
        #endregion

        #region methods
        public Form2()
        {
            InitializeComponent();
        }

        private void btStart_BG_Click(object sender, EventArgs e)
        {
            if (!fstart)
            {
                timer_BG.Start();
                btStart_BG.Text = "Stop";
                fstart = !fstart;
            }
            else
            {
                timer_BG.Stop();
                btStart_BG.Text = "Start";
                fstart = !fstart;
                lbResult_BG.Text = "result: " + Hour_BG.ToString("d2")
                                + ":" + Min_BG.ToString("d2") + ":" + Sec_BG.ToString("d2");
            }

        }

        private void btReset_BG_Click(object sender, EventArgs e)
        {
            Hour_BG = 0;
            Min_BG = 0;
            Sec_BG = 0;
            lbHour_BG.Text = "00";
            lbMin_BG.Text = "00";
            lbSec_BG.Text = "00";
            lbResult_BG.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fstart = false;
            btStart_BG.Text = "start";
            Hour_BG = 0;
            Min_BG = 0;
            Sec_BG = 0;
        }

        private void timer_BG_Tick(object sender, EventArgs e)
        {

            if (Sec_BG < 59)
            {
                Sec_BG++;
                lbSec_BG.Text = Sec_BG.ToString("D2");
            }
            else
            {
                Sec_BG = 0;
                lbSec_BG.Text = Sec_BG.ToString("D2");
                if (Min_BG < 59)
                {
                    Min_BG++;
                    lbMin_BG.Text = Min_BG.ToString("D2");
                }
                else
                {
                    Min_BG = 0;
                    lbMin_BG.Text = Min_BG.ToString("D2");
                    Hour_BG++;
                    lbHour_BG.Text = Hour_BG.ToString("D2");
                }
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!fstart)
                {
                    timer_BG.Start();
                    btStart_BG.Text = "Stop";
                    fstart = !fstart;
                }
                else
                {
                    timer_BG.Stop();
                    btStart_BG.Text = "Start";
                    fstart = !fstart;
                    lbResult_BG.Text = "Result: " + Hour_BG.ToString("D2")
                                    + ":" + Min_BG.ToString("D2") + ":" + Sec_BG.ToString("D2");
                }
            }
        }
        #endregion
    }
}
