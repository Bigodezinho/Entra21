using System;
using System.Collections.Generic;

namespace RevisaoHerdar
{
    interface IPiloto : IPessoa
    { 
        public string Licenca { get; set; }
    }
    public class PilotoF1 : IPiloto
    {
        public string Licenca { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Cpf { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    public class Piloto : IPessoa
    {
        public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       public string Cpf { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    interface IPessoa
    { 
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {
            static List<PilotoF1> BuscarPiloto(List<PilotoF1> pilotoF1s, string cpf)
            {
                PilotoF1 pilotoF1s1 = new List<PilotoF1>();
                for (int i = 0; i < pilotoF1s.Count; i++)
                {
                    if (pilotoF1s[i].Cpf.Contains(cpf))
                    {
                        pilotoF1s[i].Add(pilotoF1s[i]);
                    }
                }
                return pilotoF1s1;
            }
        }
    }
}
