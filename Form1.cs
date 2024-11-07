using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenda
{
    public partial class AgendaDeContatos : MetroFramework.Forms.MetroForm
    {
        public AgendaDeContatos()
        {
            InitializeComponent();
        }




        ////
        private void Form1_Load(object sender, EventArgs e)
        {
            CarregaContatos();
        }

        private void CarregaContatos()
        {
            DbHelper Contatos = new DbHelper();
            CbbNome.DisplayMember = "nome";
            CbbNome.ValueMember = "cod_index";
            CbbNome.DataSource = Contatos.CarregaCbbNome();
            

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CbbNome_SelectedValueChanged(object sender, EventArgs e)
        {
            label14.Text = Convert.ToString(CbbNome.SelectedValue);
        }
    }
}
