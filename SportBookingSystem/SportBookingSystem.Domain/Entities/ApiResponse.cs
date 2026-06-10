using System;
using System.Collections.Generic;
using System.Text;

namespace SportBookingSystem.Domain.Entities
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; } = new();
        public T Data { get; set; }
        public long? Count { get; set; }
        public TimeSpan? ExecutionTime { get; set; }
    }
}
