namespace tcc
{
    partial class FormAttC1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttC1));
            label1 = new Label();
            txtNomeCurso = new TextBox();
            txtHorarioCurso = new TextBox();
            label2 = new Label();
            label3 = new Label();
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
            label1.Location = new Point(410, 54);
            label1.Name = "label1";
            label1.Size = new Size(495, 81);
            label1.TabIndex = 6;
            label1.Text = "Atualizar Curso";
            // 
            // txtNomeCurso
            // 
            txtNomeCurso.Anchor = AnchorStyles.None;
            txtNomeCurso.BackColor = SystemColors.Control;
            txtNomeCurso.Font = new Font("Segoe UI", 10.8F);
            txtNomeCurso.Location = new Point(546, 265);
            txtNomeCurso.Name = "txtNomeCurso";
            txtNomeCurso.Size = new Size(202, 31);
            txtNomeCurso.TabIndex = 9;
            // 
            // txtHorarioCurso
            // 
            txtHorarioCurso.Anchor = AnchorStyles.None;
            txtHorarioCurso.BackColor = SystemColors.Control;
            txtHorarioCurso.Font = new Font("Segoe UI", 10.8F);
            txtHorarioCurso.Location = new Point(546, 357);
            txtHorarioCurso.Name = "txtHorarioCurso";
            txtHorarioCurso.Size = new Size(202, 31);
            txtHorarioCurso.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(345, 263);
            label2.Name = "label2";
            label2.Size = new Size(186, 31);
            label2.TabIndex = 11;
            label2.Text = "Nome do Curso:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(168, 355);
            label3.Name = "label3";
            label3.Size = new Size(363, 31);
            label3.TabIndex = 12;
            label3.Text = "Horário de início e fim do Curso:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(127, 99, 81);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(580, 447);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(115, 44);
            button1.TabIndex = 15;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1151, 675);
            label5.Name = "label5";
            label5.Size = new Size(79, 31);
            label5.TabIndex = 28;
            label5.Text = "Voltar";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1078, 650);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(67, 70);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // FormAttC1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 114, 132);
            ClientSize = new Size(1253, 732);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtHorarioCurso);
            Controls.Add(txtNomeCurso);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAttC1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar Curso";
            Load += FormAttC1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtNomeCurso;
        private TextBox txtHorarioCurso;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label5;
        private PictureBox pictureBox5;
    }
}