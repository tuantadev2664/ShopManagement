   M S B A M L   `   `   `  ����E  AShopWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ShopWPFApp
ShopWPFApp  5      "    ShopWPFApp.P_CustomerProfile   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:ShopWPFApp     5         MaterialDesignBody#���   5   	   $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont N� 
FontFamily# �  5       N� 
Background
 ����� N� Title$ P_CustomerProfile��5      .��5      � $��Stretch=�6   $��Stretch=�6)    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5       $
��Auto �6   $	��161��6,   �� 5!      .+�5$   
   ��  $  MaterialDesignSubtitle1TextBlock#��[ 6   $��Profile��6N   $��0��6]   $��1��6j   $��	0,10,0,10q�6z   $��20(�6�   $
��Bold"�6�   $��Center=�6�   $��60��6�   �� 5&   
   #��[ 6   $��	Full Name��6N   $��1��6_   $��0��6l   $��66,10,10,10q�6|   �� 5'   
   -   5         ��Name$ 
tbFullName��5'      $	��100��6&   ${�False��66   $��1��6H   $��1��6U   $��61,10,74,10q�6e   �� 5)   
   #��[ 6   $��	Telephone��6N   $��2��6_   $��0��6l   $��66,10,10,10q�6|   �� 5*   
   -   5        $ tbTelephone��5*      $	��100��6'   ${�False��66   $��2��6H   $��1��6U   $��61,10,74,10q�6e   �� 5,   
   #��[ 6   $��Email Address��6N   $��3��6c   $��0��6p   $��38,10,10,10q�6�   �� 5-   
   -   5        $ tbEmail��5-      $	��100��6#   ${�False��62   $��3��6D   $��1��6Q   $��61,10,74,10q�6a   �� 5/   
   #��[ 6   $��Address��6N   $��4��6]   $��0��6j   $��80,10,10,10q�6z   �� 50   
   -   5        $ 	tbAddress��50      $	��100��6%   ${�False��65   $��4��6G   $��1��6T   $��61,10,74,10q�6d   �� 52   
   $��5��6    �� Orientation$ 
Horizontal=�6#   $��Center=�6<   $��	0,10,0,10q�6Y   $��2��6l   $	��286��6�   .+�53      �� -   5        $��btnUpdateProfile��53      $��Update Profile��6-   $��30��6F   $��5q�6l   �� 54      -   5        $��btnChangePassword��54      $��Change Password��6.   $��30��6H   $��5q�6o   55      56      57      