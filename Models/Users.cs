using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    internal class Users
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string? Phone { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? EndedAt { get; set; }

        public Users(string? firstName, string? lastName, string? email, int age, int height, int weight, string? phone, DateTime? startedAt, DateTime? endedAt)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Age = age;
            Height = height;
            Weight = weight;
            Phone = phone;
            StartedAt = startedAt;
            EndedAt = endedAt;
        }
    }
}
