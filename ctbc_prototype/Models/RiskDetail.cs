using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ctbc_prototype.Models
{
    public class RiskDetail : BaseModel
    {
        public string RId { get; set; }
        public string Dept { get; set; }
        public string Region { get; set; }
        public string StartDate { get; set; }
        public string FindDate { get; set; }
        public string EventType1 { get; set; }
        public string EventType2 { get; set; }
        public string EventReason1 { get; set; }
        public string EventReason2 { get; set; }
        public string LossType1 { get; set; }
        public string LossType2 { get; set; }
        public string RiskLevel { get; set; }
        public string MajorIncident { get; set; }
        public string InfoIncident { get; set; }
    }
}
