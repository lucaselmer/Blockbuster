using System;
using System.Collections.Generic;
using ClasseCliente;
using ClasseFilme;
using ClasseLocacao;
using System.Linq;

namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {            
            
            
            int op;
            List<Filme> filmes = new List<Filme>();
            List<Cliente> clientes = new List<Cliente>();

            //Filmes
            filmes.Add(new Filme(filmes.Count+1, "SONIC – O FILME", "13/02/2020", "Baseado em um dos games mais famosos da história", 5, 10));
            filmes.Add(new Filme(filmes.Count+1, "AVES DE RAPINA", "06/02/2020", "Depois de se aventurar com o Coringa, Arlequina se junta a Canário Negro", 4, 10));
            filmes.Add(new Filme(filmes.Count+1, "007 – SEM TEMPO PARA MORRER", "01/03/2020", "Uma História do 007", 5, 10));
            filmes.Add(new Filme(filmes.Count+1, "JOJO RABBIT", "06/02/2019", "Uma História sobre o ambiente da segunda guerra mundial", 4, 10));
            filmes.Add(new Filme(filmes.Count+1, "Coringa", "25/10/2019", "Uma História do coringa", 5, 10));
            filmes.Add(new Filme(filmes.Count+1, "Viúva Negra", "30/04/2020", "Uma História da viuva negra", 4, 10));
            filmes.Add(new Filme(filmes.Count+1, "Mulher-Maravilha 1984 ", "04/06/2020", "Uma História da mulher maravilha em 1984", 4, 10));
            filmes.Add(new Filme(filmes.Count+1, "King's Man: A Origem", "13/02/2020", "Uma História capitans da king's man", 5, 10));
            filmes.Add(new Filme(filmes.Count+1, "Top Gun: Maverick", "25/06/2020", "Uma História do maverick", 5, 10));
            filmes.Add(new Filme(filmes.Count+1, "Um Príncipe em Nova York 2", "10/10/2020", "Uma História do principe em nova york 2", 5, 10));
            
            
            // Iniciando lista e criando cliente
            clientes.Add(new Cliente(clientes.Count+1, "David boni", "15/05/1994", "999.888.777-33", 2));
            clientes.ElementAt(0).locacoes.Add(new Locacao(clientes.ElementAt(0).getId()+1, clientes.ElementAt(0)));
            
            // Locando filme para o cliente
            clientes.ElementAt(0).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(1));
            clientes.ElementAt(0).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(3));
            clientes.ElementAt(0).locacoes.Add(new Locacao(clientes.ElementAt(0).getId()+1, clientes.ElementAt(0)));
            // Locando filme para o cliente
            clientes.ElementAt(0).locacoes.ElementAt(1).adicionarFilme(filmes.ElementAt(8));
            clientes.ElementAt(0).locacoes.ElementAt(1).adicionarFilme(filmes.ElementAt(9));

            
            clientes.Add(new Cliente(clientes.Count+1, "Jamal Da silva", "22/08/1996", "999.999.888-22", 2));
            clientes.ElementAt(1).locacoes.Add(new Locacao(clientes.ElementAt(1).getId()+1, clientes.ElementAt(1)));

                clientes.ElementAt(1).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(5));
                clientes.ElementAt(1).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(4));
            clientes.ElementAt(1).locacoes.Add(new Locacao(clientes.ElementAt(1).getId()+1, clientes.ElementAt(1)));

                clientes.ElementAt(1).locacoes.ElementAt(1).adicionarFilme(filmes.ElementAt(6));
                clientes.ElementAt(1).locacoes.ElementAt(1).adicionarFilme(filmes.ElementAt(7));
            clientes.ElementAt(1).locacoes.Add(new Locacao(clientes.ElementAt(1).getId()+1, clientes.ElementAt(1)));

                clientes.ElementAt(1).locacoes.ElementAt(2).adicionarFilme(filmes.ElementAt(8));
                clientes.ElementAt(1).locacoes.ElementAt(2).adicionarFilme(filmes.ElementAt(9));


            clientes.Add(new Cliente(clientes.Count+1, "Paula Lemos", "15/05/2000", "123.131.123-32", 2));
            clientes.ElementAt(2).locacoes.Add(new Locacao(clientes.ElementAt(2).getId()+1, clientes.ElementAt(2)));

                clientes.ElementAt(2).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(3));
                clientes.ElementAt(2).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(9));
                clientes.ElementAt(2).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(1));
                clientes.ElementAt(2).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(2));


            clientes.Add(new Cliente(clientes.Count+1, "Edna Silva", "12/07/1994", "111.123.456.88", 2));
            clientes.ElementAt(3).locacoes.Add(new Locacao(clientes.ElementAt(3).getId()+1, clientes.ElementAt(3)));

                clientes.ElementAt(3).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(0));


            clientes.Add(new Cliente(clientes.Count+1, "Luiz Nascimento", "05/07/1995", "123.123.123-97", 2));
            clientes.ElementAt(4).locacoes.Add(new Locacao(clientes.ElementAt(4).getId()+1, clientes.ElementAt(4)));

                clientes.ElementAt(4).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(5));
                clientes.ElementAt(4).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(8));
                clientes.ElementAt(4).locacoes.ElementAt(0).adicionarFilme(filmes.ElementAt(2));
            
            Console.WriteLine("----------Menu Locadora----------");
            Console.WriteLine("1 - Consultar clientes");
            Console.WriteLine("2 - Consultar filmes");
            op = Convert.ToInt32(Console.ReadLine());
            
            switch(op){
                case 1:{
                    foreach(Cliente cliente in clientes){
                        Console.WriteLine("_____________________________");
                        cliente.retornaDados();
                        Console.WriteLine("_____________________________");
                    }
                    break;
                }
                case 2:{
                    foreach(Filme filme in filmes){
                        Console.WriteLine("_____________________________");
                        filme.dadosFilme();
                        Console.WriteLine("_____________________________");
                    }
                    break;
                }
            }
        }
    }
}


