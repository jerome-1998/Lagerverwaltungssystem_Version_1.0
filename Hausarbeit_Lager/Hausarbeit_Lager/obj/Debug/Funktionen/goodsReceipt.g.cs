﻿#pragma checksum "..\..\..\Funktionen\goodsReceipt.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B9F6E05CBD27DDF05DB0CD1550365BF024696C03580EBCAA9981EC0550734096"
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
    /// goodsReceipt
    /// </summary>
    public partial class goodsReceipt : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Funktionen\goodsReceipt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ParentGrid;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Funktionen\goodsReceipt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbxgoodsreceiptdeliverer;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Funktionen\goodsReceipt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbxgoodsreceiptgoods;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Funktionen\goodsReceipt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxgoodsreceiptdelivered;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Funktionen\goodsReceipt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btngoodsreceipt;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Funktionen\goodsReceipt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btngoodsreceiptback;
        
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
            System.Uri resourceLocater = new System.Uri("/Hausarbeit_Lager;component/funktionen/goodsreceipt.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Funktionen\goodsReceipt.xaml"
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
            
            #line 9 "..\..\..\Funktionen\goodsReceipt.xaml"
            ((Hausarbeit_Lager.Funktionen.goodsReceipt)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ParentGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.lbxgoodsreceiptdeliverer = ((System.Windows.Controls.ListBox)(target));
            
            #line 31 "..\..\..\Funktionen\goodsReceipt.xaml"
            this.lbxgoodsreceiptdeliverer.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Lbxgoodsreceiptgoods_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lbxgoodsreceiptgoods = ((System.Windows.Controls.ListBox)(target));
            
            #line 42 "..\..\..\Funktionen\goodsReceipt.xaml"
            this.lbxgoodsreceiptgoods.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Lbxgoodsreceiptgoods_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbxgoodsreceiptdelivered = ((System.Windows.Controls.TextBox)(target));
            
            #line 53 "..\..\..\Funktionen\goodsReceipt.xaml"
            this.tbxgoodsreceiptdelivered.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tbxgoodsreceiptdelivered_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btngoodsreceipt = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\Funktionen\goodsReceipt.xaml"
            this.btngoodsreceipt.Click += new System.Windows.RoutedEventHandler(this.Btngoodsreceipt_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btngoodsreceiptback = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\Funktionen\goodsReceipt.xaml"
            this.btngoodsreceiptback.Click += new System.Windows.RoutedEventHandler(this.Btngoodsreceiptback_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
