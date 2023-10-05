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
            tsp_top.SuspendLayout();
            SuspendLayout();
            // 
            // tsp_top
            // 
            tsp_top.BackColor = Color.MediumSlateBlue;
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
            // Herencia
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1163, 751);
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
    }
}