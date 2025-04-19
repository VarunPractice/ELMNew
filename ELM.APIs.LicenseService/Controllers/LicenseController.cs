using ELM.APIs.LicenseService.Data;
using ELM.APIs.LicenseService.Models;
using ELM.Common.DTOs;
using ELM.Common.Enums;
using Microsoft.AspNetCore.Mvc;

namespace ELM.APIs.LicenseService.Controllers
{
    [ApiController]
    [Route("api/licenses")]
    public class LicenseController : Controller
    {
        private readonly LicenseDBContext _context;  
    public LicenseController(LicenseDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> CreateLicense([FromBody] LicenseDto request)
        {
            var license = new License
            {
                Key = Guid.NewGuid().ToString("N").Substring(0, 16).ToUpper(),
                Type = request.Type,
                ExpiryDate = request.ExpiryDate,
                MaxActivations = request.MaxActivations
            };
            await _context.Licenses.AddAsync(license);
            await _context.SaveChangesAsync();

            return Ok(license);
        }

    }
}
