using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3;

namespace WebApplication3.Controllers
{
    public class RisksController : Controller
    {
        private readonly InsuranceCompany11Context _context;

        public RisksController(InsuranceCompany11Context context)
        {
            _context = context;
        }

        // GET: Risks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Risks.ToListAsync());
        }

    }
}
