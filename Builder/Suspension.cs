using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Suspension : ISuspension
    {
        private int _height;
        private string _option;
        public int GetHeight()
        {
            return _height;
        }

        public void SetHeight(int height)
        {
            _height = height;
        }

        public string GetOption()
        {
            return _option;
        }

        public void SetOption(string option)
        {
            _option = option;
        }
    }
}
