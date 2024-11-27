using Snake1125.Game.Objects;

namespace Snake1125
{
    internal class Control
    {
        SnakeGame game;
        internal void Run(SnakeGame game)
        {
            this.game = game;

            //Thread это класс для запуска метода в отдельном потоке. Отдельный поток нужен, чтобы метод мог выполняться обособленно
            //он не будет тормозить остальную часть программы
            Thread thread = new Thread(ListenKeyboard);
            thread.Start();
        }

        private void ListenKeyboard(object? obj)
        {
            while (game.SnakeIsAlive)
            {
                var key = Console.ReadKey();
                Console.SetCursorPosition(0, 0);
                Direction direction;
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        direction = Direction.up;
                        break;
                    case ConsoleKey.DownArrow:
                        direction = Direction.down;
                        break;
                    case ConsoleKey.LeftArrow:
                        direction = Direction.left;
                        break;
                    case ConsoleKey.RightArrow:
                        direction = Direction.right;
                        break;
                    case ConsoleKey.Escape:
                        game.Stop();
                        return;
                    default:
                        continue;
                }
                game.SendNewSnakeDirection(direction);
            }
        }
    }
}