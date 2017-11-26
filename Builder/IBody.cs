using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface IBody
    {
        string GetColor();
        void SetColor(string color);
        string GetOption();
        void SetOption(string option);
    }
}
