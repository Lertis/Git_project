   M S B A M L   `   `   `  ����   Pirates Bay#    Pirates_Bay.Views.OptionsMenu   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  	StartMenu��$	��170��$	��370�� � Icon$# ../Resources/Icons/Pirate.ico�� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=�$��Bookman Old Style)� � 	Resources  �� 
TargetType �� Property �� Value��%6   '��       �� " ��.���  �@�Cursor$
 Hand��.��� 	 � RowDefinitions	 �� $��28 ��� $��* �.+�� -   $��TitleBar��$��0��
 � ColumnDefinitions
 �� $��28 ��� $��* ��� $��28 ��� $��28 �����  �� EndPoint$ 0.7,1&� �� 
StartPoint$ 0.7,0&�.���  � Color$ DimGray�� � Offset$ 0Q�� $ Silver��$ 1Q�.+��� -   $#��../Resources/Icons/Pirate.ico��$��0��$��2q��� -   $��1��$��Center=�$
��Bold"�$��Bell MT)�$��15(�Pirates Bay�� -   $��MinimizeButton��$��2��   TitleBarButton#��[  ���� *MinimizeCommand+����  �� 
TargetType" ��.R��� $��MinimizeImage��$)��#../Resources/Icons/MinimizeIcon.png��$��UniformToFill=�$��20��$��20��$��Center=�$��Center=� � Cursor$
 Hand�� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  �� 
TargetName$ MinimizeImage�� � ��$ 24���� $ MinimizeImage�� � ��$ 24���� -   $��CloseButton��$��3��#��[  ���� *CloseCommand+���� " ��.R��� $��
CloseImage��$&�� ../Resources/Icons/CloseIcon.png��$��UniformToFill=�$��20��$��20��$��Center=�$��Center=�$
 Hand�� P�  �@J�IsMouseOver . . ��� $ 
CloseImage�� � ��$ 24���� $ 
CloseImage�� � ��$ 24��� -   $��GridContainer��$��1��
 �� $��* ��� $��6* ��� $��* ��� $��4* ��� $��* �	 �� $��* ��� $��3* ��� $��* ��� $��3* ��� $��* �.+��� -   $��TextBlockInterfaceStyle��$��1��$��1��$��Interface style��$��20(�
�������$��DemiBold"�$��Center=�$��Center=��� -   $��TextBlockVolume��$��3��$��1��$��Volume��$��20(�
�������$��DemiBold"�$��Center=�$��Center=��� -	   $��ListBoxStyles��$��1��$��3��
������ .@��� -
   $��	BlueStyle��
�����F�
�������$
��Blue��$��Center=�$��Stretch=��� -   $��	DarkStyle�����#585252
�������$
��Dark��$��Center=�$��Stretch=��� -   $��
LightStyle��
����������#585252$��Light��$��Center=�$��Stretch=��� -   $��SliderVolume��$��3��$��3��$��Center=� � Minimum$ 0Q� � Maximum$	 100Q� � Value$ 50Q� �� Interval$ 1������  �� Color$ 	SlateGray��