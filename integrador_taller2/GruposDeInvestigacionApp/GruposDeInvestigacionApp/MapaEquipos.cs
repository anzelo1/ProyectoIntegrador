using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GruposDeInvestigacionApp
{
    public partial class MapaEquipos : Form
    {
        public MapaEquipos()
        {
            InitializeComponent();
        }
        private void gmap_Load(object sender, EventArgs e)
        {
           
        }
        public void cargarDatos(String filtrado,String filtrado2, List<String> buscarEn,int[]datos)
        {
            Grafico.Titles.Add("Datos de equipos por:" + filtrado+"\n"+"En "+filtrado2);
            int[] corregido = new int[5];
            corregido[0] = datos[1];
            corregido[1] = datos[2];
            corregido[2] = datos[3];
            corregido[3] = datos[4];
            corregido[4] = datos[5];

            for (int i = 0; i < buscarEn.Count(); i++)
            {
                Series serie = Grafico.Series.Add(buscarEn[i]);
                double numero = datos[0];
                double numero2 = corregido[i];
                double meter = (numero2 / numero * 100);
                int mostrar = (int)meter;
                serie.Label = mostrar.ToString()+"%";
                serie.Points.Add(corregido[i]);
            }
        }
        public void cargarInfoArticulos(int[] todo)
        {
            Grafico.Titles.Add("Datos de los articulos");
            for (int i = 0; i < todo.Length; i++)
            {
                int numero = i;
                numero++;
                Series serie = Grafico.Series.Add("Articulo: " + numero);
                serie.Label = todo[i].ToString();
                serie.Points.Add(todo[i]);
            }
        }
    }
}
