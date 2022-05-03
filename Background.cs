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
            Tru = false;
        }

        public int PlayerX { get; set; }
        public int PlayerY { get; set; }
        public int Tie { get; set; }
        public int Timer { get; set; }
        public string[,] array { get; set; }
        public bool Tru { get; set; }

        public ObservableCollection<Background> Observ{get;set;}

        public event PropertyChangedEventHandler PropertyChanged;

        public void Adding()
        {
            Background b = new Background(PlayerX, PlayerY, Tie, Timer);
            Observ.Add(b);
        }
        public void Checking(string[,] arr)
        {
            
            array = arr;
            for (int i = 0; i < array.GetLength(0); i++)//rows
            {
                for (int k = 0; k < array.GetLength(1); k++)//columns
                {
                    if ((k == 0) && (array[i, k] == "X") && (array[i, k + 1] == "X") && (array[i, k + 2] == "X"))
                    {
                        PlayerX += 1;
                        Change("PlayerX");
                        Tru = true;

                        Clearing();

                    }
                    if ((k == 0) && (array[i, k] == "Y") && (array[i, k + 1] == "Y") && (array[i, k + 2] == "Y"))
                    {
                        PlayerY += 1;
                        Change("PlayerY");
                        Clearing();
                        Tru = true;


                    }
                    //column checking working

                    if ((i == 0) && (array[i, k] == "X") && (array[i+1,k] == "X") && (array[i+2, k] == "X"))
                     {
                         PlayerX += 1;
                         Change("PlayerX");
                         Clearing();
                        Tru = true;

                    }
                     if ((i == 0) && (array[i, k] == "Y") && (array[i + 1, k] == "Y") && (array[i + 2, k] == "Y"))
                     {
                         PlayerY += 1;
                         Change("PlayerY");
                         Clearing();
                        Tru = true;


                    }
                     
                    
                    if ((i == 0) && (k==0)&& (array[i, k] == "X") && (array[i + 1, k+1] == "X") && (array[i + 2, k+2] == "X"))
                    {
                        PlayerX += 1;
                        Change("PlayerX");
                        Clearing();
                        Tru = true;


                    }
                    if ((i == 0) && (k == 0) && (array[i, k] == "Y") && (array[i + 1, k + 1] == "Y") && (array[i + 2, k + 2] == "Y"))
                    {
                        PlayerY += 1;
                        Change("PlayerY");
                        Clearing();
                        Tru = true;


                    }
                    
                    
                    
                    if ((i == 0) && (k == 2))
                    {
                        if ((array[i, k]=="X")&&(array[i+1,k-1]=="X") && (array[i + 2, k - 2] == "X"))
                        {
                            PlayerX += 1;
                            Change("PlayerX");
                            Clearing();
                            Tru = true;

                        }


                    }
                    if ((i == 0) && (k == 2))
                    {
                        if ((array[i, k] == "Y") && (array[i + 1, k - 1] == "Y") && (array[i + 2, k - 2] == "Y"))
                        {
                            PlayerY += 1;
                            Change("PlayerY");
                            Clearing();
                            Tru = true;

                        }


                    }
                    


                    //rows working
                }
            }
           
            //pomocí pomocného textboxu budu poznávat zda tam má být křížek nebo kolečko a pomocí datatrigeru budu na něj se odtaz, jestli tam je křížek nebo kolečko a podle toho poznám, jaký znak by tam měl být
        }
        public void Clearing()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    array[i, k] = null;
                    
                }
            }
            Change("array");
        }
        public void Full(string[,]arr)
        {
            array = arr;
            if (((array[0, 0] == "X") || (array[0, 0] == "Y")) && ((array[0, 1] == "X") || (array[0, 1] == "Y")) && ((array[1, 0] == "X") || (array[1, 0] == "Y")) && ((array[1, 1] == "X") || (array[1, 1] == "Y")) && ((array[0, 2] == "X") || (array[0, 2] == "Y")) && ((array[1, 2] == "X") || (array[1, 2] == "Y")) && ((array[2, 2] == "X") || (array[2, 2] == "Y")))
            {
                Tie += 1;
                Tru = true;
                Clearing();
                



            }
            Change("Tie");
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
