﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
	public class Town
	{
		public Town()
		{
			this.Teams = new HashSet<Team>();
		}

		[Key]
		public int TownId { get; set; }

		[MaxLength(64)]
		public string Name { get; set; }

		[ForeignKey("Country")]
		public int CountryId { get; set; }
		public Country Country { get; set; }

		public virtual ICollection<Team> Teams { get; set; }
	}
}
