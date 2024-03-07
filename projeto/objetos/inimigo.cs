using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos {
    internal class Inimigo {
        public string? Nome { get; set; }
        public InimigosEnum TipoInimigo { get; set; }
        public int Vida { get; set; }
        public int Dano { get; set; }
        public int Nivel { get; set; }
      
      
        public Inimigo(string nome, InimigosEnum tipoInimigo, int vida, int dano) {
            Nome = nome;
            TipoInimigo= tipoInimigo;
            Vida = vida;
            Dano = dano;
            Nivel = 1;
        }
    }
}
