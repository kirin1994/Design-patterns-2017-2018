using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface ISuspension
    {
        string GetOption();
        void SetOption(string option);
        int GetHeight();
        void SetHeight(int height);
    }
}
