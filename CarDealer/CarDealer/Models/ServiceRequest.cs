using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
   public class ServiceRequest
   {
      public DateTime preferredDate { get; set; }
      public string contactInfo { get; set; }
      public string vehicheInfo { get; set; }
      public string serviceType { get; set; }
   }
}
