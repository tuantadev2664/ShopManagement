   M S B A M L   `   `   `  ����E  AShopWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ShopWPFApp
ShopWPFApp  5          ShopWPFApp.P_Static   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:ShopWPFApp     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont N� 
FontFamily# �  5       N� 
Background
 ����� N� Title$ P_Static��5      .��5      � $��Stretch=�6   $��Stretch=�6)    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   ��  $  MaterialDesignSubtitle1TextBlock#��[ 6   $��2��6N   $��Static��6b   $��0��6p   $��0��6}   $��10q�6�   $��20(�6�   $
��Bold"�6�   $��Center=�6�   �� 5!   
   $��2��6   $��4��6"    �� Orientation$ 
Horizontal=�66   $��Center=�6O   $��5q�6l   $	��250��6w   .+�5"      �� #��[ 6   $	��100��6R   $��TotalRevenue��6a   $��1��6u   $��0��6�   $��10q�6�   $��15(�6�   $
��Bold"�6�   �� 5#      -   5         ��Name$ tb_TotalRevenue��5#      $	��125��60   ${�False��6@   $��1��6R   $��1��6_   $��5q�6o   5$      � 5&   
   $��1��6   $��Center=�6   $��10q�69    5'      �� 5(      $	��150 �6#   �� 5)      $	��150 �6#   �� 5*      $	��150 �6#   .+�5.      (  "System.Windows.Controls.DatePicker  -   5        $��0��5.      $��5q�5/      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 	From Date��50   	   .  (MaterialDesignThemes.Wpf.TextFieldAssist
   HasClearButton$

 True��51   	    ( $MaterialDesignFloatingHintDatePicker#��[ 52   	   53   	     55      -   5        $��1��55      $��5q�56   	   $	 To Date��57   	   $

 True��58   	   #��[ 59   	   5:   	   �� 5<      -   5        $
��Sort��5<      $��5q�66   $��2��6A   5=      &   System.Windows.Controls.DataGrid  5@   
   -   5          Name$ dataGrid��5@      $��3��5A      $��4��6      AutoGenerateColumns$ False��5B         CanUserAddRows$ False��5C         HeadersVisibility$	 All=�5D         SelectionUnit$ FullRow=�5F         AlternatingRowBackground
 �����   
IsReadOnly$
 True��5H      $��10q�5I      ��5E      �� *Static+   Columns 5J      0  *System.Windows.Controls.DataGridTextColumn  5K      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	OrderId+6A     5L      $
 Date��6C    6%   �� *	OrderDate+6C     5M      $ Customer��6O    6%   �� *Customer.CustomerName+6O     5N      $ Revenue��6D    6%   �� *
TotalPrice+6D     5O      $ Status��6E    6%   �� *OrderStatus+6E   5Q      5R      5S      