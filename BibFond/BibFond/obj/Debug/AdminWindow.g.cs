﻿#pragma checksum "..\..\AdminWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "09F16BF4C55C792F17EB4D13FB9978F830B29D32884B25B0D745536A708D0761"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BibFond;
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


namespace BibFond {
    
    
    /// <summary>
    /// AdminWindow
    /// </summary>
    public partial class AdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BookButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PubButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AuthorsButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClientButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackHomeButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Frame;
        
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
            System.Uri resourceLocater = new System.Uri("/BibFond;component/adminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminWindow.xaml"
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
            this.BookButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\AdminWindow.xaml"
            this.BookButton.Click += new System.Windows.RoutedEventHandler(this.BookButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PubButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\AdminWindow.xaml"
            this.PubButton.Click += new System.Windows.RoutedEventHandler(this.PubButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AuthorsButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\AdminWindow.xaml"
            this.AuthorsButton.Click += new System.Windows.RoutedEventHandler(this.AuthorsButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ClientButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\AdminWindow.xaml"
            this.ClientButton.Click += new System.Windows.RoutedEventHandler(this.ClientButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BackHomeButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\AdminWindow.xaml"
            this.BackHomeButton.Click += new System.Windows.RoutedEventHandler(this.BackHomeButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Frame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

