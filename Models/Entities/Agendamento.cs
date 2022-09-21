namespace LittlePepLight.Models.Entities
{
    public class Agendamento
    {
        public DateTime Data { get; set; }
        public int Id_Paciente { get; set; }
        public int Id_Funcionario { get; set; }
        public int Id_Convenio { get; set; }
    }
