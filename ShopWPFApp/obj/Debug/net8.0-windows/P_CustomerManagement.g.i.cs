﻿#pragma checksum "..\..\..\P_CustomerManagement.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90FD3446C12F25C2D080A076D6C90EA07CDB22FC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using ShopWPFApp;
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


namespace ShopWPFApp {
    
    
    /// <summary>
    /// P_CustomerManagement
    /// </summary>
    public partial class P_CustomerManagement : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\P_CustomerManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbId;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\P_CustomerManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbFullName;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\P_CustomerManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTelephone;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\P_CustomerManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbEmail;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\P_CustomerManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbAddress;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\P_CustomerManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbStatus;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\P_CustomerManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_SwitchStatus;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\P_CustomerManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearchbyText;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\P_CustomerManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ShopWPFApp;component/p_customermanagement.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\P_CustomerManagement.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tbId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbFullName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbTelephone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbStatus = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btn_SwitchStatus = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\P_CustomerManagement.xaml"
            this.btn_SwitchStatus.Click += new System.Windows.RoutedEventHandler(this.btn_Delete);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tbSearchbyText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 66 "..\..\..\P_CustomerManagement.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_SearchByName);
            
            #line default
            #line hidden
            return;
            case 10:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 78 "..\..\..\P_CustomerManagement.xaml"
            this.dataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

