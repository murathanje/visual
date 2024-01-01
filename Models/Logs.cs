using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    internal class Logs
    {
        public DateTime? Enter { get; set; }
        public DateTime? Exit { get; set; }
        public int UserId { get; set; }
        public Users? User { get; set; }

        public Logs( DateTime? enter, DateTime? exit, int userId)
        {
            Enter = enter;
            Exit = exit;
            UserId = userId;
        }
    }
}
