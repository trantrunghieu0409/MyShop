   M S B A M L   `   `   `  ���� H  DProjectMyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProjectMyShop.ViewsProjectMyShop.Views  U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf ,    &ProjectMyShop.Views.AdvancedStatistics   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:ProjectMyShop.Views     _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf    N� Title$  AdvancedStatistics��.��� -   $��StatisticsContainer�� � ColumnDefinitions �� $��1* ��� $��1* ��� $��1* � � RowDefinitions �� $��50 ��� $	��175 ��� $��* �.+�#  MaterialDesignThemes.Wpf.Card  $	��130��$��45��$��0, 0, 10, 0q�$
��Left=�   UniformCornerRadius$ 23Q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=�$��0��$��0��.����  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+��� -   $��statisticsCombobox��$��Right=�$��30��$��Center=�$��85������ *MaterialDesign+ �� SelectedIndex �� *statisticsFigureIndex+���� .R��� ����  � 	Resources    PrimaryHueMidBrush �� Color  PrimaryHueDarkBrush��%9   &	        &	      �� $ DeepPink���� $ Green������ 	 �� 
TargetType"	 ��.��� 
 �� Property
 � �� �� Value
 ������� 
 � ��
 �����  $	��130��$��45��$��0, 0, 10, 0q�$��Right=�$ 23Q�$ Depth0=�$��3��$��0��.���� $ 
Horizontal=�$��Center=�$��Center=�.+�(  "System.Windows.Controls.DatePicker  -   $��statisticsDatePicker��   SelectedDate �� *selectedDate+   CalendarStyle �� &   System.Windows.Controls.Calendar"	   " MaterialDesignCalendarPortrait �� BasedOn# [  �� 	Resources ��%9   &	        &	      �� $ DeepPink���� $ Green����� 
 � ��
 ������� $��1��$��3��$��2��$��0, 20, 0, 10q�.+�]� .+��� -   $��timeCombobox��$��Right=�$��Right=�$��
0, 0, 2, 0q�$��Center=�$��30��$��80������ *MaterialDesign+ �� *figureIndex+���� .R��� ���� �� $��Top 5 Best-selling Phones��$��20(�
����p��
�������&   System.Windows.Controls.DataGrid  -     Name$ PhoneDataGrid��$��0��   AutoGenerateColumns$ False��   ColumnHeaderHeight$ 30Q�   HeadersVisibility$ Column=�   RowHeaderWidth$	 100Q�   CanUserResizeColumns$ False��
�������$��1q�"   VerticalScrollBarVisibility$
 Auto=� J� 	AllowDrop$
 True��   GridLinesVisibility$
 None=�   HorizontalGridLinesBrush
 �����   SelectionMode$ Single=�   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$   #ID��   
IsReadOnly$
 True��   CellTemplate �� .R��� $ 
Horizontal=�$��Center=�.+��� $��5,0,0,0q����� *ID+  $      Phone Name��$
 True�� �� .R��� $ 
Horizontal=�$��Center=�.+��� ���� *	PhoneName+  $      Manufacturer��$
 True�� �� .R��� $ 
Horizontal=�$��Center=�.+��� ���� *Manufacturer+  $        Bought Price��$
 True�� �� .R��� $ 
Horizontal=�$��Center=�.+��� $
��10,0q����� *BoughtPrice+  $       Sold Price��$
 True�� �� .R��� $ 
Horizontal=�$��Center=�.+��� $��5,0,0,0q����� *	SoldPrice+  $        Quantity�� �� .R��� $ 
Horizontal=�$��Center=�.+��� $
��10,0q�$��DemiBold"����� *
Quantity+   RowStyle �� ��� 
 � ��$ Normal"�    ColumnHeaderStyle  �� ��� 
 � ��
 �   ��� 
 � ��
 ������� 
 �@��Padding$
 10,0q��� 
 � ��$ 30���� 
 � ��$
 Bold"�