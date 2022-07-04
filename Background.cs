using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Threading;

namespace Tic_Toe
{
    class Background: INotifyPropertyChanged
    {
        public Background(int playerX, int playerO, int tie, string timer)//declaring new constructor
        {
            PlayerX = playerX;
            PlayerO = playerO;
            Tie = tie;
            Timer = timer;
            
        }
        public Background()//declaring new constructor
        {
            Observ = new ObservableCollection<Background>();
            Tru = false;
        }
        DispatcherTimer t = new DispatcherTimer();//declaring timer and seconds, hours,minutes
        int s = 0;//seconds
        int h = 0;//hours
        int m = 0;//minutes
        string[,] arry = new string[3, 3];//declaring 3x3 array

        public int PlayerX { get; set; }
        public int PlayerO { get; set; }
        public int Tie { get; set; }

        string timer;
        public string Timer { get { return timer; }
            set { timer = value; }
        
        }

        public string[,] array { get; set; }//declaring array to compare 
        public bool Tru { get; set; }

        public static ObservableCollection<Background> Observ { get; set; }//observablecollection

        public event PropertyChangedEventHandler PropertyChanged;

        public void init()//default settings of timer
        {
            
            t.Interval = new TimeSpan(0, 0, 1);

            t.Tick += new EventHandler(dispatcherTick);
            t.Start();
        }
        private void dispatcherTick(object sender, EventArgs e)//ticking timer
        {
            s += 1;
            if (s >= 60)
            {
                s = s - 60;
                m += 1;
            }
            if (h >= 24)
            {
                t.Stop();
            }
            if (m >= 60)
            {
                m = m - 60;
                h += 1;
            }
            TimerFormating();


        }
        private void TimerFormating()//timer formating
        {
            if ((s <= 9) && (h <= 9) && (m <= 9))
            {
                Timer = String.Format("0{0}:0{1}:0{2}", h, m, s);
            }
            if (s <= 9 && (h <= 9) && (m >= 10))
            {
                Timer = String.Format("0{0}:{1}:0{2}", h, m, s);
            }
            if ((s <= 9) && (h >= 10) && (m >= 10))
            {
                Timer = String.Format("{0}:{1}:0{2}", h, m, s);
            }
            if ((s >= 10) && (h >= 10) && (m >= 10))
            {
                Timer = String.Format("{0}:{1}:{2}", h, m, s);
            }

            if ((s >= 10) && (h <= 9) && (m >= 10))
            {
                Timer = String.Format("0{0}:{1}:{2}", h, m, s);
            }
            if ((s <= 9) && (h >= 10) && (m <= 9))
            {
                Timer = String.Format("{0}:0{1}:0{2}", h, m, s);
            }
            if ((s >= 10) && (h <= 9) && (m <= 9))
            {
                Timer = String.Format("0{0}:0{1}:{2}", h, m, s);
            }
            if ((s >= 10) && (h >= 10) && (m <= 9))
            {
                Timer = String.Format("{0}:{1}:0{2}", h, m, s);
            }
            Change("Timer");
        }

        public void AddingToCollection(Background b)
        {
            Observ.Add(b);
            Change("Observ");
        }
        public void CheckingAndCounting(string[,] arr)//algorithm checking Tic Toe
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

                        ClearingArray();

                    }
                    if ((k == 0) && (array[i, k] == "O") && (array[i, k + 1] == "O") && (array[i, k + 2] == "O"))
                    {
                        PlayerO += 1;
                        Change("PlayerO");
                        ClearingArray();
                        Tru = true;


                    }
                    //column checking working

                    if ((i == 0) && (array[i, k] == "X") && (array[i + 1, k] == "X") && (array[i + 2, k] == "X"))
                    {
                        PlayerX += 1;
                        Change("PlayerX");
                        ClearingArray();
                        Tru = true;

                    }
                    if ((i == 0) && (array[i, k] == "O") && (array[i + 1, k] == "O") && (array[i + 2, k] == "O"))
                    {
                        PlayerO += 1;
                        Change("PlayerO");
                        ClearingArray();
                        Tru = true;


                    }


                    if ((i == 0) && (k == 0) && (array[i, k] == "X") && (array[i + 1, k + 1] == "X") && (array[i + 2, k + 2] == "X"))
                    {
                        PlayerX += 1;
                        Change("PlayerX");
                        ClearingArray();
                        Tru = true;


                    }
                    if ((i == 0) && (k == 0) && (array[i, k] == "O") && (array[i + 1, k + 1] == "O") && (array[i + 2, k + 2] == "O"))
                    {
                        PlayerO += 1;
                        Change("PlayerO");
                        ClearingArray();
                        Tru = true;


                    }



                    if ((i == 0) && (k == 2))
                    {
                        if ((array[i, k] == "X") && (array[i + 1, k - 1] == "X") && (array[i + 2, k - 2] == "X"))
                        {
                            PlayerX += 1;
                            Change("PlayerX");
                            ClearingArray();
                            Tru = true;

                        }


                    }
                    if ((i == 0) && (k == 2))
                    {
                        if ((array[i, k] == "O") && (array[i + 1, k - 1] == "O") && (array[i + 2, k - 2] == "O"))
                        {
                            PlayerO += 1;
                            Change("PlayerO");
                            ClearingArray();
                            Tru = true;

                        }


                    }



                    //rows working
                }
            }
        }
        public void ClearingArray()//clearing array
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
        public void CountingFullness(string[,] arr)//if the array is full than it adds 1 to tie
        {
            array = arr;
            if (((array[0, 0] == "X") || (array[0, 0] == "O")) && ((array[0, 1] == "X") || (array[0, 1] == "O")) && ((array[1, 0] == "X") || (array[1, 0] == "O")) && ((array[1, 1] == "X") || (array[1, 1] == "O")) && ((array[0, 2] == "X") || (array[0, 2] == "O")) && ((array[1, 2] == "X") || (array[1, 2] == "O")) && ((array[2, 2] == "X") || (array[2, 2] == "O")))
            {
                Tie += 1;
                Tru = true;
                ClearingArray();




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
        public override string ToString()//string formating in listbox
        {
            return "Player X:" + PlayerX + " Player O:" + PlayerO + " Tie:" + Tie + " Time:" + Timer;
        }
        public void Restart()
        {
            PlayerX = 0;
            Change("PlayerX");
            PlayerO = 0;
            Change("PlayerO");
            Tie = 0;
            Change("Tie");
            t.Stop();
            
            Timer = "00:00:00";
            Observ.Clear();
            Change("Observ");
            s = 0;
            m = 0;
            h = 0;
            t.Start();
            Change("Timer");

        }
        public void DoubleClick(int index)//removing from observablecollection or array
        {
            if (index != -1)
            {
                Observ.RemoveAt(index);
            }
            
            Change("Observ");
        }
     
    }
}
