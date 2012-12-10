using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamProgLibrary
{
    public class FilterProperties:List<FilterValue>
    {
        public void AddNewProperties(int index, string value)
        {
            FilterValue fv = new FilterValue(index, value);
            this.Add(fv);
        }
    }
}
