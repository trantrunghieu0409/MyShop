﻿#pragma checksum "..\..\..\..\Views\SpecificStatistics.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F6546C7DF9BDD356FC1A3F0E59DBD489B74F3285"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using ProjectMyShop.Views;
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


namespace ProjectMyShop.Views {
    
    
    /// <summary>
    /// SpecificStatistics
    /// </summary>
    public partial class SpecificStatistics : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Views\SpecificStatistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid StatisticsContainer;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Views\SpecificStatistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox statisticsCombobox;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Views\SpecificStatistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker statisticsDatePicker;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\..\Views\SpecificStatistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox categoriesCombobox;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\..\Views\SpecificStatistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox productCombobox;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\..\..\Views\SpecificStatistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl chartTabControl;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\..\Views\SpecificStatistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox bargraphCombobox;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\..\..\Views\SpecificStatistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.CartesianChart productBarGraph;
        
        #line default
        #line hidden
        
        
        #line 213 "..\..\..\..\Views\SpecificStatistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.PieChart productPieChart;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProjectMyShop;V1.0.0.0;component/views/specificstatistics.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\SpecificStatistics.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.StatisticsContainer = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.statisticsCombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 45 "..\..\..\..\Views\SpecificStatistics.xaml"
            this.statisticsCombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.statisticsCombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.statisticsDatePicker = ((System.Windows.Controls.DatePicker)(target));
            
            #line 81 "..\..\..\..\Views\SpecificStatistics.xaml"
            this.statisticsDatePicker.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.statisticsDatePicker_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.categoriesCombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 126 "..\..\..\..\Views\SpecificStatistics.xaml"
            this.categoriesCombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.categoriesCombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.productCombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 143 "..\..\..\..\Views\SpecificStatistics.xaml"
            this.productCombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.productCombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.chartTabControl = ((System.Windows.Controls.TabControl)(target));
            
            #line 169 "..\..\..\..\Views\SpecificStatistics.xaml"
            this.chartTabControl.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.chartTabControl_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.bargraphCombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 184 "..\..\..\..\Views\SpecificStatistics.xaml"
            this.bargraphCombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.bargraphCombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.productBarGraph = ((LiveCharts.Wpf.CartesianChart)(target));
            return;
            case 9:
            this.productPieChart = ((LiveCharts.Wpf.PieChart)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

