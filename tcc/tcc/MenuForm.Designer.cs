namespace tcc
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            label1 = new Label();
            picAluno = new PictureBox();
            picSalas = new PictureBox();
            picCursos = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)picAluno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSalas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(431, 45);
            label1.Name = "label1";
            label1.Size = new Size(349, 81);
            label1.TabIndex = 1;
            label1.Text = "SchoolHub";
            label1.Click += label1_Click;
            // 
            // picAluno
            // 
            picAluno.Anchor = AnchorStyles.None;
            picAluno.Cursor = Cursors.Hand;
            picAluno.Image = (Image)resources.GetObject("picAluno.Image");
            picAluno.InitialImage = (Image)resources.GetObject("picAluno.InitialImage");
            picAluno.Location = new Point(202, 213);
            picAluno.Name = "picAluno";
            picAluno.Size = new Size(172, 128);
            picAluno.SizeMode = PictureBoxSizeMode.CenterImage;
            picAluno.TabIndex = 2;
            picAluno.TabStop = false;
            picAluno.Click += picAluno_Click;
            // 
            // picSalas
            // 
            picSalas.Anchor = AnchorStyles.None;
            picSalas.Cursor = Cursors.Hand;
            picSalas.Image = (Image)resources.GetObject("picSalas.Image");
            picSalas.Location = new Point(519, 213);
            picSalas.Name = "picSalas";
            picSalas.Size = new Size(174, 128);
            picSalas.SizeMode = PictureBoxSizeMode.CenterImage;
            picSalas.TabIndex = 3;
            picSalas.TabStop = false;
            picSalas.Click += picSalas_Click;
            // 
            // picCursos
            // 
            picCursos.Anchor = AnchorStyles.None;
            picCursos.Cursor = Cursors.Hand;
            picCursos.Image = (Image)resources.GetObject("picCursos.Image");
            picCursos.Location = new Point(826, 213);
            picCursos.Name = "picCursos";
            picCursos.Size = new Size(174, 128);
            picCursos.SizeMode = PictureBoxSizeMode.CenterImage;
            picCursos.TabIndex = 4;
            picCursos.TabStop = false;
            picCursos.Click += picCursos_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(192, 362);
            label2.Name = "label2";
            label2.Size = new Size(197, 31);
            label2.TabIndex = 8;
            label2.Text = "Gerenciar Alunos";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(520, 362);
            label3.Name = "label3";
            label3.Size = new Size(176, 31);
            label3.TabIndex = 9;
            label3.Text = "Gerenciar Salas";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(820, 362);
            label4.Name = "label4";
            label4.Size = new Size(193, 31);
            label4.TabIndex = 10;
            label4.Text = "Gerenciar Cursos";
            label4.Click += label4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(519, 464);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(174, 128);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(576, 600);
            label5.Name = "label5";
            label5.Size = new Size(55, 31);
            label5.TabIndex = 12;
            label5.Text = "Sair";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 114, 132);
            ClientSize = new Size(1253, 732);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(picCursos);
            Controls.Add(picSalas);
            Controls.Add(picAluno);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuForm";
            Text = "Menu";
            Load += MenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)picAluno).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSalas).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox picAluno;
        private PictureBox picSalas;
        private PictureBox picCursos;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox5;
        private Label label5;
    }
}