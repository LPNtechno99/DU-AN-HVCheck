   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.wdKiemTra   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	   -   5          � Title$  	wdKiemTra��5   	   $	��550��6   $	��500��6(    � WindowStartupLocation$ CenterScreen=�64    � 	Resources 5	         MyCommandESC �� Text��%(   &	        �� 5   
   $
 text��6/   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command# [  5      6A    J� InputBindings 5      �� 5   
   
 �� Key$	 Esc��6    �� Command# [  6   .��5      � 	 � RowDefinitions	 5   
   �� 5      $	��300 �6   �� 5      �� 5      $��25 �6   .+�5   
   �� $��Thông tin kiểm tra��6   $��18(�6/   $
��Bold"�6=   .��5      � 	 5      �� 5      �� 5      �� 5      �� 5       �� 5!      
 � ColumnDefinitions
 5#      �� 5$      $	��180 �6'   �� 5%      .+�5'      �� $��Mã Nhận được��6     
Label_view#��[ 6/   ���	#FF276BA4
�������5(      �� 5)      $��1��6   $��Mã Đại Lý��6%   #��[ 69   ���	#FF276BA4
�������5*      �� 5+      $��2��6   $��Tên Đại Lý��6%   #��[ 6:   ���	#FF276BA4
�������5,      �� 5-      $��3��6   $��Giờ Ngày Xuất��6%   #��[ 6=   ���	#FF276BA4
�������5.      �� 5/      $��4��6   $��Tính đến hiện tại��6%   #��[ 6A   ���	#FF276BA4
�������50      �� 51      $��1��6   #��[ 6(   ���	#FF3AC55A
�������$
��None��52   +   �� 53      $��1��6   $��1��6(   #��[ 65   ���	#FF3AC55A
�������$
��None��54   +   �� 55      $��1��6   $��2��6(   #��[ 65   ���	#FFE84C3C
�������$
��None��56   +   �� 57      $��1��6   $��3��6(   #��[ 65   ���	#FFF07345
�������$
��None��58   +   �� 59      $��1��6   $��4��6(   #��[ 65   ���	#FF3AC55A
�������$
��None��5:   +   5;      5<      �� 5=   
   $��1��6   $��Kết Quả��6    $��16(�61   $
��Bold"�6?   .��5>      �� ���	#FFD3D1D1$��50(�6+   $
��Bold"�69   
�������$
��None��5?   '   $��Center=�66   $��Center=�6X   5@      �� 5A   
   $��2��6   #��[ 6   ���	#FF25397A$��Bấm Esc để thoát��5B      
�������6+   5C      5D      