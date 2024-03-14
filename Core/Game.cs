using Awale.Components;

namespace Awale.Core
{
    public class Game
    {
        static void Main(string[] args)
        {
            ArrayConstructor arrayConstructor = new ArrayConstructor();
            arrayConstructor.SendToDisplaying();
            ReadyToPlay readyToPlay = new ReadyToPlay();
            if (readyToPlay.isEmpty(arrayConstructor.cells))
            {
                readyToPlay.StartGame();
            }
        }
    }
}
