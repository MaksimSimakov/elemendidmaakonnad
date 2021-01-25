using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace kk
{
    public partial class MainPage : ContentPage
    {
        DatePicker dpicker;
        Picker puker, piker;
        Image nin;
        public MainPage()
        {
            Grid maakond = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},

                }


        };

            Label bika = new Label { Text = "Инфо. для доставки", TextColor = Color.White, BackgroundColor= Color.CornflowerBlue, FontSize = 35};
            Grid.SetColumnSpan(bika, 2);
            maakond.Children.Add(bika, 0, 0);

            puker = new Picker
            {
                Title = "Ваш Уезд"
            };
            puker.Items.Add("ИДА-ВИРУМАА");
            puker.Items.Add("ЙЫГЕВАМАА");
            puker.Items.Add("ЛЯЭНЕМАА");
            puker.Items.Add("ЛЯЭНЕ-ВИРУМАА");
            puker.Items.Add("ПЫЛВАМАА");
            puker.Items.Add("ПЯРНУМАА");
            puker.Items.Add("РАПЛАМАА");
            puker.Items.Add("СААРЕМАА");
            puker.Items.Add("ТАРТУМАА");
            puker.Items.Add("ХАРЬЮМАА");
            puker.Items.Add("ХИЙУМАА");
            puker.Items.Add("ЯРВАМАА");
            puker.Items.Add("ВЫРУМАА");
            puker.Items.Add("ВИЛЬЯНДИМАА");
            puker.Items.Add("ВАЛГАМАА");
            maakond.Children.Add(puker, 0, 1);
            puker.SelectedIndexChanged += Puker_SelectedIndexChanged;

            piker = new Picker
            {
                Title = "Центр уезда"
            };
            piker.Items.Add("Нарва");

            piker.Items.Add("ЙЫГЕВАМАА");
            piker.Items.Add("ЛЯЭНЕМАА");
            piker.Items.Add("ЛЯЭНЕ-ВИРУМАА");
            piker.Items.Add("ПЫЛВАМАА");
            piker.Items.Add("ПЯРНУМАА");
            piker.Items.Add("РАПЛАМАА");
            piker.Items.Add("СААРЕМАА");
            piker.Items.Add("ТАРТУМАА");
            piker.Items.Add("ХАРЬЮМАА");
            piker.Items.Add("ХИЙУМАА");
            piker.Items.Add("ЯРВАМАА");
            piker.Items.Add("ВЫРУМАА");
            piker.Items.Add("ВИЛЬЯНДИМАА");
            piker.Items.Add("ВАЛГАМАА");
            maakond.Children.Add(piker, 0, 2);

           Editor editor = new Editor { Placeholder = "Ваш почтовый индекс:" };
            maakond.Children.Add(editor, 0, 3);

            Image nin = new Image { };
            maakond.Children.Add(nin, 0, 4);

            Button oform = new Button { Text = "Заказать", BorderColor = Color.CornflowerBlue };
            oform.Clicked += Oform_Clicked;
            maakond.Children.Add(oform, 0, 5);

            Content = maakond;

        }

        private async void Oform_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Потвердить заказ ", "Ваш Уезд \n" + puker.SelectedItem.ToString() + "\nЦентр уезда\n" + piker.SelectedItem.ToString() + "\nДанные скрыты\n", "Заказать", "Отмена");

        }

        private void Puker_SelectedIndexChanged(object sender, EventArgs e)
        {

            piker.SelectedIndex = puker.SelectedIndex;
            puker.SelectedIndex = piker.SelectedIndex;

            if (piker.SelectedIndex == 0)
            {
                
            }
        }
    }
}
