namespace tcc
{
    partial class FormListC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListC));
            label1 = new Label();
            lstCursos = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(425, 10);
            label1.Name = "label1";
            label1.Size = new Size(386, 81);
            label1.TabIndex = 8;
            label1.Text = "Listar Curso";
            // 
            // lstCursos
            // 
            lstCursos.Anchor = AnchorStyles.None;
            lstCursos.BackColor = Color.FromArgb(89, 114, 132);
            lstCursos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lstCursos.ForeColor = Color.White;
            lstCursos.FormattingEnabled = true;
            lstCursos.ItemHeight = 31;
            lstCursos.Location = new Point(225, 146);
            lstCursos.Margin = new Padding(3, 4, 3, 4);
            lstCursos.Name = "lstCursos";
            lstCursos.Size = new Size(815, 252);
            lstCursos.TabIndex = 9;
            lstCursos.SelectedIndexChanged += lstCursos_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(127, 99, 81);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(554, 460);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(115, 44);
            button2.TabIndex = 15;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormListC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 114, 132);
            ClientSize = new Size(1253, 732);
            Controls.Add(button2);
            Controls.Add(lstCursos);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormListC";
            Text = "Listar Curso";
            Load += FormListC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ListBox lstCursos;
        private Button button2;
    }
}