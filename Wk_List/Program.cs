using System;

namespace Wk_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Table<int, string, int> table = new Table<int, string, int>();
            Type type = table.GetType();

            table.AddRow(1, "Ivan", 2);
            table.AddRow(2, "Jeka", 4);
            table.AddRow(3, "Vova", 5);
            table.AddRow(4, "Kate", 3);

            Line line = new Line();

            line.PrintLine();
            line.PrintRow("T № ", " U(name) ", "Z(points) ");
            line.PrintLine();
            line.PrintRow("", "", "");
            line.PrintRow("", "", "");
            line.PrintLine();
            Console.ReadLine();



        }
    }
}
