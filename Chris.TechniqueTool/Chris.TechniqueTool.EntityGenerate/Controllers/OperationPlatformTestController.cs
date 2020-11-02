using System;
using System.Linq;
using Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels;
using Microsoft.AspNetCore.Mvc;

namespace Chris.TechniqueTool.EntityGenerate.Controllers
{
    public class OperationPlatformTestController : Controller
    {
        private readonly OperationPlatformTestContext _context;

        public OperationPlatformTestController(OperationPlatformTestContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IActionResult Index()
        {
            var list = _context.User.ToList();

            return View(list);
        }
    }
}
