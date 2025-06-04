namespace SampleTestUI.Models
{
    public class PokerSessionFormModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool IsSelected { get; set; }
        public decimal Balance { get; set; }
        public int? FriendGroup { get; set; }
    }

}
