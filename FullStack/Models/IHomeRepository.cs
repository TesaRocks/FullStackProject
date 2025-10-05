namespace FullStack.Models
{
    public interface IHomeRepository
    {
        public Task<Home> GetHomeImage();
    }
}
