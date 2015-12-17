using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace LearnAppStrak
{
    class LoginPage : ContentPage
    {
        Button login_button, exit_button;
        Entry login_entry, password_entry;

        public LoginPage()
        {
            Style = (Style)Styles.style["SiteStyle"];

            login_button = new Button { Text = "Zaloguj", Style = (Style)Styles.style["AppButton"] };
            login_button.Clicked += OnButtonClicked;

            exit_button = new Button { Text = "Wyjdź", Style = (Style)Styles.style["AppButton"] };

            login_entry = new Entry { Placeholder = "Login", WidthRequest = 400 };
            password_entry = new Entry { Placeholder = "Hasło", IsPassword=true };
            exit_button.Clicked += OnButtonClicked;

            this.Content = new StackLayout {
                Children = {
                       new StackLayout {
                            Orientation = StackOrientation.Vertical,
                            VerticalOptions = LayoutOptions.EndAndExpand,
                            Spacing = 15,
                            Padding = new Thickness(50, 10, 50, 10),
                            Children = { login_entry, password_entry }
                       },
                       new StackLayout {
                            Orientation = StackOrientation.Vertical,
                            VerticalOptions = LayoutOptions.EndAndExpand,
                            Spacing = 15,
                            Children = { login_button, exit_button} }
                }
            };


        }


        public async void DownloadJson()
        {

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:12971/api/");
                var response = await client.GetAsync("UzytkownicyLogin");
                var placesJson = response.Content.ReadAsStringAsync().Result;
                JArray json = JArray.Parse(placesJson);
                login_entry.Text = (json[0]["haslo"]).ToString();
            }
            catch (Exception) {
                string wyjatek = "Błąd połączenia z bazą danych";
                var result = await DisplayActionSheet(wyjatek, "Wyjdź", "Ponów próbę");

                if (result == "Ponów próbę")
                    DownloadJson();

            }
            //catch (JsonReaderException ex)
            //{

            //    throw new Exception("Błąd połączenia z bazą danych", ex);
            //}

            //catch (System.Exception)
            //{
            //    string wyjatek = "Błąd połączenia z bazą danych";
            //    var result = await DisplayActionSheet(wyjatek, "Wyjdź", "", "Ponów próbę");

            //    if (result == "Ponów próbę")
            //        DownloadJson();
            //}
            //catch (System.Net.WebException ex)
            //{
            //    string wyjatek = "Błąd połączenia z bazą danych";
            //    var result = await DisplayActionSheet(wyjatek, "Wyjdź", "", "Ponów próbę");

            //    if (result == "Ponów próbę")
            //        DownloadJson();

            //}
            


        }
       public void OnButtonClicked(object sender, EventArgs args)
        {

            Button button = (Button)sender;
            if (button == login_button)
            {
                login_entry.Text = "blabalbal";
                 DownloadJson();
            }
            else if (button == exit_button) {
                login_entry.Text = "dupadupa";
            }

        }
    }
}
