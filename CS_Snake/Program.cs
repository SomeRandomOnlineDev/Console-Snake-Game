using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CS_Snake
{
    public class SnakeBody
    {
        public SnakeBody(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x; 
        public int y;
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            int windowWidth = Console.WindowWidth;
            int windowHeight = Console.WindowHeight;

            bool gameLoop = true;

            List<SnakeBody> SnakeList = new List<SnakeBody> // 
            {
                new SnakeBody(windowWidth / 2, windowHeight / 2),
                new SnakeBody((windowWidth / 2) - 1, windowHeight / 2),
                new SnakeBody((windowWidth / 2) - 2, windowHeight / 2)
            };


            int direction = 1; // Gives the player a starting direction, as well as intializes the direction variable

            void Input()
            {

                /*
                 * This method reads the keyboard input
                 * and sets the global directions variable
                 * aslong as the current direction isn't the opposite as the
                 */

                if (Keyboard.IsKeyDown(Key.Up) || Keyboard.IsKeyDown(Key.W))
                {
                    if (direction != 2)
                    {
                        direction = 1;
                    }
                }
                else if (Keyboard.IsKeyDown(Key.Down) || Keyboard.IsKeyDown(Key.S))
                {
                    if (direction != 1)
                    {
                        direction = 2;
                    }
                }
                else if (Keyboard.IsKeyDown(Key.Left) || Keyboard.IsKeyDown(Key.A))
                {
                    if (direction != 4)
                    {
                        direction = 3;
                    }
                }
                else if (Keyboard.IsKeyDown(Key.Right) || Keyboard.IsKeyDown(Key.D))
                {
                    if (direction != 3)
                    {
                        direction = 4;
                    }
                }
            }

            void Logic()
            {
                foreach (var snake in SnakeList)
                {

                    /*
                     * 1 = up
                     * 2 = down
                     * 3 = left
                     * 4 = right
                     */

                    if (direction == 1)
                    {

                    }
                    else if (direction == 2)
                    {

                    }
                    else if (direction == 3)
                    {

                    }
                    else if (direction == 4)
                    {

                    }
                }
            }

            void Draw()
            {

            }

            /*
             * This is the main game loop
             * It starts by gathering input
             * Then processes that input
             * Then Draws the game based on that logic
             */
            while (gameLoop)
            {
                Input();

                Logic();

                Draw();
            }
            
        }
    }
}
