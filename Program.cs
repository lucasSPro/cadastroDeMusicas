using System;
using CAD.Musicas.Classes;

namespace CAD.Musicas
{
    class Program
    {
        static MusicaRepositorio repositorio =  new MusicaRepositorio();
        static void Main(string[] args)
        {
           string opcaoUsuario =  ObterOpcaoUsuario();
           while(opcaoUsuario.ToUpper() != "X"){
               switch(opcaoUsuario){
                   case "1":
                        ListarMusicas();
                        break;
                   case "2":
                        InserirMusica();
                        break;
                   case "3":
                        AtualizarMusica();
                        break;
                   case "4":
                        ExcluirMusica();
                        break;
                   case "5":
                        VisualizaMusica();
                        break;
                   case "C":
                        Console.Clear();
                        break;
               }
               opcaoUsuario = ObterOpcaoUsuario();
           }
           Console.WriteLine("Obrigado por utilizar nossos serviços");
           Console.ReadLine();
        }

        private static string ObterOpcaoUsuario(){
            return "X";
        }
        private static void ListarMusicas(){
            Console.WriteLine("Listar Musicas");
            var lista = repositorio.Lista();
            if(lista.Count == 0){
                Console.WriteLine("Nenhme musica cadastrada.");
            }
            foreach(var musica in lista){
                Console.WriteLine("#ID {0}: - {1}", musica.retornaIdMusica(), musica.RetornaNomeMusica());
            }
        }
        private static void InserirMusica(){
            Console.WriteLine("Cadastrar nova musica");

            foreach(int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("{0} - {1}", i , Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o número do gênero entre as opções acima: ");
            int entradaGenero =  int.Parse(Console.ReadLine());
            
            Console.Write("Digite o nome da Música: ");
            string entradaNome =  Console.ReadLine();

            Console.Write("Digite o ano de lançamento: ");
            int entradaAno =  int.Parse(Console.ReadLine());

            Console.Write("Digite um trecho da musica: ");
            string entradaDescricao =  Console.ReadLine();

            Musica novaMusica = new Musica(
                Id: repositorio.ProximoId(),
                genero: (Genero)entradaGenero,
                nome: entradaNome,
                ano: entradaAno,
                descricao: entradaDescricao
            );
            repositorio.Insere(novaMusica);
        }
        private static void AtualizarMusica(){

        }
        private static void ExcluirMusica(){

        }
        private static void VisualizaMusica(){

        }
    }
}
