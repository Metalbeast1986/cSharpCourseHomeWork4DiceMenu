using System;
using System.Collections.Generic;
using System.Text;

namespace DiceMenu_ND4.GUI
{
    class Window : GuiObject
    {
        private Frame _border;

        public Window(int x, int y, int width, int height, char borderChar) : base(x, y, width, height)
        {
            _border = new Frame(x, y, width, height, borderChar);
        }

        public override void Render()
        {
            _border.Render();
        }
    }
}
