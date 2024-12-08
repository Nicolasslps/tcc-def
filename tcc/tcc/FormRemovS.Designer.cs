namespace tcc
{
    partial class FormRemovS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRemovS));
            label1 = new Label();
            cmbSalas = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            cmbCurso = new ComboBox();
            label3 = new Label();
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
            label1.Location = new Point(381, 68);
            label1.Name = "label1";
            label1.Size = new Size(440, 81);
            label1.TabIndex = 7;
            label1.Text = "Remover Sala";
            // 
            // cmbSalas
            // 
            cmbSalas.Anchor = AnchorStyles.None;
            cmbSalas.BackColor = SystemColors.Control;
            cmbSalas.Cursor = Cursors.Hand;
            cmbSalas.Font = new Font("Segoe UI", 12F);
            cmbSalas.ForeColor = SystemColors.WindowText;
            cmbSalas.FormattingEnabled = true;
            cmbSalas.Location = new Point(544, 358);
            cmbSalas.Margin = new Padding(3, 4, 3, 4);
            cmbSalas.Name = "cmbSalas";
            cmbSalas.Size = new Size(214, 36);
            cmbSalas.TabIndex = 18;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(127, 358);
            label2.Name = "label2";
            label2.Size = new Size(402, 31);
            label2.TabIndex = 19;
            label2.Text = "Selecione a sala que deseja remover:";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(127, 99, 81);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(559, 456);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(175, 37);
            button1.TabIndex = 20;
            button1.Text = "Remover Sala";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbCurso
            // 
            cmbCurso.Anchor = AnchorStyles.None;
            cmbCurso.BackColor = SystemColors.Control;
            cmbCurso.Cursor = Cursors.Hand;
            cmbCurso.Font = new Font("Segoe UI", 12F);
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Location = new Point(544, 275);
            cmbCurso.Margin = new Padding(3, 4, 3, 4);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(214, 36);
            cmbCurso.TabIndex = 21;
            cmbCurso.SelectedIndexChanged += cmbCurso_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(320, 275);
            label3.Name = "label3";
            label3.Size = new Size(209, 31);
            label3.TabIndex = 22;
            label3.Text = "Selecione o Curso:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1156, 675);
            label5.Name = "label5";
            label5.Size = new Size(79, 31);
            label5.TabIndex = 24;
            label5.Text = "Voltar";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1083, 650);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(67, 70);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // FormRemovS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 114, 132);
            ClientSize = new Size(1253, 732);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(label3);
            Controls.Add(cmbCurso);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(cmbSalas);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRemovS";
            Text = "Remover Sala";
            Load += FormRemovS_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox cmbSalas;
        private Label label2;
        private Button button1;
        private ComboBox cmbCurso;
        private Label label3;
        private Label label5;
        private PictureBox pictureBox5;
    }
}