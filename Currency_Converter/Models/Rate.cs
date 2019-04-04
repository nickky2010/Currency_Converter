using System;

namespace Currency_Converter.Models
{
    public class Rate
    {
        public DateTime Date { get; set; }
        public string Cur_Abbreviation { get; set; }
        public int Cur_Scale { get; set; }
        public string Cur_Name { get; set; }
        public double Cur_OfficialRate { get; set; }
        public string FrequencyOfChanges { get; set; }
    }
}
