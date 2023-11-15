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
    public partial class PlanoCartesiano : Form
    {
        public PlanoCartesiano()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PlanoCartesiano_Load(object sender, EventArgs e)
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

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txt_x.Text) > 0 && Convert.ToDouble(txt_y.Text) > 0)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "El punto se encuentra\nen el cuadrante I";
            }

            if (Convert.ToDouble(txt_x.Text) < 0 && Convert.ToDouble(txt_y.Text) > 0)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "El punto se encuentra\nen el cuadrante II";
            }

            if (Convert.ToDouble(txt_x.Text) < 0 && Convert.ToDouble(txt_y.Text) < 0)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "El punto se encuentra\nen el cuadrante III";
            }

            if (Convert.ToDouble(txt_x.Text) > 0 && Convert.ToDouble(txt_y.Text) < 0)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "El punto se encuentra\nen el cuadrante IV";
            }
            if (Convert.ToDouble(txt_x.Text) == 0 && Convert.ToDouble(txt_y.Text) == 0)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "El punto esta en el origen";
            }
            if (Convert.ToDouble(txt_x.Text) == 0 && Convert.ToDouble(txt_y.Text) > 0)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Se encuentra en\neje Y siendo positivo ";
            }
            if (Convert.ToDouble(txt_x.Text) > 0 && Convert.ToDouble(txt_y.Text) == 0)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Se encuentra en\neje X siendo positivo ";
            }
            if (Convert.ToDouble(txt_x.Text) == 0 && Convert.ToDouble(txt_y.Text) < 0)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Se encuentra en\neje Y siendo negativo ";
            }
            if (Convert.ToDouble(txt_x.Text) < 0 && Convert.ToDouble(txt_y.Text) == 0)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Se encuentra en\neje X siendo negativo ";
            }

        }

        private void txt_x_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_x.Text.Contains("-") || e.KeyChar != '-')
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

        private void txt_y_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_y.Text.Contains("-") || e.KeyChar != '-')
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
            txt_x.Text = "";
            txt_y.Text = "";
            lbl_mensaje.Text = "";
        }
    }
}
