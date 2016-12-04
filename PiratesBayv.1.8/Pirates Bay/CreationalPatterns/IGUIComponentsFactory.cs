using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Pirates_Bay.CreationalPatterns
{
    interface IGUIComponentsFactory
    {
        Brush GetTittleBarBackground();
        Button GetMenuButton(String caption, ICommand command);
        Brush GetStartMenuBackground();
        Brush GetLoadGameMenuBackground();
        Brush GetStatisticsWindowBackground();
        Brush GetPlayersInfoMenuBackground();
        TextBlock GetDescriptionTextBlock(String text);
        TextBlock GetFilledTextBlock();
        Brush GetConteinerBackground();
    }
}
