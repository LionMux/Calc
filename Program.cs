using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Beginning menu = new Beginning();
        Console.WriteLine("Добро пожаловать в мой калькуляктер 0_0");
        Dictionary<string, string> actionMap = new Dictionary<string, string>
        {
            { "1", "Return" },
            { "2", "Exit" }
        };
        while (true)
        {
            menu.FirstN();
            menu.Operation();
            menu.SecondN();
            menu.Result();
            Console.WriteLine("\n1.Повторить\n2.Выход");
            Console.Write("Выберите действие: ");
            string userInput = Console.ReadLine();
            if (actionMap.TryGetValue(userInput, out string selectedAction))
            {
                switch (selectedAction)
                {
                    case "Return":
                        Console.Clear();
                        break;
                    case "Exit":
                        return;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, выберите 1 (Return) или 2 (Next).");
            }
        }
    }
}
