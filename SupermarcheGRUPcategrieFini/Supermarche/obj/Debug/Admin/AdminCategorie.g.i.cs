﻿#pragma checksum "..\..\..\Admin\AdminCategorie.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C6E08B95183E80AC5F920A344697E3FB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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


namespace Supermarche {
    
    
    /// <summary>
    /// AdminCategorie
    /// </summary>
    public partial class AdminCategorie : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Admin\AdminCategorie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridCategorie;
        
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
            System.Uri resourceLocater = new System.Uri("/Supermarche;component/admin/admincategorie.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Admin\AdminCategorie.xaml"
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
            
            #line 8 "..\..\..\Admin\AdminCategorie.xaml"
            ((Supermarche.AdminCategorie)(target)).Loaded += new System.Windows.RoutedEventHandler(this.DataGridMenu_Categorie);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DataGridCategorie = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\..\Admin\AdminCategorie.xaml"
            this.DataGridCategorie.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGridMenu_Categorie);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 12 "..\..\..\Admin\AdminCategorie.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.retoure_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 13 "..\..\..\Admin\AdminCategorie.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Ajoute);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 14 "..\..\..\Admin\AdminCategorie.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Supprime);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 15 "..\..\..\Admin\AdminCategorie.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Modifie);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 16 "..\..\..\Admin\AdminCategorie.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

