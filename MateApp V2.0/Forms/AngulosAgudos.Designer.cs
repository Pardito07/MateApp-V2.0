namespace MateApp_V2._0.Forms
{
    partial class AngulosAgudos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AngulosAgudos));
            tsp_top = new ToolStrip();
            btn_close = new ToolStripButton();
            btn_restore = new ToolStripButton();
            btn_maximize = new ToolStripButton();
            btn_minimize = new ToolStripButton();
            btn_volver = new ToolStripButton();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txt_c = new TextBox();
            label6 = new Label();
            txt_b = new TextBox();
            label5 = new Label();
            txt_hipotenusa = new TextBox();
            label4 = new Label();
            btn_limpiar = new Button();
            btn_calcular = new Button();
            txt_menor = new TextBox();
            txt_mayor = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tsp_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tsp_top
            // 
            tsp_top.BackColor = Color.RoyalBlue;
            tsp_top.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            tsp_top.ImageScalingSize = new Size(24, 24);
            tsp_top.Items.AddRange(new ToolStripItem[] { btn_close, btn_restore, btn_maximize, btn_minimize, btn_volver });
            tsp_top.Location = new Point(0, 0);
            tsp_top.Name = "tsp_top";
            tsp_top.Size = new Size(1163, 33);
            tsp_top.TabIndex = 2;
            tsp_top.Text = "toolStrip1";
            tsp_top.MouseDown += tsp_top_MouseDown;
            // 
            // btn_close
            // 
            btn_close.Alignment = ToolStripItemAlignment.Right;
            btn_close.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_close.Image = (Image)resources.GetObject("btn_close.Image");
            btn_close.ImageTransparentColor = Color.Magenta;
            btn_close.Name = "btn_close";
            btn_close.RightToLeft = RightToLeft.No;
            btn_close.Size = new Size(34, 28);
            btn_close.Text = "Cerrar";
            btn_close.Click += btn_close_Click;
            // 
            // btn_restore
            // 
            btn_restore.Alignment = ToolStripItemAlignment.Right;
            btn_restore.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_restore.Image = (Image)resources.GetObject("btn_restore.Image");
            btn_restore.ImageTransparentColor = Color.Magenta;
            btn_restore.Name = "btn_restore";
            btn_restore.Size = new Size(34, 28);
            btn_restore.Text = "restaurar";
            btn_restore.Click += btn_restore_Click;
            // 
            // btn_maximize
            // 
            btn_maximize.Alignment = ToolStripItemAlignment.Right;
            btn_maximize.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_maximize.Image = (Image)resources.GetObject("btn_maximize.Image");
            btn_maximize.ImageTransparentColor = Color.Magenta;
            btn_maximize.Name = "btn_maximize";
            btn_maximize.Size = new Size(34, 28);
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
            btn_minimize.Size = new Size(34, 28);
            btn_minimize.Text = "Minimizar";
            btn_minimize.Click += btn_minimize_Click;
            // 
            // btn_volver
            // 
            btn_volver.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_volver.Image = (Image)resources.GetObject("btn_volver.Image");
            btn_volver.ImageTransparentColor = Color.Magenta;
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(34, 28);
            btn_volver.Text = "Volver";
            btn_volver.Click += btn_volver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(723, 289);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font("JetBrains Mono", 21.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(129, 56);
            label3.Name = "label3";
            label3.Size = new Size(961, 58);
            label3.TabIndex = 8;
            label3.Text = "Ángulos agudos, triángulo rectángulo";
            // 
            // txt_c
            // 
            txt_c.Anchor = AnchorStyles.Bottom;
            txt_c.BorderStyle = BorderStyle.FixedSingle;
            txt_c.Enabled = false;
            txt_c.Location = new Point(280, 602);
            txt_c.Name = "txt_c";
            txt_c.ReadOnly = true;
            txt_c.ShortcutsEnabled = false;
            txt_c.Size = new Size(180, 31);
            txt_c.TabIndex = 21;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(66, 604);
            label6.Name = "label6";
            label6.Size = new Size(208, 29);
            label6.TabIndex = 27;
            label6.Text = "Ángulo agudo C:";
            // 
            // txt_b
            // 
            txt_b.Anchor = AnchorStyles.Bottom;
            txt_b.BorderStyle = BorderStyle.FixedSingle;
            txt_b.Enabled = false;
            txt_b.Location = new Point(280, 524);
            txt_b.Name = "txt_b";
            txt_b.ReadOnly = true;
            txt_b.ShortcutsEnabled = false;
            txt_b.Size = new Size(180, 31);
            txt_b.TabIndex = 19;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(66, 524);
            label5.Name = "label5";
            label5.Size = new Size(208, 29);
            label5.TabIndex = 26;
            label5.Text = "Ángulo agudo B:";
            // 
            // txt_hipotenusa
            // 
            txt_hipotenusa.Anchor = AnchorStyles.Bottom;
            txt_hipotenusa.BorderStyle = BorderStyle.FixedSingle;
            txt_hipotenusa.Enabled = false;
            txt_hipotenusa.Location = new Point(280, 454);
            txt_hipotenusa.Name = "txt_hipotenusa";
            txt_hipotenusa.ReadOnly = true;
            txt_hipotenusa.ShortcutsEnabled = false;
            txt_hipotenusa.Size = new Size(180, 31);
            txt_hipotenusa.TabIndex = 18;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(66, 456);
            label4.Name = "label4";
            label4.Size = new Size(208, 29);
            label4.TabIndex = 25;
            label4.Text = "Hipotenusa    :";
            // 
            // btn_limpiar
            // 
            btn_limpiar.Anchor = AnchorStyles.Bottom;
            btn_limpiar.BackColor = Color.RoyalBlue;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpiar.ForeColor = Color.White;
            btn_limpiar.Location = new Point(293, 348);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(141, 56);
            btn_limpiar.TabIndex = 24;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_calcular
            // 
            btn_calcular.Anchor = AnchorStyles.Bottom;
            btn_calcular.BackColor = Color.RoyalBlue;
            btn_calcular.Cursor = Cursors.Hand;
            btn_calcular.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_calcular.ForeColor = Color.White;
            btn_calcular.Location = new Point(66, 348);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(141, 56);
            btn_calcular.TabIndex = 23;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = false;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // txt_menor
            // 
            txt_menor.Anchor = AnchorStyles.Bottom;
            txt_menor.BorderStyle = BorderStyle.FixedSingle;
            txt_menor.Location = new Point(280, 260);
            txt_menor.Name = "txt_menor";
            txt_menor.ShortcutsEnabled = false;
            txt_menor.Size = new Size(180, 31);
            txt_menor.TabIndex = 17;
            txt_menor.KeyPress += txt_menor_KeyPress;
            // 
            // txt_mayor
            // 
            txt_mayor.Anchor = AnchorStyles.Bottom;
            txt_mayor.BorderStyle = BorderStyle.FixedSingle;
            txt_mayor.Location = new Point(280, 205);
            txt_mayor.Name = "txt_mayor";
            txt_mayor.ShortcutsEnabled = false;
            txt_mayor.Size = new Size(180, 31);
            txt_mayor.TabIndex = 16;
            txt_mayor.KeyPress += txt_mayor_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(66, 260);
            label2.Name = "label2";
            label2.Size = new Size(182, 29);
            label2.TabIndex = 22;
            label2.Text = "Cateto Menor:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(66, 204);
            label1.Name = "label1";
            label1.Size = new Size(182, 29);
            label1.TabIndex = 20;
            label1.Text = "Cateto Mayor:";
            // 
            // AngulosAgudos
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1163, 751);
            Controls.Add(txt_c);
            Controls.Add(label6);
            Controls.Add(txt_b);
            Controls.Add(label5);
            Controls.Add(txt_hipotenusa);
            Controls.Add(label4);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_calcular);
            Controls.Add(txt_menor);
            Controls.Add(txt_mayor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(tsp_top);
            Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AngulosAgudos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AngulosAgudos";
            Load += AngulosAgudos_Load;
            tsp_top.ResumeLayout(false);
            tsp_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsp_top;
        private ToolStripButton btn_close;
        private ToolStripButton btn_restore;
        private ToolStripButton btn_maximize;
        private ToolStripButton btn_minimize;
        private ToolStripButton btn_volver;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txt_c;
        private Label label6;
        private TextBox txt_b;
        private Label label5;
        private TextBox txt_hipotenusa;
        private Label label4;
        private Button btn_limpiar;
        private Button btn_calcular;
        private TextBox txt_menor;
        private TextBox txt_mayor;
        private Label label2;
        private Label label1;
    }
}