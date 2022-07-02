using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Xml;

namespace Tic_Toe
{
    internal class File:INotifyPropertyChanged
    {
        public  ObservableCollection<File> FileObserv { get; set; }
        public int PlayerX { get; set; }
        public int PlayerO { get; set; }
        public int Tie { get; set; }

        string timer;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Timer
        {
            get { return timer; }
            set { timer = value; }

        }
        public File(int playerX, int playerO, int tie, string timer) {
            PlayerX = playerX;
            PlayerO = playerO;
            Tie = tie;
            Timer = timer;
        }
        public File()
        {
            FileObserv = new ObservableCollection<File>();
        }
        public void Change(string change)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(change));
            }
        }



        public void Loading()
        {
            int playerx;
            int playero;
            int tie;
            string timer;

            /*int playerx;
            int playery;
            int tie;
            string timer;
            string element;
            try
            {
                using (XmlReader x = XmlReader.Create("records.xml"))
                {
                    while (x.Read())
                    {
                        if(x.NodeType == XmlNodeType.Element)
                        {
                            element = x.Name;
                            
                        }
                        else if(x.NodeType == XmlNodeType.EndElement)
                        {
                            Background b = new Background(playerx, playery, tie, timer);
                            local.Add(b);
                        }
                    }
                    
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
        }
        public void Saving(int index)
        {
            int playerx = Background.Observ[index].PlayerX;
            int playero = Background.Observ[index].PlayerO;
            int tie = Background.Observ[index].Tie;
            string timer = Background.Observ[index].Timer;
            File f = new File(playerx, playero, tie, timer);
            FileObserv.Add(f);
            Change("FileObserv");

            /*if (Background.Observ.Count != 0)
            {

            
            try
            {

                using(StreamWriter s = new StreamWriter("save.csv"))
                {
                        
                        foreach (Background b in Background.Observ)
                        {
                            s.WriteLine("{0};{1};{2};{3}", b.PlayerX.ToString(), b.PlayerO.ToString(), b.Tie.ToString(), b.Timer); 
                        }
                        s.Flush();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            }*/
        }
    }
}
