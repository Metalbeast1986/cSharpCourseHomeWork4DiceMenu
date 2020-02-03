using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceMenu_ND4.Game
{
    class Hero: Unit
    {
        public Hero(int x, int y, string name) : base(x, y, name)
        {
        }

        public void MoveRight()
        {
            x++;
        }

        public void MoveLeft()
        {
            x--;
        }

        public override void Render()
        {
            Console.SetCursorPosition(x, y);
            //Console.WriteLine("render hero");

        }

    }
}
