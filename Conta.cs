namespace Projeto_Contas
{
    public class Conta
    {
        // Definindo os atributos das classes

        public string Agencia {set; get;}

        public string Numero {set; get;}

        public string Saldo {set; get;}

         // Criando método tostring na classe Pai

          public string Tostring(){
            string texto;
            texto = "A agencia é:" + this.Agencia;
            texto += "\nO numero é:" + this.Numero;
            texto += "\nO saldo é:" + this.Saldo;
            return texto;
         }
    }
}