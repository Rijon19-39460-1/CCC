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
        Course[] courses = new Course[100];
        public void AddCourse(params Course[] course)
        {
            foreach(var c in course)
            {
                for (int i = 0; i < courses.Length; i++)
                {
                    if (courses[i]==null)
                    {
                        courses[i] = c;
                        break;
                    }
                }
            }
        }
    }s
}
