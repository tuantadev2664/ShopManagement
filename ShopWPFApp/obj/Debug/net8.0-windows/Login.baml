   M S B A M L   `   `   `  ����E  AShopWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ShopWPFApp
ShopWPFApp  5   	       ShopWPFApp.Login   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ShopWPFApp     5   	     � Title$  Login��5   	   $	��600��6   $	��800��6$    � WindowStartupLocation$ CenterScreen=�5	   	    � 	Resources 5
         RoundedButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius��%�   &	        �� 5   
   " ��6+   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ 20��6!   #��z��63   $��0q�6]   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5      5      5      .��5      �� $ 10��6   ���#FFFFFF���#CCCCCC$��1q�6J   ._�5   
   �  � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��1* �6#   .+�5      �� $��0��6   $!��/DE180316-TruongAnhTuan.jpg��6$   $��UniformToFill=�6I   �� 5"      ���#F8F8F8$ 	0 10 10 0��6*   $��1��6C   ._�5#      �� $��40q�6   $��Center=�6)   .+�5$      �� $��Welcome to System��6    $��28(�69   $
��Bold"�6G   $��0 0 0 10q�6Y   �� 5%      $'��!Log in to Shop Managerment System��6    $��24(�6I   ���#666666$��0 0 0 30q�6l   $	��477��6~   �� 5'      $��Email��6    $��14(�6-   $��0 0 0 5q�6;   �� 5(      -   5        	 ��Name$	 txtEmail��5(      $��40��60   $��14(�6<   $
��10 5q�6J   $��1q�6Y   ���#DDDDDD6m   �� 5*      $��Password��6    $��14(�60   $��0 15 0 5q�6>   G� 5+      -   5        
 G�Name$
 txtPassword��5+   "   $��40��67   $��14(�6C   $
��10 5q�6Q   $��1q�6`   ���#DDDDDD6t   �� 5,      $��Forgot password?��6    $��14(�68   ���#2196F3 � Cursor$
 Hand��6[   �� 5/       �� Orientation$ 
Horizontal=�6!   $��Center=�6:   $��0,10,0,0q�6W   .+�50      �� -   5         ��Name$ 	btn_Login��50   !   $��LogIn��64   $��45��6D   $��16(�6P   $
��Bold"�6^   
����������#4CAF50#��[  51   	   $��5q�65   $
 Hand��6@   $	��101��6f   �� 54      -   5        $ btn_Exit��54   !   $
��Exit��63   $��45��6B   $��16(�6N   $
��Bold"�6\   
����������#F44336#��[  55      $��5q�6A   $
 Hand��6L   $	��103��6q   56      �� 58      -   5        $ btn_Login_Admin��58      $��Admin��66   $��45��6F   $��16(�6R   $
��Bold"�6`   
�������
����ح�#��[  59      $��5q�6-   $
 Hand��68   $��98��6d   5;      5<      5=      5>      5?      