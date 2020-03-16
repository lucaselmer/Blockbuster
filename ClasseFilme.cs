using System;
namespace ClasseFilme
{
    public class Filme
    {
      private int id;
        private String nome;
        private String dataLancamento;
        private String sinopse;
        private float valor;
        private int estoqueTotal;
        private int estoqueAtual;
        private int locado;

        
        public String getDataLancamento() {
            return dataLancamento;
        }
        public int getEstoqueAtual() {
            return estoqueAtual;
        }
        public int getEstoqueTotal() {
            return estoqueTotal;
        }
        public int getId() {
            return id;
        }
        public int getLocado() {
            return locado;
        }
        public String getNome() {
            return nome;
        }
        public String getSinopse() {
            return sinopse;
        }
        public float getValor() {
            return valor;
        }
        public void setDataLancamento(String dataLancamento) {
            this.dataLancamento = dataLancamento;
        }
        public void setEstoqueAtual(int estoqueAtual) {
            this.estoqueAtual = estoqueAtual;
        }
        public void setEstoqueTotal(int estoqueTotal) {
            this.estoqueTotal = estoqueTotal;
        }
        public void setId(int id) {
            this.id = id;
        }
        public void setLocado(int locado) {
            this.locado = locado;
        }
        public void setNome(String nome) {
            this.nome = nome;
        }
        public void setSinopse(String sinopse) {
            this.sinopse = sinopse;
        }
        public void setValor(float valor) {
            this.valor = valor;
        }
        //Construtor Filme 
        public Filme(int id, String nome, String dataLancamento, String sinopse, float valor, int estoqueTotal){
            this.id = id;
            this.nome = nome;
            this.dataLancamento = dataLancamento;
            this.sinopse = sinopse;
            this.valor = valor;
            this.estoqueTotal = estoqueTotal;
            this.estoqueAtual = estoqueTotal;
            this.locado = 0;
        }
        public void filmeLocado(){
            this.setEstoqueAtual(this.getEstoqueAtual()-1);
            this.setLocado(this.getLocado()+1);
        }
        public void devolverFilme(){
            this.setEstoqueAtual(this.getEstoqueAtual()+1);
            this.setLocado(this.getLocado()-1);
        }
        public void dadosFilme(){
            Console.WriteLine("Nome: "+getNome());
            Console.WriteLine("Data Lançamento: "+getDataLancamento());
            Console.WriteLine("Resumo: "+getSinopse());
            Console.WriteLine("Valor R$: "+getValor());
            Console.WriteLine("Estoque: "+getEstoqueAtual());
            Console.WriteLine("Quantidade de locações: "+getLocado());
        }  
    }
}