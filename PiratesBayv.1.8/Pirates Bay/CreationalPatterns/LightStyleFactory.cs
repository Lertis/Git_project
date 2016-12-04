using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Color = System.Windows.Media.Color;
using Point = System.Windows.Point;

namespace Pirates_Bay.CreationalPatterns
{
    class LightStyleFactory: IGUIComponentsFactory
    {
        public System.Windows.Controls.Button GetMenuButton(string caption, System.Windows.Input.ICommand command)
        {
            Button menuButton =  new Button() {Content = caption, Command = command};
            var style = (Style)menuButton.FindResource("MenuButtonLightStyle");
            menuButton.Style = style;
            return menuButton;
        }

        public System.Windows.Media.Brush GetStartMenuBackground()
        {
            return new ImageBrush(new BitmapImage(new Uri(@"Resources\Background images\LightStyle\StartMenuLight.jpg", UriKind.Relative)));
        }

        public System.Windows.Media.Brush GetPlayersInfoMenuBackground()
        {
            return
                new ImageBrush(new BitmapImage(new Uri(@"Resources\Background images\LightStyle\PlayersInfoLight.jpg", UriKind.Relative)));
        }

        public System.Windows.Controls.TextBlock GetDescriptionTextBlock(String text)
        {
            return new TextBlock()
            {
                Text = text,
                Foreground = new SolidColorBrush(Colors.Black),
                FontSize = 20,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center
            };
        }

        public System.Windows.Controls.TextBlock GetFilledTextBlock()
        {
            return new TextBlock()
            {
                Background = new SolidColorBrush(Colors.WhiteSmoke),
                Foreground = new SolidColorBrush(Colors.Black),
                Margin = new Thickness(20, 7, 20, 0),
                Padding = new Thickness(0),
                FontSize = 15,
                HorizontalAlignment = HorizontalAlignment.Center
            };

        }

        public System.Windows.Media.Brush GetConteinerBackground()
        {
            return new SolidColorBrush(Colors.WhiteSmoke);
        }

        public System.Windows.Media.Brush GetTittleBarBackground()
        {
            return new LinearGradientBrush(Colors.BurlyWood, Colors.White, new Point(0.4, 0), new Point(0.4, 1));
        }


        public System.Windows.Media.Brush GetLoadGameMenuBackground()
        {
            return new ImageBrush(new BitmapImage(new Uri(@"Resources\Background images\LightStyle\LoadGameMenuLight.jpg", UriKind.Relative)));
        }

        public System.Windows.Media.Brush GetStatisticsWindowBackground()
        {
            throw new NotImplementedException();
        }
    }
}
