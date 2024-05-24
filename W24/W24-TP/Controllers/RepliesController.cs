using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using W24_TP.Models;

namespace W24_TP.Controllers
{
    public class RepliesController : Controller
    {
        private readonly W24TpContext _context;

        public RepliesController(W24TpContext context)
        {
            _context = context;
        }

        // GET: Replies
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var w24TpContext = _context.Replies.Include(r => r.FkSubjectNavigation).Include(r => r.FkUserNavigation);
            return View(await w24TpContext.ToListAsync());
        }

		// GET: Replies/5
		public async Task<IActionResult> IndexPerSub(int? id, int? pageNumber, int? customPageSize)
		{
			if (pageNumber < 1)
				pageNumber = 1;

			if (customPageSize != 5)
				ViewData["customPageSize"] = customPageSize;

			_context.Subjects.Where(s => s.Id == id).FirstOrDefault()!.View++;
            await _context.SaveChangesAsync();
			var w24TpContext = _context.Replies
				.Include(s => s.FkSubjectNavigation)
				.Where(s => s.FkSubjectNavigation != null && s.FkSubjectNavigation.Id == id)
                .Include(r => r.FkUserNavigation);
			return View(await PaginatedList<Reply>.CreateAsync(w24TpContext, pageNumber ?? 1, customPageSize ?? 5));

		}

		// GET: Replies/Details/5
		//public async Task<IActionResult> Details(int? id)
		//{
		//    if (id == null)
		//    {
		//        return NotFound();
		//    }
		//
		//    var reply = await _context.Replies
		//        .Include(r => r.FkSubjectNavigation)
		//        .FirstOrDefaultAsync(m => m.Id == id);
		//    if (reply == null)
		//    {
		//        return NotFound();
		//    }
		//
		//    return View(reply);
		//}

		// GET: Replies/Create
		[Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewData["FkSubject"] = new SelectList(_context.Subjects, "Id", "Title");
            return View();
        }

        // POST: Replies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("Id,FkSubject,FkUser,Body,Date,Active")] Reply reply)
        {
            reply.FkSubjectNavigation = _context.Subjects.First(c => c.Id == reply.FkSubject);
            reply.Date = DateTime.Now;
            if (ModelState.IsValid)
            {
                _context.Add(reply);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FkSubject"] = new SelectList(_context.Subjects, "Id", "Title", reply.FkSubject);
            return View(reply);
        }

        // GET: Create/5
        [Authorize]
		public IActionResult CreatePerSub(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var reply = new Reply();
			reply.FkSubjectNavigation = _context.Subjects.FirstOrDefault(c => c.Id == id);
			return View(reply);
		}

		// POST: Subjects/Create/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		[Authorize]
		public async Task<IActionResult> CreatePerSub(int id, [Bind("FkUser,Body,Date,Active")] Reply reply)
		{
			reply.FkSubject = id;
            reply.Active = true;
			reply.Date = DateTime.Now;
            reply.FkUser = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
			{
				_context.Add(reply);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(IndexPerSub), new { id });
			}
			return View(reply);
		}

        // GET: Replies/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reply = await _context.Replies.FindAsync(id);
            if (reply == null)
            {
                return NotFound();
            }
            ViewData["FkSubject"] = new SelectList(_context.Subjects, "Id", "Title", reply.FkSubject);
            return View(reply);
        }

        // POST: Replies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FkSubject,FkUser,Body,Date,Active")] Reply reply)
        {
            if (id != reply.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reply);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReplyExists(reply.Id))
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
            ViewData["FkSubject"] = new SelectList(_context.Subjects, "Id", "Id", reply.FkSubject);
            return View(reply);
        }

		// GET: Replies/EditUser/5
		[Authorize]
		public async Task<IActionResult> EditUser(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var reply = await _context.Replies.FindAsync(id);
			if (reply == null)
			{
				return NotFound();
			}
			if (reply.FkUser != User.FindFirstValue(ClaimTypes.NameIdentifier))
			{
				return NotFound();
			}
			ViewData["FkSubject"] = new SelectList(_context.Subjects, "Id", "Title", reply.FkSubject);
			return View(reply);
		}

		// POST: Replies/EditUser/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		[Authorize]
		public async Task<IActionResult> EditUser(int id, [Bind("Id,FkSubject,FkUser,Body,Date,Active")] Reply reply)
		{
			if (id != reply.Id)
			{
				return NotFound();
			}

			_context.Entry(reply).Reference(r => r.FkSubjectNavigation).Load();

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(reply);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!ReplyExists(reply.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction("IndexPerSub", new { id = reply.FkSubjectNavigation!.Id, pageNumber = 1, customPageSize = 5 });
			}
			ViewData["FkSubject"] = new SelectList(_context.Subjects, "Id", "Id", reply.FkSubject);
			return View(reply);
		}

		// GET: Replies/Delete/5
		[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reply = await _context.Replies
                .Include(r => r.FkSubjectNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reply == null)
            {
                return NotFound();
            }

            return View(reply);
        }

        // POST: Replies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reply = await _context.Replies.FindAsync(id);

            if (reply != null)
            {
				reply.Active = false;
				_context.Replies.Update(reply);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

		// GET: Replies/Delete/5
		[Authorize]
		public async Task<IActionResult> DeleteUser(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var reply = await _context.Replies
				.Include(r => r.FkSubjectNavigation)
				.FirstOrDefaultAsync(m => m.Id == id);
			if (reply == null)
			{
				return NotFound();
			}

			return View(reply);
		}

		// POST: Replies/Delete/5
		[HttpPost, ActionName("DeleteUser")]
		[ValidateAntiForgeryToken]
		[Authorize]
		public async Task<IActionResult> DeleteUserConfirmed(int id)
		{
			var reply = await _context.Replies.FindAsync(id);

			if (reply != null)
			{
				reply.Active = false;
				_context.Replies.Update(reply);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction("IndexPerSub", new { id = reply!.FkSubject, pageNumber = 1, customPageSize = 5 });
		}

		private bool ReplyExists(int id)
        {
            return _context.Replies.Any(e => e.Id == id);
        }
    }
}
