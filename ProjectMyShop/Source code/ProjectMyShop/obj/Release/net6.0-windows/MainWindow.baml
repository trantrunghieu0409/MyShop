   M S B A M L   `   `   `  ���� H  DProjectMyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjectMyShopProjectMyShop      ProjectMyShop.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  'localclr-namespace:ProjectMyShop  -     � WindowStartupLocation$  CenterScreen=� � Title$ 
MainWindow��$	��650��$
��1100��.��� -    �Name$ layoutContainer�� � ColumnDefinitions �� $��4* ��� $��1* ��� $	��12* � � RowDefinitions �� $��1* ��� $��2* ��� $	��12* �.+��� -   $��
background��$��3��$��3��$��UniformToFill=�   
Background#���   �� $��Center=�$��2��$��2��$	��117��$��0,0,65,0q�.+��� -    ��Name$
 logo��  Logo#���  $	��117��$	��258���� $��2��$��0,10,0,0q�.+��� -    ��Name$ dashboardButton��  MyPinkGradient#���  +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��$��60������  �� Orientation$ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$
	 Home=�$��25��$��25���� $��Center=�$��18(�	Dashboard�� -   $ categoriesButton��#���  $ 5��$��60������ $ 
Horizontal=�.+�  $	 Category=�$��25��$��25���� $��Center=�$��18(�Manage categories�� -   $ productButton��#���  $ 5��$��60������ $ 
Horizontal=�.+�  $	 Reproduction=�$��25��$��25���� $��Center=�$��18(�Manage products�� -   $ orderButton��#���  $ 5��$��60��.���� $ 
Horizontal=�.+�  $	 Receipt=�$��25��$��25���� $��Center=�$��18(�Manage orders�� -	   $ 
statButton��#���  $ 5��$��60��.���� $ 
Horizontal=�.+�  $	 BarChart=�$��25��$��25���� $��Center=�$��18(�	Statistic�� -
   $ configButton��#���  $ 5��$��60��.���� $ 
Horizontal=�.+�  $
	 Gear=�$��25��$��25���� $��Center=�$��18(�Configuration � -   $��pageNavigation��
  � NavigationUIVisibility$
 Hidden=�$��2��$��2��$��1��$��	0,0,10,10q�