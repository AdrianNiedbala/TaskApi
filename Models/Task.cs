using System;

namespace TaskApi.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescritpion { get; set; }
        public DateTime Date { get; set; }
        public DateTime? Completed { get; set; }
        public bool IsDone { get; set; }
    }
}