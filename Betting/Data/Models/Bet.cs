using Betting.Data.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
	public class Bet
	{
		[Key]
		public int BetId { get; set; }
		public decimal Amount { get; set; }

		[Required]
		public Prediction Predication { get; set; }

		public DateTime DateTime { get; set; }

		[ForeignKey("Game")]
		public int GameId { get; set; }
		public virtual Game Game { get; set; }

		[ForeignKey("User")]
		public int UserId { get; set; }
		public virtual User User { get; set; }
	}
}
