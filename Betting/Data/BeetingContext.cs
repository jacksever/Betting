using Betting.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Betting.Data
{
	public class BeetingContext : DbContext
	{
		public BeetingContext() { }

		public BeetingContext(DbContextOptions options)
			: base(options) { }

		public virtual DbSet<Bet> Bets { get; set; }
		public virtual DbSet<Color> Colors { get; set; }
		public virtual DbSet<Country> Countries { get; set; }
		public virtual DbSet<Game> Games { get; set; }
		public virtual DbSet<Player> Players { get; set; }
		public virtual DbSet<PlayerStatistic> PlayerStatistics { get; set; }
		public virtual DbSet<Position> Positions { get; set; }
		public virtual DbSet<Team> Teams { get; set; }
		public virtual DbSet<Town> Towns { get; set; }
		public virtual DbSet<User> Users { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
				optionsBuilder.UseSqlServer(@"Server=.;Database=Betting;Integrated Security=True;");

			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<PlayerStatistic>(entity =>
			{
				entity.HasKey(ps => new { ps.GameId, ps.PlayerId });
			});

			modelBuilder.Entity<Team>(entity =>
			{
				entity.HasKey(t => t.TeamId);

				entity.HasOne(t => t.PrimaryKitColor)
					.WithMany(c => c.PrimaryKitTeams)
					.HasForeignKey(t => t.PrimaryKitColorId)
					.OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(t => t.SecondaryKitColor)
					.WithMany(c => c.SecondaryKitTeams)
					.HasForeignKey(t => t.SecondaryKitColorId)
					.OnDelete(DeleteBehavior.Restrict);
			});

			modelBuilder.Entity<Game>(entity =>
			{
				entity.HasKey(g => g.GameId);

				entity.HasOne(g => g.AwayTeam)
					.WithMany(c => c.AwayGames)
					.HasForeignKey(g => g.AwayTeamId)
					.OnDelete(DeleteBehavior.Restrict);

				entity.HasOne(g => g.HomeTeam)
					.WithMany(c => c.HomeGames)
					.HasForeignKey(g => g.HomeTeamId)
					.OnDelete(DeleteBehavior.Restrict);
			});
		}
	}
}
