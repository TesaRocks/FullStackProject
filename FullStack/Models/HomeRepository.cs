using FullStack.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace FullStack.Models
{
    public class HomeRepository: IHomeRepository    
    {
        private readonly HomeDBContext _context;
        public HomeRepository(HomeDBContext context)
        {
            _context = context;
        }

        public async Task<Home> GetHomeImage()
        {
            return await _context.Homes.FirstOrDefaultAsync();

            //var home = new Home
            //{
            //    Title = "Welcome to FullStack Application",
            //    Description = "This is a sample description for the home image.",
            //    ImageUrl = "https://i.ebayimg.com/images/g/kMMAAOSw7vNjhRdl/s-l1600.webp"
            //};
            //return home;
        }
    }   
}
