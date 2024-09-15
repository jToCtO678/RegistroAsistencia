namespace RegistroAsistencia.Models
{
    public class Asistencia
    {
        public int Id { get; set; }
        public int EstuidanteId { get; set; }
        public virtual Estudiante Estudiante { get; set; }
        public int PersonalId { get; set; }
        public virtual Personal Personal { get; set; }
        public int ActividadId { get; set; }
        public virtual Actividad Actividad { get; set; }
    }
}
