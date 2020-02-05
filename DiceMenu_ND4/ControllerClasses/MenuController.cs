using DiceMenu_ND4.GUI;
using DiceMenu_ND4.MenuClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiceMenu_ND4.ControllerClasses
{
    class MenuController
    {
        public GameWindow gameWindow;
        public PlayerSelectionMenu PlayerSelectionMenu;
        public DiceSelectionMenu diceSelectionMenu;
        public MainMenu mainMenu;

        bool needToRenderMainMenu = true;
        bool needToRenderPlayerMenu = false;
        bool needToRenderDiceMenu = false;
        bool needToRender = true;
        int index = 0;
        ConsoleKey key;

        public MenuController()
        {
            gameWindow = new GameWindow();
            PlayerSelectionMenu = new PlayerSelectionMenu();
            diceSelectionMenu = new DiceSelectionMenu();
            mainMenu = new MainMenu();

        }
        public void ShowMenu()
        {
            if (needToRenderMainMenu)
            {
                //gameWindow.Render();

                mainMenu.Render();

                //call out Select function to display all possible buttons
                //Select(gameWindow.buttonList);

                key = Console.ReadKey(true).Key;
                do
                {
                    key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.P:
                            {
                                PlayerSelectionMenu.Render();
                                SelectPlayers(PlayerSelectionMenu.buttonList);
                                //
                                needToRenderMainMenu = false;

                                //Console.Clear();
                                break;
                            }
                        case ConsoleKey.Q:
                            {
                                System.Environment.Exit(0);
                                break;
                            }
                    }

                } while (needToRenderMainMenu);
            }

        }
        void Active(int index, List<Button> buttonList)
        {

            //gameWindow.buttonList[index].SetActive();
            PlayerSelectionMenu.buttonList[index].SetActive();

            for (int i = 0; i < buttonList.Count; i++)
            {
                if (i != index)
                {
                    //deactivate all other buttons
                    //gameWindow.buttonList[i].SetInActive();
                    PlayerSelectionMenu.buttonList[i].SetInActive();
                }
            }

            //gameWindow.Render();
            PlayerSelectionMenu.Render();
            if (key == ConsoleKey.Enter)
            {
                CheckPlayersValue(index);
            }

        }
        void SelectPlayers(List<Button> buttonList)
        {
            needToRenderPlayerMenu = true;
            do
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            index--;
                            if (index < 0)
                            {
                                index = buttonList.Count - 1;

                            }
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            index++;
                            if (index >= buttonList.Count)
                            {
                                index = 0;
                            }
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            index=index-3;
                            if (index >= buttonList.Count)
                            {
                                index = 0;
                            }
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            index = index + 3;
                            if (index < 0)
                            {
                                index = buttonList.Count - 1;

                            }
                            break;
                        }
                }

                Active(index, buttonList);
            } while (needToRenderPlayerMenu);

        }
        public void CheckPlayersValue(int index)
        {
            needToRenderPlayerMenu = false;
            needToRenderDiceMenu = true;
            int diceCount = 0;

            if (needToRenderDiceMenu)
            {
                diceSelectionMenu.Render();
               
                key = Console.ReadKey(true).Key;
                do
                {
                    key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.Add:
                            {
                               diceCount++;
                                break;
                            }
                        case ConsoleKey.Subtract:
                            {
                               diceCount--;
                                break;
                            }
                    }
                    DiceTotalCheck(index, diceCount);
                } while (needToRenderDiceMenu);     
            }
        }
        void DiceTotalCheck(int playerCount, int diceCount)
        {
            diceSelectionMenu.SetDiceCount(diceCount);
            diceSelectionMenu.Render();

            //Console.WriteLine("DiceCount" + diceSelectionMenu.diceCount);
            /*if (key == ConsoleKey.Enter)
            {
                CheckPlayersValue(index);
            }
            */
        }
    }
}
