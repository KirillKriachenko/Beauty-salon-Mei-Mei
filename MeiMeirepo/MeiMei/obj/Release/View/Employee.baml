   M S B A M L   `   `   `  ���� A  =MeiMei, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MeiMei.PropertiesMeiMei.Properties      MeiMei.ViewModel.Employee   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /resclr-namespace:MeiMei.Properties       N� Title$  Employee�� N� 
Background �	#FFFAEBD8 � 	Resources    
ItemTemple��%(   &	        �� .R��� ���� *FIO+.���  � RowDefinitions �� $
��192* ��� $	��11* � � ColumnDefinitions �� .+��� $
��Left=�$��	10,55,0,0q�$	��Top=�$	��194�� �� 
IsEditable .  �� IsTextSearchEnabled .  �� SelectedItem �� *SelectedEmployee+���� *EmployeeFIOCollection+��  �� SelectedIndex$ 0��#��[  $��
10,82,0,21q�$��2��$
��Left=�$	��194�� �� *SelectedEmployee+	 �� UpdateSourceTrigger$	 PropertyChanged=����� *EmployeeFIOCollection+$	 PropertyChanged=��� 
���   �$��1q�$��209,55,10,21q�$��2���� $��Button��$��	10,10,0,0q�$	��Top=�$��37�����	#FFFAEBD8$
��Left=�$	��117������ *AddEmployeeCommand+��Z� ���� .R��� 
 �� Orientation$
 
Horizontal=�.+��� $&�� /MeiMei;component/Assets/Add.png��$��56��$��39�� J� OpacityMask ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ White��$ 1Q��� $
��Auto��!   MeiMei.Properties.Resources   Add_btn#��Z $��Center=��� $��Button��$��
132,10,0,0q�$	��Top=�$��37�����	#FFFAEBD8$
��Left=�$	��131������ *EditEmployeeCommand+��Z� ���� .R��� $
 
Horizontal=�.+��� $'��!/MeiMei;component/Assets/Edit.png��$��44��$��38�� �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ White��$ 1Q��� $��84��   Edit_btn#��Z $��Center=��� $��Button��$��
268,10,0,0q�$	��Top=�$��37�����	#FFFAEBD8$
��Left=�$	��112������ *RemoveEmployeeCommand+��Z� ���� .R��� $
 
Horizontal=�.+��� $)��#/MeiMei;component/Assets/Remove.png��$��61��$��40�� �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ White��$ 1Q��� $
��Auto��   
Delete_btn#��Z $��Center=�� $��209,56,11,21q�$��2�� �� $
��150* ��� $
��241* � �� $��7* ��� $
��166* ��� $	��74* ��� $	��43* ��� $	��39* �.+��� $��10,4,8,4q�$��1������ *EmployeePhoto+&   System.Windows.Controls.DataGrid     
IsReadOnly .    AutoGenerateColumns .     HeadersVisibility$ Column=�   CanUserDeleteRows .     CanUserAddRows .   �� 
IsSelected . $��2��$��1��$��	10,0,10,6q�$��2������ *EmployeeHistoriesCollection+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   CanUserSort .     CanUserResize .     	Data_text   Header# Z    Width5  /System.Windows.Controls.DataGridLengthConverter$
 200* 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Data+   .   .      NameOfServices_text# Z  $
 200*  �� *ServiceName+   .   .  !   PriceOfServices_text# Z! $
 100*  �� *Cost+� $��1��$��0,4,0,0q�$��1��.+��� "   EmployeeWind_text_Info#��Z" $��	10,4,39,0q�# J� RenderTransformOrigin$# 0.842,4.231&�$��14(�$��33��$	��Top=��� $��13,37,171,93q�$
��Wrap=�!$   EmployeeWind_text_FullName#��Z$ �� $��13,59,142,72q�$
��Wrap=�!%   EmployeeWind_text_Birthday#��Z% �� $��112,37,0,93q�$
��Wrap=����� *FIO+$	 PropertyChanged=��� $��13,80,162,51q�$
��Wrap=�!&   EmployeeWind_text_Function#��Z& �� $��112,59,0,72q�$
��Wrap=����� *	Bierthday+$	 PropertyChanged=��� $��112,80,0,51q�$
��Wrap=����� *Post+$	 PropertyChanged=�� $��2��$��0,1,0,0q�$��2�� �� $	��84* ��� $	��76* ��� $
��231* �.+��� $��
10,1,62,46q�$
��Wrap=�!'   EmployeeWind_text_Contacts#��Z' $��14(�$��3���� $��10,22,27,25q�$
��Wrap=�(   EmployeeWind_text_Phone#��Z( �� $��
10,43,27,6q�$
��Wrap=�$��Email :���� $��	9,22,1,25q�$
��Wrap=�$��1������ *	Telephone+�� $��9,43,1,4q�$
��Wrap=�$��1������ *Salary+�� � $��2��$��3��$��2�� �� $	��84* ��� $
��307* �.+��� $��	10,8,0,10q�$
��Wrap=�()   !EmployeeWind_text_PassportDetails#��Z) �� $��	10,8,0,39q�$
��Wrap=�$��1��$
��Left=�$��64������ *PerosnalData+$	 PropertyChanged=��� $��1��$��Right=�$��
0,0,109,10q�$
��Wrap=�$+��%Зарплата за сегодня:��$��Bottom=�$��16���� $��1��$��	0,0,45,10q�$
��Wrap=�$��16��$��Bottom=�$��Right=�$��37������ *SaleryToday+