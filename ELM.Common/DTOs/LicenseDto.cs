using ELM.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELM.Common.DTOs
{
    public class LicenseDto
    {
        public string Key { get; set; }
        public LicenseType Type { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int MaxActivations { get; set; }
    }
}
