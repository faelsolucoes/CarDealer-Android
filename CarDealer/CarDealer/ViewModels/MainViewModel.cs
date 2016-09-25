using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.ViewModels
{
   public class MainViewModel
   {
      public List<Sample> Items
      {
         get
         {
            return SampleData.SamplesCategories["All"].SamplesList;
         }
      }
   }
}
