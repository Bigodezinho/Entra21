using System;
using System.Collections.Generic;
using System.Linq;

namespace CadastroCaminhao
{
    internal class Program
    {
        enum Operacao3
        {
            AtualizarCaminhao,
            AtualizarMotorista,

        }
        enum Operaacao4
        {
            RemoverCaminhao,
            RemoverMotorista,
            RemoverViagem,
        }
        public static List<Caminhao> LstCaminhao { get; set; } = new List<Caminhao>();
        public static List<Motorista> LstMotorista { get; set; } = new List<Motorista>();
        public static List<Viagem> LstViagem { get; set; } = new List<Viagem>();





        private static Caminhao ObterCaminhaoPorId(int idPEsquisar)
        {
            return LstCaminhao.FirstOrDefault(c => c.Id == idPEsquisar);
        }
        private static Motorista ObterMotoristaPorId(int idProcurar)
        {
            return LstMotorista.FirstOrDefault(m => m.Id == idProcurar);
        }
        private static Viagem ObterViagemPorId(int idProcurar)
        {
            return LstViagem.FirstOrDefault(v => v.Id == idProcurar);
        }

        private static void CriarCaminhao(Caminhao caminhao)
        {
            LstCaminhao.Add(caminhao);
        }
        private static void CriarMotorista(Motorista motorista)
        {
            LstMotorista.Add(motorista);
        }

        public static void AlterarMotorista(int idProcurar, string novoNome, string novoEndereco)
        {
            //Pesquisar o Motorista pelo Id
            var resultado = ObterMotoristaPorId(idProcurar);

            //Alterar as propriedades
            if (resultado != null)
            {
                resultado.Nome = novoNome;
                resultado.Endereco = novoEndereco;
            }
        }
        public static void AlterarCaminhao(int idProcurar, string novoModelo, string novaPlaca)
        {
            // Pesquisar o caminhao pelo Id.
            var resultado = ObterCaminhaoPorId(idProcurar);

            // Alterar as propriedades
            if (resultado != null)
            {
                resultado.Modelo = novoModelo;
                resultado.Placa = novaPlaca;
            }
        }

        private static void ExcluirCaminhao(int idExcluir)
        {
            Caminhao caminhaoExcluir = ObterCaminhaoPorId(idExcluir);
            if (caminhaoExcluir != null)
                LstCaminhao.Remove(caminhaoExcluir);
        }
        private static void ExcluirMotorista(int idExcluir)
        {
            Motorista motoristaExcluir = ObterMotoristaPorId(idExcluir);
            if (motoristaExcluir != null)
                LstMotorista.Remove(motoristaExcluir);
        }
        private static void ExcluirViagem(int idExcluir)
        {
            Viagem viagemExcluir = ObterViagemPorId(idExcluir);
            if (viagemExcluir != null)
                LstViagem.Remove(viagemExcluir);
        }

        public static int ObterIdParaCaminhao(int Id)
        {
            return LstCaminhao.Count + 1;
        }
        public static int ObterIdParaMotorista(int IdMotorista)
        {
            return LstMotorista.Count + 1;
        }
        public static int ObterIdParaViagem(int IdViagem)
        {
            return LstViagem.Count + 1;
        }


        public static void Main(string[] args)
        {

            Console.WriteLine("Menu");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1- Cadastrar");
            Console.WriteLine("2- Atualizar");
            Console.WriteLine("3- Remover");
            int opcao = Convert.ToInt32(Console.ReadLine());

            do
            {

                if (opcao == 1) //cadastrar
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("0 - Cadastrar Caminhão");
                    Console.WriteLine("1 - Cadastrar Motorista");
                    Console.WriteLine("2 - Cadastrar Viagem");
                    int opcao2 = Convert.ToInt32(Console.ReadLine());

                    if (opcao2 == 0) //CadastrarCaminhao:
                    {
                        Console.WriteLine("Digite o Modelo do caminhão");
                        string Modelo = Console.ReadLine();
                        Console.WriteLine("Digite a placa do Veiculo");
                        string PlacaVeiculo = Console.ReadLine();
                        int Id = 0;
                        ObterIdParaCaminhao(Id);
                        Caminhao caminhao1 = new Caminhao(Modelo, PlacaVeiculo, Id);
                        CriarCaminhao(caminhao1);
                        LstCaminhao.Add(caminhao1);
                        Console.WriteLine("Seu caminão foi cadastrado com sucesso");
                    }

                    if (opcao2 == 1) //CadastrarMotorista:
                    {
                        Console.WriteLine("Digite o Nome Completo do Motorista");
                        string Nome = Console.ReadLine();
                        Console.WriteLine("Digite o Endereço do motorista");
                        string Endereco = Console.ReadLine();
                        int IdMotorista = 0;
                        ObterIdParaMotorista(IdMotorista);
                        Motorista motorista1 = new Motorista(Nome, Endereco, IdMotorista);
                        CriarMotorista(motorista1);
                        LstMotorista.Add(motorista1);
                        Console.WriteLine("Seu Motorista foi cadastrado com sucesso");
                    }

                    if (opcao2 == 2) //CadastrarViagem:
                    {
                        Viagem viagem = new Viagem();
                        Console.WriteLine("Digite o Id do veiculo que fará a viagem");
                        int i = int.Parse(Console.ReadLine());
                        viagem.Caminhao = ObterCaminhaoPorId(i);
                        Console.WriteLine("Digite o Id do motorista");
                        int id = int.Parse(Console.ReadLine());
                        viagem.Motorista = ObterMotoristaPorId(id);
                        LstViagem.Add(viagem);
                    }
                }



                if (opcao == 2) //Atualizar
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("0 - Atualizar Caminhão");
                    Console.WriteLine("1 - Atualizar Motorista");
                    int opcao3 = Convert.ToInt32(Console.ReadLine());

                    if (opcao3 == 0)//AtualizarCaminhao:
                    {
                        Console.WriteLine("Digite o Id do veiculo a ser atualizado");
                        int i = Convert.ToInt32(Console.ReadLine());
                        ObterCaminhaoPorId(i);
                        Console.WriteLine("Digite o novo modelo do veiculo");
                        string modelo = Console.ReadLine();
                        Console.WriteLine("Digite a nova placa do veiculo");
                        string placa = Console.ReadLine();
                        AlterarCaminhao(i, modelo, placa);
                        Console.WriteLine("Seu caminhão foi atualizado com sucesso");
                    }
                    if (opcao3 == 1)//AtualizarMotorista
                    {
                        Console.WriteLine("Digite o Id do motorista a ser atualizado");
                        int idMotorista = Convert.ToInt32(Console.ReadLine());
                        ObterMotoristaPorId(idMotorista);
                        Console.WriteLine("Digite o nome do novo motorista");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o endereço do novo motorista");
                        string endereco = Console.ReadLine();
                        AlterarMotorista(idMotorista, nome, endereco);
                        Console.WriteLine("Seu motorista foi atualizado com sucesso");
                    }
                }
                if (opcao == 3) //Remover
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("0 - Remover caminhão");
                    Console.WriteLine("1 - Remover Motorista");
                    Console.WriteLine("2 - Remover Viagem");
                    int opcao4 = Convert.ToInt32(Console.ReadLine());

                    if (opcao4 == 0)//RemoverCaminhao
                    {
                        Console.WriteLine("Digite o Id do caminhçao que deseja remover");
                        int idCaminhao = Convert.ToInt32(Console.ReadLine());
                        ExcluirCaminhao(idCaminhao);
                    }
                    if (opcao4 == 1)//RemoverMotorista
                    {
                        Console.WriteLine("Digite o Id do motorista que deseja remover");
                        int idMotorista = Convert.ToInt32(Console.ReadLine());
                        ExcluirMotorista(idMotorista);

                    }
                    if (opcao4 == 2)//RemoverViagem
                    {
                        Console.WriteLine("Digite a viagem que deseja remover");
                        int idViagem = Convert.ToInt32(Console.ReadLine());
                        ExcluirViagem(idViagem);
                    }
                }
                Console.WriteLine("Menu");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1- Cadastrar");
                Console.WriteLine("2- Atualizar");
                Console.WriteLine("3- Remover");
                opcao = Convert.ToInt32(Console.ReadLine());
            }
            while (opcao != 0);
        }



    }
}
