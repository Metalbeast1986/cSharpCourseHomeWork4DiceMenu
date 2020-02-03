using DiceMenu_ND4.GUI;
using System;

namespace DiceMenu_ND4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            GuiController guiController = new GuiController();

            guiController.ShowMenu();

            Console.ReadKey();
        }
    }
}
