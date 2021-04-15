using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Information;

namespace WebApplication1.People
{
    public class Student : Person
    {
        private int course;
        private double averageScore;

        public int Course { get; set; }
        public double AverageScore { get; set; }
    }
}
