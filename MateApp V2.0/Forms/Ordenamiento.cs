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
    public partial class Ordenamiento : Form
    {
        public Ordenamiento()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_num1.Text = "";
            txt_num2.Text = "";
            txt_num3.Text = "";
            txt_menor.Text = "";
            txt_centro.Text = "";
            txt_mayor.Text = "";
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;

            num1 = Convert.ToInt32(txt_num1.Text);
            num2 = Convert.ToInt32(txt_num2.Text);
            num3 = Convert.ToInt32(txt_num3.Text);

            ObtenerOrden(num1, num2, num3, out int menor, out int mayor, out int centro);

            txt_menor.Text = Convert.ToString(menor);
            txt_centro.Text = Convert.ToString(centro);
            txt_mayor.Text = Convert.ToString(mayor);
        }

        static void ObtenerOrden(int num1, int num2, int num3, out int menor, out int centro, out int mayor)
        {
            int[] numeros = { num1, num2, num3 };
            Array.Sort(numeros);

            menor = numeros[0];
            centro = numeros[1];
            mayor = numeros[2];
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.music = true;
            form.Show();
            this.Hide();
        }

        private void tsp_top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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
    }
}
