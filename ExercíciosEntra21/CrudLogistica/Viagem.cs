namespace CrudLogistica
{
    public class Viagem
    {
        private static int BaseId = 0;
        public int Id { get; set; }
        public Motorista Motorista { get; set; }
        public Caminhao Caminhao { get; set; }
        public Viagem()
        {
            Id = BaseId;
            BaseId++;
        }
    }
}