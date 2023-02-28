﻿#pragma checksum "..\..\..\product\ProductListWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B0F19574928B3E968188FFEAB28598A80D6007FD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LP;
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
    /// ProductListWindow
    /// </summary>
    public partial class ProductListWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\product\ProductListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\product\ProductListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid UpGrid;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\product\ProductListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ProductSelector;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\product\ProductListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ProductLabel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\product\ProductListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteFilter;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\product\ProductListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ProductListView;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\product\ProductListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn ProductId;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\product\ProductListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn ProductName;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\product\ProductListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn ProductPrice;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\product\ProductListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn ProductCategory;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\product\ProductListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddItemBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/PL;component/product/productlistwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\product\ProductListWindow.xaml"
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
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.UpGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.ProductSelector = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\product\ProductListWindow.xaml"
            this.ProductSelector.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectionChangedCategory);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ProductLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.DeleteFilter = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\product\ProductListWindow.xaml"
            this.DeleteFilter.Click += new System.Windows.RoutedEventHandler(this.DeleteFilter_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ProductListView = ((System.Windows.Controls.ListView)(target));
            
            #line 26 "..\..\..\product\ProductListWindow.xaml"
            this.ProductListView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.UpdateProduct);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ProductId = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 8:
            this.ProductName = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 9:
            this.ProductPrice = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 10:
            this.ProductCategory = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 11:
            this.AddItemBtn = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\product\ProductListWindow.xaml"
            this.AddItemBtn.Click += new System.Windows.RoutedEventHandler(this.AddItemBtn_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 44 "..\..\..\product\ProductListWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

