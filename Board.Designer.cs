namespace Life
{
    partial class frmBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            this.PanelTablero = new System.Windows.Forms.Panel();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.cmdEmpezar = new System.Windows.Forms.Button();
            this.cmdPaso = new System.Windows.Forms.Button();
            this.cmdCrear = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.chkRedondo = new System.Windows.Forms.CheckBox();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.cmdURL = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTablero
            // 
            this.PanelTablero.BackColor = System.Drawing.SystemColors.Control;
            this.PanelTablero.Location = new System.Drawing.Point(12, 64);
            this.PanelTablero.Name = "PanelTablero";
            this.PanelTablero.Size = new System.Drawing.Size(758, 407);
            this.PanelTablero.TabIndex = 0;
            // 
            // Temporizador
            // 
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // cmdEmpezar
            // 
            this.cmdEmpezar.Enabled = false;
            this.cmdEmpezar.Location = new System.Drawing.Point(304, 3);
            this.cmdEmpezar.Name = "cmdEmpezar";
            this.cmdEmpezar.Size = new System.Drawing.Size(104, 26);
            this.cmdEmpezar.TabIndex = 1;
            this.cmdEmpezar.Text = "Empezar";
            this.cmdEmpezar.UseVisualStyleBackColor = true;
            this.cmdEmpezar.Click += new System.EventHandler(this.cmdEmpezar_Click);
            // 
            // cmdPaso
            // 
            this.cmdPaso.Enabled = false;
            this.cmdPaso.Location = new System.Drawing.Point(304, 35);
            this.cmdPaso.Name = "cmdPaso";
            this.cmdPaso.Size = new System.Drawing.Size(104, 26);
            this.cmdPaso.TabIndex = 2;
            this.cmdPaso.Text = "+Paso";
            this.cmdPaso.UseVisualStyleBackColor = true;
            this.cmdPaso.Click += new System.EventHandler(this.cmdPaso_Click);
            // 
            // cmdCrear
            // 
            this.cmdCrear.Location = new System.Drawing.Point(124, 5);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(104, 26);
            this.cmdCrear.TabIndex = 3;
            this.cmdCrear.Text = "CrearTablero";
            this.cmdCrear.UseVisualStyleBackColor = true;
            this.cmdCrear.Click += new System.EventHandler(this.cmdCrear_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(234, 9);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(44, 20);
            this.txtX.TabIndex = 4;
            this.txtX.Text = "15";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(234, 35);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(44, 20);
            this.txtY.TabIndex = 5;
            this.txtY.Text = "15";
            // 
            // chkRedondo
            // 
            this.chkRedondo.AutoSize = true;
            this.chkRedondo.Location = new System.Drawing.Point(119, 38);
            this.chkRedondo.Name = "chkRedondo";
            this.chkRedondo.Size = new System.Drawing.Size(109, 17);
            this.chkRedondo.TabIndex = 6;
            this.chkRedondo.Text = "MundoRedondo?";
            this.chkRedondo.UseVisualStyleBackColor = true;
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(662, 0);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(88, 20);
            this.txtTurno.TabIndex = 7;
            this.txtTurno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdURL
            // 
            this.cmdURL.Location = new System.Drawing.Point(726, 35);
            this.cmdURL.Name = "cmdURL";
            this.cmdURL.Size = new System.Drawing.Size(24, 26);
            this.cmdURL.TabIndex = 8;
            this.cmdURL.Text = "?";
            this.cmdURL.UseVisualStyleBackColor = true;
            this.cmdURL.Click += new System.EventHandler(this.cmdURL_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(782, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdURL);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.chkRedondo);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.cmdCrear);
            this.Controls.Add(this.cmdPaso);
            this.Controls.Add(this.cmdEmpezar);
            this.Controls.Add(this.PanelTablero);
            this.Name = "frmBase";
            this.Text = "Juego de la Vida 23/3";
            this.Load += new System.EventHandler(this.frmBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTablero;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.Button cmdEmpezar;
        private System.Windows.Forms.Button cmdPaso;
        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.CheckBox chkRedondo;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.Button cmdURL;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

