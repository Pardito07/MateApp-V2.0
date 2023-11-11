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
    public partial class AngulosAgudos : Form
    {
        public AngulosAgudos()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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

        private void AngulosAgudos_Load(object sender, EventArgs e)
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

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (txt_menor.Text == "" && txt_mayor.Text == "")
            {
                MessageBox.Show("Debe ingresar el valor de los catetos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(txt_menor.Text.EndsWith("-") || txt_mayor.Text.EndsWith("-"))
            {
                MessageBox.Show("Debe ingresar un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double catetoMenor = Convert.ToDouble(txt_menor.Text);
            double catetoMayor = Convert.ToDouble(txt_mayor.Text);

            double[] angulos = { catetoMenor, catetoMayor };

            CalcularAngulos(angulos);
        }

        void CalcularAngulos(double[] angulos)
        {
            double anguloB, anguloC, hipotenusa;
            double opuesto = angulos[0];
            double adyacente = angulos[1];

            opuesto = opuesto / adyacente;
            anguloB = Math.Atan(opuesto) * (180 / Math.PI);
            anguloC = 180 - (90 + anguloB);
            hipotenusa = Math.Sqrt((Math.Pow(anguloB, 2)) + (Math.Pow(anguloC, 2)));

            txt_b.Text = Convert.ToString(Math.Round(anguloB)) + "°";
            txt_c.Text = Convert.ToString(Math.Round(anguloC)) + "°";
            txt_hipotenusa.Text = Convert.ToString(Math.Round(hipotenusa)) + "°";
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_menor.Text = "";
            txt_mayor.Text = "";
            txt_b.Text = "";
            txt_c.Text = "";
            txt_hipotenusa.Text = "";
        }

        private void txt_mayor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_mayor.Text.Contains("-") || e.KeyChar != '-')
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

        private void txt_menor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_menor.Text.Contains("-") || e.KeyChar != '-')
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
    }
}
