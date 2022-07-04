using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace Tic_Toe
{
    class File
    {
        Background b = new Background();//declaring new class
        public void SavingToFile()
        {//saving observablecollection to file, if there is any
            if (Background.Observ.Count > 0)
            {
                try
                {
                    using (StreamWriter s = new StreamWriter("file.csv", false))
                    {
                        foreach (Background b in Background.Observ)
                        {
                            s.WriteLine("{0},{1},{2},{3}", b.PlayerX.ToString(), b.PlayerO.ToString(), b.Tie.ToString(), b.Timer);

                        }
                        s.Flush();
                        MessageBox.Show("File has been written");


                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }



            }
        }
        public void TrashFile()
        {//clearing file 
            try { 
            using (StreamWriter s = new StreamWriter("file.csv", false))
            {
                s.Close();
            }
                MessageBox.Show("File has been deleted");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void LoadingFile()
        {//loading file if there is some line and if the user wants to load
            using (StreamReader s = new StreamReader("file.csv"))
            {
                string line;
                int playerx;
                int playerO;
                int tie;
                string timer;


                if ((line = s.ReadLine()) != null)
                {
                    if (MessageBox.Show("Do you wanna load previous records?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                    {
                        //dosen t load records
                    }
                    else
                    {
                        //loads records
                        do
                        {
                            string[] list = line.Split(',');
                            playerx = int.Parse(list[0]);
                            playerO = int.Parse(list[1]);
                            tie = int.Parse(list[2]);
                            timer = list[3];
                            Background b = new Background(playerx, playerO, tie, timer);
                            Background.Observ.Add(b);

                            b.Change("Observ");
                        }
                        while ((line = s.ReadLine()) != null);



                    }
                }
            }
        }
    }
}
