namespace Pomdro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sleep for 2 seconds.");
                Thread.Sleep(3000);
            }*/
            Pomdro pomdro = new Pomdro();
            pomdro.play();
            pomdro.getWorkLog();
        }
    }
}