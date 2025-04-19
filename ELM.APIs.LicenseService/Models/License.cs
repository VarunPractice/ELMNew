using ELM.Common.Enums;

namespace ELM.APIs.LicenseService.Models
{
    public class License
    {
        public Guid Id { get; set; }
        public string Key { get; set; } 
        public LicenseType Type { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int MaxActivations { get; set; } = 1;
        public int CurrentActivations { get; set; } = 0;
        public bool IsRevoked { get; set; } = false;
    }
}
