﻿#pragma checksum "..\..\..\Funktionen\leastwas.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5DAE413C8B9E2308639B31289FB179D473F4634245F112DC8875B51521D99DDB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Hausarbeit_Lager;
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


namespace Hausarbeit_Lager {
    
    
    /// <summary>
    /// leastwas
    /// </summary>
    public partial class leastwas : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Funktionen\leastwas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid parentGrid;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Funktionen\leastwas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgleastwas;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Funktionen\leastwas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxleastwassetleastwas;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Funktionen\leastwas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnleastwassave;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Funktionen\leastwas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnleastwasback;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Funktionen\leastwas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxleastwassearch;
        
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
            System.Uri resourceLocater = new System.Uri("/Hausarbeit_Lager;component/funktionen/leastwas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Funktionen\leastwas.xaml"
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
            
            #line 9 "..\..\..\Funktionen\leastwas.xaml"
            ((Hausarbeit_Lager.leastwas)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.parentGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.dgleastwas = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.tbxleastwassetleastwas = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnleastwassave = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\Funktionen\leastwas.xaml"
            this.btnleastwassave.Click += new System.Windows.RoutedEventHandler(this.btnleastwassave_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnleastwasback = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\Funktionen\leastwas.xaml"
            this.btnleastwasback.Click += new System.Windows.RoutedEventHandler(this.btnleastwasback_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tbxleastwassearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 92 "..\..\..\Funktionen\leastwas.xaml"
            this.tbxleastwassearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tbxleastwassearch_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

