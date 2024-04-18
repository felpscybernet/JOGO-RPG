

class Program {
    static void Main() {
       
        bool sairDoJogo = false;

        Console.WriteLine(@"                                                              
                                                  |Do                                
                                    |A Era    _  _|_  _         | Reino               
                                    |        |;| |;| |;|        |                   
                                _  _|_  _    \\.    .  /    _  _|_  _               
                               |;|_|;|_|;|    \\:. ,  /    |;|_|;|_|;|              
                               \\..      /    ||;   . |    \\.    .  /              
                                \\.  ,  /     ||:  .  |     \\:  .  /               
                                 ||:   |_   _ ||_ . _ | _   _||:   |                
                                 ||:  .|||_|;|_|;|_|;|_|;|_|;||:.  |                
                                 ||:   ||.    .     .      . ||:  .|                
                                 ||: . || .     . .   .  ,   ||:   |       \,/      
                                 ||:   ||:  ,  _______   .   ||: , |            /`\ 
                                 ||:   || .   /+++++++\    . ||:   |                
                                 ||:   ||.    |+++++++| .    ||: . |                
                              __ ||: . ||: ,  |+++++++|.  . _||_   |                
                     ____--`~    '--~~__|.    |+++++__|----~    ~`---,              
                -~--~                   ~---__|,--~'                  ~~----_____-~'");

        Console.WriteLine("");

        while (!sairDoJogo) {
            MostrarMenu();
            string escolha = Console.ReadLine();

            switch (escolha) {
                case "1":
                    Console.WriteLine("Iniciando um novo jogo...");

                    break;
                case "2":
                    Console.WriteLine("Carregando jogo salvo...");

                    break;
                case "3":
                    Console.WriteLine("Saindo do jogo...");
                    sairDoJogo = true;
                    break;
                default:
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void MostrarMenu() {
        Console.WriteLine("");
        Console.WriteLine("Bem-vindo ao Jogo RPG");
        Console.WriteLine("");
        Console.WriteLine("1 - Novo Jogo");
        Console.WriteLine("2 - Carregar Jogo Salvo");
        Console.WriteLine("3 - Sair");
    }
}
