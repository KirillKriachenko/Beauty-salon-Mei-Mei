   M S B A M L   `   `   `  ����A  =MeiMei, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MeiMei.PropertiesMeiMei.Properties  5   D   !    MeiMei.ViewModel.ServisPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /resclr-namespace:MeiMei.Properties     6D     N� Title$  
ServisPage��5       � 	Resources 5	         
ItemTemple��%Y   &	        �� 5
   
   .R�5      �� ��6   �� *KategoriaServis+6;   5      5      .��5      � ���	#FFFAEBD8.+�5   
   &   System.Windows.Controls.DataGrid     
IsReadOnly .    SelectionMode$ Single=�6%    �� SelectedIndex$ 0��6<      CanUserSortColumns .     CanUserAddRows .     HeadersVisibility$ Column=�6�      AutoGenerateColumns .  $��
10,57,0,10q�65  $
��Left=�6I  $	��212��6d  	 �� SelectedItem	 6�   �� *SelectedTypeService+
 �� UpdateSourceTrigger$
 PropertyChanged=���6�   �� *KategoriaCollection+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      !   MeiMei.Properties.Resources   CategoryServices_text,  &System.Windows.Controls.DataGridColumn   Header# Z 6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6]   �� *TypeService+$
 PropertyChanged=�6�   5      �� 5   
   $��Button��6:   $
��Left=�6K   $��	10,10,0,0q�6f   $	��Top=�6y   $	��112��6�   $��42��6�   ���	#FFFAEBD8��6   �� *AddServisOpenCommand+��6�   Z� ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $&�� /MeiMei;component/Assets/Add.png��6     J� OpacityMask 5      �� 5   "    �� EndPoint$ 0.5,1&�66    �� 
StartPoint$ 0.5,0&�6G   .��5   &   �  � Color$ Black��63    � Offset$ 0Q�6A   � 5   &   $ White��63   $ 1Q�6A   5    #   5"      �� 5#      $
��Auto��6$      Add_btn#��Z 61   $��Center=�6Y   5$      5%      5'      �� 5)   
   $��Button��68   $
��Left=�6I   $��
138,10,0,0q�6d   $	��Top=�6x   $	��140��6�   $��42��6�   ���	#FFFAEBD8��6   �� *EditServisCommand+��6�   Z� ��5*      �� 5+      .R�5,      �� $ 
Horizontal=�6!   .+�5-      �� $'��!/MeiMei;component/Assets/Edit.png��6     5.      �� 5/   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��50   &   � $ Black��63   $ 0Q�6A   � 51   &   $ White��63   $ 1Q�6A   52   #   54      �� 55      $
��Auto��6$      Edit_btn#��Z 61   $��Center=�6Z   56      57      59      �� 5;   
   $��Button��6;   $
��Left=�6L   $��
296,10,0,0q�6g   $	��Top=�6{   $	��112��6�   $��42��6�   ���	#FFFAEBD8��6   �� *DeleteServiceCommand+��6�   Z� ��5<      �� 5=      .R�5>      �� $ 
Horizontal=�6!   .+�5?      �� $)��#/MeiMei;component/Assets/Remove.png��6     5@      �� 5A   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��5B   &   � $ Black��63   $ 0Q�6A   � 5C   &   $ White��63   $ 1Q�6A   5D   #   5F      �� 5G      $
��Auto��6$      
Delete_btn#��Z 61   $��Center=�6\   5H      5I      5K        5M   
    . $ Column=�6%      CanUserDeleteRows .   .   .  $��237,57,10,10q�6  	 6q   �� *SelectedService+��6�   �� *PriceCollection+$
 PropertyChanged=� 5N        5O         CanUserSort .     CanUserResize .     NameOfServices_text# Z 6O   $
 200* 6�    6�   �� *ServiceName+6�     5P       .   .     PriceOfServices_text# Z 6O   $
 200* 6�    6�   �� *ServicePrice+6�   5R      5S      5T      