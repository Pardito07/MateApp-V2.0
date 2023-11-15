namespace MateApp_V2._0.Forms
{
    partial class Creditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creditos));
            tsp_top = new ToolStrip();
            btn_close = new ToolStripButton();
            btn_restore = new ToolStripButton();
            btn_maximize = new ToolStripButton();
            btn_minimize = new ToolStripButton();
            btn_volver = new ToolStripButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            tsp_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // tsp_top
            // 
            tsp_top.BackColor = Color.Transparent;
            tsp_top.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            tsp_top.ImageScalingSize = new Size(24, 24);
            tsp_top.Items.AddRange(new ToolStripItem[] { btn_close, btn_restore, btn_maximize, btn_minimize, btn_volver });
            tsp_top.Location = new Point(0, 0);
            tsp_top.Name = "tsp_top";
            tsp_top.Size = new Size(1163, 31);
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
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(686, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 276);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(490, 419);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(236, 276);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(506, 46);
            label1.Name = "label1";
            label1.Size = new Size(132, 33);
            label1.TabIndex = 6;
            label1.Text = "Créditos";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(497, 698);
            label2.Name = "label2";
            label2.Size = new Size(136, 18);
            label2.TabIndex = 7;
            label2.Text = "José Landaverde";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(686, 386);
            label3.Name = "label3";
            label3.Size = new Size(132, 18);
            label3.TabIndex = 8;
            label3.Text = "Francisco Alfaro";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(307, 107);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(236, 276);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(338, 386);
            label6.Name = "label6";
            label6.Size = new Size(107, 18);
            label6.TabIndex = 13;
            label6.Text = "Diego García";
            // 
            // Creditos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1163, 751);
            Controls.Add(label6);
            Controls.Add(pictureBox5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(tsp_top);
            Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Creditos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Creditos";
            Load += Creditos_Load;
            tsp_top.ResumeLayout(false);
            tsp_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox5;
        private Label label6;
    }
}