using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using W24_TP.Models;

namespace W24_TP.Controllers
{
	public class AdminController : Controller
	{
		private readonly W24TpContext _context;

		public AdminController(W24TpContext context)
		{
			_context = context;
		}

        public IActionResult Index()
        {
            var subjectQuery = from u in _context.AspNetUsers
                               join s in _context.Subjects on u.Id equals s.FkUser into subjectGroup
                               from sg in subjectGroup.DefaultIfEmpty()
                               group sg by u.UserName into groupedSubjects
                               select new
                               {
                                   Username = groupedSubjects.Key,
                                   SubjectCount = groupedSubjects.Count(s => s != null),
                                   LatestSubjectDate = groupedSubjects.Max(s => s != null ? s.Date : (DateTime?)null)
                               };

            var replyQuery = from u in _context.AspNetUsers
                             join r in _context.Replies on u.Id equals r.FkUser into replyGroup
                             from rg in replyGroup.DefaultIfEmpty()
                             group rg by u.UserName into groupedReplies
                             select new
                             {
                                 Username = groupedReplies.Key,
                                 ReplyCount = groupedReplies.Count(r => r != null),
                                 LatestReplyDate = groupedReplies.Max(r => r != null ? r.Date : (DateTime?)null)
                             };

            var combinedQuery = subjectQuery
                .Select(s => new
                {
                    s.Username,
                    s.SubjectCount,
                    s.LatestSubjectDate,
                    ReplyCount = 0,
                    LatestReplyDate = (DateTime?)null
                })
                .Union(replyQuery
                    .Select(r => new
                    {
                        r.Username,
                        SubjectCount = 0,
                        LatestSubjectDate = (DateTime?)null,
                        r.ReplyCount,
                        r.LatestReplyDate
                    }));

            var query = from c in combinedQuery
                        group c by c.Username into groupedData
                        select new Admin
                        {
                            Username = groupedData.Key,
                            SubjectCount = groupedData.Sum(x => x.SubjectCount),
                            ReplyCount = groupedData.Sum(x => x.ReplyCount),
                            LastSeen = groupedData.Max(x => x.LatestSubjectDate > x.LatestReplyDate ? x.LatestSubjectDate : x.LatestReplyDate)
                        };

            return View(query);
        }
    }
}
