using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using W24_TP.Models;

namespace W24_TP.Controllers
{
	public class SubjectsController : Controller
	{
		private readonly W24TpContext _context;

		public SubjectsController(W24TpContext context)
		{
			_context = context;
		}

		// GET: Subjects
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Index()
		{
			var w24TpContext = _context.Subjects
				.Include(s => s.FkCategoryNavigation)
				.Include(s => s.Replies)
				.Include(s => s.FkUserNavigation);
			return View(await w24TpContext.ToListAsync());
		}

		// GET: Subjects/5
		public async Task<IActionResult> IndexPerCat(int? id, int? pageNumber, int? customPageSize)
		{
			if (pageNumber < 1)
				pageNumber = 1;

			if (customPageSize != 5)
				ViewData["customPageSize"] = customPageSize;

			var w24TpContext = _context.Subjects
				.Include(s => s.FkCategoryNavigation)
				.Include(s => s.Replies)
				.ThenInclude(r => r.FkUserNavigation)
				.Include(s => s.FkUserNavigation)
				.Where(s => s.FkCategoryNavigation != null && s.FkCategoryNavigation.Id == id);

			return View(await PaginatedList<Subject>.CreateAsync(w24TpContext, pageNumber ?? 1, customPageSize ?? 5));
		}

		// GET: Subjects/Details/5
		//public async Task<IActionResult> Details(int? id)
		//{
		//	if (id == null)
		//	{
		//		return NotFound();
		//	}
		//
		//	var subject = await _context.Subjects
		//		.Include(s => s.FkCategoryNavigation)
		//		.FirstOrDefaultAsync(m => m.Id == id);
		//	if (subject == null)
		//	{
		//		return NotFound();
		//	}
		//
		//	return View(subject);
		//}

		// GET: Subjects/Create
		[Authorize(Roles = "Admin")]
		public IActionResult Create()
		{
			ViewData["FkCategory"] = new SelectList(_context.Categories.OrderBy(c => c.Name), "Id", "Name");
			return View();
		}

		// POST: Subjects/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Create([Bind("Id,FkCategory,FkUser,Title,Body,Date,View,Active")] Subject subject)
		{
			subject.FkCategoryNavigation = _context.Categories.First(c => c.Id == subject.FkCategory);
			subject.View = 0;
			subject.Date = DateTime.Now;
			if (ModelState.IsValid)
			{
				_context.Add(subject);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			ViewData["FkCategory"] = new SelectList(_context.Categories.OrderBy(c => c.Name), "Id", "Name");
			return View(subject);
		}

		// GET: CreatePerCat/5
		[Authorize]
		public IActionResult CreatePerCat(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var subject = new Subject();
			subject.FkCategoryNavigation = _context.Categories.FirstOrDefault(c => c.Id == id);
			return View(subject);
		}

		// POST: Subjects/CreatePerCat/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		[Authorize]
		public async Task<IActionResult> CreatePerCat(int id, [Bind("FkUser,Title,Body,Date,View,Active")] Subject subject)
		{
			subject.FkCategory = id;
			subject.Active = true;
			subject.View = 0;
			subject.Date = DateTime.Now;
			subject.FkUser = User.FindFirstValue(ClaimTypes.NameIdentifier);

			if (ModelState.IsValid)
			{
				_context.Add(subject);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(IndexPerCat), new { id });
			}
			return View(subject);
		}

		// GET: Subjects/Edit/5
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var subject = await _context.Subjects.FindAsync(id);
			if (subject == null)
			{
				return NotFound();
			}
			ViewData["FkCategory"] = new SelectList(_context.Categories, "Id", "Name", subject.FkCategory);
			return View(subject);
		}

		// POST: Subjects/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Edit(int id, [Bind("Id,FkCategory,FkUser,Title,Body,Date,View,Active")] Subject subject)
		{
			if (id != subject.Id)
			{
				return NotFound();
			}

			_context.Entry(subject).Reference(s => s.FkCategoryNavigation).Load();

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(subject);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!SubjectExists(subject.Id))
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
			ViewData["FkCategory"] = new SelectList(_context.Categories, "Id", "Name", subject.FkCategory);
			return View(subject);
		}

		// GET: Subjects/EditUser/5
		[Authorize]
		public async Task<IActionResult> EditUser(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var subject = await _context.Subjects.FindAsync(id);
			if (subject == null)
			{
				return NotFound();
			}
			if (subject.FkUser != User.FindFirstValue(ClaimTypes.NameIdentifier))
			{
				return NotFound();
			}
			ViewData["FkCategory"] = new SelectList(_context.Categories, "Id", "Name", subject.FkCategory);
			return View(subject);
		}

		// POST: Subjects/EditUser/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		[Authorize]
		public async Task<IActionResult> EditUser(int id, [Bind("Id,FkCategory,FkUser,Title,Body,Date,View,Active")] Subject subject)
		{
			if (id != subject.Id)
			{
				return NotFound();
			}

			_context.Entry(subject).Reference(s => s.FkCategoryNavigation).Load();

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(subject);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!SubjectExists(subject.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction("IndexPerCat", new { id = subject.FkCategoryNavigation!.Id, pageNumber = 1, customPageSize = 5 });
			}
			ViewData["FkCategory"] = new SelectList(_context.Categories, "Id", "Name", subject.FkCategory);
			return View(subject);
		}

		// GET: Subjects/Delete/5
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var subject = await _context.Subjects
				.Include(s => s.FkCategoryNavigation)
				.FirstOrDefaultAsync(m => m.Id == id);
			if (subject == null)
			{
				return NotFound();
			}

			return View(subject);
		}

		// POST: Subjects/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var subject = await _context.Subjects.FindAsync(id);
			if (subject != null)
			{
				subject.Active = false;
				_context.Subjects.Update(subject);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool SubjectExists(int id)
		{
			return _context.Subjects.Any(e => e.Id == id);
		}
	}
}
