namespace LittlePepLight.Models.Entities
{
    public class Paciente
    {
        public int ID_PACIENTE { get; set; }
        public string NOME { get; set; }
        public string DOC { get; set; }
        public int ID_CONVENIO { get; set; }
        public string LOGRADOURO { get; set; }
        public int NUMERO { get; set; }
        public string COMPLEMENTO { get; set; }
        public int CEP { get; set; }
        public string BAIRRO { get; set; }
        public string ESTADO { get; set; }
        public string MUNICIPIO { get; set; }
        public string LOGIN { get; set; }
        public string SENHA { get; set; }
    }
}



