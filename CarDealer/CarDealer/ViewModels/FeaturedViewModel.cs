using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.ViewModels
{
   public class FeaturedViewModel
   {
      public List<Sample> Items
      {
         get
         {
            return SampleData.SamplesCategories["All"].SamplesList;
         }
      }

      public List<Featured> FeaturedList
      {
         get
         {
            return SampleData.featuredList;
         }
      }
   }
}
