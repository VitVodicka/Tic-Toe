using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Tic_Toe
{
    class Background
    {
        public Background(int playerX, int playerY, int tie, int timer)
        {
            PlayerX = playerX;
            PlayerY = playerY;
            Tie = tie;
            Timer = timer;
        }
        public Background()
        {
            Observ = new ObservableCollection<Background>();
        }

        public int PlayerX { get; set; }
        public int PlayerY { get; set; }
        public int Tie { get; set; }
        public int Timer { get; set; }

        public ObservableCollection<Background> Observ{get;set;}

        public void Adding()
        {
            Background b = new Background(PlayerX, PlayerY, Tie, Timer);
            Observ.Add(b);
        }
        public void Checking(string[,] array)
        {

            //pomocí pomocného textboxu budu poznávat zda tam má být křížek nebo kolečko a pomocí datatrigeru budu na něj se odtaz, jestli tam je křížek nebo kolečko a podle toho poznám, jaký znak by tam měl být
        }
    }
}
