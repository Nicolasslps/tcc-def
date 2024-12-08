namespace tcc
{
    partial class FormAttA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttA));
            label1 = new Label();
            cmbAlunos = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            cmbSalas = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(353, 67);
            label1.Name = "label1";
            label1.Size = new Size(503, 81);
            label1.TabIndex = 5;
            label1.Text = "Atualizar Aluno";
            // 
            // cmbAlunos
            // 
            cmbAlunos.Anchor = AnchorStyles.None;
            cmbAlunos.BackColor = SystemColors.Control;
            cmbAlunos.Cursor = Cursors.Hand;
            cmbAlunos.Font = new Font("Segoe UI", 12F);
            cmbAlunos.FormattingEnabled = true;
            cmbAlunos.Location = new Point(548, 361);
            cmbAlunos.Margin = new Padding(3, 4, 3, 4);
            cmbAlunos.Name = "cmbAlunos";
            cmbAlunos.Size = new Size(215, 36);
            cmbAlunos.TabIndex = 6;
            cmbAlunos.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(330, 362);
            label2.Name = "label2";
            label2.Size = new Size(213, 31);
            label2.TabIndex = 18;
            label2.Text = "Selecione o Aluno:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(127, 99, 81);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(578, 453);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(115, 44);
            button1.TabIndex = 11;
            button1.Text = "Proximo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // cmbSalas
            // 
            cmbSalas.Anchor = AnchorStyles.None;
            cmbSalas.BackColor = SystemColors.Control;
            cmbSalas.Cursor = Cursors.Hand;
            cmbSalas.Font = new Font("Segoe UI", 12F);
            cmbSalas.FormattingEnabled = true;
            cmbSalas.Location = new Point(548, 273);
            cmbSalas.Margin = new Padding(3, 4, 3, 4);
            cmbSalas.Name = "cmbSalas";
            cmbSalas.Size = new Size(215, 36);
            cmbSalas.TabIndex = 21;
            cmbSalas.SelectedIndexChanged += cmbSalas_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(353, 273);
            label3.Name = "label3";
            label3.Size = new Size(190, 31);
            label3.TabIndex = 22;
            label3.Text = "Selecione a Sala:";
            // 
            // FormAttA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 114, 132);
            ClientSize = new Size(1253, 732);
            Controls.Add(label3);
            Controls.Add(cmbSalas);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(cmbAlunos);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAttA";
            Text = "Atualizar Aluno";
            Load += FormAttA_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox cmbAlunos;
        private Label label2;
        private Button button1;
        private Label label5;
        private PictureBox pictureBox5;
        private ComboBox cmbSalas;
        private Label label3;
    }
}