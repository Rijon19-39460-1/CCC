using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class studentInfo
    {
        private string name;
        public string Name { get; set;}
        private int number;
        public int Number { get; set;}
        Course[] course = new Course[100];
        public void AddCourse(params Course[] course)
        {
            //foreach(var )
        }
    }
}
