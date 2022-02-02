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
        long l = 10123;

      //  l = i; estamos fazendo uma conversão implícita.
      //  i = l; neste caso não podemos fazer, pois int armazena até 32-bit e long até 64-bit;
        i = (int)l; // estamos fazendo uma conversão explícita;
        
        
        Console.WriteLine(i);

}       
    }

       

