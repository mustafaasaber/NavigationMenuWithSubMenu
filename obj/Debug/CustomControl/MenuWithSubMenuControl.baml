   M S B A M L   `   `   `  ����J  FMenuWithSubMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:MenuWithSubMenu.CustomControlMenuWithSubMenu.CustomControl  5      :    4MenuWithSubMenu.CustomControl.MenuWithSubMenuControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:MenuWithSubMenu.CustomControl     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          >�Name$
  this��5      
������� � 	Resources 5
         DefaultSubMenuPadding u� Left  CaptionStyle �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource	 �� Mode
 �� AncestorType �� Value  MenuButtonStyle �� 
TargetType � ColumnDefinitions �� Triggers P� Property P� Value �� ElementName �� Padding �� FallbackValue �� TargetNullValue 	�Name 	� 	GroupName��%�
  &	        &	      &	 i    7  '��     '�� �    7   7   7  u� 5   
   $ 10Q�62   �� 5   
   " ��6%   .�5      ��  � ��
 �   �6+   �� 5       � ��$ Center=�62   �� 5       � ��$ 12(�6)   �� 5       � ��$ CharacterEllipsis=�6-    5      �� 5       6   �� *IsMouseOver+ �� $	 FindAncestor=�$
 ToggleButtonL� True6�   .a�5      ��  � �� �#515EC163   5      �� 5       6   �� *	IsChecked+ �� $	 FindAncestor=�$
 ToggleButtonL� True6�   .a�5      ��  � �� �#515EC163   5      �� 5       6   �� *IsMouseOver+ �� $	 FindAncestor=�$
 ListBoxItemL� True6�   .a�5      ��  � �� �#515EC163   5       �� 5!       6   �� *
IsSelected+ �� $	 FindAncestor=�$
 ListBoxItemL� True6�   .a�5"      ��  � �� �#515EC163   5#      5%      �� 5'   
   " d�6(   .�5(      ��  � ��$ 30��6'   �� 5)       � ��$ 0q�60   �� 5*       � ��
 ���� 6+   �� 5+       � |� .  6*   �� 5,       � ��$ Stretch=�64   �� 5-       � ��$ Center=�6;   �� 5/       � �� 50      �� 51      " d�6&   .R�52      �� #��z��6!   #��z��6K   ._�54      � $��5,0,5,0q�6#    55   "   �� 56   &   $
��Auto �67   �� 57   &   $��* �67   .+�5R   "   �� $��1��6,   8��  #��z��5T   ,   5V      5W       5X      P� 5Z       � ��$ 	Dashboard��69   . �5[   "   ��  �@d�	IsChecked$
 TrueY�6>   5\      5^      5`      5a      �� 5d   
   " ��6   .�5e      ��  � ��$ 0q�60   �� 5f       � ��
 �����6+   �� 5g       �@��SelectionMode$ Single=�6.   �� 5h       � |� .  6*   �� 5i       �@��SelectedIndex$ 0��6.    5j      �� 5l       6   �� *	IsChecked+$
 Menu��	 False6N   .a�5m      ��  � y�$ 	Collapsed=�63   5n      �� 5q       6   �� *
SubItems+ 6;   Z� .a�5r      ��  � y�$ 	Collapsed=�63   5s      5u      �� 5w   
   " ��6   .�5x      ��  � ��
 ���� 6+   �� 5y       � ��$ 0q�60   �� 5z       � ��$ 30��6'   �� 5{       � �� 5|      �� 5}      " ��6&   .R�5~      ��  6!   �� *SubMenuPadding+$
 this��8   8  ._�5�      	� $ SMenuButton��6*   $ SubMenu��5�   *   8�� ��5�   *   �� *	Command+��5�   *   �� *	Caption+$ Caption��$ Caption��5�   *   5�       5�      �� 5�      $
 True��6a    6*   �� *	IsChecked+$ SMenuButton��.a�5�   "   ��  �@��
IsSelected . 6?   5�      5�      5�      5�      5�      .��5�      �� $��Disabled=�5�      $��Disabled=�5�      ��5�      �� *
MenuList+��5�   
   �� 5�      .R�5�      �� .+�5�      	� $
 Menu��6"   $ MainMenu��5�   "   #��[ 5�   "   ��5�   "   �� *	Command+��5�   "   �� *	Caption+5�   "   �� 5�      $��Disabled=�5�      $��Disabled=�5�      ��5�      �� *
SubItems+5�      5�      5�      5�      5�      