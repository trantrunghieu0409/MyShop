   M S B A M L   `   `   `  ���� H  DProjectMyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProjectMyShop.ViewsProjectMyShop.Views  A%clr-namespace:ProjectMyShop.ConverterProjectMyShop.Converter  %    ProjectMyShop.Views.ManageOrder   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -local!clr-namespace:ProjectMyShop.Views  2local1%clr-namespace:ProjectMyShop.Converter  -     N� Title$  ManageOrder�� � 	Resources -  'ProjectMyShop.Converter.StatusConverter   statusConverter��%   &	          .��#  MaterialDesignThemes.Wpf.Card  
�������   UniformCornerRadius$ 10Q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowEdges$	 All=�$��20,20,20,30q�.��]� $
��True��.+���  �� Orientation$ Vertical=�$	��Top=�.+��� $��Order status��$��Normal"�$��16(��� $ ��Overview of Lastest Orders��$��DemiBold"�
�������$��12(�]� $
��True��.+��� $ 
Horizontal=�$
��0,20q�.+��� -   $��	AddButton��+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��
������$	 All=�
������$��5q����� $ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	AddCircle=��� $
��10,0q�$	��Add���� -   $��UpdateButton��$ 5��
�������
�������$	 All=�
�������$��5q���  $ Update=��� -   $��DeleteButton��$ 5��
�������
�������$	 All=�
�������$��5q���  $ Delete=��� $ 
Horizontal=�$��Right=�$��Right=�.+��� $
��From��$��Center=�$
��Bold"�
����p��$
��10,0q�(  "System.Windows.Controls.DatePicker  -   $��FromDatePicker��   IsTodayHighlighted$
 True��4  .System.Windows.Automation.AutomationProperties   IsOffscreenBehavior$ Onscreen=�	   CalendarStyle	 �� 
 �� 
TargetType&   System.Windows.Controls.Calendar"
   " MaterialDesignCalendarPortrait �� BasedOn# [  �� 	Resources   PrimaryHueMidBrush �� Color  PrimaryHueDarkBrush��%9   &	       &	      �� $ DeepPink���� $ Green�����  �� Property � �� �� Value
 ������� $��To��$��Center=�$
��Bold"�
����p��$
��10,0q�  -   $��ToDatePicker��$
 True��	 �� "
  # [  ��%9   &	       &	      �� $ DeepPink���� $ Green�����  � ��
 ������� -   $��FilterButton��$
��10,0q� . *MaterialDesignFloatingActionMiniDarkButton#��[ ��  $ Filter=��  � RowDefinitions �� $��* ��� $
��Auto �.+�&	   System.Windows.Controls.DataGrid	  -    	 Name$ OrderDataGrid��$��0�� 	  AutoGenerateColumns$ False�� 	  ColumnHeaderHeight$ 30Q� 	  HeadersVisibility$ Column=� 	  RowHeaderWidth$	 100Q� 	  CanUserResizeColumns$ False��-
  'MaterialDesignThemes.Wpf.DataGridAssist 
  CornerRadius$ 20��
�������$��1q�" 	  VerticalScrollBarVisibility$ Hidden=�$ 	  HorizontalScrollBarVisibility$ Hidden=� 	  GridLinesVisibility$
 None=� 	  CanUserAddRows$ False�� 	  SelectionMode$ Single=�$��0,0,0,10q�$��7��   IsColumnHeader$
 True�� �� SelectedIndex$ -1�� 	  CanUserDeleteRows$ False��  	  RowStyleSelector  +  %System.Windows.Controls.StyleSelector  ! 	  RowStyle! �� )  #System.Windows.Controls.DataGridRow"
  " �� Triggers" P� # P� Property# �@ 
IsSelected$ P� Value$
$ True��. ���  � ��
 ������  � ��
 �����% J� Effect% 3  -System.Windows.Media.Effects.DropShadowEffect  & 	  HorizontalGridLinesBrush& ��   
Primary100# �  ' 	  VerticalGridLinesBrush' �� # �  ( 	  Columns( 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn)   Header$)   #ID��*   CellTemplate* �� .R��� $ 
Horizontal=�$��Center=�.+��� $��5,0,0,0q����� *ID+  $)      Customer Name��* �� .R��� $ 
Horizontal=�$��Center=�.+��� ���� *CustomerName+  $)      Address��* �� .R��� $ 
Horizontal=�$��Center=�.+��� ���� *	Address+  $)     Order Date��* �� .R��� $ 
Horizontal=�$��Center=�.+�  $ Calendar=�$��0,2,0,0q��� $��5,0,0,0q����� *	OrderDate+  $)             Status��* �� .R��� $ 5��
�������$	 All=�
�������$��5q����� $ 
Horizontal=�.+��� $
��10,0q�
�������$��DemiBold"����� *Status++ �� 	Converter#+ [    $) 
    Detail��* �� .R��� .+�%  MaterialDesignThemes.Wpf.Badged  .���� , ��Name$, DetailButton��-	    3 /MaterialDesignFloatingActionMiniSecondaryButton#��[ ��  $ EyeSettings=�- 	  ColumnHeaderStyle- �� ���  � ��
 �   ���  � ��
 �������  � ��$ 30����  � ��$
 Bold"�]� $��1��$
��True��.+��� $ 
Horizontal=�$��Right=�$��
20,10,0,10q�$��Center=�.+��� -
   $, FirstButton��$��<<��$��0,0,10,0q� + 'MaterialDesignRaisedSecondaryDarkButton#��[ �� -   $, PreviousButton��$��<��#��[ �� -   . ��Name$. CurrentPageText��$��1��$��Center=�$
��Bold"�
�������/ �� Padding$/ 10,0,0,0q��� $
�� of ��$��Center=�$
��Bold"�
��������� -   $. TotalPageText��$��20��$��Center=�$
��Bold"�
�������$/ 0,0,10,0q��� -   $, 
NextButton��$��>��#��[ �� -   $, 
LastButton��$��>>��$��10,0,0,0q�#��[ 