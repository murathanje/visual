using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    internal class Exercises
    {
        public string? Title { get; set; }
        public int Set { get; set; }
        public int Rep { get; set; }
        public string? Day { get; set; }
        public string? Desc { get; set; }
        public string? WorkoutPlace { get; set; }
        public int UserId { get; set; }


        public Exercises(string? title, int set, int rep, string? day, string? desc, string? workoutPlace, int userId)
        {
            Title = title;
            Set = set;
            Rep = rep;
            Day = day;
            Desc = desc;
            WorkoutPlace = workoutPlace;
            UserId = userId;       
        }
    }
}
