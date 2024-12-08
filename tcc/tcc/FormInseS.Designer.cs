namespace tcc
{
    partial class FormInseS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInseS));
            label1 = new Label();
            txtNomeSala = new TextBox();
            txtNumeroSala = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            cmbCursos = new ComboBox();
            label4 = new Label();
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
            label1.Location = new Point(445, 80);
            label1.Name = "label1";
            label1.Size = new Size(370, 81);
            label1.TabIndex = 7;
            label1.Text = "Inserir Sala";
            label1.Click += label1_Click;
            // 
            // txtNomeSala
            // 
            txtNomeSala.Anchor = AnchorStyles.None;
            txtNomeSala.BackColor = SystemColors.Control;
            txtNomeSala.Font = new Font("Segoe UI", 10.8F);
            txtNomeSala.Location = new Point(543, 268);
            txtNomeSala.Name = "txtNomeSala";
            txtNomeSala.Size = new Size(178, 31);
            txtNomeSala.TabIndex = 8;
            // 
            // txtNumeroSala
            // 
            txtNumeroSala.Anchor = AnchorStyles.None;
            txtNumeroSala.BackColor = SystemColors.Control;
            txtNumeroSala.Font = new Font("Segoe UI", 10.8F);
            txtNumeroSala.Location = new Point(543, 332);
            txtNumeroSala.Name = "txtNumeroSala";
            txtNumeroSala.Size = new Size(178, 31);
            txtNumeroSala.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(365, 263);
            label2.Name = "label2";
            label2.Size = new Size(167, 31);
            label2.TabIndex = 10;
            label2.Text = "Nome da Sala:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(342, 329);
            label3.Name = "label3";
            label3.Size = new Size(190, 31);
            label3.TabIndex = 11;
            label3.Text = "Numero da Sala:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(127, 99, 81);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(562, 489);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(115, 44);
            button1.TabIndex = 12;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbCursos
            // 
            cmbCursos.Anchor = AnchorStyles.None;
            cmbCursos.BackColor = SystemColors.Control;
            cmbCursos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCursos.FormattingEnabled = true;
            cmbCursos.Location = new Point(543, 399);
            cmbCursos.Name = "cmbCursos";
            cmbCursos.Size = new Size(178, 36);
            cmbCursos.TabIndex = 14;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(323, 399);
            label4.Name = "label4";
            label4.Size = new Size(209, 31);
            label4.TabIndex = 15;
            label4.Text = "Selecione o Curso:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1152, 678);
            label5.Name = "label5";
            label5.Size = new Size(79, 31);
            label5.TabIndex = 27;
            label5.Text = "Voltar";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1067, 650);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(67, 70);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // FormInseS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 114, 132);
            ClientSize = new Size(1253, 732);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(label4);
            Controls.Add(cmbCursos);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNumeroSala);
            Controls.Add(txtNomeSala);
            Controls.Add(label1);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormInseS";
            Text = "Inserir Sala";
            Load += FormInseS_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtNomeSala;
        private TextBox txtNumeroSala;
        private Label label2;
        private Label label3;
        private Button button1;
        private ComboBox cmbCursos;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox5;
    }
}