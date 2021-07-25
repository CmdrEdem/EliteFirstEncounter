using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EliteJsonParser.Model
{
    /*VERSION INFO: 
     * FIRST TWO ELEMENTS: 0.0 = ALPHA; 0.1 = BETA; 1.0 = FULL IMPLEMENTATION
     * THIRD ELEMENT: JOURNAL VERSION THIS WAS BUILT AGAINST, ACCORDING TO FRONTIER DOCUMENTATION IN FORUMS.
     * FOURTH ELEMENT: ITERATION SERIAL NUMBER - SUPPOSED TO INCREASE AT EVERY COMMIT
    */
    //This class represents one line of the journal file
    //Each journal entry type implements this class
    public class JsonEliteJournalEntry
    {
        public string timestamp;
        [JsonProperty(PropertyName = "event")]
        public string _event;

        public static bool unitTest()
        {
            Console.SetError(new StreamWriter("error.log"));
            try
            {
                StreamReader sellOrganicFile = new StreamReader(".\\Sample Data\\SellOrganicData.json", Encoding.UTF8);
                StreamReader scanOrganicAnalyseFile = new StreamReader(".\\Sample Data\\ScanOrganic Analyse.json", Encoding.UTF8);

                string jsonLine = sellOrganicFile.ReadLine();

                JsonEliteJournalEntry entry = JsonConvert.DeserializeObject<JsonEliteJournalEntry>(jsonLine);

                Console.Out.WriteLine("timestamp: " + entry.timestamp);
                Console.Out.WriteLine("event: " + entry._event);

                if(entry._event.Equals("SellOrganicData"))
                {
                    JsonEliteSellOrganicData sellOrganicEntry = JsonConvert.DeserializeObject<JsonEliteSellOrganicData>(jsonLine);
                }
                else
                {
                    Console.Out.WriteLine("Journal entry is not SellOrganicData");
                }
                
            }
            catch(Exception ioe)
            {
                Console.Error.WriteLine(ioe.Message);
                Console.Error.Write(ioe.StackTrace);
                return false;
            }
            return true;
        }
    }
}
