   M S B A M L   `   `   `  ���� H  DProjectMyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProjectMyShop.ViewsProjectMyShop.Views  A%clr-namespace:ProjectMyShop.ConverterProjectMyShop.Converter  '    !ProjectMyShop.Views.ManageProduct   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -local!clr-namespace:ProjectMyShop.Views  2local1%clr-namespace:ProjectMyShop.Converter  -     N� Title$  ManageProduct�� � 	Resources /  )ProjectMyShop.Converter.CurrencyConverter   currencyConverter/  )ProjectMyShop.Converter.AbsoluteConverter  absoluteConverter��%   &	        &	          .��#  MaterialDesignThemes.Wpf.Card  
�������   UniformCornerRadius$ 10Q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowEdges$	 All=�$��	10 10 0 0q�.��]� .+���  �� Orientation$ 
Horizontal=�$	��Top=�.+��� -    ��Name$ ImportButton��$��0 0 10 0q�
������+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5������ $ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Gear=��� $	��5 0q�$��Import���� -   $��	AddButton��$��0 0 10 0q�
������$ 5������ $ 
Horizontal=�.+�  $ 	AddCircle=��� $	��Add��$	��5 0q�� -   $��mainContainer�� � ColumnDefinitions �� $	��40* ��� $
��962* ��� $	��40* �	 � RowDefinitions	 �� $	��90* ��� $
��120* ��� $
��555* ��� $	��58* �.+�� -   $��searchContainer��$��0��$��2��$��0�� �� $
��660* ��� $
��177* ��� $
��145* �.+�(  "MaterialDesignThemes.Wpf.ColorZone  
   Mode$
 Custom=�$��0, 0, 10, 0q����� *ActualHeight+ �� ElementName$ searchContainer�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   ShadowDepth$ 1Q�   Color$ 	LightGray��   Opacity$	 0.5Q�   RenderingBias$ Performance=�.��  -   $��searchBoxContainer��$	��380��$��45��$ 23Q�   ShadowDepth$ Depth0=�$��0��.��� -   $��searchContentCard�� �� $	��50* ��� $
��670* �.+��� -   $��searchButton��$ 20��
������ $��0q�$��0q�  MyPurpleGradient+	  %MaterialDesignThemes.Wpf.RippleAssist 	  Feedback# �  $��40��$��40��.��  $ Search=�$��25��$��25��
���   ��� -	   $��searchTextBox��$��10q�$��15(�
���   �)
  #MaterialDesignThemes.Wpf.HintAssist 
  Hint$ Search your phone here...��$��1��  $
 Custom=�$��
0, 0, 0, 0q�$��1������ *ActualHeight+$ searchContainer��   $ 10Q�$ 1Q�$ 	LightGray��$	 0.5Q�$ Performance=�.��  -
   $��sortBoxContainer��$��45��$ 23Q�$ Depth0=�$��0��$��
0,0,-110,0q�.���� $ 
Horizontal=�.+��� $
��From��$��Center=�$
��Bold"�
����p��$
��10,0q��� -   $��fromTextbox��$��45��$��30��$��0 6 0 0q�$��0��
���   �$��Center=��� $��To��$��Center=�$
��Bold"�
����p��$
��10,0q��� -   $��	toTextbox��$��45��$��30��$��0 6 0 0q�$��0��
���   �$��Center=��� -   $��FilterButton��$��5 0 0 0q� . *MaterialDesignFloatingActionMiniDarkButton#��[ ��  $ Filter=��� -    ��Name$ categoriesListView��$��0 0 0 10q�$��Center=�$��1��$��1��$��Visible=�  MaterialDesignListView#���  ���� .R��� $ 
Horizontal=����� .R�  
����p��$ 10Q�$	��100��$��25��$	 All=�.���� $ 
Horizontal=�$��5 0 5 0q�.+���  �� BitmapScalingMode$ HighQuality=�$��20��$��20������ *Avatar+�� 
�������   MaterialDesignBody2TextBlock#��[ $��5 0 0 0q�$��Center=����� *	CatName+�� -   $��phonesListView��$��2��$��1��$��Disabled=����� .R��    phoneContextMenu m� Icon��%w   &	       �� 
�������.@�m� -   $
��Edit��   $ Pencil=�m� -   $��Delete��   $ TrashCan=�����  �� 
TargetType" ��.���  �� Property �@�ContextMenu �� Value# [ ���� .R�� $	��300�� �� �� 	 �� �� �� .+��� $ HighQuality=�$��2��$��50��$��50������ *Avatar+�� $��0��$��1�� " MaterialDesignCaptionTextBlock#���  ���� *	PhoneName+�� $��1��$��1�� $  MaterialDesignSubtitle1TextBlock#���  ���� *	SoldPrice+ �� 	Converter# [  �� $��2��$��2��$��	30 10 0 0q� !	 MaterialDesignHelperTextBlock#��� 	 ���� *Description+�� $ 
Horizontal=�$��Center=�$��3��$��1��.+��� -   $ previousButton��$��60��$��30��$��<��${�False���� -   $��currentPagingTextBlock��$��80��$��0�� �� TextAlignment$ Center=�$��Center=��� -   $ 
nextButton��$��60��$��30��$��>��