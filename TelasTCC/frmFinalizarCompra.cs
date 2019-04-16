using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasTCC
{
    public partial class frmFinalizarCompra : Form
    {
        public frmFinalizarCompra()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            lblCliente.Text = "Cliente:       " + "Gabriella";
            lblEndereco.Text = "Endereço:  " + "Acesso Tucano Preto " + "Nº: " + "373";
            lblTelefone.Text = "Telefone:    " + "(11) 99019-4890";
        }
    }
}
