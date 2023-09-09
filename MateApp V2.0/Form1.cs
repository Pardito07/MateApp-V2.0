using MateApp_V2._0.Forms;

namespace MateApp_V2._0
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = "ACDC  Thunderstruck.wav";
        }

        public bool music = false;

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea cerrar la aplicación?", "Cerrar MateApp V2.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

            if (!music)
            {
                player.PlayLooping();
                music = true;
            }
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
    }
}