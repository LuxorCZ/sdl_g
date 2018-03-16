using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDL2;
using Game.Engine;

namespace Game
{
    class Program
    {

        private static GameController controller;

        static void Main(string[] args)
        {
            SDL.SDL_Init(SDL.SDL_INIT_EVERYTHING);

            controller = new GameController();

            while (controller.doLoop())
            {
                controller.gameLoop();
            }

        }
    }
}
