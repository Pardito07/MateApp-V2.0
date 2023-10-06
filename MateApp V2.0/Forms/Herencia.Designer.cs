namespace MateApp_V2._0.Forms
{
    partial class Herencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Herencia));
            tsp_top = new ToolStrip();
            btn_close = new ToolStripButton();
            btn_restore = new ToolStripButton();
            btn_maximize = new ToolStripButton();
            btn_minimize = new ToolStripButton();
            btn_volver = new ToolStripButton();
            label1 = new Label();
            label2 = new Label();
            txt_herencia = new TextBox();
            btn_limpiar = new Button();
            btn_calcular = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_luis = new TextBox();
            txt_juan = new TextBox();
            txt_rosa = new TextBox();
            tsp_top.SuspendLayout();
            SuspendLayout();
            // 
            // tsp_top
            // 
            tsp_top.BackColor = Color.Transparent;
            tsp_top.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            tsp_top.ImageScalingSize = new Size(24, 24);
            tsp_top.Items.AddRange(new ToolStripItem[] { btn_close, btn_restore, btn_maximize, btn_minimize, btn_volver });
            tsp_top.Location = new Point(0, 0);
            tsp_top.Name = "tsp_top";
            tsp_top.Size = new Size(1163, 33);
            tsp_top.TabIndex = 5;
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
            label1.BackColor = Color.DarkSeaGreen;
            label1.Font = new Font("JetBrains Mono", 21.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(451, 47);
            label1.Name = "label1";
            label1.Size = new Size(233, 58);
            label1.TabIndex = 6;
            label1.Text = "Herencia";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSeaGreen;
            label2.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 298);
            label2.Name = "label2";
            label2.Size = new Size(234, 58);
            label2.TabIndex = 7;
            label2.Text = "Ingrese el monto \r\nde la herencia: $";
            // 
            // txt_herencia
            // 
            txt_herencia.Anchor = AnchorStyles.Bottom;
            txt_herencia.BorderStyle = BorderStyle.FixedSingle;
            txt_herencia.Location = new Point(285, 311);
            txt_herencia.Name = "txt_herencia";
            txt_herencia.Size = new Size(180, 31);
            txt_herencia.TabIndex = 8;
            txt_herencia.KeyPress += txt_herencia_KeyPress;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Anchor = AnchorStyles.Bottom;
            btn_limpiar.BackColor = Color.DarkSeaGreen;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpiar.ForeColor = Color.White;
            btn_limpiar.Location = new Point(306, 434);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(141, 56);
            btn_limpiar.TabIndex = 26;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // btn_calcular
            // 
            btn_calcular.Anchor = AnchorStyles.Bottom;
            btn_calcular.BackColor = Color.DarkSeaGreen;
            btn_calcular.Cursor = Cursors.Hand;
            btn_calcular.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_calcular.ForeColor = Color.White;
            btn_calcular.Location = new Point(79, 434);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(141, 56);
            btn_calcular.TabIndex = 25;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = false;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSeaGreen;
            label3.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(709, 310);
            label3.Name = "label3";
            label3.Size = new Size(221, 29);
            label3.TabIndex = 27;
            label3.Text = "Herencia Luis: $";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.BackColor = Color.DarkSeaGreen;
            label4.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(709, 449);
            label4.Name = "label4";
            label4.Size = new Size(221, 29);
            label4.TabIndex = 28;
            label4.Text = "Herencia Rosa: $";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.BackColor = Color.DarkSeaGreen;
            label5.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(709, 385);
            label5.Name = "label5";
            label5.Size = new Size(221, 29);
            label5.TabIndex = 29;
            label5.Text = "Herencia Juan: $";
            // 
            // txt_luis
            // 
            txt_luis.Anchor = AnchorStyles.Bottom;
            txt_luis.BorderStyle = BorderStyle.FixedSingle;
            txt_luis.Enabled = false;
            txt_luis.Location = new Point(936, 311);
            txt_luis.Name = "txt_luis";
            txt_luis.ReadOnly = true;
            txt_luis.Size = new Size(180, 31);
            txt_luis.TabIndex = 30;
            // 
            // txt_juan
            // 
            txt_juan.Anchor = AnchorStyles.Bottom;
            txt_juan.BorderStyle = BorderStyle.FixedSingle;
            txt_juan.Enabled = false;
            txt_juan.Location = new Point(936, 385);
            txt_juan.Name = "txt_juan";
            txt_juan.ReadOnly = true;
            txt_juan.Size = new Size(180, 31);
            txt_juan.TabIndex = 31;
            // 
            // txt_rosa
            // 
            txt_rosa.Anchor = AnchorStyles.Bottom;
            txt_rosa.BorderStyle = BorderStyle.FixedSingle;
            txt_rosa.Enabled = false;
            txt_rosa.Location = new Point(936, 447);
            txt_rosa.Name = "txt_rosa";
            txt_rosa.ReadOnly = true;
            txt_rosa.Size = new Size(180, 31);
            txt_rosa.TabIndex = 32;
            // 
            // Herencia
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1163, 751);
            Controls.Add(txt_rosa);
            Controls.Add(txt_juan);
            Controls.Add(txt_luis);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_calcular);
            Controls.Add(txt_herencia);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tsp_top);
            Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Herencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Herencia";
            Load += Herencia_Load;
            tsp_top.ResumeLayout(false);
            tsp_top.PerformLayout();
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
        private Label label1;
        private Label label2;
        private TextBox txt_herencia;
        private Button btn_limpiar;
        private Button btn_calcular;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_luis;
        private TextBox txt_juan;
        private TextBox txt_rosa;
    }
}