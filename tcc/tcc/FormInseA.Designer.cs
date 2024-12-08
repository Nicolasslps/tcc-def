namespace tcc
{
    partial class FormInseA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInseA));
            label1 = new Label();
            txtNome = new TextBox();
            txtNumero = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            cmbCursos = new ComboBox();
            cmbSalas = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(405, 27);
            label1.Name = "label1";
            label1.Size = new Size(417, 81);
            label1.TabIndex = 6;
            label1.Text = "Inserir Aluno";
            label1.Click += label1_Click;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.None;
            txtNome.BackColor = SystemColors.Control;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(543, 200);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(178, 31);
            txtNome.TabIndex = 7;
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.None;
            txtNumero.BackColor = SystemColors.Control;
            txtNumero.Cursor = Cursors.IBeam;
            txtNumero.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumero.Location = new Point(543, 268);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(178, 31);
            txtNumero.TabIndex = 8;
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
            label2.TabIndex = 9;
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
            label3.TabIndex = 10;
            label3.Text = "Numero da Matricula do Aluno:";
            label3.Click += label3_Click;
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
            button1.TabIndex = 11;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
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
            label5.TabIndex = 13;
            label5.Text = "Voltar";
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
            label4.TabIndex = 14;
            label4.Text = "Curso desejado:";
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
            cmbCursos.TabIndex = 15;
            // 
            // cmbSalas
            // 
            cmbSalas.Anchor = AnchorStyles.None;
            cmbSalas.BackColor = SystemColors.Control;
            cmbSalas.Cursor = Cursors.Hand;
            cmbSalas.Font = new Font("Segoe UI", 12F);
            cmbSalas.FormattingEnabled = true;
            cmbSalas.Location = new Point(543, 399);
            cmbSalas.Name = "cmbSalas";
            cmbSalas.Size = new Size(178, 36);
            cmbSalas.TabIndex = 16;
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
            label6.TabIndex = 17;
            label6.Text = "Sala desejada:";
            // 
            // FormInseA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 114, 132);
            ClientSize = new Size(1253, 732);
            Controls.Add(label6);
            Controls.Add(cmbSalas);
            Controls.Add(cmbCursos);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(txtNome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInseA";
            Text = "Inserir Aluno";
            Load += FormInseA_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtNome;
        private TextBox txtNumero;
        private Label label2;
        private Label label3;
        private Button button1;
        private PictureBox pictureBox5;
        private Label label5;
        private Label label4;
        private ComboBox cmbCursos;
        private ComboBox cmbSalas;
        private Label label6;
    }
}