   M S B A M L   `   `   `  ����H  DProjectMyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProjectMyShop.ViewsProjectMyShop.Views  5      #    ProjectMyShop.Views.Dashboard   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:ProjectMyShop.Views     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5          N� Title$  	Dashboard��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��5* �6   �� 5      $	��10* �6   .+�5   
   #  MaterialDesignThemes.Wpf.Card  -   5        $��currentTotalPhone��5      $��1��5      $	��200��5      $	��100��5         MyPurpleGradient#���   5      $	��Top=�5         UniformCornerRadius$ 10Q�5       +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5!      $��Center=�5"      .��5$      � $��10q�6   .+�5%      �� .+�5&      �� $��Total phones��6    
������� $  MaterialDesignSubtitle2TextBlock#��[ 5(   $   �� 5,      -   5         ��Name$ 	SumPhones��5,       
������� $  MaterialDesignSubtitle1TextBlock#��[ 5/   $   ��5-   !   �� *
totalPhone+5/   $   51      '  !MaterialDesignThemes.Wpf.PackIcon  52         Kind$ 	Cellphone=�6*   $��50��6;   $��0, 0, 10, 10q�6F   $��Bottom=�6\   $��Right=�53      
�������$��50��54      56      58        59   
   $��1��5:      $��1��5;      $	��200��5<      $	��100��5=        MyBlueGradient#���  5>      $	��Top=�5?      $ 10Q�5@      $ Depth1=�5A      $��Center=�5B      .��5D      � $��10q�6   .+�5E      �� .+�5F      �� $��Week Orders��6    
�������#��[ 5H   $   �� 5L      -   5        $ SumWeekOrders��5L       
�������#��[ 5O   $   ��5M   !   �� *	weekOrder+5O   $   5R        5T      $ Receipt=�6*   $��50��69   $��50��6D   $��0, 0, 10, 10q�6P   $��Bottom=�6f   $��Right=�5U      
�������65   5W      5Y        5[   
   $��1��5\      $��2��5]      $	��200��5^      $	��100��5_        MyYellowGradient#���  5`      $	��Top=�5a      $ 10Q�5b      $ Depth1=�5c      $��Center=�5d      .��5f      � $��20q�6   .+�5g      �� .+�5h      �� $��Month Orders��6    
�������#��[ 5j   $   �� 5n      -   5        $ SumMonthOrders��5n       
�������#��[ 5q   $   ��5o   !   �� *
monthOrder+5q   $   5t        5v      $ Receipt=�6*   $��50��69   $��50��6D   $��0, 0, 10, 10q�6P   $��Bottom=�6f   $��Right=�5w      
�������65   5y      5{      �� 5|   
   $��2��6   $��3��6"   .+�5}      �� $'��!Top 5 phone (nearly) out of stock��6    �� Padding$ 10 0 0 0q�6A   $��20(�6T   
����p��
�������6|   &   System.Windows.Controls.DataGrid  5~      -   5          Name$ PhoneDataGrid��5~   $   $��0��6   	   AutoGenerateColumns$	 False��5      
   ColumnHeaderHeight$
 30Q�61      HeadersVisibility$ Column=�6I      RowHeaderWidth$	 100Q�5�         CanUserResizeColumns$ False��5�      
�������$��1q�5�      "   VerticalScrollBarVisibility$ Hidden=�5�      $   HorizontalScrollBarVisibility$ Hidden=�5�         CanUserAddRows$ False��5�         GridLinesVisibility$
 None=�5�         HorizontalGridLinesBrush
 �����   SelectionMode$ Single=�5�      4  .System.Windows.Automation.AutomationProperties   IsColumnHeader$
 True��5�       �� SelectedIndex$ -1��6B      CanUserDeleteRows$ False��6U      Columns 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$   #ID��6-      
IsReadOnly$
 True��6<      CellTemplate 5�      �� 5�      .R�5�   "   ��  �� Orientation$ 
Horizontal=�6-   $��Center=�6F   .+�5�   &   �� $��5,0,0,0q�6D   ��60   �� *ID+6W   5�   #   5�      5�        5�      $        Phone Name��6-   $
 True��6H    5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   $��Center=�6F   .+�5�   &   �� ��60   �� *	PhoneName+6M   5�   #   5�      5�        5�      $      Manufacturer��6-   $
 True��5�   )    5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   $��Center=�6F   .+�5�   &   �� ��60   �� *Manufacturer+6P   5�   #   5�      5�        5�      $         Sold price��6-   $
 True��5�   )    5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   $��Center=�6F   .+�5�   &   �� $��5,0,0,0q�6K   ��60   �� *	SoldPrice+6^   5�   #   5�      5�        5�      $          Stock��6-   $
 True��5�   )    5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   �� $
��10,0q�60   $��DemiBold"�6U   ��6>   �� *Stock+6U   5�   #   5�      5�        5�      $ 	        #��6-    5�      �� 5�      .R�5�   "   �� .+�5�   &   %  MaterialDesignThemes.Wpf.Badged  .��5�   *   ��  ��Name$ 	AddButton��61   -   5         7 3MaterialDesignFloatingActionMiniSecondaryDarkButton#��[ 5�   %   ��5�   .     5�   2   $ AddBox=�6J   5�   +   5�   '   5�   #   5�      5�         RowStyle 5�      �� 5�      �5�      �� 5�       �� Property � �� �� Value$ Normal"�6E   6V   5�          ColumnHeaderStyle  5�      �� 5�      �5�      �� 5�       � ��
 �   �6A   �� 5�       � ��
 �����6E   �� 5�       �@��Padding$
 10,0q�6B   �� 5�       � ��$ 30��6A   �� 5�       � ��$
 Bold"�6E   5�      5�      5�      5�      5�      