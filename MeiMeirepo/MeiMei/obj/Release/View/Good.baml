   M S B A M L   `   `   `  ���� A  =MeiMei, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MeiMei.PropertiesMeiMei.Properties      MeiMei.ViewModel.Good   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /resclr-namespace:MeiMei.Properties       N� Title$
  Good�� N� 
Background �	#FFFAEBD8.��� .+��� $��Button��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��112��$��37�����	#FFFAEBD8���� *AddGoodOpenCommand+��Z� ���� .R���  �� Orientation$ 
Horizontal=�.+��� $&�� /MeiMei;component/Assets/Add.png�� J� OpacityMask ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ White��$ 1Q��� $
��Auto��!   MeiMei.Properties.Resources   Add_btn#��Z $��Center=��� $��Button��$
��Left=�$��
127,10,0,0q�$	��Top=�$	��112��$��37�����	#FFFAEBD8���� *EditGoodCommand+��Z� ���� .R��� $ 
Horizontal=�.+��� $'��!/MeiMei;component/Assets/Edit.png�� �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ White��$ 1Q��� $
��Auto��	   Edit_btn#��Z	 $��Center=��� $��Button��$
��Left=�$��
244,10,0,0q�$	��Top=�$	��112��$��37�����	#FFFAEBD8���� *DeleteGoodCommand+��Z� ���� .R��� $ 
Horizontal=�.+��� $)��#/MeiMei;component/Assets/Remove.png�� �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ White��$ 1Q��� $
��Auto��
   
Delete_btn#��Z
 $��Center=�� $��0,52,0,0q� � RowDefinitions �� $	��85* ��� $	��92* � � ColumnDefinitions �� $
��141* ��� $
��311* ��� $
��159* �.+��� $��4,0,0,0q�$	��Top=� �� 
IsEditable .  �� IsTextSearchEnabled .  �� SelectedItem �� *SelectedTypeOfGoods+���� *
CompColl+��  �� SelectedIndex$ 0��$��	4,28,0,10q�$��2�� �� *SelectedTypeOfGoods+���� *
CompColl+ �� UpdateSourceTrigger$ PropertyChanged=�&   System.Windows.Controls.DataGrid     
IsReadOnly . ���	#FFFAEBD8   AutoGenerateColumns .     HeadersVisibility$ Column=�   CanUserDeleteRows .     CanUserAddRows .  $��1��$��10,0,7,2q����	#FF688CAF �� *SelectedGoods+���� *	GoodsColl+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   CanUserSort .     CanUserResize .     NameOfServices_text   Header# Z    Width5  /System.Windows.Controls.DataGridLengthConverter$
 200* 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
GoodName+   .   .     PriceOfServices_text# Z $
 200*  �� *	GoodPrice+   .   .     NumberGoods_text# Z $
 100*  �� *Count+   .  .  $ Column=� .   .  $��1��$��
10,3,10,10q�$��2��$��1������ *GoodsHistoryColl+    .   .  # Z $
 200*  �� *
GoodName+   .   .  # Z $
 200*  �� *Price+   .   .      	Data_text# Z  $
 200*  �� *Data+   .   .  !   Customer_text# Z! $
 200*  �� *
Customer+�� $��2��$��
91,62,10,0q�" �� TextWrapping$
" Wrap=�$��23��$	��Top=����� *Count+# �� NotifyOnTargetUpdated# . $ PropertyChanged=��� $��2��$��7,63,0,0q�$
��Wrap=�#��Z $��16��$	��Top=�$
��Left=�$��67���� $��2��$��
7,90,113,0q�$
��Wrap=�#��Z $��16��$	��Top=��� $��2��$��
80,90,10,0q�$
��Wrap=�$��16��$	��Top=����� *Price+�� $��2��$��	7,28,32,0q� . $��22��$	��Top=�$ �� Text$ �� *
Customer+% �� Mode$% TwoWay=� �� *SelectedCustomers+���� *CustomerColl+�� $��2��$��7,7,94,0q�$
��Wrap=�&   MainWind_btn_Customer#��Z& $��16��$	��Top=��� $��Button��$��
0,123,10,0q����	#FFFAEBD8$��2��$��Right=�$��94��$��37��$	��Top=����� *	SellGoods+��Z� ���� .R��� $ 
Horizontal=�.+��� $)��#/MeiMei;component/Assets/Tovaru.png�� �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ White��$ 1Q��� $��50��'   Sell_btn_text#��Z' $��Center=�