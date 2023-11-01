namespace BlackJack_CA
{
    internal class Program
    {
        static List<string> CardSuits = new List<string>() { "Diamonds", "Hearts", "Clubs", "Spades" }; //List of Suits
        static List<string> CardValues = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" }; //List of Cards Types
        static List<string> Deck = new List<string>(); //List of the actual Deck
        static void Main(string[] args)
        {
            Card Player1 = new Card();//Tests for Card class
            Player1.DeckReshuffle();
            string card = Player1.GetCard();
            Player1.GetCardValue(card);



            Betting _Player1 = new Betting();//Tests for Betting class
            _Player1.GetName();
            _Player1.GetTotalBettingChips();
            Console.WriteLine(_Player1.ToString());

        }
    }
}