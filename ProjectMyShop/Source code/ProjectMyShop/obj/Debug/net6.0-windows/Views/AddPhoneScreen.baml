   M S B A M L   `   `   `  ����H  DProjectMyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProjectMyShop.ViewsProjectMyShop.Views  5   	   (    "ProjectMyShop.Views.AddPhoneScreen   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -local!clr-namespace:ProjectMyShop.Views  5   	     � Title$  AddPhoneScreen��5	   	   $	��650��6    $	��800��6-   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��10* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��10* �6    � RowDefinitions 5   
   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   .+�5   
   �� -   5        $��categoryCombobox��5   B   $��1q�6   
����p��$	��100��6Z   $��35��6f   $��1��6�   $��2��6�   ��5      �� 5      .R�5      ��  �� Padding$ 5q�6    ��6,   �� *	CatName+5      5       �� 5"   
   -   5         ��Name$ chooseImageButton��5"      
������ $	��300��6e   $	��300��6q   $��1��6~   $��1��6�   $��4��6�   .��5#      �� -   5         ��Name$ avatar��5#       �� BitmapScalingMode$ HighQuality=�6$   ��6R   �� *Avatar+5$      �� 5%   
   -   5         ��Name$ phoneNameBox��5%   n   $��1q�6   
���� ��$��5q�6;   $��50��6G   $��2��6�   $��1��6�   $��10q�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Phone's name��6�    %  !MaterialDesignFloatingHintTextBox#��[  6�   ��6S   �� *	PhoneName+6�   �� 5&   
   -   5        $ manufacturerBox��5&   q   $��1q�6   
���� ��$��5q�6;   $��50��6G   $��2��6�   $��2��6�   $��10q�6�   $ Manufacturer��6�   #��[  6�   ��6S   �� *Manufacturer+6�   �� 5'   
   -   5        $ descriptionBox��5'   q   $��1q�6   
���� ��$��5q�6;   $	��150��6G   $��2��6�   $��3��6�   $��2��6�   $ Description��6�   #��[  6�   $��10q�6  ��6T   �� *Description+6  � 5(   
   $��5��6   $��1��6   $��2��6,    5)      �� 5*      $��1* �6#   �� 5+      $��1* �6#   �� 5,      $��1* �6#   .+�5.      �� -   5        $ stockBox��5.   n   $��1q�6   
���� ��$��5q�6?   $��50��6K   $��10q�6�   $ Stock��6�   #��[  6�   ��6W   �� *Stock+6�   �� 5/      -   5        $ boughtpriceBox��5/   �   $��1q�6   $��1��6*   
���� ��$��5q�6O   $��50��6[   $��10q�6�   $ Bought price��6�   #��[  6�   ��6g   �� *BoughtPrice+6�   �� 50      -	   5        $ soldpriceBox��50   �   $��1q�6   $��2��6*   
���� ��$��5q�6O   $��50��6[   $��10q�6�   $ 
Sold price��6�   #��[  6�   ��6g   �� *	SoldPrice+6�   51      �� 52   
   $��40��6   $��1��6!   $��6��61   $��2��6>   	 �� Orientation$	 
Horizontal=�6R   $��Center=�6k   .+�53      �� -
   5        $ cancelButton��53      $��Cancel��6F   $	��120��6W   $��0 0 20 0q�6c   �� 54      -   5        $ 	addButton��54      $��	Add phone��6@   $	��120��6T   $��20 0 0 0q�6`   55      56      57      