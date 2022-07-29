namespace ChainOfResponsibilityMpgAvi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PlayerHandler mp4Player = new Mp4();
            PlayerHandler mpgPlayer = new Mpg();
            PlayerHandler aviPlayer = new Avi();

            mp4Player.SonrakiHandler = mpgPlayer;
            mpgPlayer.SonrakiHandler = aviPlayer;
            
            mp4Player.play("asgsafsdg.avi");
            mp4Player.play("adgsafs.mpg");
            
            aviPlayer.play("asdgsfas.mp4");

        }
    }
}