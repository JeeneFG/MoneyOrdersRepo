using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamProgLibrary
{
   public class FilterValue
    {
        private int _index = 0;
        private string _value = "";

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public FilterValue()
        { }

        public FilterValue(int index, string value)
        {
            _index = index;
            _value = value;
        }
    }
}
