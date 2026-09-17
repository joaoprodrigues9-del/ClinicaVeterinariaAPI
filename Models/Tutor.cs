namespace ClinicaVeterinariaAPI.Models
{
    public class Tutor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public ICollection<Pet> Pet { get; set; } = new List<Pet>();
    }
}
