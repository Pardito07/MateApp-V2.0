namespace MateApp_V2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            btn_close = new ToolStripButton();
            btn_restore = new ToolStripButton();
            btn_maximize = new ToolStripButton();
            btn_minimize = new ToolStripButton();
            btn_ecuacion = new Button();
            btn_angulos = new Button();
            btn_determinante = new Button();
            btn_cajero = new Button();
            btn_herencia = new Button();
            btn_ventas = new Button();
            btn_mcd = new Button();
            btn_ordenamiento = new Button();
            btn_plano = new Button();
            btn_creditos = new Button();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Indigo;
            toolStrip1.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_close, btn_restore, btn_maximize, btn_minimize });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1163, 33);
            toolStrip1.TabIndex = 0;
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
            btn_close.Text = "cerrar";
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
            // btn_ecuacion
            // 
            btn_ecuacion.BackColor = Color.Indigo;
            btn_ecuacion.Cursor = Cursors.Hand;
            btn_ecuacion.ForeColor = Color.White;
            btn_ecuacion.Location = new Point(12, 36);
            btn_ecuacion.Name = "btn_ecuacion";
            btn_ecuacion.Size = new Size(191, 64);
            btn_ecuacion.TabIndex = 1;
            btn_ecuacion.Text = "Ecuación Cuadrática";
            btn_ecuacion.UseVisualStyleBackColor = false;
            // 
            // btn_angulos
            // 
            btn_angulos.BackColor = Color.Indigo;
            btn_angulos.ForeColor = Color.White;
            btn_angulos.Location = new Point(12, 106);
            btn_angulos.Name = "btn_angulos";
            btn_angulos.Size = new Size(191, 64);
            btn_angulos.TabIndex = 2;
            btn_angulos.Text = "Ángulos Agudos";
            btn_angulos.UseVisualStyleBackColor = false;
            // 
            // btn_determinante
            // 
            btn_determinante.BackColor = Color.Indigo;
            btn_determinante.ForeColor = Color.White;
            btn_determinante.Location = new Point(12, 176);
            btn_determinante.Name = "btn_determinante";
            btn_determinante.Size = new Size(191, 64);
            btn_determinante.TabIndex = 3;
            btn_determinante.Text = "Determinante";
            btn_determinante.UseVisualStyleBackColor = false;
            // 
            // btn_cajero
            // 
            btn_cajero.BackColor = Color.Indigo;
            btn_cajero.ForeColor = Color.White;
            btn_cajero.Location = new Point(12, 246);
            btn_cajero.Name = "btn_cajero";
            btn_cajero.Size = new Size(191, 64);
            btn_cajero.TabIndex = 4;
            btn_cajero.Text = "Cajero";
            btn_cajero.UseVisualStyleBackColor = false;
            // 
            // btn_herencia
            // 
            btn_herencia.BackColor = Color.Indigo;
            btn_herencia.ForeColor = Color.White;
            btn_herencia.Location = new Point(12, 316);
            btn_herencia.Name = "btn_herencia";
            btn_herencia.Size = new Size(191, 64);
            btn_herencia.TabIndex = 5;
            btn_herencia.Text = "Herencia";
            btn_herencia.UseVisualStyleBackColor = false;
            // 
            // btn_ventas
            // 
            btn_ventas.BackColor = Color.Indigo;
            btn_ventas.ForeColor = Color.White;
            btn_ventas.Location = new Point(12, 386);
            btn_ventas.Name = "btn_ventas";
            btn_ventas.Size = new Size(191, 64);
            btn_ventas.TabIndex = 6;
            btn_ventas.Text = "Promedio Ventas";
            btn_ventas.UseVisualStyleBackColor = false;
            // 
            // btn_mcd
            // 
            btn_mcd.BackColor = Color.Indigo;
            btn_mcd.ForeColor = Color.White;
            btn_mcd.Location = new Point(12, 456);
            btn_mcd.Name = "btn_mcd";
            btn_mcd.Size = new Size(191, 64);
            btn_mcd.TabIndex = 7;
            btn_mcd.Text = "M.C.D";
            btn_mcd.UseVisualStyleBackColor = false;
            // 
            // btn_ordenamiento
            // 
            btn_ordenamiento.BackColor = Color.Indigo;
            btn_ordenamiento.ForeColor = Color.White;
            btn_ordenamiento.Location = new Point(12, 526);
            btn_ordenamiento.Name = "btn_ordenamiento";
            btn_ordenamiento.Size = new Size(191, 64);
            btn_ordenamiento.TabIndex = 8;
            btn_ordenamiento.Text = "Ordenamiento";
            btn_ordenamiento.UseVisualStyleBackColor = false;
            // 
            // btn_plano
            // 
            btn_plano.BackColor = Color.Indigo;
            btn_plano.ForeColor = Color.White;
            btn_plano.Location = new Point(12, 596);
            btn_plano.Name = "btn_plano";
            btn_plano.Size = new Size(191, 64);
            btn_plano.TabIndex = 9;
            btn_plano.Text = "Plano Cartesiano";
            btn_plano.UseVisualStyleBackColor = false;
            // 
            // btn_creditos
            // 
            btn_creditos.BackColor = Color.Indigo;
            btn_creditos.ForeColor = Color.White;
            btn_creditos.Location = new Point(12, 666);
            btn_creditos.Name = "btn_creditos";
            btn_creditos.Size = new Size(191, 64);
            btn_creditos.TabIndex = 10;
            btn_creditos.Text = "Créditos";
            btn_creditos.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1163, 751);
            Controls.Add(btn_creditos);
            Controls.Add(btn_plano);
            Controls.Add(btn_ordenamiento);
            Controls.Add(btn_mcd);
            Controls.Add(btn_ventas);
            Controls.Add(btn_herencia);
            Controls.Add(btn_cajero);
            Controls.Add(btn_determinante);
            Controls.Add(btn_angulos);
            Controls.Add(btn_ecuacion);
            Controls.Add(toolStrip1);
            Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btn_close;
        private ToolStripButton btn_maximize;
        private ToolStripButton btn_minimize;
        private ToolStripButton btn_restore;
        private Button btn_ecuacion;
        private Button btn_angulos;
        private Button btn_determinante;
        private Button btn_cajero;
        private Button btn_herencia;
        private Button btn_ventas;
        private Button btn_mcd;
        private Button btn_ordenamiento;
        private Button btn_plano;
        private Button btn_creditos;
    }
}