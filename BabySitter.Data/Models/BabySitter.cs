using System;
using System.ComponentModel.DataAnnotations;
using BabySitter.Data.Models.Interfaces;

namespace BabySitter.Data.Models
{
    public class BabySitter : IBabySitter
    {
        [Required]
        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}