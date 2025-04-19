using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
namespace ELM.Common.Helpers
{
    public static class HardwareHelper
    {
        public static string? GetCpuId()
        {
            using var searcher = new ManagementObjectSearcher("SELECT ProcessorID FROM Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["ProcessorID"]?.ToString();
            }
            return null;
        }
    }
}
