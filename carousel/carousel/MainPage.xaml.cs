using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace carousel
{
    public partial class MainPage : CarouselPage
    {
        Button btnTest, btn1, btn2, btn3, btn4;
        Label holerikLBL, flegmatikLBL, melanholikLBL, sangvinikLBL;
        Uri uri;
        public MainPage()
        {
            //InitializeComponent();

            btnTest = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                Text = "Тест на темперамент"
            };
            btnTest.Clicked += BtnTest_Clicked;

            btn1 = new Button
            {
                ImageSource = "holerik.jpg",
            };
            btn1.Clicked += Btn1_Clicked;

            btn2 = new Button
            {
                ImageSource = "flegmatik.png"
            };
            btn2.Clicked += Btn2_Clicked;

            btn3 = new Button
            {
                ImageSource = "melanholik.jpg"
            };
            btn3.Clicked += Btn3_Clicked;

            btn4 = new Button
            {
                ImageSource = "sangvinik.jpg"
            };
            btn4.Clicked += Btn4_Clicked;

            holerikLBL = new Label
            {
                Opacity = 0,
                Padding = 20,
                Text = "Холерик — это эмоционально - активный тип темперамента с неустойчивой нервной системой, склонный к лидерству и доминированию. У холериков часто меняется настроение, поэтому они не предсказуемы. Без движения им очень скучно, поэтому холерики берут на себя много дел, чтобы почувствовать суету и ответственность. Люди с данным типом темперамента стремятся успеть везде дома, на работе, в дружбе и т.д. "
            };

            flegmatikLBL = new Label
            {
                Opacity = 0,
                Padding = 20,
                Text = "Флегматики - это  сдержанные люди,  не склонные к риску и  невозмутимы в любой ситуации. Прежде чем принять решение, они обдумывают всё до мелочей. Флегматик всегда сдержанно выражает свои эмоции. Они стараются избежать конфликта, поэтому могут уступить в споре. Представители этого типа, видят жизнь в реальных красках. Именно поэтому  их цели в большинстве случаев достигаются. "
            };

            melanholikLBL = new Label
            {
                Opacity = 0,
                Padding = 20,
                Text = "Меланхолик - это пассивный тип темперамента, которому свойственны глубокие переживания на любые события, высокая чувствительность, обидчивость и эмоциональность. "
            };

            sangvinikLBL = new Label
            {
                Opacity = 0,
                Padding = 20,
                Text = "Сангвиник — это личность, характеризующаяся высокой психической активностью, энергичностью, работоспособностью, быстротой и живостью движений, разнообразием и богатством мимики, быстрым темпом речи. Сангвиник стремится к частой смене впечатлений, легко и быстро отзывается на окружающие события, общителен."
            };

            var startPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Виды темпераметра",
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            TextColor = Color.White,
                            Padding = 20,
                            BackgroundColor = Color.DarkOrange
                        },
                        new Image
                        {
                            Source = "temperametri.gif",
                            HeightRequest = 320,
                            WidthRequest = 320
                        },
                        btnTest
                    }
                }
            };
            
            var holerikPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Холерик",
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            TextColor = Color.White,
                            Padding = 20,
                            BackgroundColor = Color.DarkOrange
                        },
                        btn1,
                        holerikLBL
                    }
                }
            };

            var flegmatikPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Флегматик",
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            TextColor = Color.White,
                            Padding = 20,
                            BackgroundColor = Color.DarkOrange
                        },
                        btn2,
                        flegmatikLBL
                    }
                }
            };

            var melanholikPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Меланхолик",
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            TextColor = Color.White,
                            Padding = 20,
                            BackgroundColor = Color.DarkOrange
                        },
                        btn3,
                        melanholikLBL
                        
                    }
                }
            };

            var sangvinikPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Сангвиник",
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            TextColor = Color.White,
                            Padding = 20,
                            BackgroundColor = Color.DarkOrange
                        },
                        btn4,
                        sangvinikLBL
                    }
                }
            };

            Children.Add(startPage);
            Children.Add(holerikPage);
            Children.Add(flegmatikPage);
            Children.Add(melanholikPage);
            Children.Add(sangvinikPage);
        }

        private async void Btn4_Clicked(object sender, EventArgs e)
        {
            sangvinikLBL.Opacity = 0;
            await sangvinikLBL.FadeTo(1, 3000);
        }

        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            melanholikLBL.Opacity = 0;
            await melanholikLBL.FadeTo(1, 3000);
        }

        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            flegmatikLBL.Opacity = 0;
            await flegmatikLBL.FadeTo(1, 3000);
        }

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            holerikLBL.Opacity = 0;
            await holerikLBL.FadeTo(1, 3000);
        }

        private async void BtnTest_Clicked(object sender, EventArgs e)
        {
            uri = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            await Browser.OpenAsync(uri);
        }
    }
}
