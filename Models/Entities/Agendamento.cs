namespace LittlePepLight.Models.Entities
{
    public class Agendamento
    {
        
        public int ID_AGENDAMENTO {get; set;}

        public DateTime DATA {get; set;}

        public int ID_PACIENTE {get; set;}

        public int ID_FUNCIONARIO {get; set;}

        public int ID_CONVENIO { get; set; }

    }
}
