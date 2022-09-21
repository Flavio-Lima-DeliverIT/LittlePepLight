namespace LittlePepLight.Models.Entities
{
    public class Profissional
    {
        int Id_Paciente { get; set; }
        string Nome { get; set; }
        string Doc { get; set; }
        int Id_Convenio { get; set; }
        string Logradouro { get; set; }
        int Numero;
        string Complemento { get; set; }
        int Cep { get; set; }
        string Bairro { get; set; }
        string Estado { get; set; }
        string Municipio { get; set; }
        string Login { get; set; }
        string senha { get; set; }
    }
}
