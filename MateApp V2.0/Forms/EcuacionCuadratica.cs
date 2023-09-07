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
    public partial class EcuacionCuadratica : Form
    {
        public EcuacionCuadratica()
        {
            InitializeComponent();
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea cerrar la aplicación?", "Cerrar MateApp V2.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_restore_Click_1(object sender, EventArgs e)
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

        private void btn_maximize_Click_1(object sender, EventArgs e)
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

        private void EcuacionCuadratica_Load(object sender, EventArgs e)
        {
            btn_restore.Visible = false;

        }

        private void btn_minimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void txt_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txt_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txt_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0, x1, x2;

            if (txt_a.Text.Trim() == "" || txt_b.Text.Trim() == "" || txt_c.Text.Trim() == "")
            {
                MessageBox.Show("Los valores de A,B y C son obligatorios", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            a = Convert.ToDouble(txt_a.Text);
            b = Convert.ToDouble(txt_b.Text);
            c = Convert.ToDouble(txt_c.Text);

            calcular(a, b, c, out x1, out x2);

            //if(x1 < 0 && x2 < 0)
            //{
            //    txt_x1.Text = Convert.ToString(x1) + "i";
            //    txt_x2.Text = Convert.ToString(x2) + "i";
            //    return;
            //}

            txt_x1.Text = Convert.ToString(x1);
            txt_x2.Text = Convert.ToString(x2);

        }

        private void calcular(double a, double b, double c, out double x1, out double x2)
        {
            x1 = -b + (Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            x2 = -b - (Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_a.Text = "";
            txt_b.Text = "";
            txt_c.Text = "";
            txt_x1.Text = "";
            txt_x2.Text = "";
        }
    }
}
