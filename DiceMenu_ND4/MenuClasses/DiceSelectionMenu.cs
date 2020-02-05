using DiceMenu_ND4.GUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiceMenu_ND4.MenuClasses
{
    class DiceSelectionMenu : Window
    {
        public int diceCount { get; set; }

        private MenuLabel _increaseDice;
        private MenuLabel _decreaceDice;
        private TextBlock _titleTextBlock;
        public List<MenuLabel> LabelList = new List<MenuLabel>();

        public DiceSelectionMenu() : base(0, 0, 120, 30, '%')
        {
            _titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "DiceMenu", "C# Course HomeWork ND4", $"Players have {diceCount}" });
            _increaseDice = new MenuLabel(20, 13, 28, 5, " [+] - Increase dice number");

            _decreaceDice = new MenuLabel(70, 13, 28, 5, " [-] - Decrease dice number");

            LabelList.Add(_increaseDice);
            LabelList.Add(_decreaceDice);
        }


        public override void Render()
        {
            base.Render();
            _titleTextBlock.Render(); 
            Console.SetCursorPosition(0, 0);
            _increaseDice.Render();
            _decreaceDice.Render();
        }
        
        /*
        public void IncreaseDiceCount(int diceCount)
        {  
            diceCount++;
        }
        public void DecreaseDiceCount(int diceCount)
        {
             diceCount--;
        }
        */
    }
}
