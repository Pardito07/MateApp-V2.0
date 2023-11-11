using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateApp_V2._0.Forms
{
    public partial class Herencia : Form
    {
        public Herencia()
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

        private void Herencia_Load(object sender, EventArgs e)
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

        private void txt_herencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int herencia;
            if (txt_herencia.Text == "")
            {
                MessageBox.Show("Debe ingresar la herencia", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            herencia = Convert.ToInt32(txt_herencia.Text);
            CalcularHerencia(herencia);
        }

        void CalcularHerencia(int herencia)
        {
            double juan, luis, rosa, licenciado = 0, porcentaje;

            juan = herencia / 3;
            luis = (4 * herencia) / 9;
            rosa = (2 * herencia) / 9;

            if (juan < herencia / 3)
            {
                porcentaje = juan * 0.03;
                juan = juan - porcentaje;
                licenciado += porcentaje;
            }
            else
            {
                porcentaje = juan * 0.05;
                juan = juan - porcentaje;
                licenciado += porcentaje;
            }

            if (luis < herencia / 3)
            {
                porcentaje = luis * 0.03;
                luis = luis - porcentaje;
                licenciado += porcentaje;
            }
            else
            {
                porcentaje = luis * 0.05;
                luis = luis - porcentaje;
                licenciado += porcentaje;
            }

            if (rosa < herencia / 3)
            {
                porcentaje = rosa * 0.03;
                rosa = rosa - porcentaje;
                licenciado += porcentaje;
            }
            else
            {
                porcentaje = rosa * 0.05;
                rosa = rosa - porcentaje;
                licenciado += porcentaje;
            }

            txt_juan.Text = Convert.ToString(juan);
            txt_luis.Text = Convert.ToString(luis);
            txt_rosa.Text = Convert.ToString(rosa);
            txt_licenciado.Text = Convert.ToString(licenciado);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_herencia.Text = "";
            txt_juan.Text = "";
            txt_luis.Text = "";
            txt_rosa.Text = "";
            txt_licenciado.Text = "";
        }
    }
}
