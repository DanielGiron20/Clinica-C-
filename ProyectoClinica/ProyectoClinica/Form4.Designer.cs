namespace ProyectoClinica
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
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
            label12 = new Label();
            id_paciente = new TextBox();
            nombre_paciente = new TextBox();
            apellido_paciente = new TextBox();
            cedula_paciente = new TextBox();
            id_doctor = new TextBox();
            detalles_paciente = new TextBox();
            telefono_paciente = new TextBox();
            cmd_ingresar = new Button();
            fechaN_paciente = new DateTimePicker();
            genero_paciente = new ComboBox();
            doctorR_paciente = new ComboBox();
            fehca_registro = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bell MT", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(414, 45);
            label1.Name = "label1";
            label1.Size = new Size(302, 37);
            label1.TabIndex = 0;
            label1.Text = "Ingreso de pacientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(132, 157);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 1;
            label2.Text = "ID paciente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(146, 223);
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
            label4.Location = new Point(146, 293);
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
            label5.Location = new Point(50, 378);
            label5.Name = "label5";
            label5.Size = new Size(192, 25);
            label5.TabIndex = 4;
            label5.Text = "Fecha de nacimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(146, 458);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 5;
            label6.Text = "Cedula:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(143, 538);
            label7.Name = "label7";
            label7.Size = new Size(79, 25);
            label7.TabIndex = 6;
            label7.Text = "Genero:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(659, 157);
            label8.Name = "label8";
            label8.Size = new Size(101, 25);
            label8.TabIndex = 7;
            label8.Text = "Telefeono:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(573, 220);
            label9.Name = "label9";
            label9.Size = new Size(194, 25);
            label9.TabIndex = 8;
            label9.Text = "Detalles del paciente:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(613, 296);
            label10.Name = "label10";
            label10.Size = new Size(148, 25);
            label10.TabIndex = 9;
            label10.Text = "Doctor referido:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(659, 375);
            label11.Name = "label11";
            label11.Size = new Size(98, 25);
            label11.TabIndex = 10;
            label11.Text = "ID doctor:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(624, 461);
            label12.Name = "label12";
            label12.Size = new Size(137, 25);
            label12.TabIndex = 11;
            label12.Text = "Fecha registro:";
            label12.Visible = false;
            // 
            // id_paciente
            // 
            id_paciente.Location = new Point(253, 151);
            id_paciente.Name = "id_paciente";
            id_paciente.Size = new Size(237, 31);
            id_paciente.TabIndex = 12;
            // 
            // nombre_paciente
            // 
            nombre_paciente.Location = new Point(253, 217);
            nombre_paciente.Name = "nombre_paciente";
            nombre_paciente.Size = new Size(237, 31);
            nombre_paciente.TabIndex = 13;
            // 
            // apellido_paciente
            // 
            apellido_paciente.Location = new Point(253, 293);
            apellido_paciente.Name = "apellido_paciente";
            apellido_paciente.Size = new Size(237, 31);
            apellido_paciente.TabIndex = 14;
            // 
            // cedula_paciente
            // 
            cedula_paciente.Location = new Point(253, 458);
            cedula_paciente.Name = "cedula_paciente";
            cedula_paciente.Size = new Size(237, 31);
            cedula_paciente.TabIndex = 16;
            // 
            // id_doctor
            // 
            id_doctor.Location = new Point(770, 372);
            id_doctor.Name = "id_doctor";
            id_doctor.Size = new Size(81, 31);
            id_doctor.TabIndex = 21;
            // 
            // detalles_paciente
            // 
            detalles_paciente.Location = new Point(770, 214);
            detalles_paciente.Name = "detalles_paciente";
            detalles_paciente.Size = new Size(237, 31);
            detalles_paciente.TabIndex = 19;
            // 
            // telefono_paciente
            // 
            telefono_paciente.Location = new Point(770, 148);
            telefono_paciente.Name = "telefono_paciente";
            telefono_paciente.Size = new Size(237, 31);
            telefono_paciente.TabIndex = 18;
            // 
            // cmd_ingresar
            // 
            cmd_ingresar.BackColor = Color.Transparent;
            cmd_ingresar.FlatStyle = FlatStyle.Flat;
            cmd_ingresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmd_ingresar.Location = new Point(477, 639);
            cmd_ingresar.Name = "cmd_ingresar";
            cmd_ingresar.Size = new Size(170, 69);
            cmd_ingresar.TabIndex = 23;
            cmd_ingresar.Text = "Ingresar";
            cmd_ingresar.UseVisualStyleBackColor = false;
            cmd_ingresar.Click += cmd_ingresar_Click;
            // 
            // fechaN_paciente
            // 
            fechaN_paciente.Location = new Point(253, 378);
            fechaN_paciente.Name = "fechaN_paciente";
            fechaN_paciente.Size = new Size(237, 31);
            fechaN_paciente.TabIndex = 24;
            // 
            // genero_paciente
            // 
            genero_paciente.FormattingEnabled = true;
            genero_paciente.Items.AddRange(new object[] { "-Selecciones-", "Masculino", "Femenino", "Otro" });
            genero_paciente.Location = new Point(253, 535);
            genero_paciente.Name = "genero_paciente";
            genero_paciente.Size = new Size(237, 33);
            genero_paciente.TabIndex = 25;
            // 
            // doctorR_paciente
            // 
            doctorR_paciente.FormattingEnabled = true;
            doctorR_paciente.Items.AddRange(new object[] { "Julio Cesar" });
            doctorR_paciente.Location = new Point(770, 293);
            doctorR_paciente.Name = "doctorR_paciente";
            doctorR_paciente.Size = new Size(237, 33);
            doctorR_paciente.TabIndex = 26;
            // 
            // fehca_registro
            // 
            fehca_registro.Location = new Point(782, 461);
            fehca_registro.Name = "fehca_registro";
            fehca_registro.Size = new Size(251, 31);
            fehca_registro.TabIndex = 27;
            fehca_registro.Visible = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1119, 768);
            Controls.Add(fehca_registro);
            Controls.Add(doctorR_paciente);
            Controls.Add(genero_paciente);
            Controls.Add(fechaN_paciente);
            Controls.Add(cmd_ingresar);
            Controls.Add(id_doctor);
            Controls.Add(detalles_paciente);
            Controls.Add(telefono_paciente);
            Controls.Add(cedula_paciente);
            Controls.Add(apellido_paciente);
            Controls.Add(nombre_paciente);
            Controls.Add(id_paciente);
            Controls.Add(label12);
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
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
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
        private Label label12;
        private TextBox id_paciente;
        private TextBox nombre_paciente;
        private TextBox apellido_paciente;
        private TextBox cedula_paciente;
        private TextBox id_doctor;
        private TextBox detalles_paciente;
        private TextBox telefono_paciente;
        private Button cmd_ingresar;
        private DateTimePicker fechaN_paciente;
        private ComboBox genero_paciente;
        private ComboBox doctorR_paciente;
        private DateTimePicker fehca_registro;
    }
}