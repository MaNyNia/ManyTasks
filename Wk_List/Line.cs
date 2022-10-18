using System;
using System.Collections.Generic;
using System.Text;

namespace Wk_List
{
    public class Line 
    {
        static int tableWidth = 40;

        public void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        //Add walls for the table
        public void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }
            Console.WriteLine(row);
        }
        //Define input center
        public string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 1) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }

            void Text(string txt)
            {
            }
        }
    }
}
