namespace ProyectoClinica
{
    partial class Form3
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(43, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(396, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(55, 560);
            button1.Name = "button1";
            button1.Size = new Size(158, 59);
            button1.TabIndex = 1;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(268, 560);
            button2.Name = "button2";
            button2.Size = new Size(154, 59);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.MenuText;
            txtUsuario.ForeColor = SystemColors.ButtonHighlight;
            txtUsuario.Location = new Point(128, 394);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(246, 31);
            txtUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = SystemColors.MenuText;
            txtContrasena.ForeColor = SystemColors.ButtonHighlight;
            txtContrasena.Location = new Point(128, 492);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(246, 31);
            txtContrasena.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(206, 353);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 5;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(188, 446);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 6;
            label2.Text = "Contrasena";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.User_icon_2_svg;
            pictureBox2.Location = new Point(55, 383);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.free_home_house_key_security_lock_safe_secure_property_4_12161;
            pictureBox3.Location = new Point(55, 478);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 58);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(481, 678);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}