   M S B A M L   `   `   `  ����   Pirates Bay&     Pirates_Bay.Views.ShipYardWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  ShipYardWindow��$	��300��$	��320�� � Icon$# ../Resources/Icons/Pirate.ico�� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=�$��Bookman Old Style)� � AllowsTransparency . 
������  � 	Resources  �� 
TargetType �� Property	 �� Value
 �� 
TargetType"  System.Windows.Media.Brushes   Transparent   White �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName   	SteelBlue   	SlateGray   Silver��%R  '��       '�� ,     �� " ��.���  �@�Cursor$
	 Hand���� " ��.���  � ��	 �� "
 ��.R�� .+��� $��Border��$��0,0,-4,0q�#��Z #��Z $��1,1,1,1q�$ 	12,12,0,0��._��� $ ContentSite��$��	12,2,12,2q�$��Center=�$��Center=�$��Header����.  P�  �@��
IsSelected . . ���  �@K�ZIndex$		 100���� $ Border��#	 Z  � ���� $ Border�� � ��$	 0q���  � ��
	 �����P�  � {� .  . ��� $ Border��#	 Z  � ���� $ Border��#	 Z  � ���� #	 Z  � ����  � ��$	 15(���  � ��
	 �����.���� $ 15��
�����w�
���   �$��1q�._�� $��7q�����  �� ImageSource$; 5../Resources/Background images/ShipyardBackground.jpg�� � RowDefinitions �� $��40 ��� $��* �.+�� -   $��TitleBar��$��0�� � ColumnDefinitions �� $��* ��� $��* ��� $��3* ��� $��* ��� $��* �.+��� $3��-../Resources/Background images/SkullCoins.png��$��1���� $��2��$��Center=�$��	ExtraBold"�$��Garamond)�$��28(�$��Center=����#FFFF00
Shipyard�� -   $��CloseButton��$��4��   TitleBarButton#��[  ���� "
 ��.R��� $��
CloseImage��$&�� ../Resources/Icons/CloseIcon.png��$��UniformToFill=�$��34��$��34��$��Center=�$��Center=� � Cursor$
 Hand�� P�  �@J�IsMouseOver . . ��� $ 
CloseImage�� � ��$	 36���� $ 
CloseImage�� � ��$	 36��� -   $��GridContainer��$��1�� �� $��* ��� $��2* ��� $��5* ��� $��* ��� $	��13* ��� $��* � �� $��* ��� $	��16* ��� $��* ��� $��2* ��� $��* �.+��� -   $��
TabControl��$��1��$��1��$��4��
�����F�.@��� -   $��TabItemUpgrades��$��Upgrades�� �� 
IsSelected . .��� -   $��GridUpgradesContainer�� �� $��* ��� $��4* ��� $��7* ��� $��6* ��� $��* ��� $��5* ��� $��6* ��� $��6* ��� $��* ��� $��5* ��� $��6* ��� $��6* ��� $��* � �� $��4* ��� $��4* ��� $	��17* ��� $��* ��� $��4* �.+��� $��0��$��1��$��3��$��
Armor ship��$��13(�$��Center=�$��Center=��� $��0��$��5��$��3��$��Improve sails��$��13(�$��Center=�$��Center=��� $��0��$��9��$��3��$��Add cannons��$��13(�$��Center=�$��Center=��� $��1��$��1��$��+��$��13(�$��Center=�$��Right=��� $��1��$��5��$��+��$��13(�$��Center=�$��Right=��� $��1��$��9��$��+��$��13(�$��Center=�$��Right=��� -   $��TextBlockImproveHpValue��$��1��$��2��$��13(�$��Center=�$
��Left=�����  �� Path$ ArmorUpgradeAmount��� -	   $��TextBlockImproveSpValue��$��1��$��6��$��13(�$��Center=�$
��Left=����� $ SailsUpgradeAmount��� -
   $��TextBlockImproveDmValue��$��1��$��10��$��13(�$��Center=�$
��Left=����� $ CannonsUpgradeAmount��� $��1��$��3��$��hp��$��13(�$��Center=�$
��Left=��� $��1��$��7��$��sp��$��13(�$��Center=�$
��Left=��� $��1��$��11��$��dm��$��13(�$��Center=�$
��Left=��� $��2��$��1��$��3��$4��.../Resources/Upgrades images/Armored board.jpg���� $��2��$��5��$��3��$5��/../Resources/Upgrades images/Improved sails.jpg��$
��Fill=��� $��2��$��9��$��3��$7��1../Resources/Upgrades images/Improved cannons.jpg���� -   $��ButtonArmorShip��$��4��$��1��$��3������ $ ArmorUpgradeCost����� "
 ��.R��� $��BorderButtonArmorShip��$ 7��
������ $��1q�
������ ._��  �� $��* ��� $��4* ��� $��9* �.+��� $��1��$8��2../Resources/Background images/GoldenShipCoint.png���� $��TextBlockArmorCost��$��2��$��18(�$
��Bold"�
��� ���$��Bell MT)�$��Center=�#��z�� P�  �@J�IsMouseOver . . ��� $ BorderButtonArmorShip�� � ��
	 �����P�  � {� .  . ��� $ BorderButtonArmorShip�� � ��
	 ������� $ TextBlockArmorCost�� � ��
	 ������� -   $��ButtonImproveSails��$��4��$��5��$��3������ $ SailsUpgradeCost����� "
 ��.R��� $��BorderButtonImproveSails��$ 7��
������ $��1q�
������ ._��  �� $��* ��� $��4* ��� $��9* �.+��� $��1��$8��2../Resources/Background images/GoldenShipCoint.png���� $��TextBlockSailsCost��$��2��$��18(�$
��Bold"�
��� ���$��Bell MT)�$��Center=�#��z�� P�  �@J�IsMouseOver . . ��� $ BorderButtonImproveSails�� � ��
	 �����P�  � {� .  . ��� $ BorderButtonImproveSails�� � ��
	 ������� $ TextBlockSailsCost�� � ��
	 ������� -   $��ButtonAddCannons��$��4��$��9��$��3������ $ CannonsUpgradeCost����� "
 ��.R��� $��BorderButtonAddCannons��$ 7��
������ $��1q�
������ ._��  �� $��* ��� $��4* ��� $��9* �.+��� $��1��$8��2../Resources/Background images/GoldenShipCoint.png���� $��TextBlockCannonsCost��$��2��$��18(�$
��Bold"�
��� ���$��Bell MT)�$��Center=�#��z�� P�  �@J�IsMouseOver . . ��� $ BorderButtonAddCannons�� � ��
	 �����P�  � {� .  . ��� $ BorderButtonAddCannons�� � ��
	 ������� $ TextBlockCannonsCost�� � ��
	 ������� -   $��TabItemShips��$��Ships��.���� $��Hidden=�$	��150��$	��270��$��Visible=�.��� -   $��GridShipsContainer��$
��1050��$	��250�� �� $	��32* ��� $��* ��� $	��14* ��� $	��11* ��� $��* � �� $��4* ��� $��3* ��� $��4* ��� $��4* ��� $��4* ��� $��* ��� $��5* ��� $��2* ��� $��2* ��� $��4* ��� $��3* ��� $��4* ��� $��4* ��� $��4* ��� $��* ��� $��5* ��� $��2* ��� $��2* ��� $��4* ��� $��3* ��� $��4* ��� $��4* ��� $��4* ��� $��* ��� $��5* ��� $��2* ��� $��2* ��� $��4* ��� $��3* ��� $��4* ��� $��4* ��� $��4* ��� $��* ��� $��5* ��� $��2* ��� $��2* ��� $��4* ��� $��3* ��� $��4* ��� $��4* ��� $��4* ��� $��* ��� $��5* ��� $��2* ��� $��2* ��� $��4* ��� $��3* ��� $��4* ��� $��4* ��� $��4* ��� $��* ��� $��5* ��� $��2* ��� $��2* ��� $��4* ��� $��3* ��� $��4* ��� $��4* ��� $��4* ��� $��* ��� $��5* ��� $��2* ��� $��2* �.+��� $��0��$��0��$��5��$��Queen Anne`s Revenge��$��13(�$��Center=�$��Center=��� $��2��$��2��$��Health:��$��13(�$��Center=�$
��Left=��� $��3��$��2��$��Speed:��$��13(�$��Center=�$
��Left=��� $��4��$��2��$��Damage:��$��13(�$��Center=�$
��Left=��� -   $��TextBlockQARShipHealth��$��2��$��3��$��13(�$��Center=�$
��Left=����� $ QueenAnnesRevenge.Health� �� Mode$ OneWay=��� -   $��TextBlockQARShipSpeed��$��3��$��3��$��13(�$��Center=�$
��Left=����� $ QueenAnnesRevenge.Speed�$ OneWay=��� -   $��TextBlockQARShipDamage��$��4��$��3��$��13(�$��Center=�$
��Left=����� $ QueenAnnesRevenge.Damage�$ OneWay=��� $��1��$��7��$��0��$?��9../Resources/Ships/Presentations/Queen Anne's Revenge.jpg���� -   $��ButtonBuyQARShip��$��6��$��2��$��2��$
��10,4q�$��20500������ "
 ��.R��� $��BorderButtonQARShip��$ 7��
������ $��1q�
������ ._��  �� $��* ��� $��4* ��� $��9* �.+��� $��1��$8��2../Resources/Background images/GoldenShipCoint.png���� $��TextBlockQARCost��$��2��$��18(�$
��Bold"�
��� ���$��Bell MT)�$��Center=�#��z�� P�  �@J�IsMouseOver . . ��� $ BorderButtonQARShip�� � ��
	 �����P�  � {� .  . ��� $ BorderButtonQARShip�� � ��
	 ������� $ TextBlockQARCost�� � ��
	 ������� $��9��$��0��$��5��$��	Old Pearl��$��13(�$��Center=�$��Center=��� $��11��$��2��$��Health:��$��13(�$��Center=�$
��Left=��� $��12��$��2��$��Speed:��$��13(�$��Center=�$
��Left=��� $��13��$��2��$��Damage:��$��13(�$��Center=�$
��Left=��� -   $��TextBlockOPShipHealth��$��11��$��3��$��13(�$��Center=�$
��Left=����� $ OldPearl.Health�$ OneWay=��� -   $��TextBlockOPShipSpeed��$��12��$��3��$��13(�$��Center=�$
��Left=����� $ OldPearl.Speed�$ OneWay=��� -   $��TextBlockOPShipDamage��$��13��$��3��$��13(�$��Center=�$
��Left=����� $ OldPearl.Damage�$ OneWay=��� $��10��$��7��$��0��$4��.../Resources/Ships/Presentations/Old Pearl.jpg���� -   $��ButtonBuyOPShip��$��15��$��2��$��2��$
��10,4q�$��20800������ "
 ��.R��� $��BorderButtonOPShip��$ 7��
������ $��1q�
������ ._��  �� $��* ��� $��4* ��� $��9* �.+��� $��1��$8��2../Resources/Background images/GoldenShipCoint.png���� $��TextBlockOPCost��$��2��$��18(�$
��Bold"�
��� ���$��Bell MT)�$��Center=�#��z�� P�  �@J�IsMouseOver . . ��� $ BorderButtonOPShip�� � ��
	 �����P�  � {� .  . ��� $ BorderButtonOPShip�� � ��
	 ������� $ TextBlockOPCost�� � ��
	 ������� $��18��$��0��$��5��$��Pirate Brig��$��13(�$��Center=�$��Center=��� $��20��$��2��$��Health:��$��13(�$��Center=�$
��Left=��� $��21��$��2��$��Speed:��$��13(�$��Center=�$
��Left=��� $��22��$��2��$��Damage:��$��13(�$��Center=�$
��Left=��� -   $��TextBlockPBShipHealth��$��20��$��3��$��13(�$��Center=�$
��Left=����� $ PirateBrig.Health��� -   $��TextBlockPBShipSpeed��$��21��$��3��$��13(�$��Center=�$
��Left=����� $ PirateBrig.Speed��� -   $��TextBlockPBShipDamage��$��22��$��3��$��13(�$��Center=�$
��Left=����� $ PirateBrig.Damage��� $��19��$��7��$��0��$6��0../Resources/Ships/Presentations/Pirate Brig.jpg���� -   $��ButtonBuyPBShip��$��24��$��2��$��2��$
��10,4q�$��20000������ "
 ��.R��� $��BorderButtonPBShip��$ 7��
������ $��1q�
������ ._��  �� $��* ��� $��4* ��� $��9* �.+��� $��1��$8��2../Resources/Background images/GoldenShipCoint.png���� $��TextBlockPBCost��$��2��$��18(�$
��Bold"�
��� ���$��Bell MT)�$��Center=�#��z�� P�  �@J�IsMouseOver . . ��� $ BorderButtonPBShip�� � ��
	 �����P�  � {� .  . ��� $ BorderButtonPBShip�� � ��
	 ������� $ TextBlockPBCost�� � ��
	 ������� $��27��$��0��$��5��$��
The Ranger��$��13(�$��Center=�$��Center=��� $��29��$��2��$��Health:��$��13(�$��Center=�$
��Left=��� $��30��$��2��$��Speed:��$��13(�$��Center=�$
��Left=��� $��31��$��2��$��Damage:��$��13(�$��Center=�$
��Left=��� -   $��TextBlockTRShipHealth��$��29��$��3��$��13(�$��Center=�$
��Left=����� $ TheRanger.Health��� -   $��TextBlockTRShipSpeed��$��30��$��3��$��13(�$��Center=�$
��Left=����� $ TheRanger.Speed��� -   $��TextBlockTRShipDamage��$��31��$��3��$��13(�$��Center=�$
��Left=����� $ TheRanger.Damage��� $��28��$��7��$��0��$5��/../Resources/Ships/Presentations/The Ranger.jpg���� -   $��ButtonBuyTRShip��$��33��$��2��$��2��$
��10,4q�$��29000������ "
 ��.R��� $��BorderButtonTRShip��$ 7��
������ $��1q�
������ ._��  �� $��* ��� $��4* ��� $��9* �.+��� $��1��$8��2../Resources/Background images/GoldenShipCoint.png���� $��TextBlockTRCost��$��2��$��18(�$
��Bold"�
��� ���$��Bell MT)�$��Center=�#��z�� P�  �@J�IsMouseOver . . ��� $ BorderButtonTRShip�� � ��
	 �����P�  � {� .  . ��� $ BorderButtonTRShip�� � ��
	 ������� $ TextBlockTRCost�� � ��
	 ������� $��36��$��0��$��5��$��The Benjamin��$��13(�$��Center=�$��Center=��� $��38��$��2��$��Health:��$��13(�$��Center=�$
��Left=��� $��39��$��2��$��Speed:��$��13(�$��Center=�$
��Left=��� $��40��$��2��$��Damage:��$��13(�$��Center=�$
��Left=��� -    $��TextBlockTBShipHealth��$��38��$��3��$��13(�$��Center=�$
��Left=����� $ TheBenjamin.Health��� -!   $��TextBlockTBShipSpeed��$��39��$��3��$��13(�$��Center=�$
��Left=����� $ TheBenjamin.Speed��� -"   $��TextBlockTBShipDamage��$��40��$��3��$��13(�$��Center=�$
��Left=����� $ TheBenjamin.Damage��� $��37��$��7��$��0��$7��1../Resources/Ships/Presentations/The Benjamin.jpg���� -#   $��ButtonBuyTBShip��$��42��$��2��$��2��$
��10,4q�$��28500������ "
 ��.R��� $��BorderButtonTBShip��$ 7��
������ $��1q�
������ ._��  �� $��* ��� $��4* ��� $��9* �.+��� $��1��$8��2../Resources/Background images/GoldenShipCoint.png���� $��TextBlockTBCost��$��2��$��18(�$
��Bold"�
��� ���$��Bell MT)�$��Center=�#��z�� P�  �@J�IsMouseOver . . ��� $ BorderButtonTBShip�� � ��
	 �����P�  � {� .  . ��� $ BorderButtonTBShip�� � ��
	 ������� $ TextBlockTBCost�� � ��
	 ������� $��45��$��0��$��5��$��The Royal Fortune��$��13(�$��Center=�$��Center=��� $��47��$��2��$��Health:��$��13(�$��Center=�$
��Left=��� $��48��$��2��$��Speed:��$��13(�$��Center=�$
��Left=��� $��49��$��2��$��Damage:��$��13(�$��Center=�$
��Left=��� -$   $��TextBlockTRFShipHealth��$��47��$��3��$��13(�$��Center=�$
��Left=����� $ TheRoyalFortune.Health��� -%   $��TextBlockTRFShipSpeed��$��48��$��3��$��13(�$��Center=�$
��Left=����� $ TheRoyalFortune.Speed��� -&   $��TextBlockTRFShipDamage��$��49��$��3��$��13(�$��Center=�$
��Left=����� $ TheRoyalFortune.Damage��� $��46��$��7��$��0��$<��6../Resources/Ships/Presentations/The Royal Fortune.jpg���� -'   $��ButtonBuyTRFShip��$��51��$��2��$��2��$
��10,4q�$��30600������ "
 ��.R��� $��BorderButtonTRFShip��$ 7��
������ $��1q�
������ ._��  �� $��* ��� $��4* ��� $��9* �.+��� $��1��$8��2../Resources/Background images/GoldenShipCoint.png���� $��TextBlockTRFCost��$��2��$��18(�$
��Bold"�
��� ���$��Bell MT)�$��Center=�#��z�� P�  �@J�IsMouseOver . . ��� $ BorderButtonTRFShip�� � ��
	 �����P�  � {� .  . ��� $ BorderButtonTRFShip�� � ��
	 ������� $ TextBlockTRFCost�� � ��
	 ������� $��54��$��0��$��5��$��Black Pearl��$��13(�$��Center=�$��Center=��� $��56��$��2��$��Health:��$��13(�$��Center=�$
��Left=��� $��57��$��2��$��Speed:��$��13(�$��Center=�$
��Left=��� $��58��$��2��$��Damage:��$��13(�$��Center=�$
��Left=��� -(   $��TextBlockBPShipHealth��$��56��$��3��$��13(�$��Center=�$
��Left=����� $ BlackPearl.Health��� -)   $��TextBlockBPShipSpeed��$��57��$��3��$��13(�$��Center=�$
��Left=����� $ BlackPearl.Speed��� -*   $��TextBlockBPShipDamage��$��58��$��3��$��13(�$��Center=�$
��Left=����� $ BlackPearl.Damage��� $��55��$��7��$��0��$6��0../Resources/Ships/Presentations/Black Pearl.jpg���� -+   $��ButtonBuyBPShip��$��60��$��2��$��2��$
��10,4q�$��37500������ "
 ��.R��� $��BorderButtonBPShip��$ 7��
������ $��1q�
������ ._��  �� $��* ��� $��4* ��� $��9* �.+��� $��1��$8��2../Resources/Background images/GoldenShipCoint.png���� $��TextBlockBPCost��$��2��$��18(�$
��Bold"�
��� ���$��Bell MT)�$��Center=�#��z�� P�  �@J�IsMouseOver . . ��� $ BorderButtonBPShip�� � ��
	 �����P�  � {� .  . ��� $ BorderButtonBPShip�� � ��
	 ������� $ TextBlockBPCost�� � ��
	 ������� $��3��$��1��$8��2../Resources/Background images/GoldenShipCoint.png���� -,   $��TextBoxPlayerGold��$��2��$��3��$��18(�$
��Bold"�
��� ���$��Bell MT)�$��Center=�$
��Left=����� $ 
PlayerGold�$ OneWay=��� --   $��
ButtonSale��$��3��$��4������ "
 ��.R��� $��BorderButtonSale��$ 7��
�������$��1q�
���iii�._��  �� $��8* ��� $��* ��� $��5* �.+��� $��TextBlockText��$��0��$��	Sell ship��$��Bell MT)�
�������$��17(�$��Center=�$��Center=�$
��Bold"��� $��TextBlockPlus��$��1��$��+��$��18(�$��	ExtraBold"�
��� ���$��Bell MT)�$��Center=��� $��TextBlockShipCost��$��2��$��18(�$
��Bold"�
��� ���$��Bell MT)�$��Center=����� $ PlayerShipPrice�$ OneWay=� P�  �@J�IsMouseOver . . ��� $ BorderButtonSale�� � ��
	 �����P�  � {� .  . ��� $ BorderButtonSale�� � ��
	 ������� $ TextBlockText�� � ��
	 ������� $ TextBlockPlus�� � ��
	 �����