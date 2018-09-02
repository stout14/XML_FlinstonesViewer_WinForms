using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Demo_WinForms_FlintstonesViewer

{
    public class XmlDataService : IDataService
    {
        private string _dataFile;

        public List<Character> ReadAll()
        {
            List<Character> characters = new List<Character>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Character>), new XmlRootAttribute("Characters"));

            try
            {
                StreamReader reader = new StreamReader(_dataFile);
                using (reader)
                {
                    characters = (List<Character>)serializer.Deserialize(reader);
                }

            }
            catch (Exception)
            {
                throw;
            }


            return characters;
        }

        public void WriteAll()
        {

        }

        public XmlDataService()
        {

        }

        public XmlDataService(string datafile)
        {
            _dataFile = datafile;
        }
    }
}
