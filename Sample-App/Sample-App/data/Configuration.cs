using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_App.data
{
    public class Configuration
    {
        public string StringSetting { get; set; }
        public int IntSetting { get; set; }
        //public Dictionary<string, InnerClass> Dict { get; set; }
        public List<string> ListOfValues { get; set; }
       // public MyEnum AnEnum { get; set; }
    }
}
