using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ExamProgLibrary
{
    public class ColourProperties:List<ColourValues>
    {
        public void AddNewProperties(int index, string value, Color color)
        {
            ColourValues cv = new ColourValues(index, value, color);
            this.Add(cv);
        }
    }
}
