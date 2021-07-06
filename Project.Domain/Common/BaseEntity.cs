using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Domain.Common
{
    public class BaseEntity : AuditableModel
    {
        public int Id { get; set; }  
    }
   
}
