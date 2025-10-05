namespace FullStack.Data
{
    public static class DBInitializer
    {
        public static void Initialize(IApplicationBuilder applicationBuilder)
        {
            HomeDBContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<HomeDBContext>();
            if (!context.Homes.Any())
            {
                context.Homes.AddRange(
                    new Models.Home
                    {
                        Id = Guid.NewGuid(),
                        Title = "Welcome to FullStack Application",
                        Description = "This is a sample description for the home image.",
                        ImageUrl = "https://i.ebayimg.com/images/g/kMMAAOSw7vNjhRdl/s-l1600.webp"
                    },
                    new Models.Home
                    {
                        Id = Guid.NewGuid(),
                        Title = "Explore the Features",
                        Description = "Discover the amazing features of our application.",
                        ImageUrl = "https://i.ebayimg.com/images/g/9KMAAOSw1WNjhRdm/s-l1600.webp"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
