using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public static Form1 frmm = new Form1();
        Stopwatch oSW = new Stopwatch();
        int peli1 = 0, peli2 = 0, peli3 = 0;
        
        public Form2()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("candi1.png");
            pictureBox2.Image = Image.FromFile("candi2.png");
            pictureBox3.Image = Image.FromFile("candi3.png");         
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            oSW.Start();
            timer1.Enabled = true;

            DrawPieChart(peli1, peli2, peli3);

            if (txtusuario.Text == "walter22")
            {
                pictureBox4.Image = Image.FromFile("img1.png");
            }
            else if (txtusuario.Text == "j0s3")
            {
                pictureBox4.Image = Image.FromFile("img2.png");
            }
            else if (txtusuario.Text == "xmariox")
            {
                pictureBox4.Image = Image.FromFile("img3.png");
            }
            else if (txtusuario.Text == "ana420")
            {
                pictureBox4.Image = Image.FromFile("img4.png");
            }
            else if (txtusuario.Text == "bleshin")
            {
                pictureBox4.Image = Image.FromFile("img5.png");
            }
            else if (txtusuario.Text == "")
            {
                pictureBox4.Image = Image.FromFile("img7.png");
            }

        }

        public void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)oSW.ElapsedMilliseconds);

            txtMin.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            txtSeg.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();

            frmm.txtMin.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            frmm.txtSeg.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();

            if(txtMin.Text=="15"&&txtSeg.Text=="00")
            {
                frmm.Hide();
                this.Show();
                txtMin.BackColor = Color.Red;
                txtSeg.BackColor = Color.Red;
                BlockVote();
                btnexit.Enabled = false;
                tabControl1.Enabled = false;
                tabControl1.SelectTab(tabPage2);
                oSW.Stop();
            }
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            pictureBox4.Image = Image.FromFile("img7.png");
            tabControl1.SelectTab(tabPage1);
            frmm.Show();
            this.Hide();
            EnableVote();
        }

        public void BlockVote()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }
        public void EnableVote()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void DrawPieChart(int value1, int value2, int value3)
        {
            //reset your chart series and legends
            chart1.Series.Clear();
            chart1.Legends.Clear();

            //Add a new Legend(if needed) and do some formating
            chart1.Legends.Add("Votacion de peliculas");
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].Title = "Votacion de peliculas";
            chart1.Legends[0].BorderColor = Color.Black;

            //Add a new chart-series
            string seriesname = "Votacion de peliculas";
            chart1.Series.Add(seriesname);
            //set the chart-type to "Pie"
            chart1.Series[seriesname].ChartType = SeriesChartType.Pie;

            //Add some datapoints so the series. in this case you can pass the values to this method
            chart1.Series[seriesname].Points.AddXY("John Wick", value1);
            chart1.Series[seriesname].Points.AddXY("Detective Pikachu", value2);
            chart1.Series[seriesname].Points.AddXY("Avengers", value3);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            peli1++;
            BlockVote();
            frmm.SetVoted(Form1.userx);
            DrawPieChart(peli1,peli2,peli3);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            peli2++;
            BlockVote();
            frmm.SetVoted(Form1.userx);
            DrawPieChart(peli1, peli2, peli3);
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            peli3++;
            BlockVote();
            frmm.SetVoted(Form1.userx);
            DrawPieChart(peli1, peli2, peli3);
        }
    }
}
