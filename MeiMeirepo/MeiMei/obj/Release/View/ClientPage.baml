   M S B A M L   `   `   `  ���� A  =MeiMei, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MeiMei.PropertiesMeiMei.Properties  !    MeiMei.ViewModel.ClientPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /resclr-namespace:MeiMei.Properties       N� Title$  Clients�� N� 
Background �	#FFFAEBD8 � 	Resources    
ItemTemple��%(   &	        �� .R��� ���� *FIO+.���  � RowDefinitions �� .+��� $��Button��$��	10,10,0,0q�$	��Top=�$��42�����	#FFFAEBD8$
��Left=�$	��117������ *AddCustomersCommand+��Z� ���� .R���  �� Orientation$ 
Horizontal=�.+��� $-��'/MeiMei;component/Assets/AddClients.png��$��56��$��39�� J� OpacityMask ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black��	 � Offset$	 0Q�� $ White��$	 1Q��� $
��Auto��!   MeiMei.Properties.Resources
   Add_btn#��Z
 $��Center=��� $��Button��$��
132,10,0,0q�$	��Top=�$��42�����	#FFFAEBD8$
��Left=�$	��131������ *EditCustomerCommand+��Z� ���� .R��� $ 
Horizontal=�.+��� $.��(/MeiMei;component/Assets/EditClients.png��$��44��$��38�� �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$	 0Q�� $ White��$	 1Q��� $��84��   Edit_btn#��Z $��Center=��� $��Button��$��
268,10,0,0q�$	��Top=�$��42�����	#FFFAEBD8$
��Left=�$	��112������ *RemoveCustomerCommand+��Z� ���� .R��� $ 
Horizontal=�.+��� $0��*/MeiMei;component/Assets/RemoveClients.png��$��61��$��40�� �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$	 0Q�� $ White��$	 1Q��� $
��Auto��   
Delete_btn#��Z $��Center=�� $��0,57,0,0q� � ColumnDefinitions �� $
��198* ��� $
��413* �.+���  �� SelectedIndex$ 0��#��[  $��
10,28,2,10q� �� SelectedItem �� *SelectedCustomer+ �� Mode$ OneWayToSource=����� *CustomersColl+$ OneWay=��� $��10,0,0,0q�$	��Top=� �� 
IsEditable .  �� IsTextSearchEnabled .  �� *SelectedCustomer+���� *CustomersColl+� $��1�� �� $
��161* ��� $
��202* �.+�&   System.Windows.Controls.DataGrid     
IsReadOnly .    AutoGenerateColumns .     HeadersVisibility$ Column=�   CanUserDeleteRows .     CanUserAddRows .  $��1��$��10q����� *CustomerHistory+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   CanUserSort .     CanUserResize .     	Data_text   Header# Z    Width5  /System.Windows.Controls.DataGridLengthConverter$
 200* 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Data+   .   .     NameOfServices_text# Z $
 200*  �� *ServiceName+   .   .      PriceOfServices_text# Z  $
 100*  �� *ServiceCost+�  �� $	��23* ��� $	��36* �.+��� $��20,10,10,11q����� *CustomerPhoto+�� $��41,10,61,129q�$
��Wrap=�!   CustomerWind_text_Info#��Z! $��1��$��	Underline{��� $��1��$
��Left=�$��0,31,0,0q�$
��Wrap=�!"   EmployeeWind_text_FullName#��Z" $	��Top=�$��	Underline{��� $��1��$
��Left=�$��0,52,0,0q�$
��Wrap=�!#   EmployeeWind_text_Contacts#��Z# $	��Top=�$��	Underline{��� $��1��$
��Left=�$��	67,32,0,0q�$
��Wrap=�$	��Top=�$	��175������ *FIO+�� $��1��$
��Left=�$��	67,52,0,0q�$
��Wrap=�$	��Top=�$	��175������ *
Contakts+�� $
��Left=�$��	0,100,0,0q�$
��Wrap=� $   CustomerWind_text_addInfo#��Z$ $	��Top=�$��1��$��	Underline{��� $
��Left=�$��0,79,0,0q�$
��Wrap=�!%   EmployeeWind_text_Birthday#��Z% $	��Top=�$��1��$��	Underline{��� $
��Left=�$��
101,79,0,0q�$
��Wrap=�$	��Top=�$��1��$��	Underline{����� *
Birthday+�� & �� AutoWordSelection& .  ' �� TextWrapping$
' Wrap=�( �� 
IsReadOnly( . $��0,121,26,10q�$��1�����	#FFFAEBD8���	#FFFAEBD8) �� SelectionBrush) �	#FFFAEBD8���� *Note+�� 
���   �$��1q�$��2��$
��10,0q�