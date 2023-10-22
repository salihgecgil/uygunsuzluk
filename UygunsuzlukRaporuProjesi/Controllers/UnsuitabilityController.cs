using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UygunsuzlukRaporuProjesi.Models;

namespace UygunsuzlukRaporuProjesi.Controllers
{
    public class UnsuitabilityController : Controller
    {
        private readonly UnsuitabilityDbContext _context;

        public UnsuitabilityController(UnsuitabilityDbContext context)
        {
            _context = context;
        }

        // GET: Unsuitability
        public async Task<IActionResult> Index()
        {
              return _context.Unsuitabilities != null ? 
                          View(await _context.Unsuitabilities.ToListAsync()) :
                          Problem("Entity set 'UnsuitabilityDbContext.Unsuitabilities'  is null.");
        }

        // GET: Unsuitability/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Unsuitabilities == null)
            {
                return NotFound();
            }

            var unsuitability = await _context.Unsuitabilities
                .FirstOrDefaultAsync(m => m.UnsuitabilityNumber == id);
            if (unsuitability == null)
            {
                return NotFound();
            }

            return View(unsuitability);
        }

        // GET: Unsuitability/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Unsuitability/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UnsuitabilityNumber,UnsuitabilityType,OrderNumber,ProjectNumber,WorkOrderNumber,PartNumber,UnsuitabilityData,PartRevisionNumber,UnsuitabilityDetectedCenterNumber,UnsuitabilityDetectedOperationNumber,ProductionQuantity,AcceptedQuantity,UnsuitabilityQuantity,UnsuitabilePersonel,UnsuitabileSection,SerialNumber,CustomerInfo,UnsuitabilityDefinition,UnsuitabilityIdentifierInfo,UnsuitabilityIdentifiingDate,UnsuitabilityConfirmerInfo,UnsuitabilityConfirmingInfo,EmergencySolution,EmergencySolutionWriterInfo,EmergencySolutionDate,UnsuitabilityCodeAndDescription,IsCustomerProduct,IsDfActivityRequired,ActionForRefusingUnsuitability,ActionForRefusingUnsuitabilityPersonelInfo,ActionForRefusingUnsuitabilityDate,AuditResult,UnsuitabilityDetectorPersonelInfo,UnsuitabilityDetectionDate")] Unsuitability unsuitability)
        {
            if (ModelState.IsValid)
            {
                _context.Add(unsuitability);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(unsuitability);
        }

        // GET: Unsuitability/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Unsuitabilities == null)
            {
                return NotFound();
            }

            var unsuitability = await _context.Unsuitabilities.FindAsync(id);
            if (unsuitability == null)
            {
                return NotFound();
            }
            return View(unsuitability);
        }

        // POST: Unsuitability/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UnsuitabilityNumber,UnsuitabilityType,OrderNumber,ProjectNumber,WorkOrderNumber,PartNumber,UnsuitabilityData,PartRevisionNumber,UnsuitabilityDetectedCenterNumber,UnsuitabilityDetectedOperationNumber,ProductionQuantity,AcceptedQuantity,UnsuitabilityQuantity,UnsuitabilePersonel,UnsuitabileSection,SerialNumber,CustomerInfo,UnsuitabilityDefinition,UnsuitabilityIdentifierInfo,UnsuitabilityIdentifiingDate,UnsuitabilityConfirmerInfo,UnsuitabilityConfirmingInfo,EmergencySolution,EmergencySolutionWriterInfo,EmergencySolutionDate,UnsuitabilityCodeAndDescription,IsCustomerProduct,IsDfActivityRequired,ActionForRefusingUnsuitability,ActionForRefusingUnsuitabilityPersonelInfo,ActionForRefusingUnsuitabilityDate,AuditResult,UnsuitabilityDetectorPersonelInfo,UnsuitabilityDetectionDate")] Unsuitability unsuitability)
        {
            if (id != unsuitability.UnsuitabilityNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(unsuitability);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UnsuitabilityExists(unsuitability.UnsuitabilityNumber))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(unsuitability);
        }

        // GET: Unsuitability/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Unsuitabilities == null)
            {
                return NotFound();
            }

            var unsuitability = await _context.Unsuitabilities
                .FirstOrDefaultAsync(m => m.UnsuitabilityNumber == id);
            if (unsuitability == null)
            {
                return NotFound();
            }

            return View(unsuitability);
        }

        // POST: Unsuitability/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Unsuitabilities == null)
            {
                return Problem("Entity set 'UnsuitabilityDbContext.Unsuitabilities'  is null.");
            }
            var unsuitability = await _context.Unsuitabilities.FindAsync(id);
            if (unsuitability != null)
            {
                _context.Unsuitabilities.Remove(unsuitability);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UnsuitabilityExists(int id)
        {
          return (_context.Unsuitabilities?.Any(e => e.UnsuitabilityNumber == id)).GetValueOrDefault();
        }
    }
}
