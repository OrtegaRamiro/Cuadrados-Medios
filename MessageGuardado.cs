using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuadrados_Medios
{
    public partial class MessageGuardado : Form
    {
        public MessageGuardado()
        {
            InitializeComponent();
        }

        Form1 Minimos = new Form1();

        private void btnImaComp_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void brtnGuardarTodo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void MessageGuardado_FormClosing(object sender, FormClosingEventArgs e)
        {
            Minimos.Visible = true;
        }


    }
}
