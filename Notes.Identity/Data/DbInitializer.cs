namespace Notes.Identity.Data
{
    public class DbInitializer
    {
        public static void Initialize(AuthDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();
        }
    }
}
