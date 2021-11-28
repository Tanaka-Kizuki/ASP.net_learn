using System;
using System.ComponentModel.DataAnnotations;

namespace AttendanceManagement.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }


        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime FinishTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime StartBreak { get; set; }

        [DataType(DataType.Time)]
        public DateTime FinishBreak { get; set; }

        public int TotalTime { get; set; }


        public Attendance()
        {
        }
    }
}
