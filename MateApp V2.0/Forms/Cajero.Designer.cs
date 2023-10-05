namespace MateApp_V2._0.Forms
{
    partial class Cajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cajero));
            toolStrip1 = new ToolStrip();
            btn_close = new ToolStripButton();
            btn_restore = new ToolStripButton();
            btn_maximize = new ToolStripButton();
            btn_minimize = new ToolStripButton();
            btn_volver = new ToolStripButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_cien = new TextBox();
            txt_veinte = new TextBox();
            txt_diez = new TextBox();
            txt_cinco = new TextBox();
            txt_uno = new TextBox();
            btn_limpiar = new Button();
            btn_retirar = new Button();
            txt_monto = new TextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Aquamarine;
            toolStrip1.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_close, btn_restore, btn_maximize, btn_minimize, btn_volver });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1163, 33);
            toolStrip1.TabIndex = 3;
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
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 310);
            label1.Name = "label1";
            label1.Size = new Size(234, 29);
            label1.TabIndex = 4;
            label1.Text = "Monto a retirar $";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("JetBrains Mono", 21.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(473, 60);
            label2.Name = "label2";
            label2.Size = new Size(181, 58);
            label2.TabIndex = 6;
            label2.Text = "Cajero";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(711, 240);
            label3.Name = "label3";
            label3.Size = new Size(234, 29);
            label3.TabIndex = 8;
            label3.Text = "Billetes de $100:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(716, 306);
            label4.Name = "label4";
            label4.Size = new Size(221, 29);
            label4.TabIndex = 10;
            label4.Text = "Billetes de $20:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(716, 363);
            label5.Name = "label5";
            label5.Size = new Size(221, 29);
            label5.TabIndex = 12;
            label5.Text = "Billetes de $10:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(716, 425);
            label6.Name = "label6";
            label6.Size = new Size(221, 29);
            label6.TabIndex = 14;
            label6.Text = "Billetes de $5 :";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(716, 479);
            label7.Name = "label7";
            label7.Size = new Size(221, 29);
            label7.TabIndex = 16;
            label7.Text = "Billetes de $1 :";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_cien
            // 
            txt_cien.Anchor = AnchorStyles.Bottom;
            txt_cien.BorderStyle = BorderStyle.FixedSingle;
            txt_cien.Enabled = false;
            txt_cien.Location = new Point(943, 241);
            txt_cien.Name = "txt_cien";
            txt_cien.ReadOnly = true;
            txt_cien.Size = new Size(180, 31);
            txt_cien.TabIndex = 17;
            // 
            // txt_veinte
            // 
            txt_veinte.Anchor = AnchorStyles.Bottom;
            txt_veinte.BorderStyle = BorderStyle.FixedSingle;
            txt_veinte.Enabled = false;
            txt_veinte.Location = new Point(943, 304);
            txt_veinte.Name = "txt_veinte";
            txt_veinte.ReadOnly = true;
            txt_veinte.Size = new Size(180, 31);
            txt_veinte.TabIndex = 18;
            // 
            // txt_diez
            // 
            txt_diez.Anchor = AnchorStyles.Bottom;
            txt_diez.BorderStyle = BorderStyle.FixedSingle;
            txt_diez.Enabled = false;
            txt_diez.Location = new Point(943, 363);
            txt_diez.Name = "txt_diez";
            txt_diez.ReadOnly = true;
            txt_diez.Size = new Size(180, 31);
            txt_diez.TabIndex = 19;
            // 
            // txt_cinco
            // 
            txt_cinco.Anchor = AnchorStyles.Bottom;
            txt_cinco.BorderStyle = BorderStyle.FixedSingle;
            txt_cinco.Enabled = false;
            txt_cinco.Location = new Point(943, 426);
            txt_cinco.Name = "txt_cinco";
            txt_cinco.ReadOnly = true;
            txt_cinco.Size = new Size(180, 31);
            txt_cinco.TabIndex = 20;
            // 
            // txt_uno
            // 
            txt_uno.Anchor = AnchorStyles.Bottom;
            txt_uno.BorderStyle = BorderStyle.FixedSingle;
            txt_uno.Enabled = false;
            txt_uno.Location = new Point(943, 477);
            txt_uno.Name = "txt_uno";
            txt_uno.ReadOnly = true;
            txt_uno.Size = new Size(180, 31);
            txt_uno.TabIndex = 21;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Anchor = AnchorStyles.Bottom;
            btn_limpiar.BackColor = Color.LightSeaGreen;
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpiar.ForeColor = Color.White;
            btn_limpiar.Location = new Point(267, 379);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(141, 56);
            btn_limpiar.TabIndex = 26;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_retirar
            // 
            btn_retirar.Anchor = AnchorStyles.Bottom;
            btn_retirar.BackColor = Color.LightSeaGreen;
            btn_retirar.Cursor = Cursors.Hand;
            btn_retirar.Font = new Font("JetBrains Mono", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_retirar.ForeColor = Color.White;
            btn_retirar.Location = new Point(40, 379);
            btn_retirar.Name = "btn_retirar";
            btn_retirar.Size = new Size(141, 56);
            btn_retirar.TabIndex = 25;
            btn_retirar.Text = "Retirar";
            btn_retirar.UseVisualStyleBackColor = false;
            btn_retirar.Click += btn_retirar_Click;
            // 
            // txt_monto
            // 
            txt_monto.Anchor = AnchorStyles.Bottom;
            txt_monto.BorderStyle = BorderStyle.FixedSingle;
            txt_monto.Location = new Point(252, 308);
            txt_monto.Name = "txt_monto";
            txt_monto.Size = new Size(180, 31);
            txt_monto.TabIndex = 1;
            txt_monto.Tag = "";
            txt_monto.KeyPress += txt_monto_KeyPress;
            // 
            // Cajero
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1163, 751);
            Controls.Add(txt_monto);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_retirar);
            Controls.Add(txt_uno);
            Controls.Add(txt_cinco);
            Controls.Add(txt_diez);
            Controls.Add(txt_veinte);
            Controls.Add(txt_cien);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cajero";
            Load += Cajero_Load;
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
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_cien;
        private TextBox txt_veinte;
        private TextBox txt_diez;
        private TextBox txt_cinco;
        private TextBox txt_uno;
        private Button btn_limpiar;
        private Button btn_retirar;
        private TextBox txt_monto;
    }
}