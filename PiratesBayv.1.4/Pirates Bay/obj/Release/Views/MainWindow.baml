   M S B A M L   `   `   `  ���� F  BPirates Bay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Pirates_Bay.ViewsPirates_Bay.Views  "    Pirates_Bay.Views.MainWindow   )Viewsclr-namespace:Pirates_Bay.Views  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  
MainWindow��$	��600��$	��810�� � WindowStyle$
 None=�$y�Visible=� � 
ResizeMode$ NoResize=� � Icon$# ../Resources/Icons/Pirate.ico�� � WindowStartupLocation$ CenterScreen=� � 	Resources  �� 
TargetType �� Property �� Value��%6   '��       �� " ��.���  �@�Cursor$
 Hand��.��� 	 � RowDefinitions	 �� $��28 ��� $��* �.+�� -   $��GridTitleBar��$��0��
 � ColumnDefinitions
 �� $��28 ��� $��* ��� $��28 ��� $��28 �����  �� EndPoint$ 0.4,1&� �� 
StartPoint$ 0.4,0&�.���  � Color$ DimGray�� � Offset$ 0Q�� $ Silver��$ 1Q�.+��� -   $#��../Resources/Icons/Pirate.ico��$��0��$��2q��� -   $��1��$��Center=�$
��Bold"�$��Bell MT)�$��15(�Pirates Bay�� -   $��MinimizeButton��$��2��   TitleBarButton#��[  ���� *MinimizeCommand+����  �� 
TargetType" ��.R��� $��MinimizeImage��$)��#../Resources/Icons/MinimizeIcon.png��$��UniformToFill=�$��20��$��20��$��Center=�$��Center=� � Cursor$
 Hand�� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  �� 
TargetName$ MinimizeImage�� � ��$ 24���� $ MinimizeImage�� � ��$ 24���� -   $��CloseButton��$��3��#��[  ���� *CloseCommand+���� " ��.R��� $��
CloseImage��$&�� ../Resources/Icons/CloseIcon.png��$��UniformToFill=�$��20��$��20��$��Center=�$��Center=�$
 Hand�� P�  �@J�IsMouseOver . . ��� $ 
CloseImage�� � ��$ 24���� $ 
CloseImage�� � ��$ 24��� $��1��	 �� $��3* ��� $��* �.+�� -   $��GridMapContainer��$��0��	 �� $��5* ��� $	��13* ��� $��2* �
 �� $��* ��� $��7* ��� $��* �.+��� -   $��	CanvasMap��$��1��$��1������  �� ImageSource$6 0../Resources/Background images/SeaBackground.jpg��� -	   $��GridOuterContainer��$��1������  �� Color$ 	SlateGray��.+�� -
   $��GridMainContainer��$��5q�
 �� $��2* ��� $��2* ��� $��2* �.+�4   .Pirates_Bay.Views.PlayerDescriptionUserControl  $��0��   Player ��  �� Path$ FirstPlayer� �� Mode$ TwoWay=�� -   $��GridOptions��$��1��
 �� $��* ��� $��* ��� $��4* ��� $��4* ��� $��* ��� $��* �	 �� $��3* ��� $��5* ��� $��4* ��� $��* ��� $��5* �.+��� $��2��$��2��$��0��$��3��$5��/../Resources/Background images/PirateSymbol.png���� -   $��ImageFirstUserActive��$��0��$��2��$��1��$8��2../Resources/Background images/PirateArrowLeft.png���� -   $��ImageSecondUserActive��$��4��$��2��$��1��$9��3../Resources/Background images/PirateArrowRight.png��$y�Hidden=��� -   $��ButtonOptions��$��1��$��2��$��4��  MenuButtonDarkStyle#��[ $��Options������ *ShowOptionsCommand+�� -   $��ButtonNewGame��$��3��$��2��$��4��#��[ $��New game������ *StartNewGameCommand+  $��2�� �� $ SecondPlayer�$ TwoWay=�