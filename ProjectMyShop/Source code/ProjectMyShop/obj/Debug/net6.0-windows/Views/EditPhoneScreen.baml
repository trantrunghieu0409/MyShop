   M S B A M L   `   `   `  ����H  DProjectMyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProjectMyShop.ViewsProjectMyShop.Views  5   	   A%clr-namespace:ProjectMyShop.ConverterProjectMyShop.Converter  69   )    #ProjectMyShop.Views.EditPhoneScreen   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -local!clr-namespace:ProjectMyShop.Views  5   	   2local1%clr-namespace:ProjectMyShop.Converter  69     � Title$  EditPhoneScreen��5	   	   $	��650��6!   $	��800��6.    � 	Resources 5
      /  )ProjectMyShop.Converter.CurrencyConverter   currencyConverter �� 
TargetType  ImageButtonStyle �� Property �� Value �� 
TargetType��%�   &	        &	        5   
   6#   �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� 5      5      5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��10* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��10* �6    � RowDefinitions 5   
   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5       $	��10* �6   �� 5!      $	��10* �6   �� 5"      $	��10* �6   �� 5#      $	��10* �6   �� 5$      $	��10* �6   .+�5&   
   �� -   5        #��[ 5&      $	��300��6U   $	��300��6a   $��0��6n   $��1��6{   $��4��6�   .��5'      �� -   5         ��Name$ avatar��5'      	 �� BitmapScalingMode$	 HighQuality=�6$   ��6R   �� *Avatar+5(      �� 5)   
   -   5        
 ��Name$
 phoneNameBox��5)   n   $��1q�6   
���� ��$��5q�6;   $��50��6G   $��2��6�   $��0��6�   $��10q�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Phone's name��6�    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6S   �� *	PhoneName+6�   �� 5*   
   -   5        $
 manufacturerBox��5*   q   $��1q�6   
���� ��$��5q�6;   $��50��6G   $��2��6�   $��1��6�   $��10q�6�   $ Manufacturer��6�   #��[ 6�   ��6S   �� *Manufacturer+6�   �� 5+   
   -   5        $
 descriptionBox��5+   q   $��1q�6   
���� ��$��5q�6;   $	��150��6G   $��2��6�   $��2��6�   $��2��6�   $ Description��6�   #��[ 6�   $��10q�6  ��6T   �� *Description+6  � 5,   
   $��4��6   $��1��6   $��2��6,    5-      �� 5.      $��1* �6#   �� 5/      $��1* �6#   �� 50      $��1* �6#   .+�52      �� -   5        $
 stockBox��52   n   $��1q�6   
���� ��$��5q�6?   $��50��6K   $��10q�6�   $ Stock��6�   #��[ 6�   ��6W   �� *Stock+6�   �� 53      -   5        $
 boughtpriceBox��53   �   $��1q�6   $��1��6*   
���� ��$��5q�6O   $��50��6[   $��10q�6�   $ Bought price��6�   #��[ 6�   ��6g   �� *BoughtPrice+6�   �� 54      -   5        $
 soldpriceBox��54   �   $��1q�6   $��2��6*   
���� ��$��5q�6O   $��50��6[   $��10q�6�   $ 
Sold price��6�   #��[ 6�   ��6g   �� *	SoldPrice+6�   55      �� 56   
   $��40��6    �� Orientation$ 
Horizontal=�6!   $��5��6:   $��1��6G   $��2��6W   $��Center=�6k   .+�57      �� -	   5         ��Name$ 
editButton��57      $
��Edit��6B   $	��120��6Q   $��Center=�6]   $��0 0 20 0q�6z   �� 58      -
   5        $ cancelButton��58      $��Cancel��6F   $	��120��6W   $��Center=�6c   59      5:      5;      