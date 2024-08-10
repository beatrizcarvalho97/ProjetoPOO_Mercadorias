using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    public class Mercadorias //Criando uma classe usando o Encapsulamento (Tipo de acesso a classe que será pública (Que ela tem acesso externo))
    {
        // Criando Atributos ou Propriedades (Variáveis das Classes) Encapsulamento Público (permitir acesso externo)

        public string nome;
        public double preco, reajuste, total;
        public int quantidade;

        // Criando do método da Classe com Acesso Externo (Encapsulamento Público)

        public void Atualiza_Preco(double porcentagem) /*O "VOID" é responsável por retornar valores. */
        {
            reajuste = preco + (preco * porcentagem / 100);
        }

        public void Fechar_Pedido()
        {
            total = quantidade * preco;
        }

    }
}
