   M S B A M L   `   `   `  ����H  DProjectMyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProjectMyShop.ViewsProjectMyShop.Views  5      A%clr-namespace:ProjectMyShop.ConverterProjectMyShop.Converter  67   '    !ProjectMyShop.Views.ManageProduct   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -local!clr-namespace:ProjectMyShop.Views  5      2local1%clr-namespace:ProjectMyShop.Converter  67   -   5          N� Title$  ManageProduct��5
       � 	Resources 5      /  )ProjectMyShop.Converter.CurrencyConverter   currencyConverter/  )ProjectMyShop.Converter.AbsoluteConverter  absoluteConverter��%:   &	        &	        5   
   6#     5   
   6#   5      .��5      #  MaterialDesignThemes.Wpf.Card  
�������   UniformCornerRadius$ 10Q�6-   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowEdges$	 All=�6F   $��	10 10 0 0q�6t   .��5      ]� .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $	��Top=�6.   .+�5      �� -   5         ��Name$ ImportButton��5      $��0 0 10 0q�5      
������+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��5      ��5      �� 5      $ 
Horizontal=�6!   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Gear=�62   �� 5      $	��5 0q�6$   $��Import��61   5      5      �� 5      -   5        $��	AddButton��5      $��0 0 10 0q�5!      
������$ 5��5#      ��5%      �� 5&      $ 
Horizontal=�6!   .+�5'        $ 	AddCircle=�62   �� 5(      $	��Add��6$   $	��5 0q�6/   5)      5+      5,      � 5-   
   -   5        $��mainContainer��5-       � ColumnDefinitions 5.      �� 5/      $	��40* �6#   �� 50      $
��962* �6#   �� 51      $	��40* �6#   	 � RowDefinitions	 53      �� 54      $	��90* �6    �� 55      $	��75* �6    �� 56      $
��555* �6    �� 57      $	��58* �6    .+�59      � -   5        $��searchContainer��59      $��0��5:      $��2��5;      $��0��5<       5>      �� 5?      $
��660* �6'   �� 5@      $
��177* �6'   �� 5A      $
��145* �6'   .+�5D      (  "MaterialDesignThemes.Wpf.ColorZone  
   Mode$
 Custom=�6+   $��0, 0, 10, 0q�5E   '   ��5F   '   �� *ActualHeight+ �� ElementName$ searchContainer�� J� Effect 5H      3  -System.Windows.Media.Effects.DropShadowEffect  5I         
BlurRadius$ 10Q�6+      ShadowDepth$ 1Q�5J   '      Color$ 	LightGray��5K   '      Opacity$	 0.5Q�5L   '      RenderingBias$ Performance=�5M   '   .��5O        -   5        $��searchBoxContainer��5O   *   $	��380��5P   "   $��45��5Q   "   $ 23Q�5R   "      ShadowDepth$ Depth0=�5S   "   $��0��5T   "   .��5U      � -   5        $��searchContentCard��5U       5V      �� 5W   "   $	��50* �63   �� 5X   "   $
��670* �63   .+�5Z      �� -   5        $��searchButton��5Z   %   $ 20��5[   !   
������ $��0q�5]   !   $��0q�5^   !     MyPurpleGradient+	  %MaterialDesignThemes.Wpf.RippleAssist 	  Feedback# �  5_   !   $��40��5`   !   $��40��5a   !   .��5b   "     $ Search=�6:   $��25��6H   $��25��6S   
���   �6_   5c      �� 5d      -	   5        $��searchTextBox��5d   &   $��10q�5f   "   $��15(�5g   "   
���   �)
  #MaterialDesignThemes.Wpf.HintAssist 
  Hint$ Search your phone here...��5i   "   $��1��5j   "   5l      5m      5n        5q      $
 Custom=�6+   $��
0, 0, 0, 0q�5r   '   $��1��5t   '   ��5s   '   �� *ActualHeight+$ searchContainer�� 5u        5v      $ 10Q�6+   $ 1Q�5w   '   $ 	LightGray��5x   '   $	 0.5Q�5y   '   $ Performance=�5z   '   .��5~        -
   5        $��sortBoxContainer��5~   *   $��45��5   "   $ 23Q�5�   "   $ Depth0=�5�   "   $��0��5�   "   $��
0,0,-110,0q�62   .��5�      �� $ 
Horizontal=�6%   .+�5�      �� $
��From��6(   $��Center=�64   $
��Bold"�6O   
����p��$
��10,0q�6{   �� 5�      $��45��6&   $��30��61   $��0 6 0 0q�6=   $��0��6O   
���   �$��Center=�6k   �� 5�      $��To��6(   $��Center=�62   $
��Bold"�6M   
����p��$
��10,0q�6y   �� 5�      $��45��6&   $��30��61   $��0 6 0 0q�6=   $��0��6O   
���   �$��Center=�6k   �� 5�      -   5        $��FilterButton��5�   %   $��5 0 0 0q�6T    . *MaterialDesignFloatingActionMiniDarkButton#��[ 5�      ��5�   "     5�   &   $ Filter=�6>   5�      5�      5�      5�      5�      �� 5�      -   5         ��Name$ categoriesListView��5�      $��0 0 0 10q�63   $��Center=�6E   $��1��6b   $��1��6o   $��Hidden=�6�   ��5�      �� 5�      .R�5�      �  ! MaterialDesignLightBackground#���  6(   5�      ��5�      �� 5�      .R�5�      �� $ 
Horizontal=�6)   $��5 0 5 0q�6B   .+�5�   "   �� $��30��6(   $��30��63   ��6?   �� *Avatar+�� 5�   "   $��10 0 0 0q�6,    $  MaterialDesignSubtitle2TextBlock#���  6W   $��Center=�6�   ��6>   �� *	CatName+6�   5�      5�      5�      �� 5�      -   5        $��phonesListView��5�      $��2��6-   $��1��6:   $��Disabled=�6J   ��5�      �� 5�      .R�5�      � 5�       5�        phoneContextMenu m� Icon��%�   &	       �� 5�      
�������.@�5�      m� -   5        $
��Edit��5�   #    5�        5�   "   $ Pencil=�6:   5�      m� 5�      -   5        $��Delete��5�   #    5�        5�   "   $ TrashCan=�6:   5�      5�      5�      ��5�      �� 5�       �� 
TargetType" ��6   .�5�      ��  �� Property �@�ContextMenu �� Value# [ 68   5�      ��5�      �� 5�      .R�5�      � $	��300��6    5�      �� 5�   "   �� 5�   "   	 5�      �� 5�   "   �� 5�   "   �� 5�   "   .+�5�      ��  �� BitmapScalingMode$ HighQuality=�6$   $��2��6R   $��50��6c   $��50��6n   ��6z   �� *Avatar+�� 5�      $��0��6(   $��1��65    " MaterialDesignCaptionTextBlock#���  6`   ��6E   �� *	PhoneName+6`   �� 5�      $��1��6(   $��1��65    $  MaterialDesignSubtitle1TextBlock#���  6�   ��6E   �� *	SoldPrice+ �� 	Converter# [  6�   �� 5�      $��2��6(   $��1��65    !	 MaterialDesignHelperTextBlock#��� 	 6b   ��6E   �� *Description+6b   5�      5�      5�      �� 5�      $ 
Horizontal=�6   $��Center=�62   $��3��6O   $��1��6\   .+�5�      �� -   5        $ previousButton��5�      $��60��61   $��30��6<   $��<��6H   ${�False��6t   �� 5�      -   5        $��currentPagingTextBlock��5�      $��80��6:   $��0��6E    �� TextAlignment$ Center=�6N   $��Center=�6e   �� 5�      -   5        $ 
nextButton��5�      $��60��6-   $��30��68   $��>��6D   6S   5�      5�      5�      5�      5�      