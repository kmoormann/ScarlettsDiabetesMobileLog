using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScarlettsLog.Mobile.Models
{
    public class LogModel
    {
        public int LogModelId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime LogDate { get; set; }

        IEnumerable<LogEntry> Entries {get; set;}
    }

}