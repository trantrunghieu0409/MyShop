   M S B A M L   `   `   `  ���� H  DProjectMyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProjectMyShop.ViewsProjectMyShop.Views  #    ProjectMyShop.Views.Dashboard   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:ProjectMyShop.Views     _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     N� Title$  	Dashboard��.���  � ColumnDefinitions �� $��1* ��� $��1* ��� $��1* � � RowDefinitions �� $��1* ��� $��5* ��� $	��10* �.+�#  MaterialDesignThemes.Wpf.Card  -   $��currentTotalPhone��$��1��$	��200��$	��100��   MyPurpleGradient#���   $	��Top=�   UniformCornerRadius$ 10Q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�$��Center=�.��� $��10q�.+��� .+��� $��Total phones��
������� $  MaterialDesignSubtitle2TextBlock#��[ �� -    ��Name$ 	SumPhones��
������� $  MaterialDesignSubtitle1TextBlock#��[ ���� *
totalPhone+'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	Cellphone=�$��50��$��0, 0, 10, 10q�$��Bottom=�$��Right=�
�������$��50��  $��1��$��1��$	��200��$	��100��  MyBlueGradient#���  $	��Top=�$ 10Q�$ Depth1=�$��Center=�.��� $��10q�.+��� .+��� $��Week Orders��
�������#��[ �� -   $ SumWeekOrders��
�������#��[ ���� *	weekOrder+  $ Receipt=�$��50��$��50��$��0, 0, 10, 10q�$��Bottom=�$��Right=�
�������  $��1��$��2��$	��200��$	��100��  MyYellowGradient#���  $	��Top=�$ 10Q�$ Depth1=�$��Center=�.��� $��20q�.+��� .+��� $��Month Orders��
�������#��[ �� -   $ SumMonthOrders��
�������#��[ ���� *
monthOrder+  $ Receipt=�$��50��$��50��$��0, 0, 10, 10q�$��Bottom=�$��Right=�
��������� $��2��$��3��.+��� $'��!Top 5 phone (nearly) out of stock�� �� Padding$ 10 0 0 0q�$��20(�
����p��
�������&   System.Windows.Controls.DataGrid  -     Name$ PhoneDataGrid��$��0��	   AutoGenerateColumns$	 False��
   ColumnHeaderHeight$
 30Q�   HeadersVisibility$ Column=�   RowHeaderWidth$	 100Q�   CanUserResizeColumns$ False��
�������$��1q�"   VerticalScrollBarVisibility$ Hidden=�$   HorizontalScrollBarVisibility$ Hidden=�   CanUserAddRows$ False��   GridLinesVisibility$
 None=�   HorizontalGridLinesBrush
 �����   SelectionMode$ Single=�4  .System.Windows.Automation.AutomationProperties   IsColumnHeader$
 True�� �� SelectedIndex$ -1��   CanUserDeleteRows$ False��   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$   #ID��   
IsReadOnly$
 True��   CellTemplate �� .R���  �� Orientation$ 
Horizontal=�$��Center=�.+��� $��5,0,0,0q����� *ID+  $        Phone Name��$
 True�� �� .R��� $ 
Horizontal=�$��Center=�.+��� ���� *	PhoneName+  $      Manufacturer��$
 True�� �� .R��� $ 
Horizontal=�$��Center=�.+��� ���� *Manufacturer+  $         Sold price��$
 True�� �� .R��� $ 
Horizontal=�$��Center=�.+��� $��5,0,0,0q����� *	SoldPrice+  $          Stock��$
 True�� �� .R��� $ 
Horizontal=�.+��� $
��10,0q�$��DemiBold"����� *Stock+  $ 	        #�� �� .R��� .+�%  MaterialDesignThemes.Wpf.Badged  .����  ��Name$ 	AddButton��-    7 3MaterialDesignFloatingActionMiniSecondaryDarkButton#��[ ��  $ AddBox=�   RowStyle �� ���  �� Property � �� �� Value$ Normal"�    ColumnHeaderStyle  �� ���  � ��
 �   ���  � ��
 �������  �@��Padding$
 10,0q���  � ��$ 30����  � ��$
 Bold"�