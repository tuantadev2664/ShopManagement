   M S B A M L   `   `   `  ����E  AShopWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ShopWPFApp
ShopWPFApp  5          ShopWPFApp.P_Cart   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:ShopWPFApp     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont N� 
FontFamily# �  5       N� 
Background
 ����� N� Title$ P_Cart��5      .��5      � $��Stretch=�6   $��Stretch=�6)    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   $	��250��6,   �� 5      $��* �6   .+�5   
   ��  $  MaterialDesignSubtitle1TextBlock#��[ 6   $��Order Detail��6N   $��0��6b   $��4��6o   $��	0,10,0,10q�6�   $��20(�6�   $
��Bold"�6�   $��Center=�6�   $	��130��6�   �� 5!   
   -   5         ��Name$ Image��5!      $��1��6   $	��200��6,   $��0��69   $	��Top=�6J   $��10q�6b   $	��175��6n   ��5"      �� *ImageSource+� 5$   
   $��1��6   $��2��6   $��	5,10,36,5q�6.   $
��Auto��6A    5%      �� 5&      $
��Auto �6    �� 5'      $
��Auto �6    �� 5(      $
��Auto �6    �� 5)      $
��Auto �6    �� 5*      $
��Auto �6    �� 5+      $��* �6     5-      �� 5.      $
��Auto �6#   �� 5/      $
��Auto �6#   �� 50      $
��Auto �6#   �� 51      $
��Auto �6#   .+�55      �� #��[ 6   $��Id��6R   $��1��6\   $��0��6i   $��5q�6y   �� 56      -   5         ��Name$ tbProductDetailId��56      $	��150��61   ${�False��6@   $��1��6R   $��1��6_   $��5q�6o   �� 58      #��[ 6   $
��Name��6R   $��2��6^   $��0��6k   $��5q�6{   �� 59      -   5        $ tbName��59      $	��150��6&   ${�False��66   $��2��6H   $��1��6U   $��5q�6e   �� 5;      #��[ 6   $��Price��6R   $��3��6_   $��0��6l   $��5q�6|   �� 5<      -   5        $ tbPrice��5<      $	��150��6'   ${�False��66   $��3��6H   $��1��6U   $��5q�6e   �� 5>      #��[ 6   $��Color��6R   $��4��6_   $��0��6l   $��5q�6|   �� 5?      -   5        $ tbColor��5?      $	��150��6'   ${�False��66   $��4��6H   $��1��6U   $��5q�6e   �� 5B      #��[ 6   $
��Size��6R   $��1��6^   $��2��6k   $��5q�6{   �� 5C      -   5        $ tbSize��5C      $	��150��6&   ${�False��65   $��1��6G   $��3��6T   $��5q�6d   �� 5E      #��[ 6   $��Quantity��6R   $��2��6b   $��2��6o   $��5q�6   �� 5F      -   5        $ 
tbQuantity��5F      $	��150��6*   ${�False��6:   $��2��6L   $��3��6Y   $��5q�6i   �� 5H      #��[ 6   $��ActualPrice��6R   $��3��6e   $��2��6r   $��5q�6�   �� 5I      -   5        $ tbActualPrice��5I      $	��150��6-   ${�False��6<   $��3��6N   $��3��6[   $��5q�6k   �� 5K      $��5��6   $��4��6&   	 �� Orientation$	 
Horizontal=�6:   $��Center=�6S   $��10q�6p   $	��400��6|   .+�5L      �� -	   5        $��Update��5L      $��30��6*   $��5q�6I   �� 5M      -
   5        $��Delete��5M      $��30��6*   $��5q�6I   �� 5O      -   5        $��Complete��5O      $��30��6I   $��10q�6U   $��80��6a   �� 5P      -   5        $ tb_TotalPrice��5P      $	��100��62   $��30��6B   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Total Price��6N   ${�False��6{   $��5q�6�   5Q      5S      &   System.Windows.Controls.DataGrid  5U   
   -   5          Name$ dataGrid��5U      $��10��5V      $��4��6      AutoGenerateColumns$ False��5W         CanUserAddRows$ False��5X         HeadersVisibility$	 All=�5Y         SelectionUnit$ FullRow=�5[         AlternatingRowBackground
 �����   
IsReadOnly$
 True��5]      $��10,10,10,10q�5^      ��5Z      �� *BookingDetailVMs+ �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5_      0  *System.Windows.Controls.DataGridTextColumn  5`      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6I   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ProductDetailId+6I   4  .System.Windows.Controls.DataGridTemplateColumn  5a      $ Image��6)      CellTemplate 5b      �� 5c      .R�5d      �� $��80��6[   $��80��6f   $��Uniform=�6r   ��6$   �� *$"ProductDetail.Product.ProductImage+6r   5e      5g        5h      $
 Name��6[    6%   �� *#!ProductDetail.Product.ProductName+6[     5i      $ Color��6M    6%   �� *ProductDetail.Color+6M     5j      $
 Size��6L    6%   �� *ProductDetail.Size+6L     5k      $ Quantity��6B    6%   �� *
Quantity+6B     5l      $ Price��6\    6%   �� *$"ProductDetail.Product.ProductPrice+6\     5m      $ Actual Price��6E    6%   �� *ActualPrice+6E   5o      5p      5q      