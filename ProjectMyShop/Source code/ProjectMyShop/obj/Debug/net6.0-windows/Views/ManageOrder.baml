   M S B A M L   `   `   `  ����H  DProjectMyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProjectMyShop.ViewsProjectMyShop.Views  5      A%clr-namespace:ProjectMyShop.ConverterProjectMyShop.Converter  67   %    ProjectMyShop.Views.ManageOrder   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -local!clr-namespace:ProjectMyShop.Views  5      2local1%clr-namespace:ProjectMyShop.Converter  67   -   5          N� Title$  ManageOrder��5
       � 	Resources 5      -  'ProjectMyShop.Converter.StatusConverter   statusConverter��%   &	          5   
   6!   5      .��5      #  MaterialDesignThemes.Wpf.Card  
�������   UniformCornerRadius$ 10Q�6-   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowEdges$	 All=�6F   $��20,20,20,30q�6t   .��5   
   ]� $
��True��6   .+�5      ��  �� Orientation$ Vertical=�6   $	��Top=�60   .+�5      �� $��Order status��6   $��Normal"�60   $��16(�6D   �� 5      $ ��Overview of Lastest Orders��6   $��DemiBold"�6>   
�������$��12(�6f   ]� 5      $
��True��6   .+�5      �� $ 
Horizontal=�6!   $
��0,20q�6:   .+�5      �� -   5        $��	AddButton��5   !   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��5      
������$	 All=�5      
������$��5q�5      ��5      �� 5   "   $ 
Horizontal=�6-   .+�5   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	AddCircle=�6>   �� 5    &   $
��10,0q�60   $	��Add��6>   6K   5!   #   5#      �� 5%      -   5        $��UpdateButton��5%   !   $ 5��5&      
�������
�������$	 All=�5)      
�������$��5q�5+      ��5,        5-   "   $ Update=�6:   5/      �� 51      -   5        $��DeleteButton��51   !   $ 5��52      
�������
�������$	 All=�55      
�������$��5q�57      ��58        59   "   $ Delete=�6:   5;      5=      �� 5?      $ 
Horizontal=�6!   $��Right=�6:   $��Right=�6Q   .+�5@      �� $
��From��6$   $��Center=�60   $
��Bold"�6K   
����p��$
��10,0q�6w   (  "System.Windows.Controls.DatePicker  5A      -   5        $��FromDatePicker��5A   %      IsTodayHighlighted$
 True��6<   4  .System.Windows.Automation.AutomationProperties   IsOffscreenBehavior$ Onscreen=�6V   	   CalendarStyle	 5B      �� 5C   "   
 �� 
TargetType&   System.Windows.Controls.Calendar"
  6(    " MaterialDesignCalendarPortrait �� BasedOn# [ 6>    �� 	Resources 5D   &     PrimaryHueMidBrush �� Color  PrimaryHueDarkBrush��%U   &	       &	 "     �� 5E   *   $ DeepPink��6U   �� 5F   *   $ Green��6V   5G   '   �5H   &   �� 5I   *    �� Property � �� �� Value
 �����6G   5K   #   5M      �� 5N      $��To��6$   $��Center=�6.   $
��Bold"�6I   
����p��$
��10,0q�6u     5O      -   5        $��ToDatePicker��5O   %   $
 True��69   	 5P      �� 5Q   "   "
  6(   # [ 6>    5R   &   ��%U   &	       &	 "     �� 5S   *   $ DeepPink��6U   �� 5T   *   $ Green��6V   5U   '   �5V   &   �� 5W   *    � ��
 �����6G   5Y   #   5[      �� 5]      -   5        $��FilterButton��5]   !   $
��10,0q�6P    . *MaterialDesignFloatingActionMiniDarkButton#��[ 5^      ��5_        5`   "   $ Filter=�6:   5b      5c      5d      5e      � 5f       � RowDefinitions 5g      �� 5h      $��* �6$   �� 5i      $
��Auto �6$   .+�5k      &	   System.Windows.Controls.DataGrid	  -   5         	 Name$ OrderDataGrid��5k   (   $��0��6    	  AutoGenerateColumns$ False��5l       	  ColumnHeaderHeight$ 30Q�61    	  HeadersVisibility$ Column=�6I    	  RowHeaderWidth$	 100Q�5m       	  CanUserResizeColumns$ False��5n      -
  'MaterialDesignThemes.Wpf.DataGridAssist 
  CornerRadius$ 20��5o      
�������$��1q�5q      " 	  VerticalScrollBarVisibility$ Hidden=�5r      $ 	  HorizontalScrollBarVisibility$ Hidden=�5s       	  GridLinesVisibility$
 None=�5t       	  CanUserAddRows$ False��5u       	  SelectionMode$ Single=�5v      $��0,0,0,10q�5w      $��7��6'      IsColumnHeader$
 True��6;    �� SelectedIndex$ -1��6f    	  CanUserDeleteRows$ False��6y     	  RowStyleSelector  5x      +  %System.Windows.Controls.StyleSelector  5y      ! 	  RowStyle! 5{      �� 5|      )  #System.Windows.Controls.DataGridRow"
  6    " �� Triggers" 5}      P� 5~   "   # P� Property# �@ 
IsSelected$ P� Value$
$ True��6@   . �5   &   ��  � ��
 ����6C   �� 5�   &    � ��
 �����6C   5�   #   5�      % J� Effect% 5�      3  -System.Windows.Media.Effects.DropShadowEffect  5�      & 	  HorizontalGridLinesBrush& 5�      �� 5�        
Primary100# �  6*   ' 	  VerticalGridLinesBrush' 5�      �� 5�      # �  6*   ( 	  Columns( 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      ,  &System.Windows.Controls.DataGridColumn)   Header$)   #ID��61   *   CellTemplate* 5�      �� 5�   "   .R�5�   &   �� $ 
Horizontal=�61   $��Center=�6J   .+�5�   *   �� $��5,0,0,0q�6H   ��64   �� *ID+6[   5�   '   5�   #   5�        5�      $)      Customer Name��61   * 5�      �� 5�   "   .R�5�   &   �� $ 
Horizontal=�61   $��Center=�6J   .+�5�   *   �� ��64   �� *CustomerName+6T   5�   '   5�   #   5�        5�      $)      Address��61   * 5�      �� 5�   "   .R�5�   &   �� $ 
Horizontal=�61   $��Center=�6J   .+�5�   *   �� ��64   �� *	Address+6O   5�   '   5�   #   5�        5�      $)     Order Date��61   * 5�      �� 5�   "   .R�5�   &   �� $ 
Horizontal=�61   $��Center=�6J   .+�5�   *     $ Calendar=�6B   $��0,2,0,0q�6R   �� 5�   *   $��5,0,0,0q�6O   ��64   �� *	OrderDate+6b   5�   '   5�   #   5�        5�      $)             Status��61   * 5�      �� 5�   "   .R�5�   &   �� $ 5��5�   !   
�������$	 All=�5�   !   
�������$��5q�5�   !   ��5�   *   �� 5�   .   $ 
Horizontal=�69   .+�5�   2   �� $
��10,0q�6<   
�������$��DemiBold"�6�   ��6J   �� *Status++ �� 	Converter#+ [  6�   5�   /   5�   '   5�   #   5�        5�      $) 
    Detail��61   * 5�      �� 5�   "   .R�5�   &   �� .+�5�   *   %  MaterialDesignThemes.Wpf.Badged  .��5�   .   �� , ��Name$, DetailButton��65   -	   5         3 /MaterialDesignFloatingActionMiniSecondaryButton#��[ 5�   .   ��5�   2     5�   6   $ EyeSettings=�6N   5�   /   5�   +   5�   '   5�   #   5�        5�      $) 	        #��61   * 5�      �� 5�   "   .R�5�   &   �� .+�5�   *     .��5�   .   �� $, 
SaveButton��65   -
   5         7 3MaterialDesignFloatingActionMiniSecondaryDarkButton#��[ 5�   1   ��5�   2     5�   6   $ ContentSave=�6N   5�   /   5�   +   5�   '   5�   #   5�      - 	  ColumnHeaderStyle- 5�      �� 5�      �5�      �� 5�   "    � ��
 �   �6E   �� 5�   "    � ��
 �����6I   �� 5�   "    � ��$ 30��6E   �� 5�   "    � ��$
 Bold"�6I   5�      5�      ]� 5�      $��1��6   $
��True��6)   .+�5�      �� $ 
Horizontal=�6!   $��Right=�6:   $��
20,10,0,10q�6R   $��Center=�6f   .+�5�      �� -   5        $, FirstButton��5�   !   $��<<��66   $��0,0,10,0q�6I    + 'MaterialDesignRaisedSecondaryDarkButton#��[ 5�   !   5�   !   �� 5�      -   5        $, PreviousButton��5�   !   $��<��5�   !   #��[ 5   !   5  !   �� 5     -   5        . ��Name$. CurrentPageText��5  $   $��1��6=   $��Center=�6F   $
��Bold"�6a   
�������/ �� Padding$/ 10,0,0,0q�6�   6�   �� 5     $
�� of ��6$   $��Center=�60   $
��Bold"�6K   
�������6r   �� 5     -   5        $. TotalPageText��5  $   $��20��6;   $��Center=�6E   $
��Bold"�6`   
�������$/ 0,0,10,0q�6�   6�   �� 5     -   5        $, 
NextButton��5  !   $��>��65   #��[ 5	  !   5
  !   �� 5     -   5        $, 
LastButton��5  !   $��>>��65   $��10,0,0,0q�6H   #��[ 5  !   5     5     5     5     5     5     