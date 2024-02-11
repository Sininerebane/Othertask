using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othertask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            const string CommandSetName = "1";
            const string CommandChangeColor = "2";
            const string CommandSetPassword = "3";
            const string CommandDisplayName = "4";
            const string CommandExit = "5";

            string userInput;
            int setColor;
            int RedColor =  1;
            int GreenColor = 2;
            string setPassword;
            string setName;
            string currentPassword = "123456";
            bool isActive = true;

            while (isActive)
           {
                Console.WriteLine("Выберите нужную команду");
                Console.WriteLine($"\n Установить имя - {CommandSetName} \n Изменить цвет консоли - {CommandChangeColor} \n Установить пароль - {CommandSetPassword}\n Вывести имя - {CommandDisplayName}\n Выход из программы - {CommandExit}"); 

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandSetName:
                        Console.Write("Установите имя:");
                        setName = Console.ReadLine();
                        Console.Clear();
                        break;

                    case CommandChangeColor:
                        Console.WriteLine("Вы собираетесь поменять цвет консоли.\n Выберете цвет");
                        Console.Write($" Красный - {RedColor}\n Зеленный - {GreenColor}\n ");
                        setColor = Convert.ToInt32(Console.ReadLine());

                        if (setColor == RedColor)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                        }                        
                        else if (setColor == GreenColor)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Clear();

                        }
                        break;

                    case CommandSetPassword:
                        Console.Write("Установите пароль:");
                        setPassword = Console.ReadLine();
                        Console.Clear();
                        break;

                    case CommandDisplayName:
                        Console.WriteLine("Если вы введете верный пароль вы сможете установить имя");
                        Console.Write("Введите пароль: ");
                        setPassword = Console.ReadLine();

                        if (setPassword == currentPassword)
                        {

                            Console.WriteLine("Введите ваше имя:");
                            setName = Console.ReadLine();
                            Console.WriteLine("Имя пользователя: " + setName);
                        }                       
                        else
                        {
                            Console.WriteLine("Пароль неверный.");
                        }
                        break;

                    case CommandExit:
                        Console.WriteLine("Вы вышли из меню!");
                        isActive = false;
                        break;
                }
            }
        }
    }
}
