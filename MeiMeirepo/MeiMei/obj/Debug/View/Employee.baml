   M S B A M L   `   `   `  ����A  =MeiMei, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MeiMei.PropertiesMeiMei.Properties  5   D       MeiMei.ViewModel.Employee   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /resclr-namespace:MeiMei.Properties     6D     N� Title$  Employee��5
       N� 
Background �	#FFFAEBD8 � 	Resources 5         
ItemTemple��%M   &	        �� 5   
   .R�5      �� ��6   �� *FIO+6/   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��192* �6   �� 5      $	��11* �6    � ColumnDefinitions 5   
   �� 5      .+�5   
   �� $
��Left=�6k   $��	10,55,0,0q�6�   $	��Top=�6�   $	��194��6�    �� 
IsEditable .  �� IsTextSearchEnabled .  �� SelectedItem 6   �� *SelectedEmployee+��6=   �� *EmployeeFIOCollection+6�   �� 5   
    �� SelectedIndex$ 0��6   #��[  6s   $��
10,82,0,21q�6�   $��2��6  $
��Left=�6  $	��194��61   6$   �� *SelectedEmployee+	 �� UpdateSourceTrigger$	 PropertyChanged=���6�   �� *EmployeeFIOCollection+$	 PropertyChanged=�61  �� 5   
   
���   �$��1q�6%   $��209,55,10,21q�69   $��2��6O   �� 5   
   $��Button��68   $��	10,10,0,0q�6I   $	��Top=�6\   $��37��6t   ���	#FFFAEBD8$
��Left=�6�   $	��117��6�   ��6   �� *AddEmployeeCommand+��6�   Z� ��5      �� 5      .R�5      �� 
 �� Orientation$
 
Horizontal=�6!   .+�5       �� $&�� /MeiMei;component/Assets/Add.png��6    $��56��6J   $��39��6U    J� OpacityMask 5!      �� 5"   "    �� EndPoint$ 0.5,1&�66    �� 
StartPoint$ 0.5,0&�6G   .��5#   &   �  � Color$ Black��63    � Offset$ 0Q�6A   � 5$   &   $ White��63   $ 1Q�6A   5%   #   5'      �� 5(      $
��Auto��6$   !   MeiMei.Properties.Resources   Add_btn#��Z 61   $��Center=�6Y   5)      5*      5,      �� 5.   
   $��Button��69   $��
132,10,0,0q�6J   $	��Top=�6^   $��37��6v   ���	#FFFAEBD8$
��Left=�6�   $	��131��6�   ��6   �� *EditEmployeeCommand+��6�   Z� ��5/      �� 50      .R�51      �� $
 
Horizontal=�6!   .+�52      �� $'��!/MeiMei;component/Assets/Edit.png��6    $��44��6K   $��38��6V    53      �� 54   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��55   &   � $ Black��63   $ 0Q�6A   � 56   &   $ White��63   $ 1Q�6A   57   #   59      �� 5:      $��84��6$      Edit_btn#��Z 6/   $��Center=�6X   5;      5<      5>      �� 5@   
   $��Button��6;   $��
268,10,0,0q�6L   $	��Top=�6`   $��37��6x   ���	#FFFAEBD8$
��Left=�6�   $	��112��6�   ��6   �� *RemoveEmployeeCommand+��6�   Z� ��5A      �� 5B      .R�5C      �� $
 
Horizontal=�6!   .+�5D      �� $)��#/MeiMei;component/Assets/Remove.png��6    $��61��6M   $��40��6X    5E      �� 5F   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��5G   &   � $ Black��63   $ 0Q�6A   � 5H   &   $ White��63   $ 1Q�6A   5I   #   5K      �� 5L      $
��Auto��6$      
Delete_btn#��Z 61   $��Center=�6\   5M      5N      5P      � 5R   
   $��209,56,11,21q�6   $��2��6%    5S      �� 5T      $
��150* �6#   �� 5U      $
��241* �6#    5W      �� 5X      $��7* �6    �� 5Y      $
��166* �6    �� 5Z      $	��74* �6    �� 5[      $	��43* �6    �� 5\      $	��39* �6    .+�5^      �� $��10,4,8,4q�6   $��1��6G   ��6&   �� *EmployeePhoto+6G   &   System.Windows.Controls.DataGrid  5_         
IsReadOnly .    AutoGenerateColumns .     HeadersVisibility$ Column=�6y      CanUserDeleteRows .     CanUserAddRows .   �� 
IsSelected . $��2��6�   $��1��6�   $��	10,0,10,6q�6�   $��2��6  ��6   �� *EmployeeHistoriesCollection+   Columns 5`      0  *System.Windows.Controls.DataGridTextColumn  5a      ,  &System.Windows.Controls.DataGridColumn   CanUserSort .     CanUserResize .     	Data_text   Header# Z 6S      Width5  /System.Windows.Controls.DataGridLengthConverter$
 200* 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   �� *Data+6�     5b       .   .      NameOfServices_text# Z  6S   $
 200* 6�    6�   �� *ServiceName+6�     5c       .   .  !   PriceOfServices_text# Z! 6S   $
 100* 6�    6�   �� *Cost+6�   5e      � 5f      $��1��6   $��0,4,0,0q�6#   $��1��64   .+�5g      �� "   EmployeeWind_text_Info#��Z" 6   $��	10,4,39,0q�6R   # J� RenderTransformOrigin$# 0.842,4.231&�6e   $��14(�6�   $��33��6�   $	��Top=�6�   �� 5h      $��13,37,171,93q�6   $
��Wrap=�62   !$   EmployeeWind_text_FullName#��Z$ 6F   �� 5i      $��13,59,142,72q�6   $
��Wrap=�62   !%   EmployeeWind_text_Birthday#��Z% 6F   �� 5j      $��112,37,0,93q�6   $
��Wrap=�61   ��6E   �� *FIO+$	 PropertyChanged=��� 5k      $��13,80,162,51q�6   $
��Wrap=�62   !&   EmployeeWind_text_Function#��Z& 6F   �� 5l      $��112,59,0,72q�6   $
��Wrap=�61   ��6E   �� *	Bierthday+$	 PropertyChanged=��� 5m      $��112,80,0,51q�6   $
��Wrap=�61   ��6E   �� *Post+$	 PropertyChanged=�5n      � 5o      $��2��6   $��0,1,0,0q�6'   $��2��68    5p      �� 5q      $	��84* �6'   �� 5r      $	��76* �6'   �� 5s      $
��231* �6'   .+�5u      �� $��
10,1,62,46q�6   $
��Wrap=�60   !'   EmployeeWind_text_Contacts#��Z' 6D   $��14(�6   $��3��6�   �� 5v      $��10,22,27,25q�6   $
��Wrap=�61   (   EmployeeWind_text_Phone#��Z( 6E   �� 5w      $��
10,43,27,6q�6   $
��Wrap=�60   $��Email :��6D   �� 5x      $��	9,22,1,25q�6   $
��Wrap=�6/   $��1��6^   ��6C   �� *	Telephone+6^   �� 5y      $��9,43,1,4q�6   $
��Wrap=�6.   $��1��6Z   ��6B   �� *Salary+�� 6k   5{      6(   5|      � 5}      $��2��6   $��3��6'   $��2��64    5~      �� 5      $	��84* �6'   �� 5�      $
��307* �6'   .+�5�      �� $��	10,8,0,10q�6   $
��Wrap=�6/   ()   !EmployeeWind_text_PassportDetails#��Z) 6C   �� 5�      $��	10,8,0,39q�6   $
��Wrap=�6/   $��1��6�   $
��Left=�6�   $��64��6�   ��6C   �� *PerosnalData+$	 PropertyChanged=�6�   �� 5�      $��1��6   $��Right=�6,   $��
0,0,109,10q�6H   $
��Wrap=�6\   $+��%Зарплата за сегодня:��6p   $��Bottom=�6�   $��16��6�   �� 5�      $��1��6   $��	0,0,45,10q�6,   $
��Wrap=�6?   $��16��6p   $��Bottom=�6|   $��Right=�6�   $��37��6�   ��6S   �� *SaleryToday+6�   5�      5�      5�      5�      