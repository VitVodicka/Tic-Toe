using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Tic_Toe
{
    class Background:INotifyPropertyChanged
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

        public event PropertyChangedEventHandler PropertyChanged;

        public void Adding()
        {
            Background b = new Background(PlayerX, PlayerY, Tie, Timer);
            Observ.Add(b);
        }
        public void Checking(string[,] array)
        {
            for (int i = 0; i < pole.GetLength(0); i++)//rows
            {
                for (int k = 0; k < pole.GetLength(1); k++)//columns
                {
                    /*if ((k == 0) && (pole[i, k] == "X") && (pole[i, k + 1] == "X") && (pole[i, k + 2] == "X"))
                    {
                        PlayerX += 1;
                        Console.WriteLine("PlayerX:"+PlayerX);

                    }
                    if ((k == 0) && (pole[i, k] == "Y") && (pole[i, k + 1] == "Y") && (pole[i, k + 2] == "Y"))
                    {
                        PlayerY += 1;
                        Console.WriteLine("PlayerY:"+PlayerY);

                    }*/
                    //column checking working

                    /* if ((i == 0) && (pole[i, k] == "X") && (pole[i+1,k] == "X") && (pole[i+2, k] == "X"))
                     {
                         PlayerX += 1;
                         Console.WriteLine("PlayerX:" + PlayerX);

                     }
                     if ((i == 0) && (pole[i, k] == "Y") && (pole[i + 1, k] == "Y") && (pole[i + 2, k] == "Y"))
                     {
                         PlayerY += 1;
                         Console.WriteLine("PlayerY:" + PlayerY);

                     }
                     row checking working
                     */
                    /*
                    if ((i == 0) && (k==0)&& (pole[i, k] == "X") && (pole[i + 1, k+1] == "X") && (pole[i + 2, k+2] == "X"))
                    {
                        PlayerX += 1;
                        Console.WriteLine("PlayerX:" + PlayerX);

                    }
                    if ((i == 0) && (k == 0) && (pole[i, k] == "Y") && (pole[i + 1, k + 1] == "Y") && (pole[i + 2, k + 2] == "Y"))
                    {
                        PlayerY += 1;
                        Console.WriteLine("PlayerY:" + PlayerY);

                    }
                    left diagonal checking
                    */
                    /*
                    if ((i == 0) && (k == 2))
                    {
                        if ((pole[i, k]=="X")&&(pole[i+1,k-1]=="X") && (pole[i + 2, k - 2] == "X"))
                        {
                            PlayerX += 1;
                            Console.WriteLine("PlayerX:" + PlayerX);
                        }


                    }
                    if ((i == 0) && (k == 2))
                    {
                        if ((pole[i, k] == "Y") && (pole[i + 1, k - 1] == "Y") && (pole[i + 2, k - 2] == "Y"))
                        {
                            PlayerY += 1;
                            Console.WriteLine("PlayerY:" + PlayerY);
                        }


                    }
                    right diagonal working
                    */


                    //rows working
                }
            }

            //string[,] pole = { { "X", "X", "X" }, { "Y", "Y", "Y" }, { "X", "X", "X" } }; column checking
            //string[,] pole = { { "X", "Y", "X" }, { "X", "Y", "X" }, { "X", "Y", "X" } }; row checking
            string[,] pole = { { "X", "X", "Y" }, { "X", "Y", "Y" }, { "Y", "Y", "Y" } };

           
            //pomocí pomocného textboxu budu poznávat zda tam má být křížek nebo kolečko a pomocí datatrigeru budu na něj se odtaz, jestli tam je křížek nebo kolečko a podle toho poznám, jaký znak by tam měl být
        }
        public void Change(string change)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(change));
            }
        }
    }
}
