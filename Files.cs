using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Xml;

namespace Tic_Toe
{
    internal class File: Background
    {
        public ObservableCollection<Background> local { get; set; }
        public File()
        {
            local = new ObservableCollection<Background>();
        }
        
        public void Loading()
        {
            int playerx;
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
                            local.Add(playerx, playery, tie, timer);
                        }
                    }
                    
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Saving()
        {
            if (Observ.Count != 0)
            {

            
            try
            {
                using(XmlWriter x = XmlWriter.Create("records.xml"))
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;
                    x.WriteStartDocument();
                    x.WriteStartElement("Records");
                    foreach (Background b in Observ)
                    {
                        x.WriteStartElement("Record");
                        x.WriteAttributeString("Player X:",b.PlayerX.ToString());
                        x.WriteAttributeString("Player O:", b.PlayerY.ToString());
                        x.WriteAttributeString("Tie:", b.Tie.ToString());
                        x.WriteAttributeString("Time:", b.Timer.ToString());
                        x.WriteEndElement();
                    }
                    x.WriteEndElement();
                    x.WriteEndDocument();
                    x.Flush();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            }
        }
    }
}
