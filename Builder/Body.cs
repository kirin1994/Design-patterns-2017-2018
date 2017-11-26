using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Body : IBody
    {
        private string _color;
        private string _option;
        public string GetColor()
        {
            return _color;
        }
        public void SetColor(string color)
        {
            _color = color;
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
