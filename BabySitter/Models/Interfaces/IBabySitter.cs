﻿using System;

namespace BabySitter.Models.Interfaces
{
    public interface IBabySitter
    {
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
    }
}