using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
	public class Team
	{
		public Team()
		{
			this.HomeGames = new HashSet<Game>();
			this.AwayGames = new HashSet<Game>();
			this.Players = new HashSet<Player>();
		}

		[Key]
		public int TeamId { get; set; }
		public decimal Budget { get; set; }
		public string Initials { get; set; }

		[Column(TypeName = "varchar(max)")]
		public string LogoUrl { get; set; }

		[MaxLength(128)]
		public string Name { get; set; }

		[ForeignKey("PrimaryKitColor")]
		public int PrimaryKitColorId { get; set; }
		public Color PrimaryKitColor { get; set; }

		[ForeignKey("SecondaryKitColor")]
		public int SecondaryKitColorId { get; set; }
		public Color SecondaryKitColor { get; set; }

		[ForeignKey("Town")]
		public int TownId { get; set; }
		public Town Town { get; set; }

		public virtual ICollection<Game> HomeGames { get; set; }
		public virtual ICollection<Game> AwayGames { get; set; }
		public virtual ICollection<Player> Players { get; set; }
	}
}
