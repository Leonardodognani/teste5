class Program // por convenção, damos o nome da classe de "Program".
{
    static void Main()              // static é o tipo de linguagem, void não retorna nada e Main é o método.
    {
        Console.Write("Digite um nome ou uma palavra: ");
        string name = Console.ReadLine();      

        Console.WriteLine("Nome/palavra: " + name);
        Console.WriteLine("Números de caracteres: " + name.Length);         // imprime 8.
        Console.WriteLine("Termina com a Letra a: " + name.EndsWith("a")); // retorna false, pois a string não termina com a.
        Console.WriteLine("Começa com a Letra L: " + name.StartsWith("L")); // retorna true, pois a string começa com L.
        Console.WriteLine("Possui a letra a: " + name.Contains("a")); // retorna true, pois a string possui a letra a.
        Console.WriteLine("A letra 'a' está na posição: " + name.IndexOf("a")); // retorna 5, pois é sua posição na string.
        Console.WriteLine("A palavra é vazia ou nula: " + string.IsNullOrEmpty(name)); // retorna se a palavra é vazia ou nula.

        string[] names = { "Leonardo", "Satanas", "Hidromel", "Diabo", "Saúde" };

        Console.WriteLine("Juntando a palavra com os elementos da Array: " + name + " e " + string.Join('/', names));
        // método .Join une todos os elementos entre strings e/ou arrays, sendo definido
        // entre ('') o tipo de espaçamento entre eles. 


        // um pouco sobre números
        
        Console.Write("Digite um número: ");
        string number = Console.ReadLine();

        if (int.TryParse(number, out int x))  // podemos conferir se o que foi digitado é um número
        {
            Console.WriteLine("Sucesso, é um número: " + (x));
        }
        else
        {
            Console.WriteLine($"Error! {number} não é um número!");
        }



        int i = 10;
        long l = 1000000000000000;

      //  l = i; estamos fazendo uma conversão implícita.
      //  i = l; neste caso não podemos fazer, pois int armazena até 32-bit e long até 64-bit;
      // então, implicitamente o compilador não aceita.

        i = (int)l; 
        // estamos fazendo uma conversão explícita. Nesse caso, caso o valor seja maior do
        // que caberia em i, os dados serão perdidos e apresentados de forma diferente do esperado.
        // ou seja, até é possível forçarmos o compilador a fazer a conversão de forma explícita,
        // mas se os valores forem maior do que o i consegue armazenar, dará erro.
        
        Console.WriteLine(i); // neste caso, dará erro e o número que será impresso será diferente.


        string s = l.ToString(); // neste caso, transformando o número em string, é possível imprimí-lo sem
        // dar erro, pois ele passa a ser uma string.

        Console.WriteLine(s); // neste caso ele imprime o valor correto de l.
    

}       
    }

       

