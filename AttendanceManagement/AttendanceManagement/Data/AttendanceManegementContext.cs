using System;
using Microsoft.EntityFrameworkCore;
using AttendanceManagement.Models;

namespace AttendanceManagement.Data
{
    public class AttendanceManegementContext :DbContext
    {
        public AttendanceManegementContext(DbContextOptions<AttendanceManegementContext> options) :base(options)
        {
        }

        public DbSet<Attendance> Attendance { get; set; }
    }
}
