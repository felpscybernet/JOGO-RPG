namespace objetos {
    public class Jogador {

        public string? Nome { get; set; }
        public GeneroEnum GeneroPersonagem { get; set; }
        public ArmasEnum Armas { get; set; }
        public int Vida { get; set; }
        public int Ouro { get; set; }
        public int Dano { get; set; }
        public int Nivel { get; set; }
        public int Experiencia { get; set; }
        public int ExperienciaParaSubirNivel { get; set; }

        public Jogador(string nome,GeneroEnum generoPersonagem,ArmasEnum armas, int vida, int dano) {
            Nome = nome;
            GeneroPersonagem= generoPersonagem; 
            Armas = armas;
            Vida = vida;
            Dano = dano;
            Ouro = 0;
            Nivel = 1;
            Experiencia = 0;
            ExperienciaParaSubirNivel = 100;
        }
        
    }


}
