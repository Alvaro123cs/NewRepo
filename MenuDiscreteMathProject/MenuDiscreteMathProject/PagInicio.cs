using MenuDiscreteMathProject._1_LogicaProgramas;
using MenuDiscreteMathProject._2_LenguajeMathProgramas;
using MenuDiscreteMathProject._3_RelacionesProgramas;
using MenuDiscreteMathProject._4_MetodosConteoProgramas;
using MenuDiscreteMathProject._5_RecurrenciaProgramas;
using MenuDiscreteMathProject._6_CircuitosProgramas;
using MenuDiscreteMathProject.o_Calculadora;
using MenuDiscreteMathProject.o_ConversionesProgramas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuDiscreteMathProject
{
    public partial class PagInicio : Form
    {
        public PagInicio()
        {
            InitializeComponent();
        }
        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            if (formPrincipal != null)
            {
                formPrincipal.AbrirFormulario<MiForm>();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MenuLogica>();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MenuLenguaje>();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MenuRelaciones>();
        }

        private void PagInicio_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MenuRecurrencia>();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MenuMetodos>();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MenuCircuitos>();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Menuconversiones>();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MenuCalcu>();
        }

        private void pictureLogica_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MenuLogica>();
        }

        private void pictureLenguaje_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MenuLenguaje>();
        }

        private void pictureRelaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MenuRelaciones>();
        }

        private void pictureMetodos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MenuMetodos>();
        }

        private void pictureRecurrencia_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MenuRecurrencia>();
        }

        private void pictureCircuitos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MenuCircuitos>();
        }

        private void pictureConversione_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Menuconversiones>();
        }

        private void pictureCalculadora_Click(object sender, EventArgs e)
        {
            AbrirFormulario<MenuCalcu>();
        }
    }
}
