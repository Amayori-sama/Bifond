﻿#pragma checksum "..\..\MyBooksListPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E2C07100F657BF855943ED7BB0A446057FC152F2E1F45A5BC4952F9A6A876632"
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
    /// MyBooksListPage
    /// </summary>
    public partial class MyBooksListPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\MyBooksListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition ColumnChange;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MyBooksListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilterComboBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MyBooksListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FilterTextBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MyBooksListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PageGrid;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MyBooksListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RecordLabel;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MyBooksListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RecordTextMovieName;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MyBooksListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AuthorComboBox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\MyBooksListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PubComboBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\MyBooksListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RecordTextTags;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\MyBooksListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SelectFileButton;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\MyBooksListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RecordTextScreen;
        
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
            System.Uri resourceLocater = new System.Uri("/BibFond;component/mybookslistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MyBooksListPage.xaml"
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
            
            #line 9 "..\..\MyBooksListPage.xaml"
            ((BibFond.MyBooksListPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ColumnChange = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 3:
            this.FilterComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.FilterTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\MyBooksListPage.xaml"
            this.FilterTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FilterTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PageGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.RecordLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.RecordTextMovieName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.AuthorComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.PubComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.RecordTextTags = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.SelectFileButton = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.RecordTextScreen = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

