﻿#pragma checksum "..\..\Main.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8313EE9742F74AB013A5250F763A2AAE7C179914"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RentalStore;
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


namespace RentalStore {
    
    
    /// <summary>
    /// Main
    /// </summary>
    public partial class Main : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbxCustomers;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewProfile;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreateLoan;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewStock;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbxMovies;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReturn;
        
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
            System.Uri resourceLocater = new System.Uri("/RentalStore;component/main.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Main.xaml"
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
            
            #line 10 "..\..\Main.xaml"
            ((RentalStore.Main)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lbxCustomers = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.btnViewProfile = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Main.xaml"
            this.btnViewProfile.Click += new System.Windows.RoutedEventHandler(this.btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnCreateLoan = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Main.xaml"
            this.btnCreateLoan.Click += new System.Windows.RoutedEventHandler(this.btn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnViewStock = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Main.xaml"
            this.btnViewStock.Click += new System.Windows.RoutedEventHandler(this.btnViewStock_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lbxMovies = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.btnReturn = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Main.xaml"
            this.btnReturn.Click += new System.Windows.RoutedEventHandler(this.BtnReturn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

