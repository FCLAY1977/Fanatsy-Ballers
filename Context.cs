using Microsoft.EntityFrameworkCore;


public class Context : DbContext

{
   
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(@"Data Source=FantasyBallers.db");
    }
   
   
    public DbSet<FantasyTeam>? FantasyTeams {get;set;}


}