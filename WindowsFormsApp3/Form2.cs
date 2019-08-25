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
        Stopwatch oSW = new Stopwatch();
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

            string[] series = { "candidato 1", "candidato 2", "candidato 3" };
            int[] puntos = { 23, 10, 70 };

            chart1.Titles.Add("votaciones");

            for (int i = 0; i < series.Length; i++)
            {
                Series serie = chart1.Series.Add(series[i]);
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }

            if (txtusuario.Text == "walter")
            {
                pictureBox4.Image = Image.FromFile("img1.png");
            }
            if (txtusuario.Text == "jose")
            {
                pictureBox4.Image = Image.FromFile("img2.png");
            }
            if (txtusuario.Text == "mario")
            {
                pictureBox4.Image = Image.FromFile("img3.png");
            }
            if (txtusuario.Text == "ana")
            {
                pictureBox4.Image = Image.FromFile("img4.png");
            }
            if (txtusuario.Text == "maria")
            {
                pictureBox4.Image = Image.FromFile("img5.png");
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)oSW.ElapsedMilliseconds);

            txtMin.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            txtSeg.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
          
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            oSW.Reset();
            txtMin.Text = "00";
            txtSeg.Text = "00";
          
            timer1.Enabled = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            oSW.Stop();
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            tabControl1.Enabled = false;
            btnexit.Enabled = false;
            txtusuario.Clear();
            pictureBox4.Image = Image.FromFile("img7.png");
           



            Form1 frmm = new Form1();
           
            frmm.Show();
          
            ;
        }
    }
}
