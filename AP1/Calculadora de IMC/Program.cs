//variavel para controle do loop
string? continuar;

do
{
    //coleta de dados
    Console.WriteLine("Digite seu nome: ");
    string? nome = Console.ReadLine();
    Console.WriteLine("Digite sua idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite sua altura: ");
    double altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite seu peso: ");
    double peso = Convert.ToDouble(Console.ReadLine());

    //calculo do IMC
    double imc = peso / (altura * altura);

    string CalculoImc;
    if (imc < 18.5)
    CalculoImc = "Abaixo do peso";
    else if (imc < 24.9)
    CalculoImc = "Normal";
    else if (imc < 29.9)
    CalculoImc = "Sobrepeso";
    else
    CalculoImc = "Obeso";

    string FaixaEtaria;
    if (idade < 12)
    FaixaEtaria = "Criança";
    else if (idade < 18)
    FaixaEtaria = "Adolescente";
    else if (idade < 60)
    FaixaEtaria = "Adulto";
    else
    FaixaEtaria = "Idoso";

    //gerar resultado
    Console.WriteLine("\n--------------------- Calculadora de IMC e Idade ---------------------");
    Console.WriteLine("Nome:" + nome);
    Console.WriteLine($"Idade: {idade} anos");
    Console.WriteLine($"IMC: {imc:F2}, {CalculoImc}");
    Console.WriteLine($"Faixa etária: {FaixaEtaria}");

    //perguntar para continuar 
    Console.WriteLine("\nDeseja gerar um novo relatório? (S/N): ");
    continuar = Console.ReadLine()?.ToUpper();
  
}while(continuar == "S");

Console.WriteLine("Obrigado por usar a Calculadora de IMC e Idade!");
    

