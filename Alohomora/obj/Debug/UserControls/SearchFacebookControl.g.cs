﻿#pragma checksum "..\..\..\UserControls\SearchFacebookControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BE9AA88F91B9B35E9B77303669161629"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Alohomora.UserControls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Alohomora.UserControls {
    
    
    /// <summary>
    /// SearchFacebookControl
    /// </summary>
    public partial class SearchFacebookControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\UserControls\SearchFacebookControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Alohomora.UserControls.SearchFacebookControl UserControl;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\UserControls\SearchFacebookControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FacebookButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\UserControls\SearchFacebookControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WebBrowser FaceBookBrowser;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\UserControls\SearchFacebookControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox FacebookListBox;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\UserControls\SearchFacebookControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer DetailsContainer;
        
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
            System.Uri resourceLocater = new System.Uri("/Alohomora;component/usercontrols/searchfacebookcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\SearchFacebookControl.xaml"
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
            this.UserControl = ((Alohomora.UserControls.SearchFacebookControl)(target));
            return;
            case 2:
            this.FacebookButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\UserControls\SearchFacebookControl.xaml"
            this.FacebookButton.Click += new System.Windows.RoutedEventHandler(this.FacebookButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FaceBookBrowser = ((System.Windows.Controls.WebBrowser)(target));
            return;
            case 4:
            this.FacebookListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.DetailsContainer = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 6:
            
            #line 101 "..\..\..\UserControls\SearchFacebookControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackToSearchClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
