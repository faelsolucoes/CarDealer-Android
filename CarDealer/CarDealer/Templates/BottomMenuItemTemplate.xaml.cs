using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CarDealer.Templates
{
   public partial class BottomMenuItemTemplate : ContentView
   {
      public uint animationDuration = 250;
      public bool _processingTag = false;

      public static BindableProperty ShowBackgroundImageProperty =
         BindableProperty.Create("ShowBackgroundImage", typeof(bool),
            typeof(BottomMenuItemTemplate),
            true,
            defaultBindingMode: BindingMode.OneWay
         );

      public bool ShowBackgroundImage
      {
         get { return (bool)GetValue(ShowBackgroundImageProperty); }
         set { SetValue(ShowBackgroundImageProperty, value); }
      }

      public static BindableProperty ShowBackgroundColorProperty =
         BindableProperty.Create("ShowBackgroundColor", typeof(bool),
            typeof(BottomMenuItemTemplate),
            false,
            defaultBindingMode: BindingMode.OneWay
         );

      public bool ShowBackgroundColor
      {
         get { return (bool)GetValue(ShowBackgroundColorProperty); }
         set { SetValue(ShowBackgroundColorProperty, value); }
      }

      public static BindableProperty ShowiconColoredCircleBackgroundProperty =
         BindableProperty.Create("ShowiconColoredCircleBackground", typeof(bool),
            typeof(BottomMenuItemTemplate),
            true,
            defaultBindingMode: BindingMode.OneWay
         );

      public bool ShowiconColoredCircleBackground
      {
         get { return (bool)GetValue(ShowiconColoredCircleBackgroundProperty); }
         set { SetValue(ShowiconColoredCircleBackgroundProperty, value); }
      }

      public static BindableProperty TextColorProperty =
         BindableProperty.Create("TextColor", typeof(Color),
            typeof(BottomMenuItemTemplate),
            defaultValue: Color.White,
            defaultBindingMode: BindingMode.OneWay
         );

      public Color TextColor
      {
         get { return (Color)GetValue(TextColorProperty); }
         set { SetValue(TextColorProperty, value); }
      }

      public BottomMenuItemTemplate()
      {
         InitializeComponent();
      }

      public async void OnWidgetTapped(object sender, EventArgs e)
      {
         if (_processingTag)
         {
            return;
         }

         _processingTag = true;

         try
         {
            await AnimateItem(this, animationDuration);

            var sample = (Sample)BindingContext;
            if (sample != null)
            {
               if ((this.Navigation.NavigationStack.Count == 0) ||
                  (sample.PageType != this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 1].GetType()))
               {
                  sample.NavigateToSample(Navigation);
               }
            }
         }
         finally
         {
            _processingTag = false;
         }
      }

      private async Task AnimateItem(View uiElement, uint duration)
      {
         var originalOpacity = uiElement.Opacity;

         await uiElement.FadeTo(.5, duration / 2, Easing.CubicIn);
         await uiElement.FadeTo(originalOpacity, duration / 2, Easing.CubicIn);
      }
   }
}
