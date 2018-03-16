#include <exception>
#include <string>
#include <iostream>
#include <SDL.h>
#include <iostream>
#include <SDL.h>
#include <game.h>
#include <iostream>

Game *g;

int main(int argc, char * argv[])
{

    g = new Game();

    //master funkce, bude inicialisovat ovládání, preference, načítání grafiky
    g->init();

    //hra může být ukončena nejen zavřením okna (v budoucnu)
    while(g->doRun())
    {
        //opět master funkce, která bude volat update všech managerů
        g->update();

    }

    //jinak zde nic dalšího asi nemusí být!

    return 0;
}