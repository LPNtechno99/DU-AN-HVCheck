   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  
MainWindow��5   	   $	��170��6   $	��350��6)    � WindowStyle$
 None=�65    � WindowStartupLocation$ CenterScreen=�6H    � 	Resources 5
         MyCommandF1 �� Text  MyCommandF2��%P   &	        &	      �� 5   
   $
 text��6.   �� 5   
   $
 text��6.   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command# [  5      6@     5   
   -   5        # [ 5      6@    J� InputBindings 5      �� 5   
   
 �� Key$ F1��6   	 �� Command#	 [  6   �� 5   
   $ F2��6   #	 [ 6   .��5      � 
 � RowDefinitions
 5   
   �� 5      $��20 �6   �� 5      �� 5      $��30 �6   .+�5   
   ��   HeaderBackground#��[ 6   .+�5      �� -   5        $��btnClose��5   1   $��X��5        ButtonStyle#��[ 6!   $��Right=�5      6A   5      � 5    
   $��1��6     BackgroundMain#���  6   
 5!      �� 5"      $��50 �6    �� 5#      .+�5%      �� $!��CHỌN CHẾ ĐỘ CHẠY: ��6   $��Center=�62   $��20(�6M   $
��Bold"�5&      $��5 0 0 0q�6*   ��5'      �� 5(       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5)      �  � Color$ 	#FF214B74��6'    � Offset$ 0Q�69   � 5*      $ 	#FF347DC7��6'   $ 1Q�69   5+      5-      �� 5.      -   5        $��cbbChonCheDo��5/   9   $��1��5.      $��35��6$   $��18(�60   $
��Bold"�6>   $��10q�6P   ���	#FFEA9494$��Center=�5/      .@�50      �� $��Chạy thường��6   �� 51      $��Chạy Kiểm Tra��6   52      53      � 54   
   $��2��6   #��[ 6    � ColumnDefinitions 55      �� 56      �� 57      .+�59      �� $'��!F1 - Chế độ chạy thường��6   $��12(�67   $
��Bold"�6E   $��Center=�5:      $��Center=�63   �� 5;      $��1��6   $(��"F2 - Chế độ chạy kiểm tra��6(   $��12(�6I   $
��Bold"�6W   $��Center=�5<      $��Center=�63   5=      5>      5?      