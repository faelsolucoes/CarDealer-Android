using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarDealer.Models
{
   public class SampleCategory
   {
      public string Name { get; set; }

      public Color BackgroundColor { get; set; }

      public String BackgroundImage { get; set; }

      public List<Sample> SamplesList { get; set; }

      public char Icon { get; set; }
   }
}
