   M S B A M L   `   `   `  ����A  =MeiMei, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MeiMei.PropertiesMeiMei.Properties  5   D   !    MeiMei.ViewModel.ClientPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /resclr-namespace:MeiMei.Properties     6D     N� Title$  Clients��5       N� 
Background �	#FFFAEBD8 � 	Resources 5
         
ItemTemple��%M   &	        �� 5   
   .R�5      �� ��6   �� *FIO+6/   5      5      .��5      �  � RowDefinitions 5   
   �� 5      .+�5   
   �� $��Button��69   $��	10,10,0,0q�6J   $	��Top=�6]   $��42��6u   ���	#FFFAEBD8$
��Left=�6�   $	��117��6�   ��6   �� *AddCustomersCommand+��6�   Z� ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $-��'/MeiMei;component/Assets/AddClients.png��6    $��56��6Q   $��39��6\    J� OpacityMask 5      �� 5   "    �� EndPoint$ 0.5,1&�66    �� 
StartPoint$ 0.5,0&�6G   .��5   &   �  � Color$ Black��63   	 � Offset$	 0Q�6A   � 5   &   $ White��63   $	 1Q�6A   5   #   5       �� 5!      $
��Auto��6$   !   MeiMei.Properties.Resources
   Add_btn#��Z
 61   $��Center=�6Y   5"      5#      5%      �� 5'   
   $��Button��69   $��
132,10,0,0q�6J   $	��Top=�6^   $��42��6v   ���	#FFFAEBD8$
��Left=�6�   $	��131��6�   ��6   �� *EditCustomerCommand+��6�   Z� ��5(      �� 5)      .R�5*      �� $ 
Horizontal=�6!   .+�5+      �� $.��(/MeiMei;component/Assets/EditClients.png��6    $��44��6R   $��38��6]    5,      �� 5-   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��5.   &   � $ Black��63   $	 0Q�6A   � 5/   &   $ White��63   $	 1Q�6A   50   #   52      �� 53      $��84��6$      Edit_btn#��Z 6/   $��Center=�6X   54      55      57      �� 59   
   $��Button��6;   $��
268,10,0,0q�6L   $	��Top=�6`   $��42��6x   ���	#FFFAEBD8$
��Left=�6�   $	��112��6�   ��6   �� *RemoveCustomerCommand+��6�   Z� ��5:      �� 5;      .R�5<      �� $ 
Horizontal=�6!   .+�5=      �� $0��*/MeiMei;component/Assets/RemoveClients.png��6    $��61��6T   $��40��6_    5>      �� 5?   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��5@   &   � $ Black��63   $	 0Q�6A   � 5A   &   $ White��63   $	 1Q�6A   5B   #   5D      �� 5E      $
��Auto��6$      
Delete_btn#��Z 61   $��Center=�6\   5F      5G      5I      � 5L   
   $��0,57,0,0q�6    � ColumnDefinitions 5M      �� 5N      $
��198* �6#   �� 5O      $
��413* �6#   .+�5Q      ��  �� SelectedIndex$ 0��6   #��[  6g   $��
10,28,2,10q�6�    �� SelectedItem 6(   �� *SelectedCustomer+ �� Mode$ OneWayToSource=���6�   �� *CustomersColl+$ OneWay=�6�   �� 5R      $��10,0,0,0q�6g   $	��Top=�6y    �� 
IsEditable .  �� IsTextSearchEnabled .  6   �� *SelectedCustomer+��6A   �� *CustomersColl+6�   � 5T      $��1��6    5U      �� 5V      $
��161* �6$   �� 5W      $
��202* �6$   .+�5Z      &   System.Windows.Controls.DataGrid     
IsReadOnly .    AutoGenerateColumns .     HeadersVisibility$ Column=�6I      CanUserDeleteRows .     CanUserAddRows .  $��1��6�   $��10q�6�   ��6�   �� *CustomerHistory+   Columns 5[      0  *System.Windows.Controls.DataGridTextColumn  5\      ,  &System.Windows.Controls.DataGridColumn   CanUserSort .     CanUserResize .     	Data_text   Header# Z 6W      Width5  /System.Windows.Controls.DataGridLengthConverter$
 200* 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6�   �� *Data+6�     5]       .   .     NameOfServices_text# Z 6W   $
 200* 6�    6�   �� *ServiceName+6�     5^       .   .      PriceOfServices_text# Z  6W   $
 100* 6�    6�   �� *ServiceCost+6�   5`      � 5b       5c      �� 5d      $	��23* �6+   �� 5e      $	��36* �6+   .+�5g      �� $��20,10,10,11q�6   ��61   �� *CustomerPhoto+�� 5h      $��41,10,61,129q�6    $
��Wrap=�66   !   CustomerWind_text_Info#��Z! 6J   $��1��6�   $��	Underline{�6�   �� 5i      $��1��6    $
��Left=�60   $��0,31,0,0q�6K   $
��Wrap=�6]   !"   EmployeeWind_text_FullName#��Z" 6q   $	��Top=�6�   $��	Underline{�6�   �� 5j      $��1��6    $
��Left=�60   $��0,52,0,0q�6K   $
��Wrap=�6]   !#   EmployeeWind_text_Contacts#��Z# 6q   $	��Top=�6�   $��	Underline{�6�   �� 5k      $��1��6    $
��Left=�60   $��	67,32,0,0q�6K   $
��Wrap=�6^   $	��Top=�6�   $	��175��6�   ��6r   �� *FIO+6�   �� 5l      $��1��6    $
��Left=�60   $��	67,52,0,0q�6K   $
��Wrap=�6^   $	��Top=�6�   $	��175��6�   ��6r   �� *
Contakts+6�   �� 5m      $
��Left=�6    $��	0,100,0,0q�6;   $
��Wrap=�6N    $   CustomerWind_text_addInfo#��Z$ 6b   $	��Top=�6�   $��1��6�   $��	Underline{�6�   �� 5n      $
��Left=�6    $��0,79,0,0q�6;   $
��Wrap=�6M   !%   EmployeeWind_text_Birthday#��Z% 6a   $	��Top=�6�   $��1��6�   $��	Underline{�6�   �� 5o      $
��Left=�6    $��
101,79,0,0q�6;   $
��Wrap=�6O   $	��Top=�6}   $��1��6�   $��	Underline{�6�   ��6c   �� *
Birthday+6�   �� 5q      & �� AutoWordSelection& .  ' �� TextWrapping$
' Wrap=�68   ( �� 
IsReadOnly( . $��0,121,26,10q�6t   $��1��6�   ���	#FFFAEBD8���	#FFFAEBD8) �� SelectionBrush) �	#FFFAEBD8��6^   �� *Note+6�   �� 5s      
���   �$��1q�61   $��2��6E   $
��10,0q�6Y   5u      5v      5x      5y      5z      