namespace CrudLogistica
{
    public class Motorista
    {
        private static int BaseId = 0;
        public int Id { get; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public Motorista()
        {
            Id = BaseId;
            BaseId++;
        }
    }
}