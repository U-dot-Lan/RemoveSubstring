using System;

namespace RemoveSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Строка Админ удалил привет Инструменты новый инструментарий про Строка котиков привет";
            string[] strings = str.Split(new string[] { " ", "Строка", "Инструменты", "привет" }, StringSplitOptions.RemoveEmptyEntries);
            string result = string.Join(' ', strings);
            Console.WriteLine(result);         
        }
    }
}
