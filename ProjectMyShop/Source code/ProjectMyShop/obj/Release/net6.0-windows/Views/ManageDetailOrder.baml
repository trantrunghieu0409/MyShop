   M S B A M L   `   `   `  ���� H  DProjectMyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProjectMyShop.ViewsProjectMyShop.Views  A%clr-namespace:ProjectMyShop.ConverterProjectMyShop.Converter  +    %ProjectMyShop.Views.ManageDetailOrder   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -local!clr-namespace:ProjectMyShop.Views  2local1%clr-namespace:ProjectMyShop.Converter  -     � WindowStyle$
  None=�$	��550��$	��700�� � WindowStartupLocation$ CenterScreen=� � 	Resources -  'ProjectMyShop.Converter.StatusConverter   statusConverter��%   &	          .��#  MaterialDesignThemes.Wpf.Card  
�������   UniformCornerRadius$ 10Q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowEdges$	 All=�$��20,20,20,30q�.��]� $
��True��.+���  �� Orientation$ Vertical=�$	��Top=�.+��� $��Detail Order��$��Normal"�$��16(��� $ 
Horizontal=�.+��� $��Order #��$��DemiBold"�
�������$��12(��� -    ��Name$ OrderIDText��$��DemiBold"�
�������$��12(����� *ID+� $��0,20,0,0q� � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto � � ColumnDefinitions �� $��* �.+�  
�������$ 10Q�$	 All=�$��0��$��10q�
�������$��5q�.��]� $
��True��.+��� $ Vertical=�$	��Top=�.+��� $��Order Overview��$��DemiBold"�
�������$��14(�$��5,0,0,5q�]� $
��True��.+��� $ Vertical=�$
��Left=�$	��250��.+��� $
��Auto��$ 
Horizontal=�$
��Left=�.+��� $��Customer name ��$��Light"��� -   	 ��Name$	 CustomerNameText��
 �� TextWrapping$

 Wrap=�$	��120������ *CustomerName+�� $
��Auto��$ 
Horizontal=�$
��Left=�.+��� $��Address��$��92��$��Light"��� -   $	 AddressText��$

 Wrap=�$	��120������ *	Address+�� $
��Auto��$ 
Horizontal=�$
��Left=�.+��� $��Voucher��$��92��$��Light"��� -   $	 Voucher��$

 Wrap=�$
��None��$	��120�� �� 
IsReadOnly$
 True���� $
��Auto��$ Vertical=�$��Right=�.+��� $
��Auto��$ 
Horizontal=�$
��Left=�.+��� $��Order date ��$��Light"�(  "System.Windows.Controls.DatePicker  -   $��OrderDatePicker��   IsTodayHighlighted$
 True��   CalendarStyle ��  �� 
TargetType&   System.Windows.Controls.Calendar"   " MaterialDesignCalendarPortrait �� BasedOn# [  �� 	Resources   PrimaryHueMidBrush �� Color  PrimaryHueDarkBrush��%9   &	       &	      �� $ DeepPink���� $ Green�����  �� Property � �� �� Value
 ������� $
��Auto��$ 
Horizontal=�$
��Left=�.+��� $��68��$��Status ��$��Light"��� -    ��Name$ StatusComboBox�� �� SelectedItem �� *Status+ �� BindsDirectlyToSource$
 True�� �� 	Converter# [   �� NotifyOnSourceUpdated$
 True�� �� NotifyOnTargetUpdated$
 True��  
�������$ 10Q�$	 All=�$��1��$��10q�
�������$��5q�.��]� $
��True��.+��� $ Vertical=�$	��Top=�.+��� $��
Phone List��$��DemiBold"�
�������$��14(�$��5,0,0,5q��� $ 
Horizontal=�$
��0,10q�$
��Left=�.+��� -   $��ChoosePhoneButton��+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��
������$	 All=�
������$��5q����� $ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	AddCircle=��� $
��10,0q�$	��Add���� -	   $��UpdateButton��$ 5��
�������
�������$	 All=�
�������$��5q���  $ Update=��� -
   $��DeleteButton��$ 5��
�������
�������$	 All=�
�������$��5q���  $ Delete=�� $��Bottom=� �� $��* ��� $
��Auto �.+�&   System.Windows.Controls.DataGrid  -     Name$ PhoneDataGrid��   AutoGenerateColumns$ False��   CanUserAddRows$
 True��   
IsReadOnly$
 True��    RowStyleSelector  +	  %System.Windows.Controls.StyleSelector	  !   RowStyle! �� )
  #System.Windows.Controls.DataGridRow" 
 " �� Triggers" P� # P� Property# �@
 
IsSelected$ P� Value$
$ True��. ���  � ��
 ������  � ��
 �����%   Columns% 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn&   Header$& Phone��'   CellTemplate' �� .R��� $ 
Horizontal=�$��Center=�.+��� $��5,0,0,0q����� ( �� Path$( Phone.PhoneName�  $& Price��)   
IsReadOnly$
) True��' �� .R��� $ 
Horizontal=�$��Center=�.+��� $��5,0,0,0q����� $( Phone.SoldPrice�  -   Quantity��$& Quantity��' �� .R��� $ 
Horizontal=�$��Center=�$��Center=�.+��� $ QuantityTextBox��$��5,0,0,0q����� *
Quantity+  $&       #��' �� .R��� $ 
Horizontal=�.+��� * ��Name$* DeleteButton��-   ��  $ Trash=��� $ 
Horizontal=�$��3��$��Right=�$��0,5,0,0q�.+��� -   $��
SaveButton��$ 5��
������$	 All=�
���������� $ 
Horizontal=�.+�  $ ContentSave=��� $
��5,-2q�$
��Save���� -   $��ReturnButton��$ 5��
�������
�������$	 All=�
�������$	��5,0q����� $ 
Horizontal=�.+�  $ KeyboardReturn=��� $
��5,-2q�$��Return��