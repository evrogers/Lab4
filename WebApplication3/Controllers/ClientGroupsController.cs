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
    public class ClientGroupsController : Controller
    {
        private readonly InsuranceCompany11Context _context;

        public ClientGroupsController(InsuranceCompany11Context context)
        {
            _context = context;
        }

        // GET: ClientGroups
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClientGroups.ToListAsync());
        }

    }
}