using SampleTestUI.Models;

namespace SampleApi.Dtos
{
    public class PokerPlayerDto
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? ImageUrl { get; set; }
        public decimal? PokerBalance { get; set; }
        public List<PlayerSessions> Sessions { get; set; }
    }
}
