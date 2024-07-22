using Cafeteria.Entities;

namespace Cafeteria;

class Program
{
    public static void Main(string[] args)
    {
        char answer;
        var snacks = new List<Snack>
        {
            new(1, "Cachorro Quente", 4.00),
            new(2, "X-Salada", 4.50),
            new(3, "X-Bacon", 5.00),
            new(4, "Torrada Simples", 2.00),
            new(5, "Refrigerante", 1.50)
        };


        var menu = new Menu();
        do
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Código\tEspecificação\tPreço");
            Console.WriteLine("1\tCachorro Quente\tR$ 4,00");
            Console.WriteLine("2\tX-Salada\tR$ 4,50");
            Console.WriteLine("3\tX-Bacon\t\tR$ 5,00");
            Console.WriteLine("4\tTorrada simples\tR$ 2,00");
            Console.WriteLine("5\tRefrigerante\tR$ 1,50");
            Console.WriteLine("------------------------------------");

            int option, quantity;
            Console.Write("\nSelecione uma opção dentre as acimas: ");
            do
            {
                option = int.Parse(Console.ReadLine()!);
                if (option < 1 || option > 5)
                {
                    Console.Write("Opção inválida, digite novamente: ");
                }

            } while (option < 1 || option > 5);

            Console.Write("Selecione a quantidade desejada: ");
            quantity = int.Parse(Console.ReadLine()!);


            var snack = snacks.First(s => s.Code == option);
            var menuItem = new MenuItem(snack, quantity);

            menu.AddItem(menuItem);

            Console.Write("Deseja continuar adicionando itens ao carrinho (s/n)? ");
            answer = char.Parse(Console.ReadLine()!);
            Console.Clear();
        } while (answer != 'n' && answer != 'N');


        Console.WriteLine(menu);
        Console.WriteLine($"Total: R$ {menu.Total.ToString("F2")}");
    }
}
