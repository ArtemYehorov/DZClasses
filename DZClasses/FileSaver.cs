using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZClasses
{
    internal class FileSaver
    {

        public void SaveStudent(Student b)
        {
            string json = JsonConvert.SerializeObject(b, Formatting.Indented);

            Student deserializedProduct = JsonConvert.DeserializeObject<Student>(json);

            var fs = new StreamWriter(@"C:\1\Student.txt");
           
            fs.Write(json);
            fs.Close();
        }

        public void SaveGroup(Group b)
        {
            string json = JsonConvert.SerializeObject(b, Formatting.Indented);

            Student deserializedProduct = JsonConvert.DeserializeObject<Student>(json);

            var fs = new StreamWriter(@"C:\1\Group.txt");

            fs.Write(json);
            fs.Close();
        }
    }
}

