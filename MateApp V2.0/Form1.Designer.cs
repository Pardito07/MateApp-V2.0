﻿namespace MateApp_V2._0
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
            tsp_top = new ToolStrip();
            btn_close = new ToolStripButton();
            btn_restore = new ToolStripButton();
            btn_maximize = new ToolStripButton();
            btn_minimize = new ToolStripButton();
            btn_play = new ToolStripButton();
            btn_stop = new ToolStripButton();
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
            lbl_titulo = new Label();
            tsp_top.SuspendLayout();
            SuspendLayout();
            // 
            // tsp_top
            // 
            tsp_top.BackColor = Color.MediumSpringGreen;
            tsp_top.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            tsp_top.ImageScalingSize = new Size(24, 24);
            tsp_top.Items.AddRange(new ToolStripItem[] { btn_close, btn_restore, btn_maximize, btn_minimize, btn_play, btn_stop });
            tsp_top.Location = new Point(0, 0);
            tsp_top.Name = "tsp_top";
            tsp_top.Size = new Size(1163, 33);
            tsp_top.TabIndex = 0;
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
            // btn_play
            // 
            btn_play.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_play.Image = (Image)resources.GetObject("btn_play.Image");
            btn_play.ImageTransparentColor = Color.Magenta;
            btn_play.Name = "btn_play";
            btn_play.Size = new Size(34, 28);
            btn_play.Text = "reproducir música";
            btn_play.Click += btn_play_Click;
            // 
            // btn_stop
            // 
            btn_stop.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_stop.Image = (Image)resources.GetObject("btn_stop.Image");
            btn_stop.ImageTransparentColor = Color.Magenta;
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(34, 28);
            btn_stop.Text = "pausar música";
            btn_stop.Click += btn_stop_Click;
            // 
            // btn_ecuacion
            // 
            btn_ecuacion.Anchor = AnchorStyles.Bottom;
            btn_ecuacion.BackColor = Color.MediumSpringGreen;
            btn_ecuacion.Cursor = Cursors.Hand;
            btn_ecuacion.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ecuacion.ForeColor = Color.Black;
            btn_ecuacion.Location = new Point(12, 226);
            btn_ecuacion.Name = "btn_ecuacion";
            btn_ecuacion.Size = new Size(191, 64);
            btn_ecuacion.TabIndex = 1;
            btn_ecuacion.Text = "Ecuación Cuadrática";
            btn_ecuacion.UseVisualStyleBackColor = false;
            btn_ecuacion.Click += btn_ecuacion_Click;
            // 
            // btn_angulos
            // 
            btn_angulos.Anchor = AnchorStyles.Bottom;
            btn_angulos.BackColor = Color.MediumSpringGreen;
            btn_angulos.Cursor = Cursors.Hand;
            btn_angulos.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_angulos.ForeColor = Color.Black;
            btn_angulos.Location = new Point(12, 296);
            btn_angulos.Name = "btn_angulos";
            btn_angulos.Size = new Size(191, 64);
            btn_angulos.TabIndex = 2;
            btn_angulos.Text = "Ángulos Agudos";
            btn_angulos.UseVisualStyleBackColor = false;
            btn_angulos.Click += btn_angulos_Click;
            // 
            // btn_determinante
            // 
            btn_determinante.Anchor = AnchorStyles.Bottom;
            btn_determinante.BackColor = Color.MediumSpringGreen;
            btn_determinante.Cursor = Cursors.Hand;
            btn_determinante.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_determinante.ForeColor = Color.Black;
            btn_determinante.Location = new Point(12, 366);
            btn_determinante.Name = "btn_determinante";
            btn_determinante.Size = new Size(191, 64);
            btn_determinante.TabIndex = 3;
            btn_determinante.Text = "Determinante";
            btn_determinante.UseVisualStyleBackColor = false;
            btn_determinante.Click += btn_determinante_Click;
            // 
            // btn_cajero
            // 
            btn_cajero.Anchor = AnchorStyles.Bottom;
            btn_cajero.BackColor = Color.MediumSpringGreen;
            btn_cajero.Cursor = Cursors.Hand;
            btn_cajero.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cajero.ForeColor = Color.Black;
            btn_cajero.Location = new Point(12, 436);
            btn_cajero.Name = "btn_cajero";
            btn_cajero.Size = new Size(191, 64);
            btn_cajero.TabIndex = 4;
            btn_cajero.Text = "Cajero";
            btn_cajero.UseVisualStyleBackColor = false;
            btn_cajero.Click += btn_cajero_Click;
            // 
            // btn_herencia
            // 
            btn_herencia.Anchor = AnchorStyles.Bottom;
            btn_herencia.BackColor = Color.MediumSpringGreen;
            btn_herencia.Cursor = Cursors.Hand;
            btn_herencia.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_herencia.ForeColor = Color.Black;
            btn_herencia.Location = new Point(12, 506);
            btn_herencia.Name = "btn_herencia";
            btn_herencia.Size = new Size(191, 64);
            btn_herencia.TabIndex = 5;
            btn_herencia.Text = "Herencia";
            btn_herencia.UseVisualStyleBackColor = false;
            btn_herencia.Click += btn_herencia_Click;
            // 
            // btn_ventas
            // 
            btn_ventas.Anchor = AnchorStyles.Bottom;
            btn_ventas.BackColor = Color.MediumSpringGreen;
            btn_ventas.Cursor = Cursors.Hand;
            btn_ventas.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ventas.ForeColor = Color.Black;
            btn_ventas.Location = new Point(960, 226);
            btn_ventas.Name = "btn_ventas";
            btn_ventas.Size = new Size(191, 64);
            btn_ventas.TabIndex = 6;
            btn_ventas.Text = "Promedio Ventas";
            btn_ventas.UseVisualStyleBackColor = false;
            btn_ventas.Click += btn_ventas_Click;
            // 
            // btn_mcd
            // 
            btn_mcd.Anchor = AnchorStyles.Bottom;
            btn_mcd.BackColor = Color.MediumSpringGreen;
            btn_mcd.Cursor = Cursors.Hand;
            btn_mcd.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_mcd.ForeColor = Color.Black;
            btn_mcd.Location = new Point(960, 296);
            btn_mcd.Name = "btn_mcd";
            btn_mcd.Size = new Size(191, 64);
            btn_mcd.TabIndex = 7;
            btn_mcd.Text = "M.C.D";
            btn_mcd.UseVisualStyleBackColor = false;
            btn_mcd.Click += btn_mcd_Click;
            // 
            // btn_ordenamiento
            // 
            btn_ordenamiento.Anchor = AnchorStyles.Bottom;
            btn_ordenamiento.BackColor = Color.MediumSpringGreen;
            btn_ordenamiento.Cursor = Cursors.Hand;
            btn_ordenamiento.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ordenamiento.ForeColor = Color.Black;
            btn_ordenamiento.Location = new Point(960, 366);
            btn_ordenamiento.Name = "btn_ordenamiento";
            btn_ordenamiento.Size = new Size(191, 64);
            btn_ordenamiento.TabIndex = 8;
            btn_ordenamiento.Text = "Ordenamiento";
            btn_ordenamiento.UseVisualStyleBackColor = false;
            btn_ordenamiento.Click += btn_ordenamiento_Click;
            // 
            // btn_plano
            // 
            btn_plano.Anchor = AnchorStyles.Bottom;
            btn_plano.BackColor = Color.MediumSpringGreen;
            btn_plano.Cursor = Cursors.Hand;
            btn_plano.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_plano.ForeColor = Color.Black;
            btn_plano.Location = new Point(960, 436);
            btn_plano.Name = "btn_plano";
            btn_plano.Size = new Size(191, 64);
            btn_plano.TabIndex = 9;
            btn_plano.Text = "Plano Cartesiano";
            btn_plano.UseVisualStyleBackColor = false;
            btn_plano.Click += btn_plano_Click;
            // 
            // btn_creditos
            // 
            btn_creditos.Anchor = AnchorStyles.Bottom;
            btn_creditos.BackColor = Color.MediumSpringGreen;
            btn_creditos.Cursor = Cursors.Hand;
            btn_creditos.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btn_creditos.ForeColor = Color.Black;
            btn_creditos.Location = new Point(960, 506);
            btn_creditos.Name = "btn_creditos";
            btn_creditos.Size = new Size(191, 64);
            btn_creditos.TabIndex = 10;
            btn_creditos.Text = "Créditos";
            btn_creditos.UseVisualStyleBackColor = false;
            btn_creditos.Click += btn_creditos_Click;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_titulo.AutoSize = true;
            lbl_titulo.BackColor = Color.MediumSpringGreen;
            lbl_titulo.Font = new Font("Microsoft Sans Serif", 21.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_titulo.ForeColor = SystemColors.ControlText;
            lbl_titulo.Location = new Point(427, 61);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(349, 52);
            lbl_titulo.TabIndex = 11;
            lbl_titulo.Text = "Matemáticas V8";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1163, 751);
            Controls.Add(lbl_titulo);
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
            Controls.Add(tsp_top);
            Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            tsp_top.ResumeLayout(false);
            tsp_top.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsp_top;
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
        private Label lbl_titulo;
        private ToolStripButton btn_play;
        private ToolStripButton btn_stop;
    }
}