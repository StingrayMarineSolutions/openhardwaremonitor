using System;
using System.Collections.Generic;
using System.Text;
using OpenHardwareMonitor.Hardware;
using System.IO;

namespace OpenHardwareMonitor.Utilities
{
    public class TemperatureMonitor
    {
        private Computer _computer;

        public TemperatureMonitor()
        {
            var settings = new OpenHardwareMonitor.PersistentSettings();
            settings.Load(Path.ChangeExtension(
                    System.Windows.Forms.Application.ExecutablePath, ".config"));

            _computer = new Computer(settings);
            _computer.Open();
            _computer.MainboardEnabled = true;
            _computer.HDDEnabled = true;
            _computer.CPUEnabled = true;
            _computer.GPUEnabled = true;
        }

        public List<float> CPUTemperatures
        {
            get
            {
                return _computer.CPUTemperatures;
            }
        }

        public List<float> GPUTemperatures
        {
            get
            {
                return _computer.GPUTemperatures;
            }
        }
    }
}
