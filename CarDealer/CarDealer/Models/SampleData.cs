using CarDealer.Pages;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace CarDealer.Models
{
	public static class SampleData
	{
      private static List<SampleCategory> _samplesCategoryList;
      private static Dictionary<string, SampleCategory> _samplesCategories;
      private static List<Sample> _allSamples;
      private static List<SampleGroup> _samplesGroupedByCategory;

      public static List<Inventory> inventoryList = new List<Inventory>()
      {
         new Inventory() { name = "Hatchback", photo = ImageSource.FromFile("inventory_Foto1.png") },
         new Inventory() { name = "Sedan", photo = ImageSource.FromFile("inventory_Foto2.png") },
         new Inventory() { name = "Truck", photo = ImageSource.FromFile("inventory_Foto3.png") },
      };

      public static About about = new About()
      {
         note = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
         photo = ImageSource.FromFile("CarAbout.png")
      };

      public static List<News> newsList = new List<News>()
      {
         new News() { note = "Jimmy Kimmel rolls out red carpet as Emmy host", photo = ImageSource.FromFile("news_Foto1.png"), positionDate = "Sep, 20, 2012" },
         new News() { note = "Medical examiner: Mia Farrow's son Thaddeus killed himself", photo = ImageSource.FromFile("news_Foto2.png"), positionDate = "Sep, 22, 2016" },
         new News() { note = "With new album 'Harder II Love,' Usher get harder to love", photo = ImageSource.FromFile("news_Foto3.png"), positionDate = "Sep, 22, 2016" }
      };

      public static List<Contact> contactList = new List<Contact>()
      {
         new Contact() { name = "Adam Aqua" },
         new Contact() { name = "Dryan Boo" }
      };

      public static List<Featured> featuredList = new List<Featured>()
      {
         new Featured() { description = "Save on Oil Change", complement = "Good until 09/27/2013" }
      };

      public static List<string> ServiceTypeList()
      {
         List<string> serviceTypeList = new List<string>();
         serviceTypeList.Add("Oil Replacement");

         return serviceTypeList;
      }

      public static Dictionary<string, SampleCategory> SamplesCategories
      {
         get
         {
            if (_samplesCategories == null)
            {
               InitializeHomeSamples();
            }

            return _samplesCategories;
         }
      }

      private static void InitializeHomeSamples()
      {
         var categories = new Dictionary<string, SampleCategory>();

         categories.Add(
            "All",
            new SampleCategory
            {
               Name = "All",
               BackgroundImage = "",
               Icon = '\uf1b9',
               SamplesList = new List<Sample> {
                  new Sample("About Us", typeof(AboutUsPage), Color.White, "", '\uf1b9'),
                  new Sample("Locations", typeof(LocationsPage), Color.White, "", '\uf041'),
                  new Sample("Our News", typeof(OurNewsPage), Color.White, "", '\uf0f6'),
                  new Sample("Contacts", typeof(ContactsPage), Color.White, "", '\uf007'),
                  new Sample("Facebook", typeof(FacebookPage), Color.White, "", '\uf230')
               }
            }
         );

         categories.Add(
            "About Us",
            new SampleCategory
            {
               Name = "About Us",
               BackgroundImage = "",
               Icon = '\uf1b9',
               SamplesList = new List<Sample> {
                  new Sample("About Us", typeof(AboutUsPage), Color.Blue, "", '\uf1b9'),
                  new Sample("Locations", typeof(LocationsPage), Color.White, "", '\uf041'),
                  new Sample("Our News", typeof(OurNewsPage), Color.White, "", '\uf0f6'),
                  new Sample("Contacts", typeof(ContactsPage), Color.White, "", '\uf007'),
                  new Sample("Facebook", typeof(FacebookPage), Color.White, "", '\uf230')
               }
            }
         );

         categories.Add(
            "Locations",
            new SampleCategory
            {
               Name = "Locations",
               BackgroundImage = "",
               Icon = '\uf041',
               SamplesList = new List<Sample> {
                  new Sample("About Us", typeof(AboutUsPage), Color.White, "", '\uf1b9'),
                  new Sample("Locations", typeof(LocationsPage), Color.Blue, "", '\uf041'),
                  new Sample("Our News", typeof(OurNewsPage), Color.White, "", '\uf0f6'),
                  new Sample("Contacts", typeof(ContactsPage), Color.White, "", '\uf007'),
                  new Sample("Facebook", typeof(FacebookPage), Color.White, "", '\uf230')
               }
            }
         );

         categories.Add(
            "Our News",
            new SampleCategory
            {
               Name = "Our News",
               BackgroundImage = "",
               Icon = '\uf0f6',
               SamplesList = new List<Sample> {
                  new Sample("About Us", typeof(AboutUsPage), Color.White, "", '\uf1b9'),
                  new Sample("Locations", typeof(LocationsPage), Color.White, "", '\uf041'),
                  new Sample("Our News", typeof(OurNewsPage), Color.Blue, "", '\uf0f6'),
                  new Sample("Contacts", typeof(ContactsPage), Color.White, "", '\uf007'),
                  new Sample("Facebook", typeof(FacebookPage), Color.White, "", '\uf230')
               }
            }
         );

         categories.Add(
            "Contacts",
            new SampleCategory
            {
               Name = "Contacts",
               BackgroundImage = "",
               Icon = '\uf007',
               SamplesList = new List<Sample> {
                  new Sample("About Us", typeof(AboutUsPage), Color.White, "", '\uf1b9'),
                  new Sample("Locations", typeof(LocationsPage), Color.White, "", '\uf041'),
                  new Sample("Our News", typeof(OurNewsPage), Color.White, "", '\uf0f6'),
                  new Sample("Contacts", typeof(ContactsPage), Color.Blue, "", '\uf007'),
                  new Sample("Facebook", typeof(FacebookPage), Color.White, "", '\uf230')
               }
            }
         );

         categories.Add(
            "Facebook",
            new SampleCategory
            {
               Name = "Facebook",
               BackgroundImage = "",
               Icon = '\uf230',
               SamplesList = new List<Sample> {
                  new Sample("About Us", typeof(AboutUsPage), Color.White, "", '\uf1b9'),
                  new Sample("Locations", typeof(LocationsPage), Color.White, "", '\uf041'),
                  new Sample("Our News", typeof(OurNewsPage), Color.White, "", '\uf0f6'),
                  new Sample("Contacts", typeof(ContactsPage), Color.White, "", '\uf007'),
                  new Sample("Facebook", typeof(FacebookPage), Color.Blue, "", '\uf230')
               }
            }
         );

         _samplesCategories = categories;

         _samplesCategoryList = new List<SampleCategory>();

         foreach (var sample in _samplesCategories.Values)
         {
            _samplesCategoryList.Add(sample);
         }

         _allSamples = new List<Sample>();

         _samplesGroupedByCategory = new List<SampleGroup>();

         foreach (var sampleCategory in SamplesCategories.Values)
         {
            var sampleItem = new SampleGroup(sampleCategory.Name.ToUpper());

            foreach (var sample in sampleCategory.SamplesList)
            {
               _allSamples.Add(sample);
               sampleItem.Add(sample);
            }

            _samplesGroupedByCategory.Add(sampleItem);
         }
      }
   }

   public class SampleGroup : List<Sample>
   {
      private readonly string _name;

      public SampleGroup(string name)
      {
         _name = name;
      }

      public string Name
      {
         get
         {
            return _name;
         }
      }
   }

}