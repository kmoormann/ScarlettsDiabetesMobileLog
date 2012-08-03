using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ScarlettsLog.Mobile.Models
{
    public class LogEntry
    {
        [Key]
        public int LogEntryId { get; set; }
        public DateTime? EntryTime { get; set; }
        public int? GlucoseNumber { get; set; }
        public string GlucosePrickLocation { get; set; }
        public decimal? NovalogDosage { get; set; }
        public decimal? LantusDosage { get; set; }
        public string InjectionLocation { get; set; }

    }
}
