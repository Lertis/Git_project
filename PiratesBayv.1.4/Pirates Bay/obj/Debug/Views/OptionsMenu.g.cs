﻿#pragma checksum "..\..\..\Views\OptionsMenu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A981B09B95717D44573FDC265C1FB543"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
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
    /// OptionsMenu
    /// </summary>
    public partial class OptionsMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Views\OptionsMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TitleBar;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\OptionsMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinimizeButton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Views\OptionsMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Views\OptionsMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridContainer;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Views\OptionsMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockInterfaceStyle;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Views\OptionsMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockVolume;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Views\OptionsMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxStyles;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Views\OptionsMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem BlueStyle;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Views\OptionsMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem DarkStyle;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Views\OptionsMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem LightStyle;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Views\OptionsMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SliderVolume;
        
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
            System.Uri resourceLocater = new System.Uri("/Pirates Bay;component/views/optionsmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\OptionsMenu.xaml"
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
            this.TitleBar = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 31 "..\..\..\Views\OptionsMenu.xaml"
            ((System.Windows.Controls.Image)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TitleBar_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 32 "..\..\..\Views\OptionsMenu.xaml"
            ((System.Windows.Controls.TextBlock)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TitleBar_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MinimizeButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.GridContainer = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.TextBlockInterfaceStyle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.TextBlockVolume = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.ListBoxStyles = ((System.Windows.Controls.ListBox)(target));
            
            #line 81 "..\..\..\Views\OptionsMenu.xaml"
            this.ListBoxStyles.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBoxStyles_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BlueStyle = ((System.Windows.Controls.ListBoxItem)(target));
            return;
            case 11:
            this.DarkStyle = ((System.Windows.Controls.ListBoxItem)(target));
            return;
            case 12:
            this.LightStyle = ((System.Windows.Controls.ListBoxItem)(target));
            return;
            case 13:
            this.SliderVolume = ((System.Windows.Controls.Slider)(target));
            
            #line 86 "..\..\..\Views\OptionsMenu.xaml"
            this.SliderVolume.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SliderVolume_OnValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
