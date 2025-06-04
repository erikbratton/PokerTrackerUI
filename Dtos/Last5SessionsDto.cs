namespace SampleApi.Dtos
{
    public class Last5PokerSessions
    {
        public int SessionId { get; set; }
        public DateTime Date { get; set; }
        public string WinnerImageUrl { get; set; }
        public string LoserImageUrl { get; set; }
        public string BiggestWinner { get; set; }
        public decimal BiggestWin {  get; set; }
        public string BiggestLoser { get; set; }
        public decimal BiggestLoss { get; set; }

    }
}
