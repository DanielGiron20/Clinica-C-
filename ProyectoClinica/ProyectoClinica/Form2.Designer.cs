namespace ProyectoClinica
{
    partial class FormPacientes
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1802, 735);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(0, 735);
            button1.Name = "button1";
            button1.Size = new Size(237, 122);
            button1.TabIndex = 1;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.Location = new Point(237, 735);
            button3.Name = "button3";
            button3.Size = new Size(233, 122);
            button3.TabIndex = 3;
            button3.Text = "Cobrar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Left;
            button4.Location = new Point(470, 735);
            button4.Name = "button4";
            button4.Size = new Size(233, 122);
            button4.TabIndex = 4;
            button4.Text = "Agregar cargo";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Left;
            button5.Location = new Point(703, 735);
            button5.Name = "button5";
            button5.Size = new Size(207, 122);
            button5.TabIndex = 5;
            button5.Text = "Hospitalizar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(916, 735);
            button2.Name = "button2";
            button2.Size = new Size(214, 122);
            button2.TabIndex = 6;
            button2.Text = "Ingresar Paciente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // FormPacientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1802, 857);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(4);
            Name = "FormPacientes";
            Text = "Pacientes";
            Load += FormPacientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button2;
    }
}