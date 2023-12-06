namespace ProyectoClinica
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button1 = new Button();
            id_doctor = new TextBox();
            nombre_doctor = new TextBox();
            apellido_doctor = new TextBox();
            cedula_doctor = new TextBox();
            telefono_doctor = new TextBox();
            correo_doctor = new TextBox();
            salario_doctor = new TextBox();
            precioC_doctor = new TextBox();
            estado_doctor = new ComboBox();
            consultorio = new ComboBox();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(436, 38);
            label1.Name = "label1";
            label1.Size = new Size(308, 37);
            label1.TabIndex = 0;
            label1.Text = "Ingreso de doctores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(144, 172);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 1;
            label2.Text = "ID doctor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(144, 251);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(144, 337);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 3;
            label4.Text = "Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(144, 428);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 4;
            label5.Text = "Cedula:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(136, 497);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(150, 517);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 6;
            label7.Text = "Telefono:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(722, 165);
            label8.Name = "label8";
            label8.Size = new Size(74, 25);
            label8.TabIndex = 7;
            label8.Text = "Correo:";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(663, 241);
            label9.Name = "label9";
            label9.Size = new Size(138, 25);
            label9.TabIndex = 8;
            label9.Text = "Estado laboral:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(722, 330);
            label10.Name = "label10";
            label10.Size = new Size(75, 25);
            label10.TabIndex = 9;
            label10.Text = "Salario:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(663, 418);
            label11.Name = "label11";
            label11.Size = new Size(149, 25);
            label11.TabIndex = 10;
            label11.Text = "Precio Consulta:";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(517, 604);
            button1.Name = "button1";
            button1.Size = new Size(176, 75);
            button1.TabIndex = 11;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // id_doctor
            // 
            id_doctor.Location = new Point(275, 166);
            id_doctor.Name = "id_doctor";
            id_doctor.Size = new Size(80, 31);
            id_doctor.TabIndex = 12;
            // 
            // nombre_doctor
            // 
            nombre_doctor.Location = new Point(275, 245);
            nombre_doctor.Name = "nombre_doctor";
            nombre_doctor.Size = new Size(263, 31);
            nombre_doctor.TabIndex = 13;
            // 
            // apellido_doctor
            // 
            apellido_doctor.Location = new Point(275, 334);
            apellido_doctor.Name = "apellido_doctor";
            apellido_doctor.Size = new Size(263, 31);
            apellido_doctor.TabIndex = 14;
            // 
            // cedula_doctor
            // 
            cedula_doctor.Location = new Point(275, 419);
            cedula_doctor.Name = "cedula_doctor";
            cedula_doctor.Size = new Size(263, 31);
            cedula_doctor.TabIndex = 15;
            // 
            // telefono_doctor
            // 
            telefono_doctor.Location = new Point(275, 511);
            telefono_doctor.Name = "telefono_doctor";
            telefono_doctor.Size = new Size(263, 31);
            telefono_doctor.TabIndex = 16;
            // 
            // correo_doctor
            // 
            correo_doctor.Location = new Point(822, 156);
            correo_doctor.Name = "correo_doctor";
            correo_doctor.Size = new Size(263, 31);
            correo_doctor.TabIndex = 17;
            // 
            // salario_doctor
            // 
            salario_doctor.Location = new Point(822, 324);
            salario_doctor.Name = "salario_doctor";
            salario_doctor.Size = new Size(153, 31);
            salario_doctor.TabIndex = 18;
            // 
            // precioC_doctor
            // 
            precioC_doctor.Location = new Point(822, 415);
            precioC_doctor.Name = "precioC_doctor";
            precioC_doctor.Size = new Size(153, 31);
            precioC_doctor.TabIndex = 19;
            // 
            // estado_doctor
            // 
            estado_doctor.FormattingEnabled = true;
            estado_doctor.Items.AddRange(new object[] { "-Seleccione-", "Contratado", "Arriendo" });
            estado_doctor.Location = new Point(822, 233);
            estado_doctor.Name = "estado_doctor";
            estado_doctor.Size = new Size(263, 33);
            estado_doctor.TabIndex = 20;
            // 
            // consultorio
            // 
            consultorio.FormattingEnabled = true;
            consultorio.Items.AddRange(new object[] { "Seleccione", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            consultorio.Location = new Point(822, 511);
            consultorio.Name = "consultorio";
            consultorio.Size = new Size(94, 33);
            consultorio.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(663, 519);
            label12.Name = "label12";
            label12.Size = new Size(110, 25);
            label12.TabIndex = 21;
            label12.Text = "Consultorio";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1186, 724);
            Controls.Add(consultorio);
            Controls.Add(label12);
            Controls.Add(estado_doctor);
            Controls.Add(precioC_doctor);
            Controls.Add(salario_doctor);
            Controls.Add(correo_doctor);
            Controls.Add(telefono_doctor);
            Controls.Add(cedula_doctor);
            Controls.Add(apellido_doctor);
            Controls.Add(nombre_doctor);
            Controls.Add(id_doctor);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button1;
        private TextBox id_doctor;
        private TextBox nombre_doctor;
        private TextBox apellido_doctor;
        private TextBox cedula_doctor;
        private TextBox telefono_doctor;
        private TextBox correo_doctor;
        private TextBox salario_doctor;
        private TextBox precioC_doctor;
        private ComboBox estado_doctor;
        private ComboBox consultorio;
        private Label label12;
    }
}