   M S B A M L   `   `   `  ����  Pirates Bay$    Pirates_Bay.Views.LoadGameMenu   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  LoadGameMenu��5   	   $	��350��6   $	��450��6+    � Icon$# ../Resources/Icons/Pirate.ico��67    � 
ResizeMode$ NoResize=�6\    � WindowStyle$
 None=�6r    � WindowStartupLocation$ CenterScreen=�6�   $��Bookman Old Style)�6�    � 	Resources 5       �� 
TargetType �� Property �� Value��%`   '��       �� 5   
   " ��6   .�5      ��  �@�Cursor$
 Hand��6'   66   5      5	      .��5
      � 	 � RowDefinitions	 5   
   �� 5      $��28 �6   6*   �� 5      $��* �6   6)   .+�5   
   � -   5        $��TitleBar��5      $��0��6   
 � ColumnDefinitions
 5      �� 5      $��28 �6#   60   �� 5      $��* �6#   6/   �� 5      $��28 �6#   60   �� 5      $��28 �6#   60   ��5      �� 5       �� EndPoint$ 0.4,1&�6&    �� 
StartPoint$ 0.4,0&�67   .��5      �  � Color$ DimGray��6#    � Offset$ 0Q�63   � 5      $ Silver��6#   $ 1Q�62   5      .+�5      �� -   5        $#��../Resources/Icons/Pirate.ico��5      $��0��6;   $��2q�6K   6�   �� 5       -   5        $��1��5       $��Center=�6(   $
��Bold"�6C   $��Bell MT)�6U   $��15(�6j   Pirates Bay6�   �� 5!      -   5        $��MinimizeButton��5!      $��2��6+      TitleBarButton#��[  6;   ��6c   �� *MinimizeCommand+��5"      �� 5#       �� 
TargetType" ��6&   .R�5$      �� $��MinimizeImage��6    $)��#../Resources/Icons/MinimizeIcon.png��65   $��UniformToFill=�6b   $��20��6z   $��20��6�   $��Center=�6�   $��Center=�6�    � Cursor$
 Hand��6�   5%       �� Triggers 5&      P� 5'       P� Property �@J�IsMouseOver P� Value . . �5(   "   ��  �� 
TargetName$ MinimizeImage��6)    � ��$ 24��6U   6b   �� 5)   "   $ MinimizeImage��6)    � ��$ 24��6V   6c   5*      5,      5/      �� 50      -   5        $��CloseButton��50      $��3��6(   #��[  68   ��6`   �� *CloseCommand+��51      �� 52      " ��6&   .R�53      �� $��
CloseImage��6    $&�� ../Resources/Icons/CloseIcon.png��62   $��UniformToFill=�6\   $��20��6t   $��20��6   $��Center=�6�   $��Center=�6�   $
 Hand��6�   54       55      P� 56       �@J�IsMouseOver . . �57   "   �� $ 
CloseImage��6)    � ��$ 24��6R   6_   �� 58   "   $ 
CloseImage��6)    � ��$ 24��6S   6`   59      5;      5>      5?      � 5@   
   -   5        $��GridMenu��5@      $��1��6   
 5A      �� 5B      $��3* �6#   60   �� 5C      $��2* �6#   60   �� 5D      $��6* �6#   60   �� 5E      $��* �6#   6/   �� 5F      $��6* �6#   60   �� 5G      $��2* �6#   60   �� 5H      $��3* �6#   60   	 5J      �� 5K      $��* �6    6-   �� 5L      $	��12* �6    6/   �� 5M      $��* �6    6-   �� 5N      $��2* �6    6.   �� 5O      $��* �6    6-   .+�5Q      �� -   5        $��ButtonLoadGame��5Q      $
��Load��6+   $��2��6:   $��3��6J     MenuButtonDarkStyle#��[ 6w   ��6W   �� *LoadCommand+6w   �� 5R      -	   5        $��ButtonCancel��5R      $��Cancel��6)   $��4��6;   $��3��6K   #��[ 6X   ��6�   �� *CloseCommand+� 5S      -
   5        $��	GridSaves��5S      $��1��6$   $��5��64   $��1��6H   
�����p�.+�5T      &   System.Windows.Controls.DataGrid  -   5        $��DataGridSaves��5T      
������    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6I      CanUserAddRows .     CanUserDeleteRows . 6�   5U      5V      5W      ��5X      �� 5Y   
    �� ImageSource$C =../Resources/Background images/DarkStyle/LoadGameMenuDark.jpg��6   5[      