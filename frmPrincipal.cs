using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizadorImagem
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofdImagens.ShowDialog() == DialogResult.OK)
            {
                pbImagens.Load(ofdImagens.FileName);
                btnInserir.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pbImagens.Image = null;
            btnInserir.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStretch.Checked == true)
            {
                pbImagens.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormal.Checked == true)
            {
                pbImagens.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
