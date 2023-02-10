﻿#pragma checksum "..\..\..\..\Views\MainMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "375BF960ADF6A16797CB963B02CF33CEC6778030"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using APLan.ViewModels;
using APLan.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace APLan.Views {
    
    
    /// <summary>
    /// MainMenu
    /// </summary>
    public partial class MainMenu : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 90 "..\..\..\..\Views\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem undo;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\Views\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem visualizedDataItem;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\..\Views\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem canvasContentItem;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\Views\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem aplanCadViewerItem;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\..\Views\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem SignalItem;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\..\Views\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image myImage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/APLan;V1.0.0.0;component/views/mainmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\MainMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\..\Views\MainMenu.xaml"
            ((APLan.Views.MainMenu)(target)).Loaded += new System.Windows.RoutedEventHandler(this.MenuItem_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.undo = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 3:
            
            #line 104 "..\..\..\..\Views\MainMenu.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Grid_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.visualizedDataItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 112 "..\..\..\..\Views\MainMenu.xaml"
            this.visualizedDataItem.Click += new System.Windows.RoutedEventHandler(this.MenuItem_VisualizedData);
            
            #line default
            #line hidden
            return;
            case 5:
            this.canvasContentItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 115 "..\..\..\..\Views\MainMenu.xaml"
            this.canvasContentItem.Click += new System.Windows.RoutedEventHandler(this.MenuItem_CanvasContent);
            
            #line default
            #line hidden
            return;
            case 6:
            this.aplanCadViewerItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 118 "..\..\..\..\Views\MainMenu.xaml"
            this.aplanCadViewerItem.Click += new System.Windows.RoutedEventHandler(this.MenuItem_AplanCADViewer);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 121 "..\..\..\..\Views\MainMenu.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Planningtab);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 124 "..\..\..\..\Views\MainMenu.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Symbols);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SignalItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 128 "..\..\..\..\Views\MainMenu.xaml"
            this.SignalItem.Click += new System.Windows.RoutedEventHandler(this.MenuItem_Signal);
            
            #line default
            #line hidden
            return;
            case 10:
            this.myImage = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

