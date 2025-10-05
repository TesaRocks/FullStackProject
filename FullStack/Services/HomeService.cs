using FullStack.Models;

namespace FullStack.Services
{
    public class HomeService : IHomeService
    {
        public Task<Home> GetHomeImageAsync()
        {
            var home = new Home
            {
                Title = "Welcome to FullStack Application",
                Description = "This is a sample description for the home image.",
                ImageUrl = "https://example.com/home-image.jpg"
            };
            return Task.FromResult(home);
        }
    }
}
