   M S B A M L   `   `   `  ����H  DProjectMyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProjectMyShop.ViewsProjectMyShop.Views  5      A%clr-namespace:ProjectMyShop.ConverterProjectMyShop.Converter  67   +    %ProjectMyShop.Views.ManageDetailOrder   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -local!clr-namespace:ProjectMyShop.Views  5      2local1%clr-namespace:ProjectMyShop.Converter  67   -   5          � WindowStyle$
  None=�5
      $	��550��5      $	��700��5   	    � WindowStartupLocation$ CenterScreen=�5       � 	Resources 5      -  'ProjectMyShop.Converter.StatusConverter   statusConverter��%   &	          5   
   6;   5      .��5      #  MaterialDesignThemes.Wpf.Card  
�������   UniformCornerRadius$ 10Q�6-   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowEdges$	 All=�6F   $��20,20,20,30q�6t   .��5   
   ]� $
��True��6   .+�5      ��  �� Orientation$ Vertical=�6   $	��Top=�60   .+�5      �� $��Detail Order��6   $��Normal"�60   $��16(�6D   �� 5      $ 
Horizontal=�6   .+�5      �� $��Order #��6    $��DemiBold"�6/   
�������$��12(�6W   �� 5      -   5         ��Name$ OrderIDText��5       $��DemiBold"�6I   
�������$��12(�6q   ��65   �� *ID+6q   5      5      � 5      $��0,20,0,0q�6    � RowDefinitions 5      �� 5       $
��Auto �6$   �� 5!      $��* �6$   �� 5"      $
��Auto �6$    � ColumnDefinitions 5$      �� 5%      $��* �6'   .+�5'        
�������$ 10Q�69   $	 All=�6R   $��0��6�   $��10q�5(   &   
�������$��5q�6F   .��5)      ]� $
��True��6    .+�5+      �� $ Vertical=�6%   $	��Top=�6<   .+�5,      �� $��Order Overview��6(   $��DemiBold"�6>   
�������$��14(�6f   $��5,0,0,5q�6t   ]� 5-      $
��True��6(   .+�5.   "   �� $ Vertical=�6-   $
��Left=�6D   $	��250��6Z   .+�5/   &   �� $
��Auto��61   $ 
Horizontal=�6>   $
��Left=�6X   .+�50   *   �� $��Customer name ��60   $��Light"�6I   �� 51   *   -   5        	 ��Name$	 CustomerNameText��51   2   
 �� TextWrapping$

 Wrap=�6L   $	��120��6~   ��6`   �� *CustomerName+6�   52   '   �� 53   &   $
��Auto��61   $ 
Horizontal=�6>   $
��Left=�6W   .+�54   *   �� $��Address��60   $��92��6B   $��Light"�6M   �� 55   *   -   5        $	 AddressText��55   2   $

 Wrap=�6G   $	��120��6t   ��6[   �� *	Address+6t   56   '   �� 57   &   $
��Auto��61   $ 
Horizontal=�6>   $
��Left=�6W   .+�58   *   �� $��Voucher��60   $��92��6B   $��Light"�6M   �� 59   *   -   5        $	 Voucher��59   2   $

 Wrap=�6C   $
��None��6W   $	��120��6c    �� 
IsReadOnly$
 True��6o   5:   '   5;   #   �� 5<   "   $
��Auto��6-   $ Vertical=�6:   $��Right=�6Q   .+�5=   &   �� $
��Auto��61   $ 
Horizontal=�6>   $
��Left=�6W   .+�5>   *   �� $��Order date ��60   $��Light"�6F   (  "System.Windows.Controls.DatePicker  5?   *   -   5        $��OrderDatePicker��5?   5      IsTodayHighlighted$
 True��6M      CalendarStyle 5A   .   �� 5B   2    �� 
TargetType&   System.Windows.Controls.Calendar"  68    " MaterialDesignCalendarPortrait �� BasedOn# [ 6N    �� 	Resources 5C   6     PrimaryHueMidBrush �� Color  PrimaryHueDarkBrush��%U   &	       &	 "     �� 5D   :   $ DeepPink��6e   �� 5E   :   $ Green��6f   5F   7   �5G   6   �� 5H   :    �� Property � �� �� Value
 �����6W   5J   3   5L   +   5M   '   �� 5N   &   $
��Auto��61   $ 
Horizontal=�6>   $
��Left=�6W   .+�5O   *   �� $��68��60   $��Status ��6;   $��Light"�6M   �� 5P   *   -   5         ��Name$ StatusComboBox��5P   3    �� SelectedItem 6K   �� *Status+ �� BindsDirectlyToSource$
 True�� �� 	Converter# [   �� NotifyOnSourceUpdated$
 True�� �� NotifyOnTargetUpdated$
 True��5Q   +   5R   '   5S   #   5U      5V      5W      5X        5Y      
�������$ 10Q�69   $	 All=�6R   $��1��6�   $��10q�5Z   &   
�������$��5q�6F   .��5[      ]� $
��True��6    .+�5]      �� $ Vertical=�6%   $	��Top=�6<   .+�5^      �� $��
Phone List��6(   $��DemiBold"�6:   
�������$��14(�6b   $��5,0,0,5q�6p   �� 5_      $ 
Horizontal=�6)   $
��0,10q�6B   $
��Left=�6P   .+�5b   "   �� -   5        $��ChoosePhoneButton��5b   )   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��5c      
������$	 All=�5e      
������$��5q�5g      ��5h   &   �� 5i   *   $ 
Horizontal=�65   .+�5j   .   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	AddCircle=�6F   �� 5k   .   $
��10,0q�68   $	��Add��6F   6S   5l   +   5n   #   �� 5p   "   -	   5        $��UpdateButton��5p   )   $ 5��5q      
�������
�������$	 All=�5t      
�������$��5q�5v      ��5w   &     5x   *   $ Update=�6B   5z   #   �� 5|   "   -
   5        $��DeleteButton��5|   )   $ 5��5}      
�������
�������$	 All=�5�      
�������$��5q�5�      ��5�   &     5�   *   $ Delete=�6B   5�   #   5�      5�      � 5�      $��Bottom=�6    5�      �� 5�   "   $��* �60   �� 5�   "   $
��Auto �60   .+�5�      &   System.Windows.Controls.DataGrid  -   5          Name$ PhoneDataGrid��5�   '      AutoGenerateColumns$ False��6>      CanUserAddRows$
 True��6Z      
IsReadOnly$
 True��6p       RowStyleSelector  5�   "   +	  %System.Windows.Controls.StyleSelector	  5�   &   !   RowStyle! 5�   "   �� 5�   &   )
  #System.Windows.Controls.DataGridRow" 
 6,   " �� Triggers" 5�   *   P� 5�   .   # P� Property# �@
 
IsSelected$ P� Value$
$ True��6L   . �5�   2   ��  � ��
 ����6O   �� 5�   2    � ��
 �����6O   5�   /   5�   '   %   Columns% 5�   "   4  .System.Windows.Controls.DataGridTemplateColumn  5�   &   ,  &System.Windows.Controls.DataGridColumn&   Header$& Phone��6=   '   CellTemplate' 5�   *   �� 5�   .   .R�5�   2   �� $ 
Horizontal=�6=   $��Center=�6V   .+�5�   6   �� $��5,0,0,0q�6f   ��6@   �� ( �� Path$( Phone.PhoneName�6f   5�   3   5�   /   5�   '     5�   %   $& Price��6<   )   
IsReadOnly$
) True��6K   ' 5�   *   �� 5�   .   .R�5�   2   �� $ 
Horizontal=�6=   $��Center=�6V   .+�5�   2   �� $��5,0,0,0q�6b   ��6<   �� $( Phone.SoldPrice�6u   5�   3   5�   /   5�   '     5�   &   -   5        Quantity��$& Quantity��5�   O   ' 5�   .   �� 5�   2   .R�5�   2   �� $ 
Horizontal=�6=   $��Center=�6V   $��Center=�6q   .+�5�   6   �� $ QuantityTextBox��6@   $��5,0,0,0q�6s   ��6Y   �� *
Quantity+6s   5�   3   5�   3   5�   +     5�   *   $&       #��6A   ' 5�   *   �� 5�   .   .R�5�   2   �� $ 
Horizontal=�6=   .+�5�   6   �� * ��Name$* DeleteButton��6=   -   5        ��5�   :     5�   >   $ Trash=�6V   5�   7   5�   3   5�   /   5�   '   5�      5�      5�      5�      �� 5�      $ 
Horizontal=�6   $��3��66   $��Right=�6C   $��0,5,0,0q�6`   .+�5�      �� -   5        $��
SaveButton��5�      $ 5��5�      
������$	 All=�5�      
��������5�      �� 5�      $ 
Horizontal=�6)   .+�5�   "     $ ContentSave=�6:   �� 5�   "   $
��5,-2q�6,   $
��Save��6:   6H   5�      5�      �� 5�      -   5        $��ReturnButton��5�      $ 5��5�      
�������
�������$	 All=�5�      
�������$	��5,0q�5�      ��5�      �� 5�      $ 
Horizontal=�6)   .+�5�   "     $ KeyboardReturn=�6:   �� 5�   "   $
��5,-2q�6,   $��Return��6:   6J   5�      5�      5�      5�      5�      5�      5�      