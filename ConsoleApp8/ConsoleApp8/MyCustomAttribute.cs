using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp8
{
    public class MyCustomAttribute:Attribute
    {
        public string SomeProperty { get; set; }
    }
}
