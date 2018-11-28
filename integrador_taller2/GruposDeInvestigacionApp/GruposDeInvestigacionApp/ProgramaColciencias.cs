using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruposDeInvestigacionApp
{
    class ProgramaColciencias
    {
        private List<GrupoInvestigacion> listadoGrupos;
        private List<String> listado;
        private List<Articulos> listadoArticulos;
        public ProgramaColciencias()
        {
            listadoGrupos = new List<GrupoInvestigacion>();
            listadoArticulos = new List<Articulos>();
            cargarArchivo();
            cargarArticulos();
        }

        public void cargarArchivo()
        {
            TextReader leer;
            leer = new StreamReader("../../../docs/GruposInvestigacion1.CSV");
            String linea = leer.ReadLine();
            linea = leer.ReadLine();
            while (linea != null)
            {
                try
                {
                    String[] cantidad = linea.Split(';');
                    
                        GrupoInvestigacion actual = new GrupoInvestigacion(cantidad[0], cantidad[1], cantidad[2], cantidad[3], cantidad[4], cantidad[5], cantidad[6], cantidad[7], cantidad[8], Int32.Parse(cantidad[9]), cantidad[10], cantidad[11], cantidad[12], cantidad[13], Int32.Parse(cantidad[14]), cantidad[15]);
                        listadoGrupos.Add(actual);
                        linea = leer.ReadLine();
                    
                }
                catch (Exception)
                {
                    linea = null;
                }

            }
            leer.Close();

        }
        public List<GrupoInvestigacion> getListado()
        {
            return listadoGrupos;
        } 
        public List<String> listadoEntregar(String parametro)
        {   
            
            listado = new List<string>();
            if (parametro.Equals("Municipio"))
            {
                for (int i = 0; i < listadoGrupos.Count(); i++)
                {
                    if (!listado.Contains(listadoGrupos[i].getNombreMunicipio()))
                    {
                        listado.Add(listadoGrupos[i].getNombreMunicipio());
                    }
                }
            }
            else if (parametro.Equals("Departamento"))
            {
                for (int i = 0; i < listadoGrupos.Count(); i++)
                {
                    if (!listado.Contains(listadoGrupos[i].getNombreDepartamento()))
                    {
                        listado.Add(listadoGrupos[i].getNombreDepartamento());
                    }
                }
            }
            else if (parametro.Equals("Región"))
            {
                for (int i = 0; i < listadoGrupos.Count(); i++)
                {
                    if (!listado.Contains(listadoGrupos[i].getNombreRegion()))
                    {
                        listado.Add(listadoGrupos[i].getNombreRegion());
                    }
                }
            }
            else if (parametro.Equals("ID Area"))
            {
                for (int i = 0; i < listadoGrupos.Count(); i++)
                {
                    if (!listado.Contains(listadoGrupos[i].getIdArea()))
                    {
                        listado.Add(listadoGrupos[i].getIdArea());
                    }
                }
            }
            else if (parametro.Equals("Nombre Area"))
            {
                for (int i = 0; i < listadoGrupos.Count(); i++)
                {
                    if (!listado.Contains(listadoGrupos[i].getNombreGranArea()))
                    {
                        listado.Add(listadoGrupos[i].getNombreGranArea());
                    }
                }
            }
            else if (parametro.Equals("Clasificación"))
            {
                for (int i = 0; i < listadoGrupos.Count(); i++)
                {
                    if (!listado.Contains(listadoGrupos[i].getNombreClasificacion()))
                    {
                        listado.Add(listadoGrupos[i].getNombreClasificacion());
                    }
                }
            }

            return listado;
        }
        public int[] cantidadEquipos(String referencia1, String referencia2)
        {
            int[] retornar = new int[6];
            if (referencia1.Equals("Municipio"))
            {
                for (int i = 0; i < listadoGrupos.Count(); i++)
                {
                    if (listadoGrupos[i].getNombreMunicipio().Equals(referencia2))
                    {
                        retornar[0]++;
                        if (listadoGrupos[i].getNombreClasificacion().Equals("A1"))
                        {
                            retornar[1]++;
                        }else if (listadoGrupos[i].getNombreClasificacion().Equals("A"))
                        {
                            retornar[2]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("B"))
                        {
                            retornar[3]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("C"))
                        {
                            retornar[4]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("Reconocido"))
                        {
                            retornar[5]++;
                        }
                    }
                }
            }else if (referencia1.Equals("Departamento"))
            {
                for (int i = 0; i < listadoGrupos.Count(); i++)
                {
                    if (listadoGrupos[i].getNombreDepartamento().Equals(referencia2))
                    {
                        retornar[0]++;
                        if (listadoGrupos[i].getNombreClasificacion().Equals("A1"))
                        {
                            retornar[1]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("A"))
                        {
                            retornar[2]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("B"))
                        {
                            retornar[3]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("C"))
                        {
                            retornar[4]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("Reconocido"))
                        {
                            retornar[5]++;
                        }
                    }
                }
            }
            else if (referencia1.Equals("Región"))
            {
                for (int i = 0; i < listadoGrupos.Count(); i++)
                {
                    if (listadoGrupos[i].getNombreRegion().Equals(referencia2))
                    {
                        retornar[0]++;
                        if (listadoGrupos[i].getNombreClasificacion().Equals("A1"))
                        {
                            retornar[1]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("A"))
                        {
                            retornar[2]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("B"))
                        {
                            retornar[3]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("C"))
                        {
                            retornar[4]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("Reconocido"))
                        {
                            retornar[5]++;
                        }
                    }
                }
            }
            else if(referencia1.Equals("ID Area"))
            {
                for (int i = 0; i < listadoGrupos.Count(); i++)
                {
                    if (listadoGrupos[i].getIdArea().Equals(referencia2))
                    {
                        retornar[0]++;
                        if (listadoGrupos[i].getNombreClasificacion().Equals("A1"))
                        {
                            retornar[1]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("A"))
                        {
                            retornar[2]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("B"))
                        {
                            retornar[3]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("C"))
                        {
                            retornar[4]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("Reconocido"))
                        {
                            retornar[5]++;
                        }
                    }
                }
            }
            else if(referencia1.Equals("Nombre Area"))
            {
                for (int i = 0; i < listadoGrupos.Count(); i++)
                {
                    if (listadoGrupos[i].getNombreGranArea().Equals(referencia2))
                    {
                        retornar[0]++;
                        if (listadoGrupos[i].getNombreClasificacion().Equals("A1"))
                        {
                            retornar[1]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("A"))
                        {
                            retornar[2]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("B"))
                        {
                            retornar[3]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("C"))
                        {
                            retornar[4]++;
                        }
                        else if (listadoGrupos[i].getNombreClasificacion().Equals("Reconocido"))
                        {
                            retornar[5]++;
                        }
                    }
                }
            }
            return retornar;
        }
        public int[] cargarArticulos()
        {
            TextReader leer;
            int[] articulos = new int[99];
           
            leer = new StreamReader("../../../docs/Articulos.txt");
            String linea = leer.ReadLine();
            while (linea != null)
            {
                try
                {
                String[] datos = linea.Split(':');
                String[] librosSeparados = datos[2].Split(' ');
                Articulos nuevo = new Articulos(datos[1],librosSeparados);
                listadoArticulos.Add(nuevo);
                linea = leer.ReadLine();
                }
                catch (Exception)
                {
                    linea = null;
                }

            }
            leer.Close();
            for (int i = 0; i < listadoArticulos.Count(); i++)
            {
                Articulos actual = listadoArticulos[i];
                for (int j = 0; j <actual.getLibros().Length-1; j++)
                {
                    try
                    {
                        int pos = Int32.Parse(actual.getLibros()[j]);
                        pos--;
                        articulos[pos]++;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            return articulos;
        }
    }
}
