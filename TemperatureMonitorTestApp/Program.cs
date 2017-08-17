using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureMonitorTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tempMonitor = new OpenHardwareMonitor.Utilities.TemperatureMonitor();

            while (true)
            {
                var cpuTemperatures = tempMonitor.CPUTemperatures;

                Console.WriteLine("CPU Temperatures");
                for (int i = 0; i < cpuTemperatures.Count; ++i)
                    Console.WriteLine("Core #" + i + ": " + cpuTemperatures[i]);

                var gpuTemperatures = tempMonitor.GPUTemperatures;
                Console.WriteLine("GPU Temperatures");
                for (int i = 0; i < gpuTemperatures.Count; ++i)
                    Console.WriteLine("GPU #" + i + ": " + gpuTemperatures[i]);

                Console.ReadKey();
            }

        }
    }
}
