﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace segundo_projeto
{
    class Produto
    {
        public string nome { get; private set; }
        public double preco { get; private set; }
        public int quantidadeEmEstoque { get; private set; }



        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = 0;
        }

        public double valorTotalEmEstoque()
        {
            return preco * quantidadeEmEstoque;
        }

        public void realizarEntrada(int quantidade)
        {
            quantidadeEmEstoque = quantidadeEmEstoque + quantidade;
        }

        public void realizarSaida(int quantidade)
        {
            quantidadeEmEstoque = quantidadeEmEstoque - quantidade;
        }

        public override string ToString()
        {
            return nome
                + ", R$"
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + quantidadeEmEstoque
                +" unidades, Total: R$"
                + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
