using Projeto_Contas;

// Instanciando as classes

Corrente obj_cc = new Corrente();
obj_cc.Agencia = "500";
obj_cc.Numero = "20";
obj_cc.Saldo = "1500";
obj_cc.Limite = 3500;


// Concatenando e exibindo informarções

Console.WriteLine("A agencia da sua conta é:" + obj_cc.Agencia);
Console.WriteLine("O número da sua conta é:" + obj_cc.Numero);
Console.WriteLine("O salo da sua conta é:" + obj_cc.Saldo);
Console.WriteLine("O limite da sua conta é:" + obj_cc.Limite);

// Concatenando e exibindo informarções

Corrente obj2_cc= new Corrente();
obj_cc.Agencia = "789";
obj_cc.Numero = "2";
obj_cc.Saldo = "1865";
obj_cc.Limite = 6000;


Console.WriteLine("A agencia da sua conta 2 é:" + obj2_cc.Agencia);
Console.WriteLine("O número da sua conta  2 é:" + obj2_cc.Numero);
Console.WriteLine("O salo da sua conta 2 é:" + obj2_cc.Saldo);
Console.WriteLine("O limite da sua conta 2 é:" + obj2_cc.Limite);

