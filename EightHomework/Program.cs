using System.Text;

namespace EightHomework
{
    internal class Solution
    {
        static void Task()
        {
            //Большие гонки.
            //На шоу Большие гонки собираются 4 команды из разных стран. В команде по 15 человек.
            //Всего за одну игру команда проходит по 6 испытаний(6 разных игр).Будет неинтересно,
            //если каждый раз игры будут одинаковыми, поэтому каждый раз игры разные. Главный
            //организатор, Оливье Ганьян, добавляет новые игры.Необходимо правильно организовать
            //классы, чтобы класс передачи «Большие Гонки» не изменял свой функционал, а добавлял
            //новый.В консоли необходимо создать 4 команды: Россия, Франция, Китай и Казахстан, и
            //чтобы они сыграли в 6 игр.
            //Какие игры создать:
            //1.Пляж Beach
            //2.Мышеловка Mousetrap
            //3.Море Sea
            //4.Рыбалка Fishing
            //5.Почтальоны Mailpeople
            //6.Горка Slide
            //7.Rodeo
            //Также вам необходимо создать свою игру, но не изменяя класс, а расширяя функционал
            //класса.Подумайте, какой паттерн нужно использовать.
            Console.WriteLine("Testing Big Races with no games");
            List<IGame> gameLess = new List<IGame>();
            Teams noGames = new Teams(gameLess);
            Console.WriteLine("\n\n");
            noGames.BigRaces();
            Console.WriteLine("\n\n");
            List<IGame> games = new List<IGame>
            {
                new Beach(),
                new Fishing(),
                new Mailpeople(),
                new Mousetrap(),
                new Sea(),
                new Slide(),
            };
            Teams teams = new Teams(games);
            Console.WriteLine("Testing Big Races with no teams");
            Console.WriteLine("\n\n");
            teams.BigRaces();
            Console.WriteLine("\n\n");
            Console.WriteLine("Creating Russian team");
            Console.WriteLine("\n\n");
            Russia russia = Teams.InstanceRussia;
            Console.WriteLine("\n\n");
            Console.WriteLine("Testing Big Races with 1 team");
            teams.BigRaces();
            Console.WriteLine("Creating French, Chinese, Kazakh team");
            Kazakhstan kazakhstan = Teams.InstanceKazakhstan;
            China china = Teams.InstanceChina;
            France france = Teams.InstanceFrance;
            Console.WriteLine("\n\n");
            Console.WriteLine("Testing Big Races with 4 teams");
            teams.BigRaces();
            Console.WriteLine("Adding new Game - Rodeo");
            teams.AddGame(new Rodeo());
            Console.WriteLine("Testing Big Races with new Game");
            Console.WriteLine("\n\n");
            teams.BigRaces();
            return;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Task();
        }
    }
}