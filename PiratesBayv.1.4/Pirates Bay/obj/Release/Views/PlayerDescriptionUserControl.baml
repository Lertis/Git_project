   M S B A M L   `   `   `  ����   Pirates Bay4    .Pirates_Bay.Views.PlayerDescriptionUserControl   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -     >�Name$  PlayerDescriptionControl��.��� -   $��GridSecondPlayerInfo��$��2������  �� ImageSource$3 -../Resources/Background images/JollyRoger.jpg�� � RowDefinitions �� $��* ��� $��6* ��� $��4* ��� $��4* ��� $��4* ��� $��4* ��� $��* � � ColumnDefinitions �� $��* ��� $��4* ��� $��8* ��� $��7* ��� $��9* ��� $��* �.+��� -   $��ImageGoldenCoint��$��1��$��1��$8��2../Resources/Background images/GoldenShipCoint.png���� -   $��TextBoxPlayerGold��$��2��$��1��$��18(�$
��Bold"�
��� ���$��Bell MT)�$��Center=�$
��Left=�����  �� Path$ Player.Gold� �� Mode$ OneWay=� �� ElementName$ PlayerDescriptionControl���� -   $��TextBlockPlayerName��$��Bell MT)�$��1��$��3��$��2��
�������
���   �$��25(�$
��Bold"�$��Center=�$
��Left=����� $ Player.Name�$ OneWay=�$ PlayerDescriptionControl���� -   $��TextBlockPlayerShipName��$��2��$��1��$��4��
�������
���   �$��Bell MT)�$
��Bold"�$��17(�$��Center=�$��Center=����� $ Player.Ship.Name�$ OneWay=�$ PlayerDescriptionControl���� $��1��$��2��$��3��$��3��$
��Fill=����� $# Player.Ship.PresentationImage�$ TwoWay=�$ PlayerDescriptionControl���� $��3��$��3��$��Bell MT)�$��15(����#2C2727 �� Padding$ 3q�
�������$��DemiBold"�$��  Health���� $��4��$��3��$��14(����#2C2727
�������$ 3q�$��Bell MT)�$��DemiBold"�$��   Speed���� $��5��$��3��$��14(����#2C2727
�������$ 3q�$��Bell MT)�$��DemiBold"�$��  Damage���� $��3��$��4��$��14(����#2C2727
����������� $ Player.Ship.Health�$ OneWay=�$ PlayerDescriptionControl���� $��4��$��4��$��14(����#2C2727
����������� $ Player.Ship.Speed�$ OneWay=�$ PlayerDescriptionControl���� $��5��$��4��$��14(����#2C2727
����������� $ Player.Ship.Damage�$ OneWay=�$ PlayerDescriptionControl��