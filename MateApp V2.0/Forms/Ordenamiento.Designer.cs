namespace MateApp_V2._0.Forms
{
    partial class Ordenamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordenamiento));
            label1 = new Label();
            tsp_top = new ToolStrip();
            btn_close = new ToolStripButton();
            btn_restore = new ToolStripButton();
            btn_maximize = new ToolStripButton();
            btn_minimize = new ToolStripButton();
            btn_volver = new ToolStripButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_num2 = new TextBox();
            txt_num1 = new TextBox();
            txt_num3 = new TextBox();
            btn_calcular = new Button();
            btn_limpiar = new Button();
            txt_mayor = new TextBox();
            txt_menor = new TextBox();
            txt_centro = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tsp_top.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleVioletRed;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(494, 41);
            label1.Name = "label1";
            label1.Size = new Size(200, 33);
            label1.TabIndex = 0;
            label1.Text = "Ordenamiento";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleVioletRed;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(138, 222);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 3;
            label2.Text = "Número 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PaleVioletRed;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(138, 408);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 4;
            label3.Text = "Número 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PaleVioletRed;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(138, 315);
            label4.Name = "label4";
            label4.Size = new Size(87, 18);
            label4.TabIndex = 5;
            label4.Text = "Número 2:";
            // 
            // txt_num2
            // 
            txt_num2.Location = new Point(138, 359);
            txt_num2.Name = "txt_num2";
            txt_num2.Size = new Size(180, 23);
            txt_num2.TabIndex = 2;
            // 
            // txt_num1
            // 
            txt_num1.Location = new Point(138, 266);
            txt_num1.Name = "txt_num1";
            txt_num1.Size = new Size(180, 23);
            txt_num1.TabIndex = 1;
            txt_num1.KeyPress += textBox2_KeyPress;
            // 
            // txt_num3
            // 
            txt_num3.Location = new Point(138, 452);
            txt_num3.Name = "txt_num3";
            txt_num3.Size = new Size(180, 23);
            txt_num3.TabIndex = 3;
            // 
            // btn_calcular
            // 
            btn_calcular.Anchor = AnchorStyles.Bottom;
            btn_calcular.BackColor = Color.PaleVioletRed;
            btn_calcular.Cursor = Cursors.Hand;
            btn_calcular.Font = new Font("Microsoft Sans Serif", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_calcular.ForeColor = Color.White;
            btn_calcular.Location = new Point(516, 283);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(141, 56);
            btn_calcular.TabIndex = 4;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = false;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Anchor = AnchorStyles.Bottom;
            btn_limpiar.BackColor = Color.PaleVioletRed;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Font = new Font("Microsoft Sans Serif", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpiar.ForeColor = Color.White;
            btn_limpiar.Location = new Point(516, 359);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(141, 56);
            btn_limpiar.TabIndex = 10;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // txt_mayor
            // 
            txt_mayor.Enabled = false;
            txt_mayor.Location = new Point(886, 359);
            txt_mayor.Name = "txt_mayor";
            txt_mayor.ReadOnly = true;
            txt_mayor.Size = new Size(180, 23);
            txt_mayor.TabIndex = 16;
            // 
            // txt_menor
            // 
            txt_menor.Enabled = false;
            txt_menor.Location = new Point(886, 266);
            txt_menor.Name = "txt_menor";
            txt_menor.ReadOnly = true;
            txt_menor.Size = new Size(180, 23);
            txt_menor.TabIndex = 15;
            // 
            // txt_centro
            // 
            txt_centro.Enabled = false;
            txt_centro.Location = new Point(886, 452);
            txt_centro.Name = "txt_centro";
            txt_centro.ReadOnly = true;
            txt_centro.Size = new Size(180, 23);
            txt_centro.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.PaleVioletRed;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(886, 315);
            label5.Name = "label5";
            label5.Size = new Size(153, 18);
            label5.TabIndex = 13;
            label5.Text = "Número del centro:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.PaleVioletRed;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(886, 408);
            label6.Name = "label6";
            label6.Size = new Size(120, 18);
            label6.TabIndex = 12;
            label6.Text = "Número mayor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.PaleVioletRed;
            label7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(886, 222);
            label7.Name = "label7";
            label7.Size = new Size(126, 18);
            label7.TabIndex = 11;
            label7.Text = "Número menor:";
            // 
            // Ordenamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1163, 751);
            Controls.Add(txt_mayor);
            Controls.Add(txt_menor);
            Controls.Add(txt_centro);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(btn_calcular);
            Controls.Add(btn_limpiar);
            Controls.Add(txt_num3);
            Controls.Add(txt_num1);
            Controls.Add(txt_num2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tsp_top);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Ordenamiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ordenamiento";
            Load += Ordenamiento_Load;
            tsp_top.ResumeLayout(false);
            tsp_top.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ToolStrip tsp_top;
        private ToolStripButton btn_close;
        private ToolStripButton btn_restore;
        private ToolStripButton btn_maximize;
        private ToolStripButton btn_minimize;
        private ToolStripButton btn_volver;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_num2;
        private TextBox txt_num1;
        private TextBox txt_num3;
        private Button btn_calcular;
        private Button btn_limpiar;
        private TextBox txt_mayor;
        private TextBox txt_menor;
        private TextBox txt_centro;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}