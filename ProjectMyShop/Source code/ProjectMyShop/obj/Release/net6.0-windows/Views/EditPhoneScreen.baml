   M S B A M L   `   `   `  ���� H  DProjectMyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProjectMyShop.ViewsProjectMyShop.Views  A%clr-namespace:ProjectMyShop.ConverterProjectMyShop.Converter  )    #ProjectMyShop.Views.EditPhoneScreen   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -local!clr-namespace:ProjectMyShop.Views  2local1%clr-namespace:ProjectMyShop.Converter    � Title$  EditPhoneScreen��$	��650��$	��800�� � 	Resources /  )ProjectMyShop.Converter.CurrencyConverter   currencyConverter �� 
TargetType  ImageButtonStyle �� Property �� Value �� 
TargetType��%I   &	        &	        �� " ��.���  � �� �� " ��.R��� .���  � ColumnDefinitions �� $	��10* ��� $	��50* ��� $	��50* ��� $	��10* � � RowDefinitions �� $	��10* ��� $	��10* ��� $	��10* ��� $	��10* ��� $	��10* ��� $	��10* ��� $	��10* �.+��� -   #��[ $	��300��$	��300��$��0��$��1��$��4��.���� -    ��Name$ avatar��	 �� BitmapScalingMode$	 HighQuality=����� *Avatar+�� -   
 ��Name$
 phoneNameBox��$��1q�
���� ��$��5q�$��50��$��2��$��0��$��10q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Phone's name�� % !MaterialDesignFloatingHintTextBox#��[ ���� *	PhoneName+�� -   $
 manufacturerBox��$��1q�
���� ��$��5q�$��50��$��2��$��1��$��10q�$ Manufacturer��#��[ ���� *Manufacturer+�� -   $
 descriptionBox��$��1q�
���� ��$��5q�$	��150��$��2��$��2��$��2��$ Description��#��[ $��10q����� *Description+� $��4��$��1��$��2�� �� $��1* ��� $��1* ��� $��1* �.+��� -   $
 stockBox��$��1q�
���� ��$��5q�$��50��$��10q�$ Stock��#��[ ���� *Stock+�� -   $
 boughtpriceBox��$��1q�$��1��
���� ��$��5q�$��50��$��10q�$ Bought price��#��[ ���� *BoughtPrice+�� -   $
 soldpriceBox��$��1q�$��2��
���� ��$��5q�$��50��$��10q�$ 
Sold price��#��[ ���� *	SoldPrice+�� $��40�� �� Orientation$ 
Horizontal=�$��5��$��1��$��2��$��Center=�.+��� -	    ��Name$ 
editButton��$
��Edit��$	��120��$��Center=�$��0 0 20 0q��� -
   $ cancelButton��$��Cancel��$	��120��$��Center=�