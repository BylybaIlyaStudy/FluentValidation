﻿using WebApplication1.Information;

namespace WebApplication1.People
{
    public class Adult : Person
    {
        private WorkInfo workInfo;
        private double salary;

        public WorkInfo WorkInfo { get; set; }
        public double Salary { get; set; }
    }
}
