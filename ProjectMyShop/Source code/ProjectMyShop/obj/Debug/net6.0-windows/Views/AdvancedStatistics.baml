   M S B A M L   `   `   `  ����H  DProjectMyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProjectMyShop.ViewsProjectMyShop.Views  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5	      ,    &ProjectMyShop.Views.AdvancedStatistics   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:ProjectMyShop.Views     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5	        N� Title$  AdvancedStatistics��5      .��5      � -   5        $��StatisticsContainer��5       � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��175 �6   �� 5      $��* �6   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $	��130��5      $��45��5      $��0, 0, 10, 0q�5      $
��Left=�5         UniformCornerRadius$ 23Q�5      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=�5      $��0��5       $��0��5!      .��5"      ��  �� Orientation$ 
Horizontal=�5#      $��Center=�5$      $��Center=�5%      .+�5'      �� -   5        $��statisticsCombobox��5'      $��Right=�65   $��30��5(   !   $��Center=�5+   !   $��85��5,   !    �� SelectedIndex 5)   !   �� *statisticsFigureIndex+��5-      �� 5.      .R�5/      �� ��6(   �� 50       � 	Resources 52         PrimaryHueMidBrush �� Color  PrimaryHueDarkBrush��%U   &	        &	 "     �� 53      $ DeepPink��6E   �� 54      $ Green��6F   55      ��56      �� 57      	 �� 
TargetType"	 ��6    .�58      �� 
 �� Property
 � �� �� Value
 �����6;   �� 59      
 � ��
 �����6<   5:      5<      5=      5>        5@   
   $	��130��5A      $��45��5B      $��0, 0, 10, 0q�5C      $��Right=�5D      $ 23Q�5E      $ Depth0=�5F      $��3��5G      $��0��5H      .��5I      �� $ 
Horizontal=�5J      $��Center=�5K      $��Center=�5L      .+�5N      (  "System.Windows.Controls.DatePicker  -   5        $��statisticsDatePicker��5N         SelectedDate 69   �� *selectedDate+   CalendarStyle 5O      �� 5P      &   System.Windows.Controls.Calendar"	  6     " MaterialDesignCalendarPortrait �� BasedOn# [ 66    �� 	Resources 5Q      ��%U   &	        &	 "     �� 5R   "   $ DeepPink��6M   �� 5S   "   $ Green��6N   5T      �5U      �� 5V   "   
 � ��
 �����6?   5X      5Z      5[      5\      �� 5^   
   $��1��6   $��3��6"   $��2��66   $��0, 20, 0, 10q�6G   .+�5_      ]� .+�5`      �� -   5        $��timeCombobox��5`   2   $��Right=�6   $��Right=�6F   $��0, 0, 10, 0q�6b   $��30��5a   !   $��62��5d   !    5b   !   �� *figureIndex+��5e      �� 5f      .R�5g      �� ��6(   �� 5h      5j      �� 5k      $��Top 5 Best-selling Phones��6   $��20(�6=   
����p��
�������6e   5l      &   System.Windows.Controls.DataGrid  5m      -   5          Name$ PhoneDataGrid��5m   $   $��0��6      AutoGenerateColumns$ False��5n         ColumnHeaderHeight$ 30Q�61      HeadersVisibility$ Column=�6I      RowHeaderWidth$	 100Q�5o         CanUserResizeColumns$ False��5p      
�������$��1q�5r      "   VerticalScrollBarVisibility$
 Auto=�5s       J� 	AllowDrop$
 True��69      GridLinesVisibility$
 None=�6K      HorizontalGridLinesBrush
 �����   SelectionMode$ Single=�6�      Columns 5u      4  .System.Windows.Controls.DataGridTemplateColumn  5v      ,  &System.Windows.Controls.DataGridColumn   Header$   #ID��6-      
IsReadOnly$
 True��6<      CellTemplate 5w      �� 5x      .R�5y   "   �� $ 
Horizontal=�6-   $��Center=�6F   .+�5z   &   �� $��5,0,0,0q�6D   ��60   �� *ID+6W   5{   #   5|      5~        5      $        Phone Name��6-   $
 True��6H    5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   $��Center=�6F   .+�5�   &   �� ��60   �� *	PhoneName+6M   5�   #   5�      5�        5�      $      Manufacturer��6-   $
 True��5�   )    5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   $��Center=�6F   .+�5�   &   �� ��60   �� *Manufacturer+6P   5�   #   5�      5�        5�      $          Bought Price��6-   $
 True��5�   )    5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   $��Center=�6F   .+�5�   &   �� $
��10,0q�60   ��6>   �� *BoughtPrice+5�   #   5�      5�        5�      $         Sold Price��6-   $
 True��5�   )    5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   $��Center=�6F   .+�5�   &   �� $��5,0,0,0q�6K   ��60   �� *	SoldPrice+6^   5�   #   5�      5�        5�      $ 	        #��6-    5�      �� 5�      .R�5�   "   �� .+�5�   &   %  MaterialDesignThemes.Wpf.Badged  .��5�   *   ��  ��Name$ 	AddButton��61    7 3MaterialDesignFloatingActionMiniSecondaryDarkButton#��[ 5�   %   ��5�   .   '	  !MaterialDesignThemes.Wpf.PackIcon	  5�   2     	  Kind$  AddBox=�6J   5�   +   5�   '   5�   #   5�      5�      !   RowStyle! 5�      �� 5�      �5�      �� 5�      
 � ��$ Normal"�6E   6V   5�      "   ColumnHeaderStyle" 5�      �� 5�      �5�      �� 5�      
 � ��
 �   �6A   �� 5�      
 � ��
 �����6E   �� 5�      
 �@��Padding$
 10,0q�6B   �� 5�      
 � ��$ 30��6A   �� 5�      
 � ��$
 Bold"�6E   5�      5�      5�      5�      5�      