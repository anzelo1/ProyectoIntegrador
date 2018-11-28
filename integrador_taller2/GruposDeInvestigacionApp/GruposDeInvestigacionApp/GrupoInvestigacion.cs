using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruposDeInvestigacionApp
{
    class GrupoInvestigacion
    {
        private String nombreConvocatoria;
        private String anoConvocatoria;
        private String codigoGrupo;
        private String nombreGrupo;
        private String fechaCreacion;
        private String nombreMunicipio;
        private String nombreDepartamento;
        private String nombrePais;
        private String nombreRegion;
        private int codigoDane;
        private String idArea;
        private String nombreArea;
        private String nombreGranArea;
        private String clasificacion;
        private int orden;
        private String antiguedad;
        
        public GrupoInvestigacion(String nomeCon, String anoCon,String codigoG, String nombreG, String fechaCre,String nombreMun
            ,String nombreDep,String nombreP, String nombreRe, int codigDan, String idAr,String nombreA,String nombreGran, String calsifi, int ord, String antigue)
        {
            nombreConvocatoria =nomeCon;
            anoConvocatoria =anoCon;
            codigoGrupo =codigoG;
            nombreGrupo =nombreG;
            fechaCreacion =fechaCre;
            nombreMunicipio =nombreMun;
            nombreDepartamento =nombreDep;
            nombrePais =nombreP;
            nombreRegion=nombreRe;
            codigoDane=codigDan;
            idArea=idAr;
            nombreArea=nombreA;
            nombreGranArea = nombreGran;
            clasificacion=calsifi;
            orden=ord;
            antiguedad=antigue;
        }

        

        public String getNombreConvo()
        {
            return nombreConvocatoria;
        }
        public String getanoConvocatoria()
        {
            return anoConvocatoria;
        }
        public String getcodigoGrupo()
        {
            return codigoGrupo;
        }
        public String getNombreGrupo()
        {
            return nombreGrupo;
        }
        public String getFechaCreacion()
        {
            return fechaCreacion;
        }
        public String getNombreMunicipio()
        {
            return nombreMunicipio;
        }
        public String getNombreDepartamento()
        {
            return nombreDepartamento;
        }
        public String getnombrePais()
        {
            return nombrePais;
        }
        public String getNombreRegion()
        {
            return nombreRegion;
        }
        public int getCodigoDane()
        {
            return codigoDane;
        }
        public String getIdArea()
        {
            return idArea;
        }
        public String getNombreClasificacion()
        {
            return clasificacion;
        }
        public int getOrden()
        {
            return orden;
        }
        public String getAntiguedad()
        {
            return antiguedad;
        }
        public String getNombreGranArea()
        {
            return nombreGranArea;
        }
    }
}
