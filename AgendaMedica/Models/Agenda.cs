namespace AgendaMedica.Models
{
    public class Agenda
    {
        public Guid AgendaId { get; set; }
        public Guid MedicoId { get; set; } //FK
        public Medico? Medico { get; set; }
        public Guid PacienteId { get; set; } //FK
        public Paciente? Paciente { get; set; }
        public DateTime DataConsulta { get; set; }
        public string? Status { get; set; }
    }
}
