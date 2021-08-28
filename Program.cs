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
            Console.WriteLine();
            Console.WriteLine("CAD musica seja bem vindo!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar Musicas");
            Console.WriteLine("2 - Inserir nova Música");
            Console.WriteLine("3 - Alualizar Música");
            Console.WriteLine("4 - Excluir Música");
            Console.WriteLine("5 - Visializar detalhe da Música");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            
            string opcaoUsuario =  Console.ReadLine().ToUpper();
            Console.WriteLine();
            
            return opcaoUsuario;
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

            Console.Write("Digite o artista da Musica: ");
            string entradaArtista =  Console.ReadLine();

            Musica novaMusica = new Musica(
                Id: repositorio.ProximoId(),
                genero: (Genero)entradaGenero,
                nome: entradaNome,
                ano: entradaAno,
                artista: entradaArtista
            );
            repositorio.Insere(novaMusica);
        }
        private static void AtualizarMusica(){
            Console.Write("Digite o id da musica: ");
            int indiceMusica = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("{0} - {1}", i , Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o número do gênero entre as opções acima: ");
            int entradaGenero =  int.Parse(Console.ReadLine());
            
            Console.Write("Digite o nome da Música: ");
            string entradaNome =  Console.ReadLine();

            Console.Write("Digite o ano de lançamento: ");
            int entradaAno =  int.Parse(Console.ReadLine());

            Console.Write("Digite o artista da Musica: ");
            string entradaArtista =  Console.ReadLine();

            
            Musica novaMusica = new Musica(
                Id: indiceMusica,
                genero: (Genero)entradaGenero,
                nome: entradaNome,
                ano: entradaAno,
                artista: entradaArtista
            );
            repositorio.Atualizar(indiceMusica, novaMusica);
        }
        private static void ExcluirMusica(){
            Console.Write("Digite o id da Musica: ");
            int indiceMusica = int.Parse(Console.ReadLine());
            
            repositorio.Excluir(indiceMusica);
        }
        private static void VisualizaMusica(){

        }
    }
}
