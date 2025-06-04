namespace SampleTestUI.Models
{
    public class Player
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string? ImageUrl { get; set; }
        public double PokerBalance { get; set; }
        // 0 is Pi Lamb, 1 is Hometown, 2 is Both
        public int? FriendGroup { get; set; }

    }
}
