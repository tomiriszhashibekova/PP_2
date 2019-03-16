using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace snake
{
    class GameState
    {

        Timer timer = new Timer(120);

        public Worm worm = new Worm('O');
        public Food food = new Food('@');
        public Wall wall = new Wall('#');

        public void Run()
        {
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            food.Generate(worm.body, wall.body);
            wall.Draw();
            food.Draw();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            worm.Clear();
            worm.Move();
            worm.Draw();
            CheckCollision();
        }

        public void Stop()
        {
            timer.Stop();
            Console.Clear();
        }

        public GameState()
        {
            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(40, 40);
            Console.CursorVisible = false;
        }

        public void ProcessKeyEvent(ConsoleKeyInfo consoleKeyInfo)
        {
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    worm.Dx = 0;
                    worm.Dy = -1;
                    break;
                case ConsoleKey.DownArrow:
                    worm.Dx = 0;
                    worm.Dy = 1;
                    break;
                case ConsoleKey.RightArrow:
                    worm.Dx = 1;
                    worm.Dy = 0;
                    break;
                case ConsoleKey.LeftArrow:
                    worm.Dx = -1;
                    worm.Dy = 0;
                    break;
                case ConsoleKey.Spacebar:
                    timer.Enabled = !timer.Enabled;
                    break;

            }
        }

        private void CheckCollision()
        {
            if (worm.CheckIntersection(wall.body))
            {
                timer.Enabled = false;
                Console.Clear();
                Console.SetCursorPosition(10, 20);
                Console.Write("Game over!");
            }
            else if (worm.CheckIntersection(food.body))
            {
                worm.Eat(food.body);
                food.Generate(worm.body, wall.body);
                food.Draw();
            }
        }
    }
}
