using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPOO
{
    public partial class Frm_Mercadorias : Form
    {
        public Frm_Mercadorias()
        {
            InitializeComponent();
        }

        // Criando os Objetos da Classe em instâncias

        Mercadorias produto1 = new Mercadorias();
        Mercadorias produto2 = new Mercadorias();
        Mercadorias produto3 = new Mercadorias();

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Reajuste_Click(object sender, EventArgs e)
        {
            // Receber os nomes dos produtos e os seus valores digitados armazenando nas variáveis da classe

            produto1.nome = Txt_Produto1.Text;                      //Atribuindo o campo digitado para dentro da variável/atributo "Nome" do objeto "produto1"
            produto1.preco = double.Parse(Txt_Valor1.Text);         //Atribuindo o valor digitado e convertido para double dentro da variável/atributo "preco" do objeto "produto1"
            produto1.reajuste = double.Parse(Txt_Reajuste.Text);

            produto2.nome = Txt_Produto2.Text;                      //Atribuindo o campo digitado para dentro da variável/atributo "Nome" do objeto "produto2"
            produto2.preco = Convert.ToDouble(Txt_Valor2.Text);     //Atribuindo o valor digitado e convertido para double dentro da variável/atributo "preco" do objeto "produto2"
            produto2.reajuste = double.Parse(Txt_Reajuste.Text);

            produto3.nome = Txt_Produto3.Text;                      //Atribuindo o campo digitado para dentro da variável/atributo "Nome" do objeto "produto3"
            produto3.preco = double.Parse(Txt_Valor3.Text);         //Atribuindo o valor digitado e convertido para double dentro da variável/atributo "preco" do objeto "produto3"
            produto3.reajuste = double.Parse(Txt_Reajuste.Text);

            // Mostrando os produtos e valores que estão na memória

            Lbl_Resultado.Text = "Produto 1: " + produto1.nome + "\n" + "Preço Inicial: " + produto1.preco.ToString("c2") + "\n"; // "\n" significa "pular linha" --> New line
            //produto1.Atualiza_Preco(10); // Usando o Método para Reajustar o Valor em 10%
            // Usando o Método para Reajustar o Valor com base no valor de reajuste digitado pelo cliente
            produto1.Atualiza_Preco(produto1.reajuste);
            Lbl_Resultado.Text += "Novo Preço: " + produto1.reajuste.ToString("c2") + "\n\n";

            Lbl_Resultado.Text += "Produto 2: " + produto2.nome + "\n" + "Preço Inicial: " + produto2.preco.ToString("c2") + "\n";
            //produto2.Atualiza_Preco(10); // Usando o Método para Reajustar o Valor em 10%
            // Usando o Método para Reajustar o Valor com base no valor de reajuste digitado pelo cliente
            produto2.Atualiza_Preco(produto2.reajuste);
            Lbl_Resultado.Text += "Novo Preço: " + produto2.reajuste.ToString("c2") + "\n\n";

            Lbl_Resultado.Text += "Produto 3: " + produto3.nome + "\n" + "Preço Inicial: " + produto3.preco.ToString("c2") + "\n";
            //produto3.Atualiza_Preco(10); // Usando o Método para Reajustar o Valor em 10%
            // Usando o Método para Reajustar o Valor com base no valor de reajuste digitado pelo cliente
            produto3.Atualiza_Preco(produto3.reajuste);
            Lbl_Resultado.Text += "Novo Preço: " + produto3.reajuste.ToString("c2") + "\n\n";
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Lbl_Valor1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_3(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(Txt_Produto1.Text != "" && Txt_Quantidade1.Text != "" && Txt_Valor1.Text != "") && (Txt_Produto2.Text != "" && Txt_Quantidade2.Text != "" && Txt_Valor2.Text != "") && (Txt_Produto3.Text != "" && Txt_Quantidade3.Text != "" && Txt_Total3.Text != "")
            produto1.quantidade = int.Parse(Txt_Quantidade1.Text); // A variável pede para o objeto qual o valor que pertence ao atributo selecionado
            produto2.quantidade = int.Parse(Txt_Quantidade2.Text);
            produto3.quantidade = int.Parse(Txt_Quantidade3.Text);

            produto1.preco = double.Parse(Txt_Valor1.Text); // A variável da classe recebe o valor digitado.
            produto2.preco = double.Parse(Txt_Valor2.Text); // A variável da classe recebe o valor digitado.
            produto3.preco = double.Parse(Txt_Valor3.Text); // A variável da classe recebe o valor digitado.

            // O Acesso a classe é sempre feito por meio do objeto!!

            produto1.Fechar_Pedido(); // Usando o método da classe para efetuar o calculo total por produto
            produto2.Fechar_Pedido(); // Usando o método da classe para efetuar o calculo total por produto
            produto3.Fechar_Pedido(); // Usando o método da classe para efetuar o calculo total por produto

            // Agora é necessário "Mostrar" o resultado no campo visivel da tela
            // Sempre converter para o formato de quem irá receber! (neste caso a caixinha, em exemplos anteriores, foi a variavel)
            // ("c2") = Conversão para formato de moeda e quantidade de casas decimais --> c = Currency

            Txt_Total1.Text = produto1.total.ToString("c2"); // Neste caso, como eu preciso incluir a informação dentro do objeto (caixa Txt), eu preciso converter a variavel para string
            Txt_Total2.Text = produto2.total.ToString("c2");
            Txt_Total3.Text = produto3.total.ToString("c2");

            Txt_TotalGeral.Text = (produto1.total + produto2.total + produto3.total).ToString("c2");
        }
   
    }
}
