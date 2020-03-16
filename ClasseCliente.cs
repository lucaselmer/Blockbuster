using System;
using System.Collections.Generic;
using ClasseLocacao;
using ClasseFilme;
using System.Linq;

namespace ClasseCliente
{
    public class Cliente
    {
        private int id;
        private String nome;
        private String dataNascimento;
        private String cpf;
        private int dias;
        private int filmesLocados;
        public List<Locacao> locacoes = new List<Locacao>();

        public String getCpf() {
        return cpf;
        }
        public String getDataNascimento() {
            return dataNascimento;
        }
        public int getDias() {
            return dias;
        }
        public int getFilmesLocados() {
            return filmesLocados;
        }
        public int getId() {
            return id;
        }       
        public String getNome() {
            return nome;
        }
        public void setCpf(String cpf) {
            this.cpf = cpf;
        }
        public void setDataNascimento(String dataNascimento) {
            this.dataNascimento = dataNascimento;
        }
        public void setDias(int dias) {
            this.dias = dias;
        }
        public void setFilmesLocados(int filmesLocados) {
            this.filmesLocados = filmesLocados;
        }
        public void setId(int id) {
            this.id = id;
        }
        public void setNome(String nome) {
            this.nome = nome;
        }
        // Construtor Clientes
        public Cliente(int id, String nome, String dataNascimento, String cpf, int dias){
            this.id = id;
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.cpf = cpf;
            this.dias = dias;
            this.filmesLocados = 0;
        }
        public void retornaDados(){
            Console.WriteLine("Id:"+this.getId());
            Console.WriteLine("Nome:"+this.getNome());
            Console.WriteLine("Data de Nascimento:"+this.getDataNascimento());
            Console.WriteLine("CPF :"+this.getCpf());
            Console.WriteLine("Dias para devolver:"+this.getDias());
            Console.WriteLine("Quantidade Filmes Locados:"+this.getFilmesLocados());
            if(locacoes.ElementAt(0).getId()!=0){
                Console.WriteLine("Filmes Locados:");
                int quantLocados = 0 ;
                foreach(Locacao locacao in locacoes){
                    quantLocados ++;
                    Console.WriteLine("Locação: "+quantLocados+ "  ");
                    foreach(Filme filme in locacao.filmes){
                        Console.WriteLine(filme.getNome());
                    }
                    locacao.calculaData();
                    locacao.calcularPrecoFinal();
                    Console.WriteLine("Valor R$: "+locacao.getValorTotal());
                    Console.WriteLine("Locação: "+locacao.getDataLocacao());
                    Console.WriteLine("Devolução: "+locacao.getDataDevolucao());
                }
                Console.WriteLine("Quantidade de locações: "+quantLocados);
            }
        }
    }
}