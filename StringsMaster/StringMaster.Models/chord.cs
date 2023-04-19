using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMaster.Models
{
    public class chord
    {
        public string strings { get; set; }
        public string fingering { get; set; }
        public string chordName { get; set; }
        public string enharmonicChordName { get; set; }
        public string voicingID { get; set; }
        public string tones { get; set; }

    }
}
