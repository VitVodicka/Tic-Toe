﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1DACA14FEF8011B8368C70711BAF733DF86488BE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Tic_Toe;


namespace Tic_Toe {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox arrayColumn0Row0;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox arrayColumn0Row1;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox arrayColumn0Row2;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox arrayColumn1Row0;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox arrayColumn1Row1;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox arrayColumn1Row2;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox arrayColumn2Row0;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox arrayColumn2Row1;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox arrayColumn2Row2;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock turn;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock stopwatch;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox record;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tic-Toe;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.arrayColumn0Row0 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 22 "..\..\..\MainWindow.xaml"
            this.arrayColumn0Row0.Checked += new System.Windows.RoutedEventHandler(this.checking);
            
            #line default
            #line hidden
            return;
            case 2:
            this.arrayColumn0Row1 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 30 "..\..\..\MainWindow.xaml"
            this.arrayColumn0Row1.Checked += new System.Windows.RoutedEventHandler(this.checking);
            
            #line default
            #line hidden
            return;
            case 3:
            this.arrayColumn0Row2 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 38 "..\..\..\MainWindow.xaml"
            this.arrayColumn0Row2.Checked += new System.Windows.RoutedEventHandler(this.checking);
            
            #line default
            #line hidden
            return;
            case 4:
            this.arrayColumn1Row0 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 46 "..\..\..\MainWindow.xaml"
            this.arrayColumn1Row0.Checked += new System.Windows.RoutedEventHandler(this.checking);
            
            #line default
            #line hidden
            return;
            case 5:
            this.arrayColumn1Row1 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 54 "..\..\..\MainWindow.xaml"
            this.arrayColumn1Row1.Checked += new System.Windows.RoutedEventHandler(this.checking);
            
            #line default
            #line hidden
            return;
            case 6:
            this.arrayColumn1Row2 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 62 "..\..\..\MainWindow.xaml"
            this.arrayColumn1Row2.Checked += new System.Windows.RoutedEventHandler(this.checking);
            
            #line default
            #line hidden
            return;
            case 7:
            this.arrayColumn2Row0 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 72 "..\..\..\MainWindow.xaml"
            this.arrayColumn2Row0.Checked += new System.Windows.RoutedEventHandler(this.checking);
            
            #line default
            #line hidden
            return;
            case 8:
            this.arrayColumn2Row1 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 80 "..\..\..\MainWindow.xaml"
            this.arrayColumn2Row1.Checked += new System.Windows.RoutedEventHandler(this.checking);
            
            #line default
            #line hidden
            return;
            case 9:
            this.arrayColumn2Row2 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 88 "..\..\..\MainWindow.xaml"
            this.arrayColumn2Row2.Checked += new System.Windows.RoutedEventHandler(this.checking);
            
            #line default
            #line hidden
            return;
            case 10:
            this.turn = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.stopwatch = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            
            #line 114 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Restart);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 124 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Restart);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 134 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Restart);
            
            #line default
            #line hidden
            return;
            case 15:
            this.record = ((System.Windows.Controls.ListBox)(target));
            
            #line 145 "..\..\..\MainWindow.xaml"
            this.record.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.doubleListClick);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 146 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Record_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

