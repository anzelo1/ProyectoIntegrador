using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GruposDeInvestigacionApp
{
    public partial class VentanaPrincipal : Form
    {
        private ProgramaColciencias programa;
        private List<GrupoInvestigacion> listado;
        public VentanaPrincipal()
        {

            InitializeComponent();
            pictureBox1.Image = Image.FromFile("../../../docs/colciencias_1.JPG");
            programa = new ProgramaColciencias();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
                VentanaEquipos ventana = new VentanaEquipos(this);
                ventana.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        public List<String> retornarListadoModelo(String nombre)
        {
           return programa.listadoEntregar(nombre);
        }
        public int[] numeroEquipos(String referencia1,String referencia2)
        {
            return programa.cantidadEquipos(referencia1, referencia2);
        }
        public int[] obtenerArticulos()
        {
            return programa.cargarArticulos();
        }
    }
}
