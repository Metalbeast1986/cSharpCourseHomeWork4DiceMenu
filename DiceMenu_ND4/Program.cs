using DiceMenu_ND4.ControllerClasses;
using DiceMenu_ND4.GUI;
using System;

namespace DiceMenu_ND4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            MenuController menuController = new MenuController();
            menuController.ShowMenu();


            Console.ReadKey();
        }
    }
}
