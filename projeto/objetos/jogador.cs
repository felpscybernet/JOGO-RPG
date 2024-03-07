namespace objetos {
    public class Jogador {

        public string? Nome { get; set; }
        public GeneroEnum GeneroPersonagem { get; set; }
        public int Vida { get; set; }
        public int Ouro { get; set; }
        public int Dano { get; set; }
        public int Nivel { get; set; }
        public int Experiencia { get; set; }
        public int ExperienciaParaSubirNivel { get; set; }

        public Jogador(string nome,GeneroEnum generoPersonagem, int vida, int dano) {
            Nome = nome;
            GeneroPersonagem= generoPersonagem;            
            Vida = vida;
            Dano = dano;
            Ouro = 0;
            Nivel = 1;
            Experiencia = 0;
            ExperienciaParaSubirNivel = 100;
        }
        
    }


}
