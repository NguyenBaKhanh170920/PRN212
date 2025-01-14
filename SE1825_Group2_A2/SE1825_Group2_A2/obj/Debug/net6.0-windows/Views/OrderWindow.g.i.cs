﻿#pragma checksum "..\..\..\..\Views\OrderWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B7749273B38C2920B205FD9489CD42B5F981AEC3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SE1825_Group2_A2;
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


namespace SE1825_Group2_A2 {
    
    
    /// <summary>
    /// OrderWindow
    /// </summary>
    public partial class OrderWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 37 "..\..\..\..\Views\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDate;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Views\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbOrderDetailId;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Views\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbOrderDId;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Views\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbProductId;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Views\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbQuantity;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Views\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbUnitPrice;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\Views\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvOrders;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Views\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn gvcOrderId;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\Views\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvOrderDetails;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\Views\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn gvcOrderDetailId;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SE1825_Group2_A2;component/views/orderwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\OrderWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dpDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            
            #line 38 "..\..\..\..\Views\OrderWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 39 "..\..\..\..\Views\OrderWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnResetFilter_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 41 "..\..\..\..\Views\OrderWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddOrder_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbOrderDetailId = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.tbOrderDId = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.tbProductId = ((System.Windows.Controls.TextBox)(target));
            
            #line 69 "..\..\..\..\Views\OrderWindow.xaml"
            this.tbProductId.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbProductId_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tbQuantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.tbUnitPrice = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            
            #line 78 "..\..\..\..\Views\OrderWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddDetail_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 79 "..\..\..\..\Views\OrderWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnEditDetail_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.lvOrders = ((System.Windows.Controls.ListView)(target));
            
            #line 84 "..\..\..\..\Views\OrderWindow.xaml"
            this.lvOrders.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvOrders_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.gvcOrderId = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 15:
            this.lvOrderDetails = ((System.Windows.Controls.ListView)(target));
            
            #line 102 "..\..\..\..\Views\OrderWindow.xaml"
            this.lvOrderDetails.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvOrderDetails_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 16:
            this.gvcOrderDetailId = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 14:
            
            #line 93 "..\..\..\..\Views\OrderWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            break;
            case 17:
            
            #line 113 "..\..\..\..\Views\OrderWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDeleteDetail_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

