using System;

namespace SchoolApi.DataAccess.Models
{
    public class OverallResults
    {
        public int Appeared { get; set; }
        public int TotalStudentsPassed { get; set; }
        public decimal PassPercent { get; set; }

        public int SUB1Failed { get; set; }
        public int SUB2Failed { get; set; }
        public int SUB3Failed { get; set; }
        public int SUB4Failed { get; set; }
        public int SUB5Failed { get; set; }
        public int SUB6Failed { get; set; }


    }
}
