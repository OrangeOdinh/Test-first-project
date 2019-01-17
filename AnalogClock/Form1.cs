using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AnalogClock
{
    public partial class Form1 : Form
    {
        #region properties
        //Ve dong ho
        private int centerX = 100;
        private int centerY = 100;
        private int radius = 100;
        public int CenterX { get => centerX; set => centerX = value; }
        public int CenterY { get => centerY; set => centerY = value; }
        public int Radius { get => radius; set => radius = value; }


        //bao thuc
        private ListAlarm lAlarm;
        public ListAlarm LAlarm { get => lAlarm; set => lAlarm = value; }

        private string filePath = "DataStorage.xml";
        FlowLayoutPanel fpanel = new FlowLayoutPanel();

        #endregion

        #region methods
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            try
            {
                LAlarm = DeserializeToXML(filePath) as ListAlarm;
            }
            catch
            {
                LAlarm = new ListAlarm();
                LAlarm.LAlarms = new List<Alarm>();
            }
            finally
            {
                createForm();        
            }
            showData();
           
        }

        public void showData()
        {
            fpanel.Width = pnelAlarm.Width;
            fpanel.Height = pnelAlarm.Height;
            pnelAlarm.Controls.Add(fpanel);
            if (LAlarm != null && LAlarm.LAlarms != null)
            {
                for (int i = 0; i < LAlarm.LAlarms.Count; i++)
                {
                    ALarmControl al = new ALarmControl();
                    al.Alarms = LAlarm.LAlarms[i];
                    al.Deleted += Al_Deleted;
                    al.show();
                    fpanel.Controls.Add(al);
                }
            }
           
        }

       
        public void createForm()    //Tạo khu vực nhập lịch mới
        {
            AddAlarmControl al2 = new AddAlarmControl();
            al2.Added += Al2_Added;
            fpanel.Controls.Add(al2);
        }
        private void Al2_Added(object sender, EventArgs e)
        {
            AddAlarmControl sder = sender as AddAlarmControl;
            Alarm alarm = sder.Alarms;
            LAlarm.LAlarms.Add(alarm);
            fpanel.Controls.Clear();
            createForm();
            showData();
        }

        private void Al_Deleted(object sender, EventArgs e)
        {
            ALarmControl sder = sender as ALarmControl;
            Alarm alarm = sder.Alarms;
            fpanel.Controls.Remove(sder);
            LAlarm.LAlarms.Remove(alarm);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelClock.Invalidate();
            lbHour_Clock.Text = (DateTime.Now).ToString(@"hh:mm:ss tt");
            checkAlarm();
        }

        private void panelClock_Paint(object sender, PaintEventArgs e)
        {
            DateTime now = DateTime.Now;
            float x;
            float y;
            //Vẽ Kim Giây
            clockWork(now.Second, radius, .80,out x,out y);

            Pen spen = new Pen(Color.Red, 2f);
            e.Graphics.DrawLine(spen, centerX, centerY, x, y);
            spen.Dispose();

            //Vẽ Kim phút
            clockWork(now.Minute, radius, .65,out x,out y);

            Pen mpen = new Pen(Color.Violet, 4f);
            e.Graphics.DrawLine(mpen, centerX, centerY, x, y);
            mpen.Dispose();

            //Vẽ Kim Giờ
            clockWork(now.Hour % 12 * 5 + now.Minute / 12, radius, .70, out x, out y);

            Pen hpen = new Pen(Color.Black, 5f);
            e.Graphics.DrawLine(hpen, centerX, centerY, x, y);
            hpen.Dispose();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="time"></param>
        /// <param name="radius">Bán kính đồng hồ</param>
        /// <param name="shortedHand">Tỉ Lệ rút ngắn kim</param>
        /// <param name="xPosition">tọa độ kim</param>
        /// <param name="yPosition">tọa độ của kim</param>
        private void clockWork(int time, int radius,double shortedHand, out float xPosition, out float yPosition)
        {
            double x = 0;
            double y = 0;
            int angleHand = 0;  //góc của kim

            //tính góc
            if (time < 15)
            {
                angleHand = 90 - (time * 6);
            }
            else if (time < 30)
            {
                angleHand = 360 - (time % 15) * 6;
            }
            else if (time < 45)
            {
                angleHand = 270 - (time % 15) * 6;
            }
            else if (time < 60)
            {
                angleHand = 180 - (time % 15) * 6;
            }

            double radianAngle = angleHand * (Math.PI / 180);
            x = radius + (Math.Cos(radianAngle) * radius * shortedHand);
            y = radius - (Math.Sin(radianAngle) * radius * shortedHand);

            xPosition = Convert.ToSingle(x);
            yPosition = Convert.ToSingle(y);
        }
        private void toolstripBG_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void toolstripDN_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            XmlSerializer xw = new XmlSerializer(typeof(ListAlarm));
            xw.Serialize(fs, data);

            fs.Close();
        }
        public object DeserializeToXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer xr = new XmlSerializer(typeof(ListAlarm));
                object result = xr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch (Exception)
            {
                fs.Close();
                throw new NotImplementedException();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(this.LAlarm, filePath);
        }
     
       
        private void checkAlarm()
        {
            DateTime nn = DateTime.Now;
            int day = 0;
            switch (nn.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    day = 0;
                    break;
                case DayOfWeek.Monday:
                    day = 1;
                    break;
                case DayOfWeek.Tuesday:
                    day = 2;
                    break;
                case DayOfWeek.Wednesday:
                    day = 3;
                    break;
                case DayOfWeek.Thursday:
                    day = 4;
                    break;
                case DayOfWeek.Friday:
                    day = 5;
                    break;
                case DayOfWeek.Saturday:
                    day = 6;
                    break;
            }

            Alarm a = new Alarm();

            foreach (Alarm item in LAlarm.LAlarms)
            {
                if (item.TimeAlarm.X == nn.Hour && item.TimeAlarm.Y == nn.Minute && item.DayAlarm[day] == 1 && nn.Second < 1)
                {
                    a = item;
                    SoundPlayer splayer =
                          new SoundPlayer("Ambao.wav");
                    splayer.Play();
                    break;
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                ShowIcon = true;
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(2000);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipText = "Application minimized!";
            notifyIcon1.BalloonTipTitle = @"#Eskaylation";
        }
    }
    #endregion
}
