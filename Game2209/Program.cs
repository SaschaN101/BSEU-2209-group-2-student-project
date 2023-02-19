
namespace Game2209
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.ShowHelloBanner();

            Player playerOne = game.CreatePlayer(1);
            Player playerTwo = game.CreatePlayer(2);

            game.ChooseEquipment(playerOne);
            game.ChooseEquipment(playerTwo);

            Player winner = game.Fight(playerOne, playerTwo);
            game.Countdown();

            game.CongratulateWinner(winner);
        }
    }
}
