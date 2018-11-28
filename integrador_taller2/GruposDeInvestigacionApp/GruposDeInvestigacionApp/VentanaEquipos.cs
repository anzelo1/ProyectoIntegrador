using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace GruposDeInvestigacionApp
{
    public partial class VentanaEquipos : Form
    {
        GMarkerGoogle markers;
        GMapOverlay markeroverlay;

        private VentanaPrincipal principal;
        List<String> nombres;
        public VentanaEquipos(VentanaPrincipal ventana)
        {
            principal = ventana;
            InitializeComponent();
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text ="";
            label11.Text ="";
            label14.Text ="";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String filtro = comboBox1.Text;
            if (filtro.Equals("Municipio"))
            {
                nombres = principal.retornarListadoModelo(filtro);
                comboBox2.Items.Clear();
                for (int i = 0; i < nombres.Count(); i++)
                {
                    comboBox2.Items.Add(nombres[i]);
                }
            }
            else if (filtro.Equals("Departamento"))
            {
                nombres = principal.retornarListadoModelo(filtro);
                comboBox2.Items.Clear();
                for (int i = 0; i < nombres.Count(); i++)
                {
                    comboBox2.Items.Add(nombres[i]);
                }
            }
            else if (filtro.Equals("Región"))
            {
                nombres = principal.retornarListadoModelo(filtro);
                comboBox2.Items.Clear();
                for (int i = 0; i < nombres.Count(); i++)
                {
                    comboBox2.Items.Add(nombres[i]);
                }
            }
            else if (filtro.Equals("ID Area"))
            {
                nombres = principal.retornarListadoModelo(filtro);
                comboBox2.Items.Clear();
                for (int i = 0; i < nombres.Count(); i++)
                {
                    comboBox2.Items.Add(nombres[i]);
                }
            }
            else if (filtro.Equals("Nombre Area"))
            {
                nombres = principal.retornarListadoModelo(filtro);
                comboBox2.Items.Clear();
                for (int i = 0; i < nombres.Count(); i++)
                {
                    comboBox2.Items.Add(nombres[i]);
                }
            }
            else if (filtro.Equals("Clasificación"))
            {
                nombres = principal.retornarListadoModelo(filtro);
                comboBox2.Items.Clear();
                for (int i = 0; i < nombres.Count(); i++)
                {
                    comboBox2.Items.Add(nombres[i]);
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String referencia1 = comboBox1.Text;
            String referencia2 = comboBox2.Text;
            String mensaje = referencia2 + ",Colombia";
            try
            {
                int[] numero = principal.numeroEquipos(referencia1, referencia2);
                label7.Text = numero[0] + "";
                label8.Text =numero[1]+"";
                label9.Text =numero[2]+"";
                label10.Text =numero[3]+"";
                label11.Text =numero[4]+"";
                label14.Text = numero[5] + "";

                gMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
                gMap.SetPositionByKeywords(mensaje);

               
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor seleccione las casillas por las que desea buscar");
            }
        }

        private void grafico_Click(object sender, EventArgs e)
        {
            MapaEquipos ventana = new MapaEquipos();
            ventana.Show();
            int[] equipos = principal.numeroEquipos(comboBox1.Text, comboBox2.Text);
            List<String> lista = new List<string>();
            lista.Add("Calificado como A1");
            lista.Add("Calificado como A");
            lista.Add("Calificado como B");
            lista.Add("Calificado como C");
            lista.Add("Calificado como Reconocido");
            ventana.cargarDatos(comboBox1.Text, comboBox2.Text, lista, equipos);
        }

        private void MostrarEquiposMapas_Click(object sender, EventArgs e)
        {
           double latitud = gMap.Position.Lat;
            double longitud = gMap.Position.Lng;
            Random rand = new Random();
            double randomLati = rand.Next(80000);
            double randomLongi = rand.Next(80000);
            int[] numeros = principal.numeroEquipos(comboBox1.Text, comboBox2.Text);
            int probarLati = (int)latitud;
            int probarLongi = (int)longitud;
                        markeroverlay = new GMapOverlay("Marcador");
            markeroverlay.Markers.Clear();
            gMap.Overlays.Clear();
            if (probarLati > 10)
            {
                for (int i = 0; i < numeros[0]; i++)
                {
                randomLati = randomLati / 10000000000;
                randomLongi = randomLongi / 10000000000;
                    latitud = gMap.Position.Lat;
                    longitud = gMap.Position.Lng;
                    if (i % 2 == 0)
                    {
                        latitud = latitud + randomLati;
                        longitud = longitud + randomLongi;
                        GMarkerGoogle actual = new GMarkerGoogle(new PointLatLng(latitud, longitud), GMarkerGoogleType.green);
                        markeroverlay.Markers.Add(actual);
                        gMap.Overlays.Add(markeroverlay);

                    }else if (i % 2 != 0)
                    {
                        latitud = latitud - randomLati;
                        longitud = longitud - randomLongi;
                        GMarkerGoogle actual = new GMarkerGoogle(new PointLatLng(latitud, longitud), GMarkerGoogleType.green);
                        actual.ToolTipMode = MarkerTooltipMode.Always;
                        markeroverlay.Markers.Add(actual);
                        gMap.Overlays.Add(markeroverlay);
                    }
                    randomLati = rand.Next(80000);
                    randomLongi = rand.Next(80000);
                }
            }
            else if(probarLati<10)
            {
                for (int i = 0; i < numeros[0]; i++)
                {
                randomLati = randomLati / 10000000;
                randomLongi = randomLongi / 10000000;
                    latitud = gMap.Position.Lat;
                    longitud = gMap.Position.Lng;
                    if (i % 2 == 0)
                    {
                        latitud = latitud + randomLati;
                        longitud = longitud + randomLongi;
                        GMarkerGoogle actual = new GMarkerGoogle(new PointLatLng(latitud, longitud), GMarkerGoogleType.green);
                        markeroverlay.Markers.Add(actual);
                        gMap.Overlays.Add(markeroverlay);
                       
                    }
                    else if (i % 2 != 0)
                    {
                        latitud = latitud - randomLati;
                        longitud = longitud - randomLongi;
                        GMarkerGoogle actual = new GMarkerGoogle(new PointLatLng(latitud, longitud), GMarkerGoogleType.green);
                        markeroverlay.Markers.Add(actual);
                        gMap.Overlays.Add(markeroverlay);
                    }
                    randomLati = rand.Next(80000);
                    randomLongi = rand.Next(80000);
                }
            }
            
        }

        private void Articulo_Click(object sender, EventArgs e)
        {
            int[] numeros = principal.obtenerArticulos();
            MapaEquipos actual = new MapaEquipos();
            actual.cargarInfoArticulos(numeros);
            actual.Show();
        }
    }
}
