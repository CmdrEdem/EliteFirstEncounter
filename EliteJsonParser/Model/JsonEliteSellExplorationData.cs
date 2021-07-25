using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteJsonParser.Model
{
    class JsonEliteSellExplorationData:JsonEliteJournalEntry
    {
        public string[] Systems;
        public string[] Discovered;
        public int BaseValue;
        public int Bonus;
        public int TotalEarnings;
    }
}
