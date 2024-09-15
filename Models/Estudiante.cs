namespace RegistroAsistencia.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Ciclo { get; set; }
        public int AsistenciaId { get; set; }
        public virtual ICollection<Asistencia> Asistencias { get; set; }

    }
}
