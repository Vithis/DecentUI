﻿#pragma checksum "..\..\SettingsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7A4C29A379054718BB78153EAA0429EF1C6279AE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DecentUI_WPF;
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


namespace DecentUI_WPF {
    
    
    /// <summary>
    /// SettingsWindow
    /// </summary>
    public partial class SettingsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider transperencySlider;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox transperencyLabel;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider redSlider;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label redLabel;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider greenSlider;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label greenLabel;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider blueSlider;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label blueLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/DecentUI_WPF;component/settingswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SettingsWindow.xaml"
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
            
            #line 8 "..\..\SettingsWindow.xaml"
            ((DecentUI_WPF.SettingsWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.transperencySlider = ((System.Windows.Controls.Slider)(target));
            
            #line 25 "..\..\SettingsWindow.xaml"
            this.transperencySlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.transperencySlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.transperencyLabel = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\SettingsWindow.xaml"
            this.transperencyLabel.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.transperencyLabel_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.redSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 55 "..\..\SettingsWindow.xaml"
            this.redSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.redSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.redLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.greenSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 84 "..\..\SettingsWindow.xaml"
            this.greenSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.greenSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.greenLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.blueSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 113 "..\..\SettingsWindow.xaml"
            this.blueSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.blueSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.blueLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
