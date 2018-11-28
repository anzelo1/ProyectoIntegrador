using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruposDeInvestigacionApp
{
    class Articulos
    {
        private String codigoGrupo;
        private String[] libros;

        public Articulos(String codi, String[] libro)
        {
            codigoGrupo = codi;
            this.libros = libro;
        }
        public String getCodigo()
        {
            return codigoGrupo;
        }
        public String[] getLibros()
        {
            return libros;
        }
    }
}
