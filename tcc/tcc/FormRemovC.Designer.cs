namespace tcc
{
    partial class FormRemovC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRemovC));
            label1 = new Label();
            cmbCursos = new ComboBox();
            label2 = new Label();
            button1 = new Button();
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
            label1.Size = new Size(479, 81);
            label1.TabIndex = 7;
            label1.Text = "Remover Curso";
            // 
            // cmbCursos
            // 
            cmbCursos.Anchor = AnchorStyles.None;
            cmbCursos.BackColor = SystemColors.Control;
            cmbCursos.Font = new Font("Segoe UI", 12F);
            cmbCursos.FormattingEnabled = true;
            cmbCursos.Location = new Point(521, 314);
            cmbCursos.Margin = new Padding(3, 4, 3, 4);
            cmbCursos.Name = "cmbCursos";
            cmbCursos.Size = new Size(214, 36);
            cmbCursos.TabIndex = 17;
            cmbCursos.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(414, 245);
            label2.Name = "label2";
            label2.Size = new Size(421, 31);
            label2.TabIndex = 18;
            label2.Text = "Selecione o curso que deseja remover:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(127, 99, 81);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(540, 412);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(175, 37);
            button1.TabIndex = 19;
            button1.Text = "Remover Curso";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1148, 675);
            label5.Name = "label5";
            label5.Size = new Size(79, 31);
            label5.TabIndex = 26;
            label5.Text = "Voltar";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1075, 650);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(67, 70);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // FormRemovC
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(89, 114, 132);
            ClientSize = new Size(1253, 732);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(cmbCursos);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRemovC";
            Text = "Remover Curso";
            Load += FormRemovC_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox cmbCursos;
        private Label label2;
        private Button button1;
        private Label label5;
        private PictureBox pictureBox5;
    }
}