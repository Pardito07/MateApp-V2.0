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
    public partial class Determinante : Form
    {
        public Determinante()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


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

        private void Determinante_Load(object sender, EventArgs e)
        {
            btn_restore.Visible = false;
        }

        private void tsp_top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_retirar_Click(object sender, EventArgs e)
        {
            string a1, b1, r1, c2, d2, s2;
            a1 = txt_a1.Text;
            b1 = txt_b1.Text;
            r1 = txt_r1.Text;
            c2 = txt_c2.Text;
            d2 = txt_d2.Text;
            s2 = txt_s2.Text;
            string[] campos = new string[] { a1, b1, r1, c2, d2, s2 };

            foreach (string valor in campos)
            {
                if (valor == "")
                {
                    MessageBox.Show("Todos los campos son obligatorios", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (valor == "-" || valor.EndsWith("-"))
                {
                    MessageBox.Show("Debes ingresar un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            CalcularDeterminante(campos);
        }

        private void txt_a1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_a1.Text.Contains("-") || e.KeyChar != '-')
            {
                if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
                else if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_b1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_b1.Text.Contains("-") || e.KeyChar != '-')
            {
                if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
                else if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }
        private void txt_r1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_r1.Text.Contains("-") || e.KeyChar != '-')
            {
                if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
                else if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_c2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_c2.Text.Contains("-") || e.KeyChar != '-')
            {
                if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
                else if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_d2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_d2.Text.Contains("-") || e.KeyChar != '-')
            {
                if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
                else if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_s2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_s2.Text.Contains("-") || e.KeyChar != '-')
            {
                if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
                else if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_a1.Text = "";
            txt_b1.Text = "";
            txt_r1.Text = "";
            txt_c2.Text = "";
            txt_d2.Text = "";
            txt_s2.Text = "";
            txt_x.Text = "";
            txt_y.Text = "";
        }

        void CalcularDeterminante(string[] determinante)
        {
            int a1, b1, c1, d1, r, s, res1, res2, res3, y, x;
            a1 = Convert.ToInt32(determinante[0]);
            b1 = Convert.ToInt32(determinante[1]);
            r = Convert.ToInt32(determinante[2]);
            c1 = Convert.ToInt32(determinante[3]);
            d1 = Convert.ToInt32(determinante[4]);
            s = Convert.ToInt32(determinante[5]);

            res1 = (a1 * d1) - (b1 * c1);
            res2 = (r * d1) - (b1 * s);
            res3 = (a1 * s) - (r * c1);

            x = res2 / res1;
            y = res3 / res1;

            txt_x.Text = Convert.ToString(x);
            txt_y.Text = Convert.ToString(y);
        }
    }
}
