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
    public partial class Creditos : Form
    {
        public Creditos()
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

        private void btn_minimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.music = true;
            form.Show();
            this.Hide();
        }

        private void Creditos_Load(object sender, EventArgs e)
        {
            btn_restore.Visible = false;
        }
    }
}
