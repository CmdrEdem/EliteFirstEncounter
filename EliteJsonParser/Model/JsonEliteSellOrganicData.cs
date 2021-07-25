using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteJsonParser.Model
{
    class JsonEliteSellOrganicData: JsonEliteJournalEntry
    {
        public Int64 MarketId;
        public JsonEliteBioDataElement[] BioData;

    }
}
