using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LearnAppStrak
{
    class Styles : ContentPage
    {
        public Styles() { }

        public static ResourceDictionary style = new ResourceDictionary()
        {
#region AppButton 
            {
                "AppButton",new Style(typeof (Button)) {
                    Setters =
                    {
                        new Setter { Property = View.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                        new Setter { Property = View.VerticalOptionsProperty, Value=LayoutOptions.Center },
                        new Setter { Property = Button.BorderWidthProperty, Value=1 },
                        new Setter { Property = Button.BackgroundColorProperty, Value=Color.FromRgb(136,136,136) },
                        new Setter { Property = Button.BorderColorProperty, Value=Color.FromRgb(40,40,40)  },
                        new Setter { Property = Button.TextColorProperty, Value=Color.White},
                        new Setter { Property = Button.WidthRequestProperty, Value=270 }
                    }
                }

            },
            #endregion
#region SiteStyle
            {"SiteStyle", new Style(typeof(ContentPage)) {
                Setters=
                {
                    new Setter {Property = Button.BackgroundColorProperty, Value = Color.FromRgb(244,244,244) }
                }

            }
            }
#endregion
        };
    }
}
