using MateApp_V2._0.Forms;
using System.Diagnostics;

namespace MateApp_V2._0
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = "ACDC  Thunderstruck.wav";
        }

        public bool music = false;

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea cerrar la aplicación?", "Cerrar Matemáticas V8", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_restore.Visible = false;
            btn_stop.Visible = false;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_ecuacion_Click(object sender, EventArgs e)
        {
            EcuacionCuadratica ecuacion = new EcuacionCuadratica();
            ecuacion.Show();
            this.Hide();
        }

        private void btn_creditos_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            creditos.Show();
            this.Hide();
        }

        private void btn_angulos_Click(object sender, EventArgs e)
        {
            AngulosAgudos angulos = new AngulosAgudos();
            angulos.Show();
            this.Hide();
        }

        private void btn_cajero_Click(object sender, EventArgs e)
        {
            Cajero cajero = new Cajero();
            cajero.Show();
            this.Hide();
        }

        private void btn_determinante_Click(object sender, EventArgs e)
        {
            Determinante determinante = new Determinante();
            determinante.Show();
            this.Hide();
        }

        private void btn_herencia_Click(object sender, EventArgs e)
        {
            Herencia herencia = new Herencia();
            herencia.Show();
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

        private void btn_play_Click(object sender, EventArgs e)
        {
            btn_stop.Visible = true;
            btn_play.Visible = false;
            if (!music)
            {
                player.PlayLooping();
                music = true;
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            btn_stop.Visible = false;
            btn_play.Visible = true;
            if (music)
            {
                player.Stop();
                music = false;
            }
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            PromedioVentas promedio = new PromedioVentas();
            promedio.Show();
            this.Hide();
        }

        private void btn_ordenamiento_Click(object sender, EventArgs e)
        {
            Ordenamiento ordenamiento = new Ordenamiento();
            ordenamiento.Show();
            this.Hide();
        }
    }
}