using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WECPOFLogic;
using Xamarin.Forms;

namespace carousel
{
    public partial class MainPage : CarouselPage
    {
        CommandBinding commandBinding;
        public MainPage()
        {
            //InitializeComponent();

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
                            HeightRequest = 350,
                            WidthRequest = 350
                        }
                        
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
                            TextColor = Color.Black
                        },
                        new Image
                        {
                            Source = "holerik.jpg",
                            HeightRequest = 250,
                            WidthRequest = 250
                        },
                        new Label
                        {
                            Padding = 20,
                            Text = "Холерик — это эмоционально - активный тип темперамента с неустойчивой нервной системой, склонный к лидерству и доминированию. У холериков часто меняется настроение, поэтому они не предсказуемы. Без движения им очень скучно, поэтому холерики берут на себя много дел, чтобы почувствовать суету и ответственность. Люди с данным типом темперамента стремятся успеть везде дома, на работе, в дружбе и т.д. "
                        }
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
                            TextColor = Color.Black
                        },
                        new Image
                        {
                            Source = "flegmatik.png",
                            HeightRequest = 250,
                            WidthRequest = 250
                        },
                        new Button
                        { 
                            Text = "Описание",
                            
                        },
                        new Label
                        {
                            Padding = 20,
                            Text = "Флегматики - это  сдержанные люди,  не склонные к риску и  невозмутимы в любой ситуации. Прежде чем принять решение, они обдумывают всё до мелочей. Флегматик всегда сдержанно выражает свои эмоции. Они стараются избежать конфликта, поэтому могут уступить в споре. Представители этого типа, видят жизнь в реальных красках. Именно поэтому  их цели в большинстве случаев достигаются. "
                        }
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
                            TextColor = Color.Black
                        },
                        new Image
                        {
                            Source = "melanholik.jpg",
                            HeightRequest = 250,
                            WidthRequest = 250
                        },
                        new Label
                        {
                            Padding = 20,
                            Text = "Меланхолик - это пассивный тип темперамента, которому свойственны глубокие переживания на любые события, высокая чувствительность, обидчивость и эмоциональность. "
                        }
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
                            TextColor = Color.Black
                        },
                        new Image
                        {
                            Source = "sangvinik.jpg",
                            HeightRequest = 250,
                            WidthRequest = 250
                        },
                        new Label
                        {
                            Padding = 20,
                            Text = "Сангвиник — это личность, характеризующаяся высокой психической активностью, энергичностью, работоспособностью, быстротой и живостью движений, разнообразием и богатством мимики, быстрым темпом речи. Сангвиник стремится к частой смене впечатлений, легко и быстро отзывается на окружающие события, общителен."
                        }
                    }
                }
            };

            Children.Add(startPage);
            Children.Add(holerikPage);
            Children.Add(flegmatikPage);
            Children.Add(melanholikPage);
            Children.Add(sangvinikPage);
        }
    }
}
