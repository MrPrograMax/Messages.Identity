namespace Messages.Identity.Data
{
    public class DbInitializer
    {
        public static void Initializer(AuthDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
