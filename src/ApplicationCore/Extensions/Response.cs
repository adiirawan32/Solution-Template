using System;

namespace ApplicationCore
{
    public abstract class Response
    {
        public DateTimeOffset Timestamp { get; set; } = DateTimeOffset.Now;
    }
}
