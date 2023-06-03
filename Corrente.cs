namespace Projeto_Contas
{
    public class Corrente : Conta
    {
        // Definindo os atributos das classes

         public double Limite {set; get;}
         
         // Criando método tostring

         public string Tostring(){
            string texto;
            texto = "A agencia é:" + base.Agencia;
            texto += "\nO numero é:" + base.Numero;
            texto += "\nO saldo é:" + base.Saldo;
            texto += "\nO limite é:" + this.Limite;
            return texto;
         }
}
}