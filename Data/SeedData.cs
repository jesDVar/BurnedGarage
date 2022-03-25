namespace BurnedGarage.Data
{
    public class SeedData
    {
        private static BurnedGarageContext db = default!;
        public static async Task InitAsync(BurnedGarageContext context, IServiceProvider services, string adminPW)
        {
            db = context;




        }
    }
}
