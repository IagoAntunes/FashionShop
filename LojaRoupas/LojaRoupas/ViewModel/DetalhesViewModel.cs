using LojaRoupas.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaRoupas.ViewModel
{
    public class DetalhesViewModel
    {
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public string Preco { get; set; }
        public DetalhesViewModel(Roupa roupa)
        {
            this.Nome = roupa.Nome;
            this.Imagem = roupa.Imagem;
            this.Preco = roupa.Preco;
        }
    }
}
