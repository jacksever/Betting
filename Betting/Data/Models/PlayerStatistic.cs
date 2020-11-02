using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
	public class PlayerStatistic
	{
		public string Assits { get; set; }
		public int MinutesPlayed { get; set; }
		public string ScoredGoals { get; set; }
		
		[ForeignKey("Player")]
		public int PlayerId { get; set; }
		public Player Player { get; set; }

		[ForeignKey("Game")]
		public int GameId { get; set; }
		public Game Game { get; set; }
	}
}
