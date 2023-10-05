namespace MateApp_V2._0.Forms
{
    partial class Determinante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Determinante));
            toolStrip1 = new ToolStrip();
            btn_close = new ToolStripButton();
            btn_restore = new ToolStripButton();
            btn_maximize = new ToolStripButton();
            btn_minimize = new ToolStripButton();
            btn_volver = new ToolStripButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            txt_a1 = new TextBox();
            txt_b1 = new TextBox();
            txt_r1 = new TextBox();
            label8 = new Label();
            txt_s2 = new TextBox();
            txt_d2 = new TextBox();
            txt_c2 = new TextBox();
            label9 = new Label();
            label11 = new Label();
            label13 = new Label();
            btn_limpiar = new Button();
            btn_retirar = new Button();
            label14 = new Label();
            label15 = new Label();
            txt_x = new TextBox();
            txt_y = new TextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.LightSalmon;
            toolStrip1.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_close, btn_restore, btn_maximize, btn_minimize, btn_volver });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1163, 33);
            toolStrip1.TabIndex = 4;
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
            btn_maximize.Click += btn_maximize_Click;
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("JetBrains Mono", 21.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(135, 56);
            label1.Name = "label1";
            label1.Size = new Size(909, 58);
            label1.TabIndex = 5;
            label1.Text = "Sistema de ecuaciones lineales 2x2";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 172);
            label2.Name = "label2";
            label2.Size = new Size(156, 29);
            label2.TabIndex = 6;
            label2.Text = "Ecuación 1:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 241);
            label3.Name = "label3";
            label3.Size = new Size(36, 26);
            label3.TabIndex = 7;
            label3.Text = "a:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(500, 241);
            label5.Name = "label5";
            label5.Size = new Size(36, 26);
            label5.TabIndex = 9;
            label5.Text = "b:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(934, 241);
            label7.Name = "label7";
            label7.Size = new Size(36, 26);
            label7.TabIndex = 11;
            label7.Text = "r:";
            // 
            // txt_a1
            // 
            txt_a1.Anchor = AnchorStyles.Bottom;
            txt_a1.BorderStyle = BorderStyle.FixedSingle;
            txt_a1.Location = new Point(88, 239);
            txt_a1.Name = "txt_a1";
            txt_a1.Size = new Size(150, 31);
            txt_a1.TabIndex = 12;
            txt_a1.KeyPress += txt_a1_KeyPress;
            // 
            // txt_b1
            // 
            txt_b1.Anchor = AnchorStyles.Bottom;
            txt_b1.BorderStyle = BorderStyle.FixedSingle;
            txt_b1.Location = new Point(538, 239);
            txt_b1.Name = "txt_b1";
            txt_b1.Size = new Size(150, 31);
            txt_b1.TabIndex = 14;
            txt_b1.KeyPress += txt_b1_KeyPress;
            // 
            // txt_r1
            // 
            txt_r1.Anchor = AnchorStyles.Bottom;
            txt_r1.BorderStyle = BorderStyle.FixedSingle;
            txt_r1.Location = new Point(972, 239);
            txt_r1.Name = "txt_r1";
            txt_r1.Size = new Size(150, 31);
            txt_r1.TabIndex = 16;
            txt_r1.KeyPress += txt_r1_KeyPress;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(50, 318);
            label8.Name = "label8";
            label8.Size = new Size(156, 29);
            label8.TabIndex = 17;
            label8.Text = "Ecuación 2:";
            // 
            // txt_s2
            // 
            txt_s2.Anchor = AnchorStyles.Bottom;
            txt_s2.BorderStyle = BorderStyle.FixedSingle;
            txt_s2.Location = new Point(972, 387);
            txt_s2.Name = "txt_s2";
            txt_s2.Size = new Size(150, 31);
            txt_s2.TabIndex = 27;
            txt_s2.KeyPress += txt_s2_KeyPress;
            // 
            // txt_d2
            // 
            txt_d2.Anchor = AnchorStyles.Bottom;
            txt_d2.BorderStyle = BorderStyle.FixedSingle;
            txt_d2.Location = new Point(538, 387);
            txt_d2.Name = "txt_d2";
            txt_d2.Size = new Size(150, 31);
            txt_d2.TabIndex = 25;
            txt_d2.KeyPress += txt_d2_KeyPress;
            // 
            // txt_c2
            // 
            txt_c2.Anchor = AnchorStyles.Bottom;
            txt_c2.BorderStyle = BorderStyle.FixedSingle;
            txt_c2.Location = new Point(88, 387);
            txt_c2.Name = "txt_c2";
            txt_c2.Size = new Size(150, 31);
            txt_c2.TabIndex = 23;
            txt_c2.KeyPress += txt_c2_KeyPress;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("JetBrains Mono", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(934, 389);
            label9.Name = "label9";
            label9.Size = new Size(36, 26);
            label9.TabIndex = 22;
            label9.Text = "s:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.Font = new Font("JetBrains Mono", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(500, 389);
            label11.Name = "label11";
            label11.Size = new Size(36, 26);
            label11.TabIndex = 20;
            label11.Text = "d:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom;
            label13.AutoSize = true;
            label13.Font = new Font("JetBrains Mono", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(50, 389);
            label13.Name = "label13";
            label13.Size = new Size(36, 26);
            label13.TabIndex = 18;
            label13.Text = "c:";
            // 
            // btn_limpiar
            // 
            btn_limpiar.Anchor = AnchorStyles.Bottom;
            btn_limpiar.BackColor = Color.LightSalmon;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpiar.ForeColor = Color.White;
            btn_limpiar.Location = new Point(618, 476);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(141, 56);
            btn_limpiar.TabIndex = 29;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_retirar
            // 
            btn_retirar.Anchor = AnchorStyles.Bottom;
            btn_retirar.BackColor = Color.LightSalmon;
            btn_retirar.Cursor = Cursors.Hand;
            btn_retirar.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_retirar.ForeColor = Color.White;
            btn_retirar.Location = new Point(391, 476);
            btn_retirar.Name = "btn_retirar";
            btn_retirar.Size = new Size(141, 56);
            btn_retirar.TabIndex = 28;
            btn_retirar.Text = "Calcular";
            btn_retirar.UseVisualStyleBackColor = false;
            btn_retirar.Click += btn_retirar_Click;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom;
            label14.AutoSize = true;
            label14.Location = new Point(622, 615);
            label14.Name = "label14";
            label14.Size = new Size(43, 23);
            label14.TabIndex = 30;
            label14.Text = "y =";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom;
            label15.AutoSize = true;
            label15.Location = new Point(342, 615);
            label15.Name = "label15";
            label15.Size = new Size(43, 23);
            label15.TabIndex = 31;
            label15.Text = "x =";
            // 
            // txt_x
            // 
            txt_x.Anchor = AnchorStyles.Bottom;
            txt_x.BorderStyle = BorderStyle.FixedSingle;
            txt_x.Enabled = false;
            txt_x.Location = new Point(391, 611);
            txt_x.Name = "txt_x";
            txt_x.ReadOnly = true;
            txt_x.Size = new Size(150, 31);
            txt_x.TabIndex = 32;
            // 
            // txt_y
            // 
            txt_y.Anchor = AnchorStyles.Bottom;
            txt_y.BorderStyle = BorderStyle.FixedSingle;
            txt_y.Enabled = false;
            txt_y.Location = new Point(671, 611);
            txt_y.Name = "txt_y";
            txt_y.ReadOnly = true;
            txt_y.Size = new Size(150, 31);
            txt_y.TabIndex = 33;
            // 
            // Determinante
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1163, 751);
            Controls.Add(txt_y);
            Controls.Add(txt_x);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_retirar);
            Controls.Add(txt_s2);
            Controls.Add(txt_d2);
            Controls.Add(txt_c2);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(txt_r1);
            Controls.Add(txt_b1);
            Controls.Add(txt_a1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Determinante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Determinante";
            Load += Determinante_Load;
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label7;
        private TextBox txt_a1;
        private TextBox txt_b1;
        private TextBox txt_r1;
        private Label label8;
        private TextBox txt_s2;
        private TextBox txt_d2;
        private TextBox txt_c2;
        private Label label9;
        private Label label11;
        private Label label13;
        private Button btn_limpiar;
        private Button btn_retirar;
        private Label label14;
        private Label label15;
        private TextBox txt_x;
        private TextBox txt_y;
    }
}