using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pod_sale_reznya
{
    internal class Pod
    {
        public static Dictionary<string, int> Names = new Dictionary<string, int>()
        {
            {"Aegis",200 },
            {"Charon",400 },
            {"Pasito",300 }
        };
        public static Dictionary<string, int> Models = new Dictionary<string, int>()
        {
            {"B60", 1500 },
            {"Baby plus",800 },
            {"второй",2000 }
        };
        public static Dictionary<string, int> Counts = new Dictionary<string, int>()
        {
            {"infinity", 2000 },
            {"20000", 1250 },
            {"12000", 800 }
        };
        public static Dictionary<string, int> Equipments = new Dictionary<string, int>()
        {
            {"Базовая", 500 },
            {"Продвинутая", 800 },
            {"Полная", 1200 }
        };
        public static Dictionary<string, int> Auto_tyagi_ = new Dictionary<string, int>()
        {
            {"Где я", 0 },
            {"Автотяги", 300 },
            {"От кнопки", 200 }
        };
        public static void pricelist(string title, Dictionary<string, int> dict, out Dictionary<string, int> tmp_dict, out string tmp_title_for_pod_menu)
        {
            Console.Clear();
            Console.WriteLine("Выберите " + title);
            foreach (var i in dict.Keys)
            {
                Console.WriteLine($"  {i}  -  {dict[i]}");
            }
            tmp_dict = dict;
            tmp_title_for_pod_menu = title;
        }
        public static void categories(string result = "")
        {
            Console.Clear();
            Console.WriteLine($"Выберите пункт, меню, подходящего под ваш Под, который Вы хотите заказать или нажмите пробел, чтобы завершить заказ:\n  Название\n  Модель\n  Количество затяг\n  Комплектация\n  Затяжки\nВаш под:\n{result}");
        }
    }
}
