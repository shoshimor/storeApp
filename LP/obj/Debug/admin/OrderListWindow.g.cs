﻿#pragma checksum "..\..\..\admin\OrderListWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A7FF9C11EC288F12AB3573B1DB5563E1BE220F48"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PL;
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


namespace PL {
    
    
    /// <summary>
    /// OrderListWindow
    /// </summary>
    public partial class OrderListWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\admin\OrderListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label orderListLbl;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\admin\OrderListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView OrderListView;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\admin\OrderListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn OrderId;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\admin\OrderListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn CustomerName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\admin\OrderListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn ProductPrice;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\admin\OrderListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn ProductCategory;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\admin\OrderListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn AmountOfItems;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PL;component/admin/orderlistwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\admin\OrderListWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.orderListLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.OrderListView = ((System.Windows.Controls.ListView)(target));
            
            #line 12 "..\..\..\admin\OrderListWindow.xaml"
            this.OrderListView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.OrderListView_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.OrderId = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 4:
            this.CustomerName = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 5:
            this.ProductPrice = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 6:
            this.ProductCategory = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 7:
            this.AmountOfItems = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 8:
            
            #line 24 "..\..\..\admin\OrderListWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

