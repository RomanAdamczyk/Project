using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Domain.Common
{
    public class AuditableModel
    {
        public int CreatyById { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifiedById { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}
