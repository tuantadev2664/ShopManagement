   M S B A M L   `   `   `  ����E  AShopWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ShopWPFApp
ShopWPFApp  5   	   !    ShopWPFApp.W_ChangePassword   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ShopWPFApp     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	    � Title$ W_ChangePassword��5   	   $	��450��6"   $	��400��6/   .��5      � $��Stretch=�6   $��Center=�6)    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   G� -   5         G�Name$ pbOldPassword��5      $��0��6-   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Enter old password��6:   $	��300��6n   $��20q�6}   G� 5   
   -   5        $ pbNewPassword��5      $��1��6-   $ Enter new password��6:   $	��300��6n   $��20q�6}   G� 5   
   -   5        $ pbReNewPassword��5      $��2��6/   $ Confirm new password��6<   $	��300��6r   $��20q�6�   �� 5   
   $��3��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��0,10,0,0q�6X   .+�5      �� -   5        $��Submit��5      $	��100��6&   $��30��62   $��5q�6>   6I   �� 5       -   5        $��Cancel��5       $	��100��6&   $��30��62   $��5q�6>   6I   5!      5"      5#      