   M S B A M L   `   `   `  ���� A  =MeiMei, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MeiMei.PropertiesMeiMei.Properties  !    MeiMei.ViewModel.ServisPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /resclr-namespace:MeiMei.Properties       N� Title$  
ServisPage�� � 	Resources    
ItemTemple��%4   &	        �� .R��� ���� *KategoriaServis+.��� ���	#FFFAEBD8.+�&   System.Windows.Controls.DataGrid     
IsReadOnly .    SelectionMode$ Single=� �� SelectedIndex$ 0��   CanUserSortColumns .     CanUserAddRows .     HeadersVisibility$ Column=�   AutoGenerateColumns .  $��
10,57,0,10q�$
��Left=�$	��212��	 �� SelectedItem	 �� *SelectedTypeService+
 �� UpdateSourceTrigger$
 PropertyChanged=����� *KategoriaCollection+   Columns 0  *System.Windows.Controls.DataGridTextColumn  !   MeiMei.Properties.Resources   CategoryServices_text,  &System.Windows.Controls.DataGridColumn   Header# Z    Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *TypeService+$
 PropertyChanged=��� $��Button��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��112��$��42�����	#FFFAEBD8���� *AddServisOpenCommand+��Z� ���� .R���  �� Orientation$ 
Horizontal=�.+��� $&�� /MeiMei;component/Assets/Add.png�� J� OpacityMask ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ White��$ 1Q��� $
��Auto��   Add_btn#��Z $��Center=��� $��Button��$
��Left=�$��
138,10,0,0q�$	��Top=�$	��140��$��42�����	#FFFAEBD8���� *EditServisCommand+��Z� ���� .R��� $ 
Horizontal=�.+��� $'��!/MeiMei;component/Assets/Edit.png�� �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ White��$ 1Q��� $
��Auto��   Edit_btn#��Z $��Center=��� $��Button��$
��Left=�$��
296,10,0,0q�$	��Top=�$	��112��$��42�����	#FFFAEBD8���� *DeleteServiceCommand+��Z� ���� .R��� $ 
Horizontal=�.+��� $)��#/MeiMei;component/Assets/Remove.png�� �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ White��$ 1Q��� $
��Auto��   
Delete_btn#��Z $��Center=�   . $ Column=�   CanUserDeleteRows .   .   .  $��237,57,10,10q�	 �� *SelectedService+���� *PriceCollection+$
 PropertyChanged=�      CanUserSort .     CanUserResize .     NameOfServices_text# Z $
 200*  �� *ServiceName+   .   .     PriceOfServices_text# Z $
 200*  �� *ServicePrice+