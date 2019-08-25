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

        public static string[,] arr = new string[4,5];
        

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("img6.png");
            //memes
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arr[0, 0] = "walter22";
            arr[0, 1] = "9225";
            arr[0, 2] = "img1.png";
            arr[0, 3] = "false";
            arr[1, 0] = "walter22";
            arr[1, 1] = "9225";
            arr[1, 2] = "img1.png";
            arr[1, 3] = "false";
            arr[2, 0] = "walter22";
            arr[2, 1] = "9225";
            arr[2, 2] = "img1.png";
            arr[2, 3] = "false";
            arr[3, 0] = "walter22";
            arr[3, 1] = "9225";
            arr[3, 2] = "img1.png";
            arr[3, 3] = "false";
            arr[4, 0] = "walter22";
            arr[4, 1] = "9225";
            arr[4, 2] = "img1.png";
            arr[4, 3] = "false";
        }

       
       

        private void Btniniciar_Click(object sender, EventArgs e)
        {   
            
            if ((txtnumero.Text != "") && (txtcontra.Text != ""))
            {
                if ()
                {
                    MessageBox.Show("A ingresado al sistema");
                   this.Hide();

                    Form2 frm = new Form2();
                    frm.txtusuario.Text = txtnumero.Text;
                    
                    frm.Show();
                   
                

                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                    txtnumero.Clear();
                    txtcontra.Clear();
                }
            }
            else
            {
                MessageBox.Show("No puede dejar campos vacios");
            }

           



            // pictureBox4.Image = Image.FromFile("img1.png");
        }

        private void Txtnumero_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Txtnumero_TextChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (arr[i, j] == txtnumero.Text)
                    {

                    }
                }
            }

            if(txtnumero.Text == "" )
            {
                
            }
        }
    }
    }

