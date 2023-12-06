namespace ProyectoClinica
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            suites = new TextBox();
            privadas = new TextBox();
            semiprivadas = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(997, 708);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 761);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 1;
            label1.Text = "Suites disponibles:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 761);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 2;
            label2.Text = "Privadas disponibles:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(665, 761);
            label3.Name = "label3";
            label3.Size = new Size(218, 25);
            label3.TabIndex = 3;
            label3.Text = "Semiprivadas disponibles:";
            // 
            // suites
            // 
            suites.Location = new Point(198, 758);
            suites.Name = "suites";
            suites.Size = new Size(121, 31);
            suites.TabIndex = 4;
            // 
            // privadas
            // 
            privadas.Location = new Point(515, 755);
            privadas.Name = "privadas";
            privadas.Size = new Size(121, 31);
            privadas.TabIndex = 5;
            // 
            // semiprivadas
            // 
            semiprivadas.Location = new Point(883, 755);
            semiprivadas.Name = "semiprivadas";
            semiprivadas.Size = new Size(121, 31);
            semiprivadas.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1050, 848);
            Controls.Add(semiprivadas);
            Controls.Add(privadas);
            Controls.Add(suites);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox suites;
        private TextBox privadas;
        private TextBox semiprivadas;
    }
}