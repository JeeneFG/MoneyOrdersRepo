using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ExamProgLibrary
{
   public class ColourValues
    {
        private int _colorIndex = 0;
        private string _colorValue = "";
        private Color _color = Color.White;

        public int Index
        {
            get { return _colorIndex; }
            set { _colorIndex = value; }
        }
        public string Value
        {
            get { return _colorValue; }
            set { _colorValue = value; }
        }
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public ColourValues()
        {
        }

         public ColourValues(int index, string value,Color color)
         {
             _colorIndex = index;
             _colorValue = value;
             _color = color;
         }
    }
}
