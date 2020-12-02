using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manejador_Iglesia.Shared.Models
{
    public class Persona
    {
        public int PersonaId { get; set; }

        public string Sexo { get; set; }

        public string Apellidos { get; set; }

        public string Nombres { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string PaisNacimiento { get; set; }

        public string CiudadNacimiento { get; set; }

        public string PaisActual { get; set; }

        public string CiudadActual { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Celular { get; set; }

        public string CorreoElectronico { get; set; }

        public string DocumentoIdentidad { get; set; }

        public string NumeroIdentidad { get; set; }

        public string EstadoCivil { get; set; }

        public string NombrePareja { get; set; }

        public string Hijos { get; set; }

        public int NumeroHijos { get; set; }

        public string Profesion { get; set; }

        public string OcupacionActual { get; set; }

        public string NombreEmpresa { get; set; }

        public string TelefonoLaboral { get; set; }

        public string NivelEstudio { get; set; }

        public string SuspensionInstitucion { get; set; }

        public string RazonSuspension { get; set; }
        public byte[] Imagen { get; set; }

        public DateTime FechaConversion { get; set; }

        public DateTime FechaBautismo { get; set; }

        public DateTime FechaAceptacion { get; set; }

        public string Denominacion { get; set; }

        public string IglesiaActual { get; set; }

        public string IglesiaAnterior { get; set; }

        public string NombrePastor { get; set; }

        public string Disiciplinado { get; set; }

        public int VecesDisciplinado { get; set; }

        public string CausasDisciplinado { get; set; }

        public string Funcion { get; set; }

        public string MinisteriosServidos { get; set; }

        public string MinisterioMayorFruto { get; set; }

        public string MinisterioLlamando { get; set; }

        public string Metas { get; set; }

        public string RespaldoAutoridades { get; set; }
    }
}
