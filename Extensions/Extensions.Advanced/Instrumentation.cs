using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.Advanced
{
    public sealed class Instrumentation
    {
        public Guid Id { get; private set; }
        private DateTime _startedAt;
        public string ProcessName { get; set; }

        public Instrumentation()
        {
            Id = Guid.NewGuid();
        }

        public void Start()
        {
            _startedAt = DateTime.Now;
        }

        public int GetElapsedTime()
        {
            return (int)Math.Round((DateTime.Now - _startedAt).TotalSeconds, 0);
        }
    }
}
