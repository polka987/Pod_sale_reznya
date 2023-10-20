using Pod_sale_reznya;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace Pod_sale_reznya
{
    internal class Program
    {
        static int amount = 0;
        static string result = "";
        static string title = "";
        private static void Main()
        {
            Dictionary<string, int> tmp = new Dictionary<string, int>();
            Pod.categories(result == "" ? null : result);
            try
            {
                int res = strelki(1, 5);
                switch (res)
                {
                    case 1:
                        Pod.pricelist("Название", Pod.Names, out tmp, out title);
                        break;
                    case 2:
                        Pod.pricelist("Модель", Pod.Models, out tmp, out title);
                        break;
                    case 3:
                        Pod.pricelist("Количество затяг", Pod.Counts, out tmp, out title);
                        break;
                    case 4:
                        Pod.pricelist("Комплектация", Pod.Equipments, out tmp, out title);
                        break;
                    case 5:
                        Pod.pricelist("Затяжки", Pod.Auto_tyagi_, out tmp, out title);
                        break;
                }
                int new_res = strelki(1, 3);
                result += $"{title}: {tmp.Keys.ToArray()[new_res-1]} -  {tmp[tmp.Keys.ToArray()[new_res - 1]]}\n";
                amount += tmp[tmp.Keys.ToArray()[new_res-1]];
                Main();
            }
            catch { Main(); }
        }
        public static int strelki(int start, int end)
        {
            ConsoleKeyInfo point;
            int pos = start;
            Console.SetCursorPosition(0, pos);
            Console.Write("->");
            do
            {
                point = Console.ReadKey(true);
                Console.SetCursorPosition(0, pos);
                Console.Write("  ");
                if (point.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos == start - 1) pos = end;
                }
                else if (point.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos > end) pos = 1;
                }

                Console.SetCursorPosition(0, pos);
                Console.Write("->");
            } while (point.Key != ConsoleKey.Enter && point.Key != ConsoleKey.Spacebar);
            if (point.Key == ConsoleKey.Spacebar)
            {
                work_for_file("result.txt", amount);
                return 0;
            }
            else
                return pos;
        }
        static void work_for_file(string path, int Amount)
        {
            result += $"\n\tИтоговый чек: {Amount}\n";
            if (!File.Exists(path))
                File.WriteAllText(path, "");
            File.AppendAllText(path, result);
            amount = 0;
            result = "";
            Main();
        }
    }
}