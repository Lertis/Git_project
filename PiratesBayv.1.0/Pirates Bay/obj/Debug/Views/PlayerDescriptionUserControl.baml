   M S B A M L   `   `   `  ����  Pirates Bay4    .Pirates_Bay.Views.PlayerDescriptionUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          >�Name$  PlayerDescriptionControl��5      .��5	      � -   5        $��GridSecondPlayerInfo��5	      $��2��6   ��5
   
   �� 5       �� ImageSource$3 -../Resources/Background images/JollyRoger.jpg��6   6W    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��6* �6   6*   �� 5      $��4* �6   6*   �� 5      $��4* �6   6*   �� 5      $��4* �6   6*   �� 5      $��4* �6   6*   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��4* �6   6,   �� 5      $��8* �6   6,   �� 5      $��7* �6   6,   �� 5      $��9* �6   6,   �� 5      $��* �6   6+   .+�5   
   �� -   5        $��ImageGoldenCoint��5      $��1��6(   $��1��65   $8��2../Resources/Background images/GoldenShipCoint.png��6E   �� 5   
   -   5        $��TextBoxPlayerGold��5      $��2��6-   $��1��6=   $��18(�6J   $
��Bold"�6X   
��� ���$��Bell MT)�6|   $��Center=�6�   $
��Left=�6�   ��6�   ��  �� Path$ Player.Gold� �� Mode$ OneWay=� �� ElementName$ PlayerDescriptionControl��6  �� 5    
   -   5        $��TextBlockPlayerName��5       $��Bell MT)�6/   $��1��6D   $��3��6Q   $��2��6a   
�������
���   �$��25(�6�   $
��Bold"�6�   $��Center=�6  $
��Left=�6+  ��6�   �� $ Player.Name�$ OneWay=�$ PlayerDescriptionControl��6+  �� 5!   
   -   5        $��TextBlockPlayerShipName��5!      $��2��63   $��1��6@   $��4��6P   
�������
���   �$��Bell MT)�6�   $
��Bold"�6�   $��17(�6  $��Center=�6  $��Center=�65  ��6�   �� $ Player.Ship.Name�$ OneWay=�$ PlayerDescriptionControl��65  �� 5"   
   $��1��6   $��2��6    $��3��64   $��3��6A   $
��Fill=�6�   ��6R   �� $# Player.Ship.PresentationImage�$ TwoWay=�$ PlayerDescriptionControl��6�   �� 5#   
   $��3��6   $��3��6!   $��Bell MT)�62   $��15(�6G   ���#2C2727 �� Padding$ 3q�6j   
�������$��DemiBold"�6�   $��  Health��6�   �� 5$   
   $��4��6   $��3��6!   $��14(�61   ���#2C2727
�������$ 3q�6h   $��Bell MT)�6t   $��DemiBold"�6�   $��   Speed��6�   �� 5%   
   $��5��6   $��3��6!   $��14(�61   ���#2C2727
�������$ 3q�6h   $��Bell MT)�6t   $��DemiBold"�6�   $��  Damage��6�   �� 5&   
   $��3��6   $��4��6!   $��14(�61   ���#2C2727
���������6g   �� $ Player.Ship.Health�$ OneWay=�$ PlayerDescriptionControl���� 5'   
   $��4��6   $��4��6!   $��14(�61   ���#2C2727
���������6g   �� $ Player.Ship.Speed�$ OneWay=�$ PlayerDescriptionControl���� 5(   
   $��5��6   $��4��6!   $��14(�61   ���#2C2727
���������6g   �� $ Player.Ship.Damage�$ OneWay=�$ PlayerDescriptionControl��5*      5+      