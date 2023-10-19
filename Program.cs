using System;

class Program
{
    static void Main()
    {
        int fase;
        int fasef;
        int fased;
        int tempo;
        int tempof;
        int tempod;
        float c;

        fase = 96;
        Console.WriteLine("Quantas fases fáceis tem o jogo?");
        fasef = Convert.ToInt32(Console.ReadLine());

        fased = fase - fasef;
        tempof = fasef;
        tempod = fased * 2;
        tempo = tempof + tempod;
        c = tempo * 5;

        Console.WriteLine("Quantidade de fases fáceis: {0}", fasef);
        Console.WriteLine("Quantidade de fases difíceis: {0}", fased);
        Console.WriteLine("Horas nas fases fáceis: {0} horas", tempof);
        Console.WriteLine("Horas nas fases difíceis: {0} horas", tempod);
        Console.WriteLine("Total de horas gastas até concluir o jogo: {0} horas", tempo);
        Console.WriteLine("Valor em reais da jogatina: R$ {0}", c.ToString("0.00"));
        Console.WriteLine("Pressione uma tecla para finalizar.");

        Console.ReadKey();
    }
}
