   M S B A M L   `   `   `  ����H  DProjectMyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjectMyShopProjectMyShop  5   	       ProjectMyShop.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   'localclr-namespace:ProjectMyShop  5   	   -   5          � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ 
MainWindow��5
   	   $	��650��6   $
��1100��6)   .��5      � -   5         �Name$ layoutContainer��5       � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      $��1* �6   �� 5      $	��12* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $	��12* �6   .+�5   
   �� -   5        $��
background��5      $��3��5      $��3��5      $��UniformToFill=�5         
Background#���   5      �� 5   
   $��Center=�5      $��2��5       $��2��6!   $	��117��65   $��0,0,65,0q�6B   .+�5!      �� -   5         ��Name$
 logo��5!        Logo#���  5"      $	��117��60   $	��258��6=   5#      �� 5'   
   $��2��6   $��0,10,0,0q�6"   .+�5(      �� -   5         ��Name$ dashboardButton��5(        MyRedGradient#���  6M   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��6z   $��60��5)      ��5*      �� 5+       �� Orientation$ 
Horizontal=�6!   .+�5,      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$
	 Home=�62   $��25��6>   $��25��6I   �� 5-      $��Center=�6$   $��18(�6?   	Dashboard6X   5.      50      �� 51      -   5        $ categoriesButton��51        MyPinkGradient#���  6O   $ 5��6}   $��60��52      ��53      �� 54      $ 
Horizontal=�6!   .+�55        $	 Category=�62   $��25��6B   $��25��6M   �� 56      $��Center=�6$   $��18(�6?   Manage categories6`   57      59      �� 5:      -   5        $ productButton��5:      #���  6I   $ 5��6w   $��60��5;      ��5<      �� 5=      $ 
Horizontal=�6!   .+�5>        $	 Reproduction=�62   $��25��6F   $��25��6Q   �� 5?      $��Center=�6$   $��18(�6?   Manage products6^   5@      5B      �� 5C      -   5        $ orderButton��5C      #���  6E   $ 5��6s   $��60��5D      .��5E      �� $ 
Horizontal=�6   .+�5F        $	 Receipt=�6.   $��25��6=   $��25��6H   �� 5G      $��Center=�6    $��18(�6;   Manage orders6X   5H      5I      �� 5J      -	   5        $ 
statButton��5J      #���  6C   $ 5��6q   $��60��5K      .��5L      �� $ 
Horizontal=�6   .+�5M        $	 BarChart=�6.   $��25��6>   $��25��6I   �� 5N      $��Center=�6    $��18(�6;   	Statistic6T   5O      5P      �� 5Q      -
   5        $ configButton��5Q      #���  6F   $ 5��6t   $��60��5R      .��5S      �� $ 
Horizontal=�6   .+�5T        $
	 Gear=�6.   $��25��6:   $��25��6E   �� 5U      $��Center=�6    $��18(�6;   Configuration6X   5V      5W      5X       � 5[   
   -   5        $��pageNavigation��5[      
  � NavigationUIVisibility$
 Hidden=�5\      $��2��5^      $��2��5_      $��1��5`      $��	0,0,10,10q�6   5b      5c      5d      