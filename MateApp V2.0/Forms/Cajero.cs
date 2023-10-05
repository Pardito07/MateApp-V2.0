using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateApp_V2._0.Forms
{
    public partial class Cajero : Form
    {
        public Cajero()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.music = true;
            form.Show();
            this.Hide();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (WindowState == FormWindowState.Maximized)
            {
                btn_maximize.Visible = false;
                btn_restore.Visible = true;
            }
            else
            {
                btn_maximize.Visible = true;
            }
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            if (WindowState == FormWindowState.Normal)
            {
                btn_restore.Visible = false;
                btn_maximize.Visible = true;
            }
            else
            {
                btn_restore.Visible = true;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea cerrar la aplicación?", "Cerrar Matemáticas V8", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Cajero_Load(object sender, EventArgs e)
        {
            btn_restore.Visible = false;
        }

        private void btn_retirar_Click(object sender, EventArgs e)
        {
            int monto;
            monto = Convert.ToInt32(txt_monto.Text);
            if (monto > 500)
            {
                MessageBox.Show("El monto máximo a retirar es de $500", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_monto.Text = "";
                return;
            }

            CalcularMonto(monto);
        }

        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        void CalcularMonto(int monto)
        {
            int cien, veinte, diez, cinco, uno;

            cien = monto / 100;
            veinte = (monto % 100) / 20;
            diez = (monto % 20) / 10;
            cinco = (monto % 10) / 5;
            uno = (monto % 5) / 1;

            txt_cien.Text = Convert.ToString(cien);
            txt_veinte.Text = Convert.ToString(veinte);
            txt_diez.Text = Convert.ToString(diez);
            txt_cinco.Text = Convert.ToString(cinco);
            txt_uno.Text = Convert.ToString(uno);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_monto.Text = "";
            txt_cien.Text = "";
            txt_veinte.Text = "";
            txt_diez.Text = "";
        }
    }
}
