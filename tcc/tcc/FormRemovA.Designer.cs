namespace tcc
{
    partial class FormRemovA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRemovA));
            label1 = new Label();
            cmbAlunos = new ComboBox();
            btnDeletar = new Button();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            cmbSalas = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(381, 68);
            label1.Name = "label1";
            label1.Size = new Size(487, 81);
            label1.TabIndex = 6;
            label1.Text = "Remover Aluno";
            // 
            // cmbAlunos
            // 
            cmbAlunos.Anchor = AnchorStyles.None;
            cmbAlunos.BackColor = SystemColors.Control;
            cmbAlunos.Cursor = Cursors.Hand;
            cmbAlunos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAlunos.FormattingEnabled = true;
            cmbAlunos.Location = new Point(544, 358);
            cmbAlunos.Margin = new Padding(3, 4, 3, 4);
            cmbAlunos.Name = "cmbAlunos";
            cmbAlunos.Size = new Size(214, 36);
            cmbAlunos.TabIndex = 16;
            cmbAlunos.SelectedIndexChanged += cmbAlunos_SelectedIndexChanged;
            // 
            // btnDeletar
            // 
            btnDeletar.Anchor = AnchorStyles.None;
            btnDeletar.BackColor = Color.FromArgb(127, 99, 81);
            btnDeletar.Cursor = Cursors.Hand;
            btnDeletar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDeletar.ForeColor = Color.White;
            btnDeletar.Location = new Point(559, 456);
            btnDeletar.Margin = new Padding(3, 4, 3, 4);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(175, 37);
            btnDeletar.TabIndex = 18;
            btnDeletar.Text = "Remover Aluno";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += button1_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1125, 687);
            label5.Name = "label5";
            label5.Size = new Size(79, 31);
            label5.TabIndex = 20;
            label5.Text = "Voltar";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1052, 662);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(67, 70);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(114, 358);
            label3.Name = "label3";
            label3.Size = new Size(424, 31);
            label3.TabIndex = 22;
            label3.Text = "Selecione o aluno que deseja remover:";
            // 
            // cmbSalas
            // 
            cmbSalas.Anchor = AnchorStyles.None;
            cmbSalas.BackColor = SystemColors.Control;
            cmbSalas.Cursor = Cursors.Hand;
            cmbSalas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSalas.FormattingEnabled = true;
            cmbSalas.Location = new Point(544, 275);
            cmbSalas.Margin = new Padding(3, 4, 3, 4);
            cmbSalas.Name = "cmbSalas";
            cmbSalas.Size = new Size(214, 36);
            cmbSalas.TabIndex = 23;
            cmbSalas.SelectedIndexChanged += cmbSalas_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(250, 275);
            label4.Name = "label4";
            label4.Size = new Size(288, 31);
            label4.TabIndex = 24;
            label4.Text = "Selecione a sala do aluno:";
            // 
            // FormRemovA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 114, 132);
            ClientSize = new Size(1253, 732);
            Controls.Add(label4);
            Controls.Add(cmbSalas);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(btnDeletar);
            Controls.Add(cmbAlunos);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormRemovA";
            Text = "Remover Aluno";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox cmbAlunos;
        private Button btnDeletar;
        private Label label5;
        private PictureBox pictureBox5;
        private Label label3;
        private ComboBox cmbSalas;
        private Label label4;
    }
}