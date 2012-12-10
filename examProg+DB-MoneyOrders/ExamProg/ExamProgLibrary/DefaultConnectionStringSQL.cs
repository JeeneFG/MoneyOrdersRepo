using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamProgLibrary
{
    public class DefaultConnectionStringSQL
    {
        public static string DefaultConnection()
        {
            return "Data Source=JEENE-ПК;Initial Catalog=ForExamProgDB;Integrated Security=True";
        }
    }
}
