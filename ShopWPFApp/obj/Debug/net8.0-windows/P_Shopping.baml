   M S B A M L   `   `   `  ����E  AShopWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ShopWPFApp
ShopWPFApp  5          ShopWPFApp.P_Shopping   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:ShopWPFApp     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont N� 
FontFamily# �  5       N� 
Background
 ����� N� Title$ 
P_Shopping��5      .��5      � $��Stretch=�6   $��Stretch=�6)   $��30,0,0,0q�6E    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  $  MaterialDesignSubtitle1TextBlock#��[ 5   	   $��2��5   	   $��Shopping��6   $��0��5   	   $��0��6   $��10q�6&   $��20(�5   	   $
��Bold"�6   $��Center=�5   	   �� 5!   
   -   5         ��Name$ cb_Category��5!      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Category��6(   $��1��6R   $	��200��6`   $��	114,0,0,0q�6o   $��Center=�6�   $��1��6�   $	��312��6�   6�   �� 5$   
   $��2��6   .��5%      � $��Stretch=�6   $��Stretch=�63    � ColumnDefinitions 5&      �� 5'      $��* �6'    5*      �� 5+      $
��Auto �6$   .+�50      �� ��6   �� *MyObjectList+��51      �� 52      .R�53      � 	 � Orientation$	 
Horizontal=�6(   54      ��56      �� 57      .R�58      #  MaterialDesignThemes.Wpf.Card  $��10q�62   $	��250��6>   .��59   "   �  5:   &   �� 5;   *   $	��250 �68   �� 5<   *   $��* �68   �� 5=   *   $
��Auto �68   .+�5@   &   �� $
��Auto��6,   $��UniformToFill=�6Z   ��6:   �� *ProductImage+6Z   �� 5B   &   $��1��61   $��8,24,8,0q�6>   .+�5C   *   �� $��Center=�64   $
��Bold"�6Q   $��18(�6c   $��5q�6�   ��6q   �� *ProductName+6�   �� 5D   *   $��Center=�64   $��5q�6�   ��6Q   �� *ProductPrice+
 �� StringFormat$
  ${0:N2}��6�   5E   '   �� 5G   &   $��2��61   $��8q�6>   $��Center=�6I    �� Orientation$ 
Horizontal=�6f   .+�5H   *   �� -   5        $��View Detail��5H   1   $��30��6G   $��5q�6T   ��5I   1   �� *	ProductId+5J   '   5K   #   5L      5M      5O      5Q      5R      5S      5T      