using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Common.DTOs.Logs
{
    public class LogRequestDto
    {
        public string CorrelationId { get; set; } = null!;
        public DateTime Time { get; set; }
        public string? ServiceName { get; set; }
        public string? Request { get; set; }

    }
}