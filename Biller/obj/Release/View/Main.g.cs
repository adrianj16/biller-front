﻿#pragma checksum "..\..\..\View\Main.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D829EC5EE6E1323CA601DCAE83491BB0462398F631392A35406C8D9CCEC579B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Biller.View;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Biller.View {
    
    
    /// <summary>
    /// Main
    /// </summary>
    public partial class Main : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid HeadBar;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Shutdown;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SideBar;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Dashboard_BTN;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pedidos_BTN;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Productos_BTN;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Inventario_BTN;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Seguimiento_BTN;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Reportes_BTN;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\View\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid PrincipalPage;
        
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
            System.Uri resourceLocater = new System.Uri("/Biller;component/view/main.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Main.xaml"
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
            this.HeadBar = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Shutdown = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\View\Main.xaml"
            this.Shutdown.Click += new System.Windows.RoutedEventHandler(this.Shutdown_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SideBar = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.Dashboard_BTN = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\View\Main.xaml"
            this.Dashboard_BTN.Click += new System.Windows.RoutedEventHandler(this.Dashboard_BTN_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Pedidos_BTN = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\View\Main.xaml"
            this.Pedidos_BTN.Click += new System.Windows.RoutedEventHandler(this.Pedidos_BTN_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Productos_BTN = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\View\Main.xaml"
            this.Productos_BTN.Click += new System.Windows.RoutedEventHandler(this.Productos_BTN_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Inventario_BTN = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\View\Main.xaml"
            this.Inventario_BTN.Click += new System.Windows.RoutedEventHandler(this.Inventario_BTN_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Seguimiento_BTN = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\View\Main.xaml"
            this.Seguimiento_BTN.Click += new System.Windows.RoutedEventHandler(this.Seguimiento_BTN_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Reportes_BTN = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\View\Main.xaml"
            this.Reportes_BTN.Click += new System.Windows.RoutedEventHandler(this.Reportes_BTN_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.PrincipalPage = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

