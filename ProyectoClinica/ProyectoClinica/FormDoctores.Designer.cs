namespace ProyectoClinica
{
    partial class FormDoctores
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button1 = new Button();
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
            dataGridView1.Size = new Size(1459, 710);
            dataGridView1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(247, 710);
            button3.Name = "button3";
            button3.Size = new Size(241, 106);
            button3.TabIndex = 3;
            button3.Text = "Pagar al doctor";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(494, 710);
            button4.Name = "button4";
            button4.Size = new Size(241, 106);
            button4.TabIndex = 4;
            button4.Text = "Cobrar al doctor";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(741, 710);
            button5.Name = "button5";
            button5.Size = new Size(235, 106);
            button5.TabIndex = 5;
            button5.Text = "Registro de consultas";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(0, 710);
            button6.Name = "button6";
            button6.Size = new Size(241, 106);
            button6.TabIndex = 1;
            button6.Text = "Salvar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.Location = new Point(982, 710);
            button1.Name = "button1";
            button1.Size = new Size(214, 106);
            button1.TabIndex = 6;
            button1.Text = "Ingresar doctor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormDoctores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1459, 816);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Margin = new Padding(4);
            Name = "FormDoctores";
            Text = "Doctores";
            Load += FormDoctores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button1;
    }
}