using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        public static string[,] arr = new string[5,4];
        public static int userx = 0, usery = 0;
        public static Form2 frm = new Form2();

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("img6.png");
            //memes
            arr[0, 0] = "walter22";
            arr[0, 1] = "9225";
            arr[0, 2] = "img1.png";
            arr[0, 3] = "false";
            arr[1, 0] = "j0s3";
            arr[1, 1] = "4301";
            arr[1, 2] = "img1.png";
            arr[1, 3] = "false";
            arr[2, 0] = "xmariox";
            arr[2, 1] = "2646";
            arr[2, 2] = "img1.png";
            arr[2, 3] = "false";
            arr[3, 0] = "ana420";
            arr[3, 1] = "9580";
            arr[3, 2] = "img1.png";
            arr[3, 3] = "false";
            arr[4, 0] = "bleshin";
            arr[4, 1] = "7794";
            arr[4, 2] = "img1.png";
            arr[4, 3] = "false";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("test yes");
        }

        private void Btniniciar_Click(object sender, EventArgs e)
        {
            bool chkuser = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (arr[i, j] == txtnumero.Text)
                    {
                        userx = i;
                        usery = j;
                        chkuser = true;
                        break;
                    }
                }
            }
            if(chkuser)
            {
                MessageBox.Show("Vote por su pelicula favorita");
                this.Hide();
                frm.txtusuario.Text = Form1.arr[Form1.userx, 0];
                if (Form1.arr[userx, 3] == "true")
                {
                    frm.BlockVote();
                }
                frm.Show();
            }
            else
            {
                if (txtnumero.Text == "")
                {
                    MessageBox.Show("No puede dejar campos vacios");
                }
                else
                {
                    MessageBox.Show("Nickname/Codigo de cliente no valido");
                    txtnumero.Clear();
                }
            }
        }

        private void Txtnumero_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Txtnumero_TextChanged(object sender, EventArgs e)
        {

            bool chkuser = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (arr[i, j] == txtnumero.Text)
                    {
                        chkuser = true;
                        break;
                    }
                }
            }
            if (chkuser)
            {
                ImgSelect(txtnumero.Text);
            }
            else
            {
                pictureBox1.Image = Image.FromFile("img6.png");
            }
        }

        private void ImgSelect(string usr)
        {
            if(usr=="walter22"||usr=="9225")
            {
                pictureBox1.Image = Image.FromFile("img1.png");
            }
            else if (usr == "j0s3" || usr == "4301")
            {
                pictureBox1.Image = Image.FromFile("img2.png");
            }
            else if (usr == "xmariox" || usr == "2646")
            {
                pictureBox1.Image = Image.FromFile("img3.png");
            }
            else if (usr == "ana420" || usr == "9580")
            {
                pictureBox1.Image = Image.FromFile("img4.png");
            }
            else if (usr == "bleshin" || usr == "7794")
            {
                pictureBox1.Image = Image.FromFile("img5.png");
            }
        }

        public void SetVoted(int posx)
        {
            Form1.arr[posx, 3] = "true";
        }
    }
    }

