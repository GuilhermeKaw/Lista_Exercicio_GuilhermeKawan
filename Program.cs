#region NIVEL 1 - VARIÁVEIS E OPERAÇÕES BÁSICAS

#region 1. Calculadora de Média Simples
Console.WriteLine("=== Calculadora de Média Simples ===");

Console.Write("Digite a 1ª nota: ");
decimal nota1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a 2ª nota: ");
decimal nota2 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a 3ª nota: ");
decimal nota3 = Convert.ToDecimal(Console.ReadLine());

decimal soma = nota1 + nota2 + nota3;
decimal media = soma / 3;

Console.WriteLine("A média é: " + media);
#endregion

#region 2. Conversor de Idade
Console.WriteLine("\n=== Conversor de Idade ===");

Console.Write("Digite sua idade em anos: ");
int idade = Convert.ToInt32(Console.ReadLine());

int idadeDias = idade * 365;
Console.WriteLine("Sua idade em dias é: " + idadeDias);
#endregion

#region 3. Troca de Valores
Console.WriteLine("\n=== Troca de Valores ===");

int A = 10;
int B = 20;
int temp;

Console.WriteLine("Valores iniciais:");
Console.WriteLine("A = " + A);
Console.WriteLine("B = " + B);

temp = A;
A = B;
B = temp;

Console.WriteLine("Valores após a troca:");
Console.WriteLine("A = " + A);
Console.WriteLine("B = " + B);
#endregion

#endregion



#region NIVEL 2 - ESTRUTURAS CONDICIONAIS

#region 1. Verificador de Maioridade
Console.WriteLine("\n=== Verificador de Maioridade ===");

Console.Write("Digite sua idade: ");
int idadeUsuario = Convert.ToInt32(Console.ReadLine());

if (idadeUsuario >= 18)
{
    Console.WriteLine("Entrada autorizada.");
}
else
{
    Console.WriteLine("Entrada não autorizada. Menor de idade.");
}
#endregion

#region 2. Classificador de Número
Console.WriteLine("\n=== Classificador de Número ===");

Console.Write("Digite um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0 && numero % 2 == 0)
{
    Console.WriteLine("Número par e positivo.");
}
else if (numero > 0 && numero % 2 != 0)
{
    Console.WriteLine("Número ímpar e positivo.");
}
else if (numero < 0)
{
    Console.WriteLine("Número negativo.");
}
else
{
    Console.WriteLine("Número zero.");
}
#endregion

#region 3. Validação de Login Simples
Console.WriteLine("\n=== Validação de Login ===");

string usuarioCorreto = "admin";
string senhaCorreta = "12345";

Console.Write("Digite o usuário: ");
string usuario = Console.ReadLine();

Console.Write("Digite a senha: ");
string senha = Console.ReadLine();

if (usuario == usuarioCorreto && senha == senhaCorreta)
{
    Console.WriteLine("Login autorizado!");
}
else
{
    Console.WriteLine("Usuário ou senha inválidos.");
}
#endregion

#endregion



#region NIVEL 3 - ESTRUTURAS DE REPETIÇÃO (LOOPS)

#region 1. Contagem Regressiva
Console.WriteLine("\n=== Contagem Regressiva ===");

for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("Lançar!");
#endregion

#region 2. Soma de Ímpares (While)
Console.WriteLine("\n=== Soma de Números Ímpares ===");

int somaImpares = 0;
int numInput;

while (true)
{
    Console.Write("Digite um número (0 para parar): ");
    numInput = Convert.ToInt32(Console.ReadLine());

    if (numInput == 0)
        break;

    if (numInput % 2 != 0)
        somaImpares += numInput;
}

Console.WriteLine("Soma dos números ímpares: " + somaImpares);
#endregion

#region 3. Tabuada Personalizada
Console.WriteLine("\n=== Tabuada Personalizada ===");

Console.Write("Digite um número: ");
int tabuada = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(tabuada + " x " + i + " = " + (tabuada * i));
}
#endregion

#endregion

#region NIVEL 4 - COLEÇÕES (ARRAYS E LISTAS)

#region 1. Inversão de Array
Console.WriteLine("\n=== Inversão de Array ===");

string[] nomes = { "Ana", "João", "Pedro", "Maria", "Lucas" };

Console.WriteLine("Lista original:");
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}

Console.WriteLine("Lista invertida:");
for (int i = nomes.Length - 1; i >= 0; i--)
{
    Console.WriteLine(nomes[i]);
}
#endregion

#region 2. Busca e Contagem em Lista (foreach)
Console.WriteLine("\n=== Busca e Contagem em Lista ===");

List<string> cores = new List<string> { "Azul", "Vermelho", "Verde", "Azul", "Amarelo", "Azul" };

Console.Write("Digite uma cor para buscar: ");
string corBusca = Console.ReadLine();

int contador = 0;

foreach (string cor in cores)
{
    if (cor == corBusca)
    {
        contador++;
    }
}

Console.WriteLine("A cor '" + corBusca + "' aparece " + contador + " vezes.");
#endregion

#endregion