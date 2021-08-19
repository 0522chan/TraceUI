using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TraceUI.Model
{
    public class Model
    {
        public double TimeStamp { get; set; }
        public string StartOfFrame { get; set; }
        public string Chn { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Dr { get; set; }
        public int DLC { get; set; }
        public byte Data { get; set; }
    }
    
}
