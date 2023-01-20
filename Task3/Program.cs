//Завдання 3

//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 

//Потрібно: 

//Створіть 2 інтерфейси IPlayable та IRecodable. У кожному з інтерфейсів створіть по
//3 методи void Play() / void Pause() / void Stop() та void Record() / void Pause() / void Stop() відповідно.
//Створіть похідний клас Player від базових інтерфейсів IPlayable та IRecodable.
//Написати програму, яка виконує програвання та запис.

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Play();
            player.Stop();
            player.Record();
            player.Pause();
            Console.WriteLine("---------");
            IPlayable playable = player as IPlayable;
            playable.Play();
            playable.Stop();
            playable.Pause();
            Console.WriteLine("---------");
            IRecodable recodable = player as IRecodable;
            recodable.Stop();
            recodable.Record();
            recodable.Pause();
        }
    }
}