   M S B A M L   `   `   `  ���� U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  H DProjectMyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProjectMyShop.ViewsProjectMyShop.Views $   ProjectMyShop.Views.Statistics   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  -local!clr-namespace:ProjectMyShop.Views  -     N� Title$  
Statistics��.��� -   $��StatisticsContainer�� � ColumnDefinitions �� $��1* ��� $��1* ��� $��1* � � RowDefinitions �� $��50 ��� $	��100 ��� $	��175 ��� $��* �.+�#  MaterialDesignThemes.Wpf.Card  $	��130��$��45��$��0, 0, 10, 0q�$
��Left=�   UniformCornerRadius$ 23Q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=�$��0��$��0��.����  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+��� -   $��statisticsCombobox��$��Right=�$��30��$��Center=�$��85������ *MaterialDesign+ �� SelectedIndex �� *statisticsFigureIndex+���� .R��� ����   $	��130��$��45��$��0, 0, 10, 0q�$��Right=�$ 23Q�$ Depth0=�$��3��$��0��.���� $ 
Horizontal=�$��Center=�$��Center=�.+�(  "System.Windows.Controls.DatePicker  -   $��statisticsDatePicker��   SelectedDate �� *selectedDate+   CalendarStyle �� 	 �� 
TargetType&   System.Windows.Controls.Calendar"	   "  MaterialDesignCalendarPortrait
 �� BasedOn#
 [   �� 	Resources   PrimaryHueMidBrush �� Color  PrimaryHueDarkBrush��%9   &	       &	      �� $ DeepPink���� $ Green�����  �� Property � �� �� Value
 �����  -   $��currentTotalPhone��$��1��$	��200��$	��100��  MyPurpleGradient#���  $	��Top=�$ 10Q�$ Depth1=�$��Center=�.��� $��10q�.+��� .+��� $��Revenue��
������� $  MaterialDesignSubtitle2TextBlock#��[ �� -    ��Name$ TotalRevenueTextBlock��
������� $  MaterialDesignSubtitle1TextBlock#��[ ���� '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Store=�$��50��$��0, 0, 10, 10q�$��Bottom=�$��Right=�
�������$��50��  $��1��$��1��$	��200��$	��100��  MyBlueGradient#���  $	��Top=�$ 10Q�$ Depth1=�$��Center=�.��� $��10q�.+��� .+��� $��Profit��
�������#��[ �� -   $ TotalProfitTextBlock��
�������#��[ ����   $ Dollar=�$��50��$��50��$��0, 0, 10, 10q�$��Bottom=�$��Right=�
�������  $��1��$��2��$	��200��$	��100��  MyYellowGradient#���  $	��Top=�$ 10Q�$ Depth1=�$��Center=�.��� $��10q�.+��� .+��� $��Orders��
�������#��[ �� -   $ TotalOrdersTextBlock��
�������#��[ ���� *Count+  $ Receipt=�$��50��$��50��$��0, 0, 10, 10q�$��Bottom=�$��Right=�
�������  $��0��$��2��$��3��$��2�����	#60ffffff$ 10Q�$��10q�$��25, 20, 25, 0q�$ Depth0=�.���� -	   $��chartTabControl�� �� *tabSelectedIndex+.@��� $��Revenue��.���  �� $
��1.5* ��� $	��10* �.+�]� .+��� -
   $��revenueCombobox��$��Right=�$��30��$��Center=�$��75�� �� *figureIndex+���� *MaterialDesign+���� .R��� ���� #   LiveCharts.Wpf.CartesianChart  -   $��revenueChart��$��1��&    LiveCharts.Wpf.Charts.Base.Chart   Series !   LiveCharts.Wpf.ColumnSeries  	   LiveCharts.Wpf.Series 	  Title$ Maria�� 	  Values;
   5LiveCharts.Wpf.Converters.NumericChartValuesConverter$ 3
   $ Maria��$ 4
   $ Maria��$ 5
   $ Maria��$ 6
 �� $��Profit��.���  �� $
��1.5* ��� $	��10* �.+�]� .+��� -   $��profitCombobox��$��Right=�$��Center=�$��30��$��75�� �� *profitFigureIndex+���� *MaterialDesign+���� .R��� ����   -   $��profitChart��$��1��   $ Maria��$ 3
   $ Maria��$ 4
   $ Maria��$ 5
   $ Maria��$ 6
 