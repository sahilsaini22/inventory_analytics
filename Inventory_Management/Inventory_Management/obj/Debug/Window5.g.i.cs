﻿#pragma checksum "..\..\Window5.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "87A3B482D2526EA9D52C8D75224EBBDEAC7689D06C99D988E533F7CB1E3D7CFF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Inventory_Management;
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


namespace Inventory_Management {
    
    
    /// <summary>
    /// Window5
    /// </summary>
    public partial class Window5 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox T_Quan;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B_Up;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox T_Move;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox T_Quan_Sh;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Window5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B_Down;
        
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
            System.Uri resourceLocater = new System.Uri("/Inventory_Management;component/window5.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window5.xaml"
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
            this.T_Quan = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\Window5.xaml"
            this.T_Quan.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.T_Quan_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.B_Up = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Window5.xaml"
            this.B_Up.Click += new System.Windows.RoutedEventHandler(this.B_Up_Add);
            
            #line default
            #line hidden
            return;
            case 3:
            this.T_Move = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\Window5.xaml"
            this.T_Move.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.T_Move_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.T_Quan_Sh = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\Window5.xaml"
            this.T_Quan_Sh.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.T_Quan_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.B_Down = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\Window5.xaml"
            this.B_Down.Click += new System.Windows.RoutedEventHandler(this.B_Up_Sub);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 42 "..\..\Window5.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 43 "..\..\Window5.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Move_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

