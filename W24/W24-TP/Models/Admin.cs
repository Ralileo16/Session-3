using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace W24_TP.Models
{
	public partial class Admin
	{
		[Key, Column]
		public string Username { get; set; } = null!;

		public int SubjectCount { get; set; }

		public int ReplyCount { get; set; }

		public DateTime? LastSeen { get; set; }
	}
}
