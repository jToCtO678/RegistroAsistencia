using System.ComponentModel.DataAnnotations;

namespace RegistroAsistencia.Models
{
    public class Actividad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public string Descripción { get; set; }
        public int AsistenciaId { get; set; }
        public virtual ICollection<Asistencia> Asistencia { get; set; }
    }
}
