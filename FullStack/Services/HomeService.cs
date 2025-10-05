using FullStack.Models;

namespace FullStack.Services
{
    public class HomeService : IHomeService
    {
        private readonly IHomeRepository _homeRepository;
        public HomeService(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }
        public async Task<Home> GetHomeImageAsync()
        {
            var home = await _homeRepository.GetHomeImage();
            return home;

        }
    }
}
