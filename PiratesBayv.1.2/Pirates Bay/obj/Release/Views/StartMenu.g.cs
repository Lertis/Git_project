﻿#pragma checksum "..\..\..\Views\StartMenu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "787BEDFD7507F95DD14A71F96704F71A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Pirates_Bay.Views {
    
    
    /// <summary>
    /// StartMenu
    /// </summary>
    public partial class StartMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Views\StartMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TitleBar;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\StartMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinimizeButton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Views\StartMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Views\StartMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMenu;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Views\StartMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonStartNewGame;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Views\StartMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonLoadGame;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\Views\StartMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonStatistics;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Views\StartMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOptions;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Views\StartMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonExit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Pirates Bay;component/views/startmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\StartMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\..\Views\StartMenu.xaml"
            ((Pirates_Bay.Views.StartMenu)(target)).Closed += new System.EventHandler(this.StartMenu_OnClosed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TitleBar = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 31 "..\..\..\Views\StartMenu.xaml"
            ((System.Windows.Controls.Image)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TitleBar_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 32 "..\..\..\Views\StartMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TitleBar_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MinimizeButton = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.GridMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.ButtonStartNewGame = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.ButtonLoadGame = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.ButtonStatistics = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.ButtonOptions = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.ButtonExit = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

