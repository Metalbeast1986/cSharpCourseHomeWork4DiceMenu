using DiceMenu_ND4.GUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiceMenu_ND4.MenuClasses
{
    class MainMenu : Window
    {
        private MenuLabel _startText;
        private MenuLabel _quitText;
        private TextBlock _titleTextBlock;
        public List<MenuLabel> LabelList = new List<MenuLabel>();

        public MainMenu() : base(0, 0, 120, 30, '%')
        {
            _titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Dice", "C# Course HomeWork ND4", "Made in Vilnius Coding School" });

            _startText = new MenuLabel(20, 13, 28, 5, "P - Play");

            _quitText = new MenuLabel(70, 13, 28, 5, "Q - Quit");

            LabelList.Add(_startText);
            LabelList.Add(_quitText);

        }
        public override void Render()
        {
            base.Render();

            _titleTextBlock.Render();

            _startText.Render();
            _quitText.Render();

            Console.SetCursorPosition(0, 0);
        }
    }
}
