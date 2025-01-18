using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP05.Q1
{
    internal class Circle:ICircle
    {
        public int Area { get; set; }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle:{Area}");
        }
    }
}
