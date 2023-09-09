namespace MateApp_V2._0.Forms
{
    partial class EcuacionCuadratica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcuacionCuadratica));
            toolStrip1 = new ToolStrip();
            btn_close = new ToolStripButton();
            btn_restore = new ToolStripButton();
            btn_maximize = new ToolStripButton();
            btn_minimize = new ToolStripButton();
            btn_volver = new ToolStripButton();
            btn_calcular = new Button();
            lbl_a = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_b = new TextBox();
            txt_a = new TextBox();
            txt_c = new TextBox();
            txt_x1 = new TextBox();
            txt_x2 = new TextBox();
            btn_limpiar = new Button();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.MediumTurquoise;
            toolStrip1.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_close, btn_restore, btn_maximize, btn_minimize, btn_volver });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1163, 31);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_close
            // 
            btn_close.Alignment = ToolStripItemAlignment.Right;
            btn_close.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_close.Image = (Image)resources.GetObject("btn_close.Image");
            btn_close.ImageTransparentColor = Color.Magenta;
            btn_close.Name = "btn_close";
            btn_close.RightToLeft = RightToLeft.No;
            btn_close.Size = new Size(28, 28);
            btn_close.Text = "Cerrar";
            btn_close.Click += btn_close_Click_1;
            // 
            // btn_restore
            // 
            btn_restore.Alignment = ToolStripItemAlignment.Right;
            btn_restore.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_restore.Image = (Image)resources.GetObject("btn_restore.Image");
            btn_restore.ImageTransparentColor = Color.Magenta;
            btn_restore.Name = "btn_restore";
            btn_restore.Size = new Size(28, 28);
            btn_restore.Text = "restaurar";
            btn_restore.Click += btn_restore_Click_1;
            // 
            // btn_maximize
            // 
            btn_maximize.Alignment = ToolStripItemAlignment.Right;
            btn_maximize.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_maximize.Image = (Image)resources.GetObject("btn_maximize.Image");
            btn_maximize.ImageTransparentColor = Color.Magenta;
            btn_maximize.Name = "btn_maximize";
            btn_maximize.Size = new Size(28, 28);
            btn_maximize.Text = "Maximizar";
            btn_maximize.Click += btn_maximize_Click_1;
            // 
            // btn_minimize
            // 
            btn_minimize.Alignment = ToolStripItemAlignment.Right;
            btn_minimize.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_minimize.Image = (Image)resources.GetObject("btn_minimize.Image");
            btn_minimize.ImageTransparentColor = Color.Magenta;
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(28, 28);
            btn_minimize.Text = "Minimizar";
            btn_minimize.Click += btn_minimize_Click_1;
            // 
            // btn_volver
            // 
            btn_volver.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_volver.Image = (Image)resources.GetObject("btn_volver.Image");
            btn_volver.ImageTransparentColor = Color.Magenta;
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(28, 28);
            btn_volver.Text = "Volver";
            btn_volver.Click += btn_volver_Click;
            // 
            // btn_calcular
            // 
            btn_calcular.BackColor = Color.MediumTurquoise;
            btn_calcular.Cursor = Cursors.Hand;
            btn_calcular.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_calcular.Location = new Point(513, 278);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(141, 56);
            btn_calcular.TabIndex = 4;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = false;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // lbl_a
            // 
            lbl_a.AutoSize = true;
            lbl_a.BackColor = Color.MediumTurquoise;
            lbl_a.FlatStyle = FlatStyle.Flat;
            lbl_a.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_a.ForeColor = Color.Black;
            lbl_a.Location = new Point(158, 275);
            lbl_a.Name = "lbl_a";
            lbl_a.Size = new Size(36, 19);
            lbl_a.TabIndex = 3;
            lbl_a.Text = "a =";
            lbl_a.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumTurquoise;
            label2.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(158, 326);
            label2.Name = "label2";
            label2.Size = new Size(36, 19);
            label2.TabIndex = 4;
            label2.Text = "b =";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumTurquoise;
            label3.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(158, 377);
            label3.Name = "label3";
            label3.Size = new Size(36, 19);
            label3.TabIndex = 5;
            label3.Text = "c =";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumTurquoise;
            label4.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(786, 292);
            label4.Name = "label4";
            label4.Size = new Size(45, 19);
            label4.TabIndex = 6;
            label4.Text = "x1 =";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumTurquoise;
            label5.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(786, 365);
            label5.Name = "label5";
            label5.Size = new Size(45, 19);
            label5.TabIndex = 7;
            label5.Text = "x2 =";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_b
            // 
            txt_b.Location = new Point(244, 325);
            txt_b.Name = "txt_b";
            txt_b.ShortcutsEnabled = false;
            txt_b.Size = new Size(150, 23);
            txt_b.TabIndex = 2;
            txt_b.KeyPress += txt_b_KeyPress;
            // 
            // txt_a
            // 
            txt_a.Location = new Point(244, 276);
            txt_a.Name = "txt_a";
            txt_a.ShortcutsEnabled = false;
            txt_a.Size = new Size(150, 23);
            txt_a.TabIndex = 1;
            txt_a.KeyPress += txt_a_KeyPress;
            // 
            // txt_c
            // 
            txt_c.Location = new Point(244, 377);
            txt_c.Name = "txt_c";
            txt_c.ShortcutsEnabled = false;
            txt_c.Size = new Size(150, 23);
            txt_c.TabIndex = 3;
            txt_c.KeyPress += txt_c_KeyPress;
            // 
            // txt_x1
            // 
            txt_x1.Enabled = false;
            txt_x1.Location = new Point(869, 293);
            txt_x1.Name = "txt_x1";
            txt_x1.ReadOnly = true;
            txt_x1.Size = new Size(150, 23);
            txt_x1.TabIndex = 5;
            // 
            // txt_x2
            // 
            txt_x2.Enabled = false;
            txt_x2.Location = new Point(869, 363);
            txt_x2.Name = "txt_x2";
            txt_x2.ReadOnly = true;
            txt_x2.Size = new Size(150, 23);
            txt_x2.TabIndex = 6;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.MediumTurquoise;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpiar.Location = new Point(513, 352);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(141, 56);
            btn_limpiar.TabIndex = 8;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumTurquoise;
            label1.Font = new Font("JetBrains Mono", 21.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(237, 42);
            label1.Name = "label1";
            label1.Size = new Size(683, 40);
            label1.TabIndex = 9;
            label1.Text = "Resolución de ecuaciones de 2do grado";
            // 
            // EcuacionCuadratica
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1163, 751);
            Controls.Add(label1);
            Controls.Add(btn_limpiar);
            Controls.Add(txt_x2);
            Controls.Add(txt_x1);
            Controls.Add(txt_c);
            Controls.Add(txt_a);
            Controls.Add(txt_b);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_a);
            Controls.Add(btn_calcular);
            Controls.Add(toolStrip1);
            Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EcuacionCuadratica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EcuacionCuadratica";
            Load += EcuacionCuadratica_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btn_close;
        private ToolStripButton btn_restore;
        private ToolStripButton btn_maximize;
        private ToolStripButton btn_minimize;
        private ToolStripButton btn_volver;
        private Button btn_calcular;
        private Label lbl_a;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_b;
        private TextBox txt_a;
        private TextBox txt_c;
        private TextBox txt_x1;
        private TextBox txt_x2;
        private Button btn_limpiar;
        private Label label1;
    }
}