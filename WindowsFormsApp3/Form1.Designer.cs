namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btniniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(158, 214);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(137, 20);
            this.txtnumero.TabIndex = 12;
            this.txtnumero.TextChanged += new System.EventHandler(this.Txtnumero_TextChanged);
            this.txtnumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtnumero_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nickname/Codigo Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(72, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btniniciar);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 292);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGEO";
            // 
            // btniniciar
            // 
            this.btniniciar.Location = new System.Drawing.Point(84, 258);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(155, 23);
            this.btniniciar.TabIndex = 14;
            this.btniniciar.Text = "Acceder";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.Btniniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 317);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sistema de votacion de peliculas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btniniciar;
    }
}

