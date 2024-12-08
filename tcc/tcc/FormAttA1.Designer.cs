namespace tcc
{
    partial class FormAttA1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttA1));
            label1 = new Label();
            txtNomeAluno = new TextBox();
            txtNumeroAluno = new TextBox();
            button1 = new Button();
            cmbCursos = new ComboBox();
            cmbSala = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(370, 30);
            label1.Name = "label1";
            label1.Size = new Size(503, 81);
            label1.TabIndex = 6;
            label1.Text = "Atualizar Aluno";
            label1.Click += label1_Click;
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Anchor = AnchorStyles.None;
            txtNomeAluno.BackColor = SystemColors.Control;
            txtNomeAluno.Cursor = Cursors.IBeam;
            txtNomeAluno.Font = new Font("Segoe UI", 10.8F);
            txtNomeAluno.Location = new Point(543, 200);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(178, 31);
            txtNomeAluno.TabIndex = 11;
            txtNomeAluno.TextChanged += txtNomeAluno_TextChanged;
            // 
            // txtNumeroAluno
            // 
            txtNumeroAluno.Anchor = AnchorStyles.None;
            txtNumeroAluno.BackColor = SystemColors.Control;
            txtNumeroAluno.Cursor = Cursors.Hand;
            txtNumeroAluno.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroAluno.Location = new Point(543, 268);
            txtNumeroAluno.Name = "txtNumeroAluno";
            txtNumeroAluno.Size = new Size(178, 31);
            txtNumeroAluno.TabIndex = 13;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(127, 99, 81);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(565, 480);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(115, 44);
            button1.TabIndex = 14;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbCursos
            // 
            cmbCursos.Anchor = AnchorStyles.None;
            cmbCursos.BackColor = SystemColors.Control;
            cmbCursos.Cursor = Cursors.Hand;
            cmbCursos.Font = new Font("Segoe UI", 12F);
            cmbCursos.FormattingEnabled = true;
            cmbCursos.Location = new Point(543, 332);
            cmbCursos.Name = "cmbCursos";
            cmbCursos.Size = new Size(178, 36);
            cmbCursos.TabIndex = 16;
            // 
            // cmbSala
            // 
            cmbSala.Anchor = AnchorStyles.None;
            cmbSala.BackColor = SystemColors.Control;
            cmbSala.Cursor = Cursors.Hand;
            cmbSala.Font = new Font("Segoe UI", 12F);
            cmbSala.FormattingEnabled = true;
            cmbSala.Location = new Point(543, 399);
            cmbSala.Name = "cmbSala";
            cmbSala.Size = new Size(178, 36);
            cmbSala.TabIndex = 17;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(345, 197);
            label2.Name = "label2";
            label2.Size = new Size(190, 31);
            label2.TabIndex = 18;
            label2.Text = "Nome do Aluno:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(181, 264);
            label3.Name = "label3";
            label3.Size = new Size(354, 31);
            label3.TabIndex = 19;
            label3.Text = "Numero da Matricula do Aluno:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(353, 331);
            label4.Name = "label4";
            label4.Size = new Size(182, 31);
            label4.TabIndex = 20;
            label4.Text = "Curso desejado:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(372, 398);
            label6.Name = "label6";
            label6.Size = new Size(163, 31);
            label6.TabIndex = 21;
            label6.Text = "Sala desejada:";
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
            label5.TabIndex = 23;
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
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // FormAttA1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 114, 132);
            ClientSize = new Size(1253, 732);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbSala);
            Controls.Add(cmbCursos);
            Controls.Add(button1);
            Controls.Add(txtNumeroAluno);
            Controls.Add(txtNomeAluno);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAttA1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar Aluno";
            Load += FormAttA1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtNomeAluno;
        private TextBox txtNumeroAluno;
        private Button button1;
        private ComboBox cmbCursos;
        private ComboBox cmbSala;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox5;
    }
}