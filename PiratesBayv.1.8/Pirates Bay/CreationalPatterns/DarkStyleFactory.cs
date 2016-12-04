using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Pirates_Bay.CreationalPatterns
{
    class DarkStyleFactory: IGUIComponentsFactory
    {
        public System.Windows.Controls.Button GetMenuButton(string caption, System.Windows.Input.ICommand command)
        {
            Button menuButton = new Button() { Content = caption, Command = command };
            var style = (Style)menuButton.FindResource("MenuButtonDarkStyle");
            menuButton.Style = style;
            return menuButton;
        }

        public System.Windows.Media.Brush GetStartMenuBackground()
        {
            return new ImageBrush(new BitmapImage(new Uri(@"Resources\Background images\DarkStyle\StartMenuDark.jpg", UriKind.Relative)));

        }

        public System.Windows.Media.Brush GetPlayersInfoMenuBackground()
        {
            return
                new ImageBrush(new BitmapImage(new Uri(@"Resources\Background images\DarkStyle\PlayersInfoDark.jpg", UriKind.Relative)));
        }

        public System.Windows.Controls.TextBlock GetDescriptionTextBlock(string text)
        {
            return new TextBlock()
            {
                Text = text,
                Foreground = new SolidColorBrush(Colors.Silver),
                FontSize = 20,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center
            };
        }

        public System.Windows.Controls.TextBlock GetFilledTextBlock()
        {
            return new TextBlock()
            {
                Background = new SolidColorBrush(Colors.SlateGray),
                Foreground = new SolidColorBrush(Colors.Silver),
                Margin = new Thickness(20, 7, 20, 0),
                Padding = new Thickness(0),
                FontSize = 15,
                HorizontalAlignment = HorizontalAlignment.Center
            };
        }

        public System.Windows.Media.Brush GetConteinerBackground()
        {
            return new SolidColorBrush(Colors.SlateGray);
        }

        public Brush GetTittleBarBackground()
        {
            return new LinearGradientBrush(Colors.DimGray, Colors.Silver, new Point(0.4, 0), new Point(0.4, 1));
        }


        public Brush GetLoadGameMenuBackground()
        {
            return new ImageBrush(new BitmapImage(new Uri(@"Resources\Background images\DarkStyle\LoadGameMenuDark.jpg", UriKind.Relative)));
        }

        public Brush GetStatisticsWindowBackground()
        {
            throw new NotImplementedException();
        }
    }
}
