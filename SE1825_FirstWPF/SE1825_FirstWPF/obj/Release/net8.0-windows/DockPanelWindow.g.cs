﻿#pragma checksum "..\..\..\DockPanelWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65257B645A2286486691FED2AF378B313AB82E4E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SE1825_FirstWPF;
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


namespace SE1825_FirstWPF {
    
    
    /// <summary>
    /// DockPanelWindow
    /// </summary>
    public partial class DockPanelWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\DockPanelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu mnuMain;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\DockPanelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuShow;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\DockPanelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuProduct;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\DockPanelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuStaff;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\DockPanelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuReport;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\DockPanelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuOrder;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\DockPanelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuProfile;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\DockPanelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuLogin;
        
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
            System.Uri resourceLocater = new System.Uri("/SE1825_FirstWPF;component/dockpanelwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DockPanelWindow.xaml"
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
            
            #line 8 "..\..\..\DockPanelWindow.xaml"
            ((SE1825_FirstWPF.DockPanelWindow)(target)).Activated += new System.EventHandler(this.Window_Activated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mnuMain = ((System.Windows.Controls.Menu)(target));
            return;
            case 3:
            this.mnuShow = ((System.Windows.Controls.MenuItem)(target));
            
            #line 12 "..\..\..\DockPanelWindow.xaml"
            this.mnuShow.Click += new System.Windows.RoutedEventHandler(this.mnuShow_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.mnuProduct = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\..\DockPanelWindow.xaml"
            this.mnuProduct.Click += new System.Windows.RoutedEventHandler(this.mnuProduct_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mnuStaff = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\..\DockPanelWindow.xaml"
            this.mnuStaff.Click += new System.Windows.RoutedEventHandler(this.mnuStaff_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.mnuReport = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\..\DockPanelWindow.xaml"
            this.mnuReport.Click += new System.Windows.RoutedEventHandler(this.mnuReport_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.mnuOrder = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\..\DockPanelWindow.xaml"
            this.mnuOrder.Click += new System.Windows.RoutedEventHandler(this.mnuOrder_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.mnuProfile = ((System.Windows.Controls.MenuItem)(target));
            
            #line 17 "..\..\..\DockPanelWindow.xaml"
            this.mnuProfile.Click += new System.Windows.RoutedEventHandler(this.mnuProfile_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.mnuLogin = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\..\DockPanelWindow.xaml"
            this.mnuLogin.Click += new System.Windows.RoutedEventHandler(this.mnuLogin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

