   M S B A M L   `   `   `  ����E  AShopWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ShopWPFApp
ShopWPFApp  5          ShopWPFApp.P_OrderHistory   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:ShopWPFApp     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont N� 
FontFamily# �  5   	    N� 
Background
 ����� N� Title$ P_OrderHistory��5       � 	Resources 5        BookingCardStyle �� 
TargetType �� Property �� Value3  -System.Windows.Media.Effects.DropShadowEffect	   
BlurRadius
   ShadowDepth   Opacity   Color  StatusChipStyle �� Triggers �� Binding �� Value��%�  &	       &	 N    �� 5   
   " ��6)   .�5      ��  � ��
 �����6+   �� 5       �@��CornerRadius$ 8��6-   �� 5       � ��$ 0,0,0,16q�6'   �� 5       �@��Padding$ 16q�6(   �� 5       �@J�Effect 5        5      $	 10Q�6'   $
 1Q�67   $	 0.2Q�6G   $ #000000��6U   5      5      �� 5    
   " ��6(   .�5!      ��  �@��CornerRadius$ 16��6-   �� 5"       �@��Padding$
 12,4q�6(    5#      �� 5$       6   �� *OrderStatus+ Pending6>   .a�5%      ��  � �� �#FFF3E063   �� 5&       � �� �#E651006=   5'      �� 5(       6   �� *OrderStatus+ 	Confirmed6>   .a�5)      ��  � �� �#E8F5E963   �� 5*       � �� �#1B5E206=   5+      �� 5,       6   �� *OrderStatus+ 	Cancelled6>   .a�5-      ��  � �� �#FFEBEE63   �� 5.       � �� �#B71C1C6=   5/      51      52      .��54      �   MaterialDesignBackground#���  6    � RowDefinitions 55   
   �� 56      $
��Auto �6   �� 57      $
��Auto �6   �� 58      $��* �6   .+�5<   
   #  MaterialDesignThemes.Wpf.Card  $��0��6   $��
16,16,16,8q�6+   .��5=      �  � ColumnDefinitions 5>      �� 5?      $��* �6'   �� 5@      $
��Auto �6'   .+�5C      �� $��Order History��6    $  MaterialDesignHeadline5TextBlock#��[ 5D      $��Center=�5E      $��Center=�5F      $��16q�5G      �� 5J      -   5        $��1��5J        MaterialDesignIconButton#��[ 5K       � ToolTip$ Refresh��5L      $��8q�5M      .��5O      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Refresh=�6.   $��Center=�6=   5P      5Q      5R      �� 5T   
   $��1��6   $��1��5U       �� Orientation$ 
Horizontal=�5V      $��Center=�5W      $��5q�5X      .+�5Y      �� -   5        $��Search by OrderId��5Y      $��30��5[      $��10q�5\      �� 5]      -   5         ��Name$ tbSearchbyText��5]      $	��100��5^      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search��5_      $
{�True��5`      $��4��5a      $��1��5b      $��5q�5c      5d      �� 5g   
   $��2��6   $��
16,8,16,16q�5h      $
��Auto=�5i      .��5j      �� ��6   �� *	orderList+��5k      �� 5l      .R�5m        $��0,0,0,16q�6.      UniformCornerRadius$ 8Q�6@   .��5n      9�  9� 
IsExpanded$
 True��5o   "   ��5n   '   �� *	OrderId+ �� StringFormat$ Booking #{0}��.��5p   "   �� $��16q�6-   .+�5r   &   � $��0,0,0,16q�6+    5s   *   �� 5t   .   $��* �6?   �� 5u   .   $
��Auto �6?   �� 5v   .   $
��Auto �6?   .+�5y   *   �� $��0��65   $ 
Horizontal=�6E   .+�5z   .     $ Calendar=�6F   $��Center=�5{   @   $��0,0,8,0q�5|   @   �� 5}   .   $��Center=�5~   2   ��5}   8   �� *	OrderDate+$ Booking Date: {0}��5~   2   5   +   �� 5�   *   $��3��61   #��[ 6A   ._�5�   .   �� $��Medium"�5�   2   ��5�   8   �� *OrderStatus+5�   2   5�   +   �� 5�   *   -   5        $��1��5�   1     MaterialDesignFlatButton#��[ 5�   -   ��5�   -   �� * DataContext.EditBookingCommand+ �� RelativeSource ��  �� AncestorType ItemsControl��5�   -   �� *	OrderId+.��5�   .   �� $ 
Horizontal=�69   .+�5�   2     $ Remove=�6J   $��0,0,8,0q�6X   �� 5�   2   $��Remove��6<   5�   /   5�   +   5�   '   �� 5�   &   $ 
Horizontal=�61   $��0,0,0,16q�6J   .+�5�   *     $ CurrencyUsd=�6B   $��Center=�5�   <   $��0,0,8,0q�5�   <   �� 5�   *   $��Medium"�5�   .   $��16(�5�   .   ��5�   4   �� *
TotalPrice+$ Total: ${0:N2}��5�   .   5�   '     5�   &   $ 4Q�6:   ���#F5F5F5.��5�   *   �� $��0q�5�   -   
������ $	��300��5�   -   ��5�   3   �� *OrderDetails+ �� View 5�   .   �� 5�   2   .P�5�   6   �� $��ID��6E    �� Width$ 80��6Q    �� CellTemplate 5�   :   �� 5�   >   .R�5�   B   �� $ 
Horizontal=�6M   .+�5�   F   �� ��6P   �� *OrderDetailId+5�   C   5�   ?   5�   7   �� 5�   6   $��Image��6E   $	 100��6T    5�   :   �� 5�   >   .R�5�   B   �� $ 
Horizontal=�6M   .+�5�   F   �� $��80��5�      $��80��5�      $��Uniform=�5�      ��5�   L   �� *$"ProductDetail.Product.ProductImage+5�      5�   C   5�   ?   5�   7   �� 5�   6   $
��Name��6E   $	 100��6S    5�   :   �� 5�   >   .R�5�   B   �� $ 
Horizontal=�6M   .+�5�   F   �� ��6P   �� *#!ProductDetail.Product.ProductName+5�   C   5�   ?   5�   7   �� 5�   6   $��Color��6E   $ 95��6T    5�   :   �� 5�   >   .R�5�   B   �� $ 
Horizontal=�6M   .+�5�   F   �� ��6P   �� *ProductDetail.Color+5�   C   5�   ?   5�   7   �� 5�   6   $
��Size��6E   $ 90��6S    5�   :   �� 5�   >   .R�5�   B   �� $ 
Horizontal=�6M   .+�5�   F   �� ��6P   �� *ProductDetail.Size+5�   C   5�   ?   5�   7   �� 5�   6   $��Quantity��6E   $	 120��6W    5�   :   �� 5�   >   .R�5�   B   �� $ 
Horizontal=�6M   .+�5�   F   �� ��6P   �� *
Quantity+5�   C   5�   ?   5�   7   �� 5�   6   $��Price��6E   $	 100��6T    5�   :   �� 5�   >   .R�5�   B   �� $ 
Horizontal=�6M   $��Right=�5�   G   .+�5�   F     $ CurrencyUsd=�6^   $��0,0,4,0q�5�   X   �� 5�   F   ��6P   �� *$"ProductDetail.Product.ProductPrice+$ {0:N2}��5�   C   5�   ?   5�   7   �� 5�   6   $��ActualPrice��6E   $	 150��6Z    5�   :   �� 5�   >   .R�5�   B   �� $ 
Horizontal=�6M   $��Right=�5�   G   .+�5�   F     $ CurrencyUsd=�6^   $��0,0,4,0q�5�   X   �� 5�   F   ��6P   �� *ActualPrice+$ {0:N2}��5  C   5  ?   5  7   5  3   5  +   5  '   5	  #   5
     5     5     5     5     5     5     