   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   
Label_view  �� 
TargetType �� TextAlignment  BorderStyle �� 
TargetType �� Property �� Value  ButtonStyle  HeaderBackground �� EndPoint �� 
StartPoint � Color � Offset  HeaderWindow  BackgroundMain	 �� Color  ComboBoxNormalBorderBrush ! ComboBoxNormalBackgroundBrush # ComboBoxDisabledForegroundBrush #	 ComboBoxDisabledBackgroundBrush 
 ComboBoxDisabledBorderBrush   ComboBoxToggleButtonTemplate
 � ColumnDefinitions �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName  ComboBoxFlatStyle �� 	ClickMode d� 	IsChecked �� Path �� RelativeSource �� Mode J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate �� 
IsReadOnly �� 
IsReadOnly � AllowsTransparency �� IsDropDownOpen J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight-   'System.Windows.Input.KeyboardNavigation    DirectionalNavigation�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      localclr-namespace:GUI  5      %�  &	        &	     &	 �    &	 �    &	 y    &	     &	 8    &	 [    &	 ~    &		 �    &	
 �    &	 �    7  7  7  7 	 7 	 7 
 7  &	 L	    7  7  7  �� 5      "  ��6)   .R�5   
   � .+�5      �� 
���   �$	��0.6q�6)   ._�5      �� #��z��6   #��z��6@   #��z��6b   5	      �� 5
      #��z��6   $��16(�6C   $
��Bold"�6[   #��z��5   #   $ Center=�6W   $��Center=�6x   5      5      �� 5      " ��6    .�5   
   ��  � ��
 �����6'   �� 5   
    � ��
 �����6(   �� 5   
    � ��$	 0.2q�6,   �� 5   
    �@��CornerRadius$ 2��6)   5      �� 5      " ��6    .�5   
   ��  � ��$ 12(�6%   �� 5   
    � ��
 �����6'   �� 5   
    � ��
 � E��6'   �� 5   
    � ��$ 20��6"   �� 5   
    � ��$ Center=�6.   �� 5   
    � ��$ Center=�65   5      �� 5      $ 0.5,1&�63   $ 0.5,0&�6D   .��5    
   � $ 	#FFF3B097��6   $ 0Q�6)   � 5!   
   $ 	#FFEEB29C��6   $ 1Q�6)   5"      �� 5$      $ 0.5,1&�6/   $ 0.5,0&�6@   .��5%   
   � $ 	#FF487AE4��6   $ 0Q�6)   � 5&   
   $ 	#FF5696D6��6   $ 1Q�6)   5'      �� 5)      $	 	#FFE4CFAA��6-   �� 5,      $	 	#FF63C5EA��68   �� 5-      $	 	#FFF3F35E��6<   �� 5.      $	 #3B76B2��6>   �� 5/      $	 #EEAC2E��6>   �� 50      $	 #3B76B2��6:   �� 52      "  d�6   .R�53   
   � 
 54      �� 55      �� 56      $��20 �6#   .+�58      �� $��Border��6)   $��2��6   8��  $ 0��5:      $��
1, 1, 1, 1q�6    8�� 5;      �� 5<      $��ButtonBorder��6L   $��1��6   $��
1, 1, 1, 1q�6%   ���#444$ 
0, 0, 0, 0��5=      $��
0, 0, 0, 0q�6)   8�� 5>      F� 5@      $��Arrow��6   $��1��6    =����        �    �� � 	= ��[ � z �� � z     � 	=  	= 	$��Center=�5B      ���#444$��Center=�5C      5D       5E   
   P� 5F       �@J�IsMouseOver . . �5G      �� $ ButtonBorder��65    � ��
 �����6O   5H      P� 5I       �@d�	IsChecked$
 TrueY�68   . �5J      �� $ ButtonBorder��65    � ��
 �����6O   �� 5K      $ Arrow��6/    � �� �	#FF8D979E6B   5L      P� 5M       � {� .  . �5N      �� $ Border��65   8   � ��6I   �� 5O      $ ButtonBorder��65   8   � ��6O   �� 5P      $ ButtonBorder��67   8   � ��6Q   �� 5Q      8   � ��6;   �� 5R      $ Arrow��6/    � �� �#9996B   5S      5U      �� 5V      " ��6&   .�5W   
   ��  �@J�SnapsToDevicePixels . 6:   �� 5X   
    �@�OverridesDefaultStyle . 6C   �� 5Y   
    � ��$
 Auto=�6G   �� 5Z   
    � ��$
 Auto=�6E   �� 5[   
    � �� . 6:   �� 5\   
    � ��
 �   �63   �� 5]   
    �@�FocusVisualStyle 6>   Z� �� 5^   
    � �� 5_      �� 5`      "  ��6"   .R�5a      � .+�5b      d� $��ToggleButton��6'   $��2��6;   $ Press=�5c      |�.  8��   5d      �� $ IsDropDownOpen� �� *TemplatedParent+$ TwoWay=�5e      �� 5g      $��ContentSite��6+   $��5, 3, 23, 3q�6>    .  $
��Left=�5h      $��Center=�6:   #��z 5i      #��z 5j      #��z��5k      �� 5l      $��PART_EditableTextBox��6"   $��3, 3, 23, 3q�6>   # z 5m      $y�Hidden=�5n      
������ $
��Left=�5o      $��Center=�61   |�. .��5p   (   ��5q      �� 5r   "   "  ��62   .R�5s   &   �� $��PART_ContentHost��6-   |�.  6E   5t   #   .��5u   0   5v      � 5x      $��Popup��6    $��Bottom=�6-   |�.   . #��z 5z      $��Slide=�5{      .��5|      � $��DropDown��6#    . #��z 5}      #��z 5~      .+�5   "   �� $��DropDownBorder��6)   
�������$��
0, 1, 0, 0q�6R   $ 0��5�      $��1,1,1,1q�6*   8�� 5�      �� 5�   "   $��4q�6/    . .��5�   &   �� $ 	Contained=�65   5�   #   5�      5�      5�       5�      P� 5�       �@��HasItems .  . �5�      �� $ DropDownBorder��6K    � ��$ 95��6g   5�      P� 5�       � {� .  . �5�      �� 8   � ��6G   5�      P� 5�       �@��
IsGrouping . . �5�      ��  � �� .  6N   5�      P� 5�       �@��
IsEditable . . �5�      ��  �@  	IsTabStop .  6M   �� 5�      $ PART_EditableTextBox��6E    � y�$ Visible=�6g   �� 5�      $ ContentSite��6E    � y�$ Hidden=�6^   5�      5�      5�      5�      5�      