namespace RegistroAsistencia.Models
{
    public class Personal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public int AsistenciaId { get; set; }
        public virtual ICollection<Asistencia> Asistencias { get; set; }
    }
}
