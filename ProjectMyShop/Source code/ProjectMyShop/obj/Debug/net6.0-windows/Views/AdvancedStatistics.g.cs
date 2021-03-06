#pragma checksum "..\..\..\..\Views\AdvancedStatistics.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9020E9EAF99E482EB60C4CCEBF77A80BBF646C48"
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
    /// AdvancedStatistics
    /// </summary>
    public partial class AdvancedStatistics : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Views\AdvancedStatistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid StatisticsContainer;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\AdvancedStatistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox statisticsCombobox;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Views\AdvancedStatistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker statisticsDatePicker;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\Views\AdvancedStatistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox timeCombobox;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\Views\AdvancedStatistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PhoneDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectMyShop;component/views/advancedstatistics.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AdvancedStatistics.xaml"
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
            
            #line 42 "..\..\..\..\Views\AdvancedStatistics.xaml"
            this.statisticsCombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.statisticsCombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.statisticsDatePicker = ((System.Windows.Controls.DatePicker)(target));
            
            #line 78 "..\..\..\..\Views\AdvancedStatistics.xaml"
            this.statisticsDatePicker.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.statisticsDatePicker_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.timeCombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 99 "..\..\..\..\Views\AdvancedStatistics.xaml"
            this.timeCombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.timeCombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PhoneDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

