   M S B A M L   `   `   `  ����H  DProjectMyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProjectMyShop.ViewsProjectMyShop.Views  5   	   5clr-namespace:ProjectMyShop.DTOProjectMyShop.DTO  69       ProjectMyShop.Views.Login   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -local!clr-namespace:ProjectMyShop.Views  5   	   )dtoclr-namespace:ProjectMyShop.DTO  69   -   5          � Title$  Login��5	   	   $	��500��6   $	��350��6$    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   $��Segoe UI Emoji)�5   	   .��5      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF2281D1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ 	#FF33288B��6#   $ 0.546Q�65   5      5      �� 5   
   $	��280��6   $	��240��6    $��Bottom=�6-   $
��0,80q�6H    �� RadiusY$ 10��6V    �� RadiusX$ 10��6c   
�������	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   
BlurRadius$
 15Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5      � 5   
   $��Bottom=�6   $��35,80q�6*   $	��240��69   .+�5       �� $��LOGIN��6   $��Center=�6$   $	��Top=�6A   $��5q�6Y   
�������$��18(�6v   �� 5!      $��Center=�6   $��15q�64   .+�5"      �� -   5         ��Name$ TextBoxEmail��5"      $
��0,10q�60   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Email��6>    %  !MaterialDesignFloatingHintTextBox#��[  6e   $��Champagne & Limousines)�6�   $��18(�6�   G� 5#      -   5         G�Name$ PasswordBox��5#      $
��0,10q�63   $ Password��6A    ) %MaterialDesignFloatingHintPasswordBox#��[ 6k   $��Champagne & Limousines)�6�   $��18(�6�   5$      5%      �� 5&   
   -   5        $	��150��5&      $��Center=�6   $��Bottom=�6:   $
��0,65q�6U   $��LOGIN��6c   6s   �� 5'   
   $��FORGET PASSWORD?��6   $��Center=�6,   $��Bottom=�6I   $��30q�6d   
������� � Cursor$
 Hand��6�   �� 5(   
   $��/Assets/Images/home.png��6   $	��100��61   $	��100��6=   $	��Top=�6J   $��30q�6b   5)      5*      