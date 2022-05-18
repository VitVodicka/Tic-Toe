using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Threading;

namespace Tic_Toe
{
    class Background: INotifyPropertyChanged
    {
        public Background(int playerX, int playerY, int tie, string timer)
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
        DispatcherTimer t = new DispatcherTimer();
        int s = 0;
        int h = 0;
        int m = 0;
        string[,] arry = new string[3, 3];

        public int PlayerX { get; set; }
        public int PlayerY { get; set; }
        public int Tie { get; set; }

        string timer;
        public string Timer { get { return timer; }
            set { timer = value; }
        
        }

        public string[,] array { get; set; }
        public bool Tru { get; set; }

        public ObservableCollection<Background> Observ { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void init()
        {
            
            t.Interval = new TimeSpan(0, 0, 1);

            t.Tick += new EventHandler(dispatcherTick);
            t.Start();
        }
        private void dispatcherTick(object sender, EventArgs e)
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
        private void TimerFormating()
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

        public void Adding()
        {
            Background b = new Background(PlayerX, PlayerY, Tie, Timer);
            Observ.Add(b);
        }
        public void CheckingAndCounting(string[,] arr)
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
                    if ((k == 0) && (array[i, k] == "Y") && (array[i, k + 1] == "Y") && (array[i, k + 2] == "Y"))
                    {
                        PlayerY += 1;
                        Change("PlayerY");
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
                    if ((i == 0) && (array[i, k] == "Y") && (array[i + 1, k] == "Y") && (array[i + 2, k] == "Y"))
                    {
                        PlayerY += 1;
                        Change("PlayerY");
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
                    if ((i == 0) && (k == 0) && (array[i, k] == "Y") && (array[i + 1, k + 1] == "Y") && (array[i + 2, k + 2] == "Y"))
                    {
                        PlayerY += 1;
                        Change("PlayerY");
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
                        if ((array[i, k] == "Y") && (array[i + 1, k - 1] == "Y") && (array[i + 2, k - 2] == "Y"))
                        {
                            PlayerY += 1;
                            Change("PlayerY");
                            ClearingArray();
                            Tru = true;

                        }


                    }



                    //rows working
                }
            }

            //pomocí pomocného textboxu budu poznávat zda tam má být křížek nebo kolečko a pomocí datatrigeru budu na něj se odtaz, jestli tam je křížek nebo kolečko a podle toho poznám, jaký znak by tam měl být
        }
        public void ClearingArray()
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
        public void CountingFullness(string[,] arr)
        {
            array = arr;
            if (((array[0, 0] == "X") || (array[0, 0] == "Y")) && ((array[0, 1] == "X") || (array[0, 1] == "Y")) && ((array[1, 0] == "X") || (array[1, 0] == "Y")) && ((array[1, 1] == "X") || (array[1, 1] == "Y")) && ((array[0, 2] == "X") || (array[0, 2] == "Y")) && ((array[1, 2] == "X") || (array[1, 2] == "Y")) && ((array[2, 2] == "X") || (array[2, 2] == "Y")))
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
        public override string ToString()
        {
            return "Player X:" + PlayerX + " Player Y:" + PlayerY + " Tie:" + Tie + " Time:" + Timer;
        }
        public void Restart()
        {
            PlayerX = 0;
            Change("PlayerX");
            PlayerY = 0;
            Change("PlayerY");
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
        public void DoubleClick(int index)
        {
            if (index != -1)
            {
                Observ.RemoveAt(index);
            }
            
            Change("Observ");
        }
    }
}
