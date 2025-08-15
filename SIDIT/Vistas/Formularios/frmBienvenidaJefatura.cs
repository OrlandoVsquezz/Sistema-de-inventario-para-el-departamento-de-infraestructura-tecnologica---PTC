using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmBienvenidaJefatura : Form
    {
        public frmBienvenidaJefatura()
        {
            InitializeComponent();
        }

        private void pbInventarioBJ_Click(object sender, EventArgs e)
        {
            this.Hide(); //Oculta el form actual
            frmMenuJefatura menuJefatura = new frmMenuJefatura();   //Crea una instancia del nuevo form
            menuJefatura.Show();   //Se muestra el form nuevo
        }

        private void lblVerInventarioJefatura_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            frmMenuJefatura menuJefatura = new frmMenuJefatura();  
            menuJefatura.Show();   
        }

        private void pbUsuarioBJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura menuJefatura = new frmMenuJefatura();
            menuJefatura.Show();
        }

        private void lblVerUsuarioJefatura_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura menuJefatura = new frmMenuJefatura();
            menuJefatura.Show();
        }

        private void pbSolicitudesBJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura menuJefatura = new frmMenuJefatura();
            menuJefatura.Show();
        }

        private void lblVerSolicitudesJefatura_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura menuJefatura = new frmMenuJefatura();
            menuJefatura.Show();
        }

        private void pbConsumoBJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura menuJefatura = new frmMenuJefatura();
            menuJefatura.Show();
        }

        private void lblVerConsumoJefatura_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura menuJefatura = new frmMenuJefatura();
            menuJefatura.Show();
        }


    }
}
