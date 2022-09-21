namespace LittlePepLight.Models.Entities
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tipo_Doc { get; set; }
        public string Doc { get; set; }
        public int Tipo_Profissional { get; set; }
        public string Funcao { get; set; }
        public string Especializacao { get; set; }
        public int Matricula { get; set; }
        public string Login { get; set; }
        public string senha { get; set; }
    }
}
