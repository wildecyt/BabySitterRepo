using System;

namespace BabySitter.Data.Models.Interfaces
{
    public interface IBabySitter
    {
        int Id { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
    }
}