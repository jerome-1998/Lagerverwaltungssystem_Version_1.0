﻿#pragma checksum "..\..\..\Funktionen\ABCAnalyse.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "575A83B264E61F0E351CBCC4751AFD996F44D44CAF478CCF6943EB5A6902FC79"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Hausarbeit_Lager.Funktionen;
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


namespace Hausarbeit_Lager.Funktionen {
    
    
    /// <summary>
    /// ABCAnalyse
    /// </summary>
    public partial class ABCAnalyse : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Funktionen\ABCAnalyse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid parenGrid;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Funktionen\ABCAnalyse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgabc;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Funktionen\ABCAnalyse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnabcmanuell;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Funktionen\ABCAnalyse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnabcautomatic;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Funktionen\ABCAnalyse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxabcagood;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Funktionen\ABCAnalyse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxabcbgood;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\Funktionen\ABCAnalyse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnabcback;
        
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
            System.Uri resourceLocater = new System.Uri("/Hausarbeit_Lager;component/funktionen/abcanalyse.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Funktionen\ABCAnalyse.xaml"
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
            
            #line 9 "..\..\..\Funktionen\ABCAnalyse.xaml"
            ((Hausarbeit_Lager.Funktionen.ABCAnalyse)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.parenGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.dgabc = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.btnabcmanuell = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Funktionen\ABCAnalyse.xaml"
            this.btnabcmanuell.Click += new System.Windows.RoutedEventHandler(this.btnabcmanuell_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnabcautomatic = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\Funktionen\ABCAnalyse.xaml"
            this.btnabcautomatic.Click += new System.Windows.RoutedEventHandler(this.btnabcautomatic_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tbxabcagood = ((System.Windows.Controls.TextBox)(target));
            
            #line 86 "..\..\..\Funktionen\ABCAnalyse.xaml"
            this.tbxabcagood.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tbxabcagood_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tbxabcbgood = ((System.Windows.Controls.TextBox)(target));
            
            #line 94 "..\..\..\Funktionen\ABCAnalyse.xaml"
            this.tbxabcbgood.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tbxabcagood_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnabcback = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\..\Funktionen\ABCAnalyse.xaml"
            this.btnabcback.Click += new System.Windows.RoutedEventHandler(this.btnabcback_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
