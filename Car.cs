using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class Car
    {
        public string? Type { get; set; }
        public string? Model { get; set; }
        public bool IsRunning { get; set; }

        public void Start() => IsRunning = true;
        public void Stop() => IsRunning = false;
    }
}
