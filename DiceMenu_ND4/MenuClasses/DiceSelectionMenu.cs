using DiceMenu_ND4.GUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiceMenu_ND4.MenuClasses
{
    class DiceSelectionMenu : Window
    {
        
        private Button _p2;
        private Button _p3;
        private Button _p4;
        private Button _p5;
        private Button _p6;
        private Button _p7;

        /*
        private Button _startButton;
        private Button _creditsButton;
        private Button _quitButton;
        */

        private TextBlock _titleTextBlock;
        public List<Button> buttonList = new List<Button>();

        public DiceSelectionMenu() : base(0, 0, 120, 30, '%')
        {
            _titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "DiceMenu", "C# Course HomeWork ND4", "Please select player count" });

            _p2 = new Button(20, 13, 18, 5, "P2");
            _p2.SetActive();
            
            _p3 = new Button(50, 13, 18, 5, "P3");
            _p4 = new Button(80, 13, 18, 5, "P4");

            _p5 = new Button(20, 20, 18, 5, "P5");
            _p6 = new Button(50, 20, 18, 5, "P6");
            _p7 = new Button(80, 20, 18, 5, "P7");

            //_creditsButton = new Button(50, 13, 18, 5, "Credits");

            //_quitButton = new Button(80, 13, 18, 5, "Quit");
            /*
            buttonList.Add(_startButton);
            buttonList.Add(_creditsButton);
            buttonList.Add(_quitButton);
            */

            buttonList.Add(_p2);
            buttonList.Add(_p3);
            buttonList.Add(_p4);
            buttonList.Add(_p5);
            buttonList.Add(_p6);
            buttonList.Add(_p7);
        }


        public override void Render()
        {
            base.Render();

            _titleTextBlock.Render();
            /*
            _startButton.Render();
            _creditsButton.Render();
            _quitButton.Render();
            */
            _p2.Render();
            _p3.Render();
            _p4.Render();
            _p5.Render();
            _p6.Render();
            _p7.Render();
            Console.SetCursorPosition(0, 0);
        }
    }
}
