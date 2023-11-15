namespace MateApp_V2._0.Forms
{
    partial class PlanoCartesiano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanoCartesiano));
            tsp_top = new ToolStrip();
            btn_close = new ToolStripButton();
            btn_restore = new ToolStripButton();
            btn_maximize = new ToolStripButton();
            btn_minimize = new ToolStripButton();
            btn_volver = new ToolStripButton();
            btn_calcular = new Button();
            btn_limpiar = new Button();
            pictureBox1 = new PictureBox();
            txt_x = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_y = new TextBox();
            lbl_mensaje = new Label();
            label3 = new Label();
            tsp_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tsp_top
            // 
            tsp_top.BackColor = Color.LightCoral;
            tsp_top.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            tsp_top.ImageScalingSize = new Size(24, 24);
            tsp_top.Items.AddRange(new ToolStripItem[] { btn_close, btn_restore, btn_maximize, btn_minimize, btn_volver });
            tsp_top.Location = new Point(0, 0);
            tsp_top.Name = "tsp_top";
            tsp_top.Padding = new Padding(0, 0, 3, 0);
            tsp_top.Size = new Size(1163, 33);
            tsp_top.TabIndex = 7;
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
            // btn_calcular
            // 
            btn_calcular.Anchor = AnchorStyles.Bottom;
            btn_calcular.BackColor = Color.CornflowerBlue;
            btn_calcular.Cursor = Cursors.Hand;
            btn_calcular.Font = new Font("Microsoft Sans Serif", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_calcular.ForeColor = Color.White;
            btn_calcular.Location = new Point(474, 312);
            btn_calcular.Margin = new Padding(4, 5, 4, 5);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(201, 93);
            btn_calcular.TabIndex = 8;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = false;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Anchor = AnchorStyles.Bottom;
            btn_limpiar.BackColor = Color.CornflowerBlue;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Font = new Font("Microsoft Sans Serif", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpiar.ForeColor = Color.White;
            btn_limpiar.Location = new Point(474, 439);
            btn_limpiar.Margin = new Padding(4, 5, 4, 5);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(201, 93);
            btn_limpiar.TabIndex = 9;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(775, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // txt_x
            // 
            txt_x.Anchor = AnchorStyles.Bottom;
            txt_x.BorderStyle = BorderStyle.FixedSingle;
            txt_x.Location = new Point(191, 356);
            txt_x.Name = "txt_x";
            txt_x.Size = new Size(180, 31);
            txt_x.TabIndex = 11;
            txt_x.KeyPress += txt_x_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.CornflowerBlue;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(191, 315);
            label1.Name = "label1";
            label1.Size = new Size(65, 26);
            label1.TabIndex = 12;
            label1.Text = "Eje X";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.CornflowerBlue;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(191, 415);
            label2.Name = "label2";
            label2.Size = new Size(66, 26);
            label2.TabIndex = 14;
            label2.Text = "Eje Y";
            // 
            // txt_y
            // 
            txt_y.Anchor = AnchorStyles.Bottom;
            txt_y.BorderStyle = BorderStyle.FixedSingle;
            txt_y.Location = new Point(191, 456);
            txt_y.Name = "txt_y";
            txt_y.Size = new Size(180, 31);
            txt_y.TabIndex = 13;
            txt_y.KeyPress += txt_y_KeyPress;
            // 
            // lbl_mensaje
            // 
            lbl_mensaje.Anchor = AnchorStyles.Bottom;
            lbl_mensaje.AutoSize = true;
            lbl_mensaje.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_mensaje.Location = new Point(802, 472);
            lbl_mensaje.Name = "lbl_mensaje";
            lbl_mensaje.Size = new Size(0, 26);
            lbl_mensaje.TabIndex = 15;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(421, 44);
            label3.Name = "label3";
            label3.Size = new Size(346, 52);
            label3.TabIndex = 16;
            label3.Text = "Plano cartesiano";
            // 
            // PlanoCartesiano
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1163, 751);
            Controls.Add(label3);
            Controls.Add(lbl_mensaje);
            Controls.Add(label2);
            Controls.Add(txt_y);
            Controls.Add(label1);
            Controls.Add(txt_x);
            Controls.Add(pictureBox1);
            Controls.Add(btn_calcular);
            Controls.Add(btn_limpiar);
            Controls.Add(tsp_top);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "PlanoCartesiano";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlanoCartesiano";
            Load += PlanoCartesiano_Load;
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
        private Button btn_calcular;
        private Button btn_limpiar;
        private PictureBox pictureBox1;
        private TextBox txt_x;
        private Label label1;
        private Label label2;
        private TextBox txt_y;
        private Label lbl_mensaje;
        private Label label3;
    }
}