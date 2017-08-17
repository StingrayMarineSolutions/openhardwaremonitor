Solution file OpenHardwareMonitor.sln can be opened in Visual Studio to see all projects/files

A utility class OpenHardwareMonitor.Utilities.TemperatureMonitor is added to OpenHardwareMonitor.
Its purpose is to have easy access to temperature information in other applications.  Two functions
are added to OpenHardwareMonitor.Hardware.Computer class to fascillitate extraction of temperature
(public List<float> CPUTemperatures and public List<float> GPUTemperatures).

To see how  OpenHardwareMonitor.Utilities.TemperatureMonitor is used an additional console app
(TemperatureMonitorTestApp) is added to the solution.  Its Main function shows how
OpenHardwareMonitor.Utilities.TemperatureMonitor works:
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

Note that the constructor of OpenHardwareMonitor.Utilities.TemperatureMonitor is timeconsuming
(i.e. make sure you reuse the same object instead of creating new ones every time).
