using System;

namespace DecoratorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IMilkTea tea = new TranChauDuongDen();

            tea = new CheeseDecorator(tea);
            Console.WriteLine(tea.getInfo());
            Console.WriteLine(tea.charging());

            tea = new SocolaDecorator(tea);
            Console.WriteLine(tea.getInfo());
            Console.WriteLine(tea.charging());

            tea = tea.unwrapping();
            Console.WriteLine(tea.getInfo());
            Console.WriteLine(tea.charging());

            tea = tea.unwrapping();
            Console.WriteLine(tea.getInfo());
            Console.WriteLine(tea.charging());
        }
    }
}
