   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.wdHienThiDuLieu   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  wdHienThiDuLieu��5   	   $	��650��6!   $	��900��6.    � WindowStartupLocation$ CenterScreen=�6:    � 	Resources 5	         DGHeaderStyle �� 
TargetType&   System.Windows.Controls.DataGrid �� Property  DGCHeaderStyle �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader  MyCommandEsc �� Text  MyCommandF5��%�  &	        &	 X     &	 9    &	 W    �� 5
   
   "  6&   .�5      ��  �@ ColumnHeaderStyle# �  62   5      �� 5   
   "  6'   .�5      ��  � ��$ 30��6'   �� 5       � ��
 �2͚�6+   �� 5       � ��
 �   �6+   �� 5       � ��$ 14(�6)   �� 5       � ��$ Calibri)�6+   5      �� 5   
   $
 text��6/   �� 5   
   $
 text��6.   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command# [ 5      6A     5   
   -   5        # [ 5      6@   	 J� InputBindings	 5      �� 5   
   

 �� Key$	
 Esc��6    �� Command# [ 6   �� 5   
   $
 F5��6   # [ 6   .��5       �  � RowDefinitions 5!   
   �� 5"      $��3* �6   �� 5#      $	��10* �6   �� 5$      $��1* �6   .+�5&   
   �� $��Truy xuất dữ liệu��6   $��14(�6.   $
��Bold"�6<   .��5'      �  5(      �� 5)      �� 5*       � ColumnDefinitions 5,      �� 5-      �� 5.      .+�51      ��   
Label_view#��[ 6   $#��Truy xuất theo ngày tháng��6?   ���	#FF2EC990
�������6z   �� 52      $��1��6   #��[ 6%   $#��Truy xuất theo khách hàng��6L   ���	#FF2EC990
�������6�   (  "System.Windows.Controls.DatePicker  54      $��5 0 5 0q�6   $��35��6/   $��1��6;   ���	#FFFFE7946K   �� 55      $��1��6   $��1��6+   $��12(�68   $
��Bold"�6F   ���	#FFFFE794$��35��56      $��Center=�6'   $��5 0 5 0q�6B   57      58      �� 59   
   $��1��6   ._�5:        -   5        $��	dataGrid3��5:   $   $��2��6      AutoGenerateColumns .    RowHeaderWidth$ 10Q�5;         GridLinesVisibility$ 
Horizontal=�6'      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5<         SelectionUnit$
 Cell=�6#      SelectionMode$ Extended=�68      CanUserResizeColumns .     CanUserResizeRows .  $��Stretch=�5=   -   $��Stretch=�6K   $��10q�6p      RowStyle 5>      �� 5?      )  #System.Windows.Controls.DataGridRow"  6   .�5@      ��  � �� �	#FFA4EAA467    �� Triggers 5A      P� 5B       P� Property �@J�IsMouseOver P� Value . . �5C   "   ��  � ��
 � � �6?   �� 5D   "    � ��
 �����6?   5E      5G      5I      5J      � 5K   
   $��2��6    5L      �� 5M      �� 5N      .+�5P      �� #��[ 6   $��Bấm Esc để thoát��6;   
����������	#FF2C47A45Q      �� 5R      $��1��6   #��[ 6$   $"��F5 - Tải lại dữ liệu��6K   
����������	#FF2C47A45S      5T      5U      5V      