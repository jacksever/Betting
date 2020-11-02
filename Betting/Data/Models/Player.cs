using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
	public class Player
	{
		[Key]
		public int PlayerId { get; set; }

		[MaxLength(64)]
		public string Name { get; set; }
		public int SquardNumber { get; set; }
		public bool IsInjured { get; set; }

		[ForeignKey("Position")]
		public int PositionId { get; set; }
		public Position Position { get; set; }

		[ForeignKey("Team")]
		public int TeamId { get; set; }
		public Team Team { get; set; }
	}
}
