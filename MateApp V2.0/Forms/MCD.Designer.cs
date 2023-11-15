namespace MateApp_V2._0.Forms
{
    partial class MCD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MCD));
            tsp_top = new ToolStrip();
            btn_close = new ToolStripButton();
            btn_restore = new ToolStripButton();
            btn_maximize = new ToolStripButton();
            btn_minimize = new ToolStripButton();
            btn_volver = new ToolStripButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_num1 = new TextBox();
            txt_num2 = new TextBox();
            txt_mcd = new TextBox();
            btn_calcular = new Button();
            btn_limpiar = new Button();
            label4 = new Label();
            tsp_top.SuspendLayout();
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
            tsp_top.Padding = new Padding(0, 0, 3, 0);
            tsp_top.Size = new Size(1163, 33);
            tsp_top.TabIndex = 7;
            tsp_top.Text = "toolStrip1";
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
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.PowderBlue;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(526, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 52);
            label1.TabIndex = 8;
            label1.Text = "MCD";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.PowderBlue;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(161, 338);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 26);
            label2.TabIndex = 9;
            label2.Text = "Número 1:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.BackColor = Color.PowderBlue;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(161, 561);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 26);
            label3.TabIndex = 10;
            label3.Text = "Número 2:";
            // 
            // txt_num1
            // 
            txt_num1.Anchor = AnchorStyles.Bottom;
            txt_num1.Location = new Point(161, 391);
            txt_num1.Margin = new Padding(4, 5, 4, 5);
            txt_num1.Name = "txt_num1";
            txt_num1.Size = new Size(180, 31);
            txt_num1.TabIndex = 11;
            txt_num1.KeyPress += txt_num1_KeyPress;
            // 
            // txt_num2
            // 
            txt_num2.Anchor = AnchorStyles.Bottom;
            txt_num2.Location = new Point(161, 607);
            txt_num2.Margin = new Padding(4, 5, 4, 5);
            txt_num2.Name = "txt_num2";
            txt_num2.Size = new Size(180, 31);
            txt_num2.TabIndex = 12;
            txt_num2.KeyPress += txt_num2_KeyPress;
            // 
            // txt_mcd
            // 
            txt_mcd.Anchor = AnchorStyles.Bottom;
            txt_mcd.Location = new Point(857, 471);
            txt_mcd.Margin = new Padding(4, 5, 4, 5);
            txt_mcd.Name = "txt_mcd";
            txt_mcd.Size = new Size(180, 31);
            txt_mcd.TabIndex = 13;
            // 
            // btn_calcular
            // 
            btn_calcular.Anchor = AnchorStyles.Bottom;
            btn_calcular.BackColor = Color.PowderBlue;
            btn_calcular.Cursor = Cursors.Hand;
            btn_calcular.Font = new Font("Microsoft Sans Serif", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_calcular.ForeColor = Color.White;
            btn_calcular.Location = new Point(495, 376);
            btn_calcular.Margin = new Padding(4, 5, 4, 5);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(201, 93);
            btn_calcular.TabIndex = 14;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = false;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Anchor = AnchorStyles.Bottom;
            btn_limpiar.BackColor = Color.PowderBlue;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Font = new Font("Microsoft Sans Serif", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpiar.ForeColor = Color.White;
            btn_limpiar.Location = new Point(495, 526);
            btn_limpiar.Margin = new Padding(4, 5, 4, 5);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(201, 93);
            btn_limpiar.TabIndex = 15;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.BackColor = Color.PowderBlue;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(879, 409);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 26);
            label4.TabIndex = 16;
            label4.Text = "El MCD es:";
            // 
            // MCD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1163, 751);
            Controls.Add(label4);
            Controls.Add(btn_calcular);
            Controls.Add(btn_limpiar);
            Controls.Add(txt_mcd);
            Controls.Add(txt_num2);
            Controls.Add(txt_num1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tsp_top);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "MCD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MCD";
            Load += MCD_Load;
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
        private Label label3;
        private TextBox txt_num1;
        private TextBox txt_num2;
        private TextBox txt_mcd;
        private Button btn_calcular;
        private Button btn_limpiar;
        private Label label4;
    }
}