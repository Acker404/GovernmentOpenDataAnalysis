using CsvHelper.Configuration;
using CsvHelper;
using CsvHelperApplication;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovernmentOpenDataAnalysis
{
    internal class Class1
    {
    }
}

namespace CsvHelperApplication
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}