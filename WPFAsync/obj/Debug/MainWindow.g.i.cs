﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "391F5D6ED71D35AC11F51CBF3AE24DE616733297"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ATTMetroDemo.Entity;
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


namespace ATTMetroDemo {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ATTMetroDemo.MainWindow winMain;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStart;
        
        #line default
        #line hidden
        
        
        #line 191 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStop;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAbort;
        
        #line default
        #line hidden
        
        
        #line 195 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbJobTimeReport;
        
        #line default
        #line hidden
        
        
        #line 198 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbJobTime;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ATTMetroDemo.Entity.SliderControl redSlider;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ATTMetroDemo.Entity.SliderControl blueSlider;
        
        #line default
        #line hidden
        
        
        #line 202 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ATTMetroDemo.Entity.SliderControl greenSlider;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtRedLabel;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBlueLabel;
        
        #line default
        #line hidden
        
        
        #line 205 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtGreenLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/ATTMetroDemo;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.winMain = ((ATTMetroDemo.MainWindow)(target));
            return;
            case 2:
            this.btnStart = ((System.Windows.Controls.Button)(target));
            
            #line 190 "..\..\MainWindow.xaml"
            this.btnStart.Click += new System.Windows.RoutedEventHandler(this.btnStartLeftClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnStop = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.btnAbort = ((System.Windows.Controls.Button)(target));
            
            #line 192 "..\..\MainWindow.xaml"
            this.btnAbort.Click += new System.Windows.RoutedEventHandler(this.evtAbortClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbJobTimeReport = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.tbJobTime = ((System.Windows.Controls.TextBox)(target));
            
            #line 198 "..\..\MainWindow.xaml"
            this.tbJobTime.KeyUp += new System.Windows.Input.KeyEventHandler(this.evtJobTimeChangeKeyUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.redSlider = ((ATTMetroDemo.Entity.SliderControl)(target));
            return;
            case 8:
            this.blueSlider = ((ATTMetroDemo.Entity.SliderControl)(target));
            return;
            case 9:
            this.greenSlider = ((ATTMetroDemo.Entity.SliderControl)(target));
            return;
            case 10:
            this.txtRedLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.txtBlueLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.txtGreenLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

