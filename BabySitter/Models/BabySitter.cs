using System;
using BabySitter.Models.Interfaces;

namespace BabySitter.Models
{
    public class BabySitter : IBabySitter
    {
        public DateTime StartTime { get; set; }
    }
}