using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
	public class Game
	{
		public Game()
		{
			this.Bets = new HashSet<Bet>();
		}

		[Key]
		public int GameId { get; set; }

		public string AwayTeamBetRate { get; set; }
		public string AwayTeamGoals { get; set; }
		public string DrawBetRate { get; set; }
		public string HomeTeamBetRate { get; set; }
		public string HomeTeamGoals { get; set; }

		public string Results { get; set; }
		public DateTime DateTime { get; set; }

		[ForeignKey("AwayTeam")]
		public int AwayTeamId { get; set; }
		public Team AwayTeam { get; set; }

		[ForeignKey("HomeTeam")]
		public int HomeTeamId { get; set; }
		public Team HomeTeam { get; set; }

		public virtual ICollection<Bet> Bets { get; set; }
	}
}
