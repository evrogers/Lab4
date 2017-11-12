using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;

namespace WebApplication3.Controllers
{
    public class StaffsController : Controller
    {
        private readonly InsuranceCompany11Context _context;

        public StaffsController(InsuranceCompany11Context context)
        {
            _context = context;
        }

        // GET: Staffs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Staffs.ToListAsync());
        }

    }
}