using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_SQL_Consultorio
{
    class Dentistas1
    {
        ConexionConsultorioDataContext bdConsultorio = new ConexionConsultorioDataContext();
        
        public IQueryable MostrarDentistas()
            {
                var Registros = from valor in bdConsultorio.Dentistas
                                select valor;
                return Registros;
            }

        public IQueryable MostrarEspecialidades()
        {
            var registros = from valor in bdConsultorio.Especialidades
                            select valor;
            return registros;
        }

        public IQueryable MostrarPacientes()
        {
            var registros = from valor in bdConsultorio.Pacientes
                            select valor;
            return registros;
        }

        public IQueryable MostrarCitas() 
        {
            var registros = from valor in bdConsultorio.Citas
                            select valor;
            return registros;
        }
    }
}
