namespace MateApp_V2._0.Forms
{
    partial class PromedioVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromedioVentas));
            tsp_top = new ToolStrip();
            btn_close = new ToolStripButton();
            btn_restore = new ToolStripButton();
            btn_maximize = new ToolStripButton();
            btn_minimize = new ToolStripButton();
            btn_volver = new ToolStripButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_venta1 = new TextBox();
            txt_venta2 = new TextBox();
            txt_venta3 = new TextBox();
            btn_limpiar = new Button();
            btn_calcular = new Button();
            txt_promedio = new TextBox();
            label5 = new Label();
            lbl_mensaje = new Label();
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
            tsp_top.Size = new Size(1163, 31);
            tsp_top.TabIndex = 6;
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
            btn_close.Click += btn_close_Click;
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
            btn_restore.Click += btn_restore_Click;
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
            btn_maximize.Click += btn_maximize_Click;
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
            btn_minimize.Click += btn_minimize_Click;
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(431, 50);
            label1.Name = "label1";
            label1.Size = new Size(274, 33);
            label1.TabIndex = 7;
            label1.Text = "Promedio de ventas";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(137, 189);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 8;
            label2.Text = "Venta 1";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(137, 361);
            label3.Name = "label3";
            label3.Size = new Size(64, 18);
            label3.TabIndex = 9;
            label3.Text = "Venta 3";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(137, 275);
            label4.Name = "label4";
            label4.Size = new Size(64, 18);
            label4.TabIndex = 10;
            label4.Text = "Venta 2";
            // 
            // txt_venta1
            // 
            txt_venta1.Anchor = AnchorStyles.Bottom;
            txt_venta1.Location = new Point(137, 228);
            txt_venta1.Name = "txt_venta1";
            txt_venta1.Size = new Size(180, 23);
            txt_venta1.TabIndex = 1;
            txt_venta1.KeyPress += txt_venta1_KeyPress;
            // 
            // txt_venta2
            // 
            txt_venta2.Anchor = AnchorStyles.Bottom;
            txt_venta2.Location = new Point(137, 314);
            txt_venta2.Name = "txt_venta2";
            txt_venta2.Size = new Size(180, 23);
            txt_venta2.TabIndex = 2;
            txt_venta2.KeyPress += txt_venta2_KeyPress;
            // 
            // txt_venta3
            // 
            txt_venta3.Anchor = AnchorStyles.Bottom;
            txt_venta3.Location = new Point(137, 400);
            txt_venta3.Name = "txt_venta3";
            txt_venta3.Size = new Size(180, 23);
            txt_venta3.TabIndex = 3;
            txt_venta3.KeyPress += txt_venta3_KeyPress;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Anchor = AnchorStyles.Bottom;
            btn_limpiar.BackColor = Color.Orange;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Font = new Font("Microsoft Sans Serif", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpiar.ForeColor = Color.White;
            btn_limpiar.Location = new Point(498, 332);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(141, 56);
            btn_limpiar.TabIndex = 5;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_calcular
            // 
            btn_calcular.Anchor = AnchorStyles.Bottom;
            btn_calcular.BackColor = Color.Orange;
            btn_calcular.Cursor = Cursors.Hand;
            btn_calcular.Font = new Font("Microsoft Sans Serif", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_calcular.ForeColor = Color.White;
            btn_calcular.Location = new Point(498, 256);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(141, 56);
            btn_calcular.TabIndex = 4;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = false;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // txt_promedio
            // 
            txt_promedio.Anchor = AnchorStyles.Bottom;
            txt_promedio.Enabled = false;
            txt_promedio.Location = new Point(860, 275);
            txt_promedio.Name = "txt_promedio";
            txt_promedio.ReadOnly = true;
            txt_promedio.Size = new Size(180, 23);
            txt_promedio.TabIndex = 30;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(852, 236);
            label5.Name = "label5";
            label5.Size = new Size(199, 18);
            label5.TabIndex = 29;
            label5.Text = "El promedio de ventas es de:\r\n";
            // 
            // lbl_mensaje
            // 
            lbl_mensaje.Anchor = AnchorStyles.Bottom;
            lbl_mensaje.AutoSize = true;
            lbl_mensaje.BackColor = Color.Transparent;
            lbl_mensaje.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_mensaje.Location = new Point(878, 351);
            lbl_mensaje.Name = "lbl_mensaje";
            lbl_mensaje.Size = new Size(0, 18);
            lbl_mensaje.TabIndex = 31;
            // 
            // PromedioVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1163, 751);
            Controls.Add(lbl_mensaje);
            Controls.Add(txt_promedio);
            Controls.Add(label5);
            Controls.Add(btn_calcular);
            Controls.Add(btn_limpiar);
            Controls.Add(txt_venta3);
            Controls.Add(txt_venta2);
            Controls.Add(txt_venta1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tsp_top);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PromedioVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PromedioVentas";
            Load += PromedioVentas_Load;
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
        private Label label4;
        private TextBox txt_venta1;
        private TextBox txt_venta2;
        private TextBox txt_venta3;
        private Button btn_limpiar;
        private Button btn_calcular;
        private TextBox txt_promedio;
        private Label label5;
        private Label lbl_mensaje;
    }
}