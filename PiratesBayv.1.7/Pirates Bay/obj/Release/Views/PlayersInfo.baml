   M S B A M L   `   `   `  ����   Pirates Bay#    Pirates_Bay.Views.PlayersInfo   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  PlayersInfo��$	��440��$	��450�� � Icon$# ../Resources/Icons/Pirate.ico�� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=�$��Bookman Old Style)�.���  � RowDefinitions �� $��28 ��� $��* �.+�� -   $��TitleBar��$��0�� � ColumnDefinitions �� $��28 ��� $��* ��� $��28 ��� $��28 �����  �� EndPoint$ 0.4,1&� �� 
StartPoint$ 0.4,0&�.��� 	 � Color$	 DimGray��
 � Offset$
 0Q�� $	 Silver��$
 1Q�.+��� -   $#��../Resources/Icons/Pirate.ico��$��0��$��2q��� -   $��1��$��Center=�$
��Bold"�$��Bell MT)�$��15(�	Players�� -   $��MinimizeButton��$��2��   TitleBarButton#��[  ���� *MinimizeCommand+����  �� 
TargetType" ��.R��� $��MinimizeImage��$)��#../Resources/Icons/MinimizeIcon.png��$��UniformToFill=�$��20��$��20��$��Center=�$��Center=� � Cursor$
 Hand�� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  �� 
TargetName$ MinimizeImage�� �� Property � �� �� Value$ 24���� $ MinimizeImage�� � ��$ 24���� -   $��CloseButton��$��3��#��[  ���� *CloseCommand+���� " ��.R��� $��
CloseImage��$&�� ../Resources/Icons/CloseIcon.png��$��UniformToFill=�$��20��$��20��$��Center=�$��Center=�$
 Hand�� P�  �@J�IsMouseOver . . ��� $ 
CloseImage�� � ��$ 24���� $ 
CloseImage�� � ��$ 24��� -   $��GridMainConteiner��$��1�� �� $��* ��� $	��25* ��� $��* ��� $��3* ��� $��* �.+�� -   $��GridDataContainer��$��1�� �� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $	��11* �.+��� -   $!��TextBlockFirstPlayerCaption��$��First player��$��0��$��0��
�������$��20(�$
��Bold"�$��Center=�$��Center=��� -	   $"��TextBlockSecondPlayerCaption��$��Second player��$��0��$��1��
�������$��20(�$
��Bold"�$��Center=�$��Center=��� -
   $��TextBoxFirstUserName��$��1��$��0��$
��30,0q����#585252$��15(����#585252 �� TextAlignment$ Center=�����  �� Path$ FirstPlayerName� �� Mode$ TwoWay=��� -   $��TextBoxSecondtUserName��$��1��$��1��$
��30,0q����#585252$��15(����#585252$ Center=����� $ SecondPlayerName�$ TwoWay=��� -   $"��TextBlockFirstPlayerShipName��$��2��$��0��
�����p�$��	20,7,20,0q�
������� �� Padding$ 0q�$��15(�$��Center=����� $ FirstPlayerShipName�$ TwoWay=��� -   $#��TextBlockSecondPlayerShipName��$��2��$��1��
�����p�$��	20,7,20,0q�
�������$ 0q�$��15(�$��Center=����� $ SecondPlayerShipName�$ TwoWay=��� $��3��$��15,10q�$��0��$��Hidden=�$��Visible=�.��� -   $#��GridFirstPlayerShipsContainer��$	��500�� �� $��* ��� $��* ��� $��* � �� $��6* ��� $��* ��� $��* ��� $��* �����  �� Color$ 	SlateGray��.+��� -   $��ImageFirstUserFirstShip��$��2q�$��0��$��0��$?��9../Resources/Ships/Presentations/Queen Anne's Revenge.jpg��$
 Hand���� -   $��ImageFirstUserSecondShip��$��7q�$��1��$��0��$4��.../Resources/Ships/Presentations/Old Pearl.jpg��$
 Hand���� -   $��ImageFirstUserThirdShip��$��7q�$��2��$��0��$6��0../Resources/Ships/Presentations/Pirate Brig.jpg��$
 Hand���� -   $ ��FirstPlayerFirstShipHealth��$��0��$��1��
�����p�$��	20,7,20,0q�
�������$��Health: 2400��$ 0q�$��15(�$��Center=��� -   $��FirstPlayerFirstShipSpeed��$��0��$��2��
�����p�$��	20,7,20,0q�
�������$��	Speed: 60��$ 0q�$��15(�$��Center=��� -   $ ��FirstPlayerFirstShipDamage��$��0��$��3��
�����p�$��	20,7,20,0q�
�������$��Damage: 250��$ 0q�$��15(�$��Center=��� -   $!��FirstPlayerSecondShipHealth��$��1��$��1��
�����p�$��	20,7,20,0q�
�������$��Health: 2000��$ 0q�$��15(�$��Center=��� -   $ ��FirstPlayerSecondShipSpeed��$��1��$��2��
�����p�$��	20,7,20,0q�
�������$��	Speed: 60��$ 0q�$��15(�$��Center=��� -   $!��FirstPlayerSecondShipDamage��$��1��$��3��
�����p�$��	20,7,20,0q�
�������$��Damage: 300��$ 0q�$��15(�$��Center=��� -   $ ��FirstPlayerThirdShipHealth��$��2��$��1��
�����p�$��	20,7,20,0q�
�������$��Health: 1900��$ 0q�$��15(�$��Center=��� -   $��FirstPlayerThirdShipSpeed��$��2��$��2��
�����p�$��	20,7,20,0q�
�������$��	Speed: 90��$ 0q�$��15(�$��Center=��� -   $ ��FirstPlayerThirdShipDamage��$��2��$��3��
�����p�$��	20,7,20,0q�
�������$��Damage: 270��$ 0q�$��15(�$��Center=��� $��3��$��15,10q�$��1��$��Hidden=�$��Visible=�.��� -   $$��GridSecondPlayerShipsContainer��$	��500�� �� $��* ��� $��* ��� $��* � �� $��6* ��� $��* ��� $��* ��� $��* ����� $ 	SlateGray��.+��� -   $��ImageSecondUserFirstShip��$��2q�$��0��$��0��$?��9../Resources/Ships/Presentations/Queen Anne's Revenge.jpg��$
 Hand���� -   $��ImageSecondUserSecondShip��$��7q�$��1��$��0��$4��.../Resources/Ships/Presentations/Old Pearl.jpg��$
 Hand���� -   $��ImageSecondUserThirdShip��$��7q�$��2��$��0��$6��0../Resources/Ships/Presentations/Pirate Brig.jpg��$
 Hand���� -   $!��SecondPlayerFirstShipHealth��$��0��$��1��
�����p�$��	20,7,20,0q�
�������$��Health: 2400��$ 0q�$��15(�$��Center=��� -    $ ��SecondPlayerFirstShipSpeed��$��0��$��2��
�����p�$��	20,7,20,0q�
�������$��	Speed: 60��$ 0q�$��15(�$��Center=��� -!   $!��SecondPlayerFirstShipDamage��$��0��$��3��
�����p�$��	20,7,20,0q�
�������$��Damage: 250��$ 0q�$��15(�$��Center=��� -"   $"��SecondPlayerSecondShipHealth��$��1��$��1��
�����p�$��	20,7,20,0q�
�������$��Health: 2000��$ 0q�$��15(�$��Center=��� -#   $!��SecondPlayerSecondShipSpeed��$��1��$��2��
�����p�$��	20,7,20,0q�
�������$��	Speed: 60��$ 0q�$��15(�$��Center=��� -$   $"��SecondPlayerSecondShipDamage��$��1��$��3��
�����p�$��	20,7,20,0q�
�������$��Damage: 300��$ 0q�$��15(�$��Center=��� -%   $!��SecondPlayerThirdShipHealth��$��2��$��1��
�����p�$��	20,7,20,0q�
�������$��Health: 1900��$ 0q�$��15(�$��Center=��� -&   $ ��SecondPlayerThirdShipSpeed��$��2��$��2��
�����p�$��	20,7,20,0q�
�������$��	Speed: 90��$ 0q�$��15(�$��Center=��� -'   $!��SecondPlayerThirdShipDamage��$��2��$��3��
�����p�$��	20,7,20,0q�
�������$��Damage: 270��$ 0q�$��15(�$��Center=�� -(   $��GridButtonContainer��$��3�� �� $��* ��� $��* ��� $��* �.+��� -)   $��
ButtonPlay��$
��Play��$��1��  MenuButtonDarkStyle#��[ ���� *StartPlayCommand+����  �� ImageSource$B <../Resources/Background images/DarkStyle/PlayersInfoDark.jpg��