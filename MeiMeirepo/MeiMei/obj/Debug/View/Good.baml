   M S B A M L   `   `   `  ����A  =MeiMei, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MeiMei.PropertiesMeiMei.Properties  5   D       MeiMei.ViewModel.Good   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /resclr-namespace:MeiMei.Properties     6D     N� Title$
  Good��5       N� 
Background �	#FFFAEBD8.��5
      � .+�5   
   �� $��Button��68   $
��Left=�6I   $��	10,10,0,0q�6d   $	��Top=�6w   $	��112��6�   $��37��6�   ���	#FFFAEBD8��6   �� *AddGoodOpenCommand+��6�   Z� ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $&�� /MeiMei;component/Assets/Add.png��6     J� OpacityMask 5      �� 5   "    �� EndPoint$ 0.5,1&�66    �� 
StartPoint$ 0.5,0&�6G   .��5   &   �  � Color$ Black��63    � Offset$ 0Q�6A   � 5   &   $ White��63   $ 1Q�6A   5   #   5      �� 5      $
��Auto��6$   !   MeiMei.Properties.Resources   Add_btn#��Z 61   $��Center=�6Y   5      5      5      �� 5   
   $��Button��65   $
��Left=�6F   $��
127,10,0,0q�6a   $	��Top=�6u   $	��112��6�   $��37��6�   ���	#FFFAEBD8��6   �� *EditGoodCommand+��6�   Z� ��5      �� 5      .R�5      �� $ 
Horizontal=�6!   .+�5       �� $'��!/MeiMei;component/Assets/Edit.png��6     5!      �� 5"   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��5#   &   � $ Black��63   $ 0Q�6A   � 5$   &   $ White��63   $ 1Q�6A   5%   #   5'      �� 5(      $
��Auto��6$   	   Edit_btn#��Z	 61   $��Center=�6Z   5)      5*      5,      �� 5-   
   $��Button��67   $
��Left=�6H   $��
244,10,0,0q�6c   $	��Top=�6w   $	��112��6�   $��37��6�   ���	#FFFAEBD8��6   �� *DeleteGoodCommand+��6�   Z� ��5.      �� 5/      .R�50      �� $ 
Horizontal=�6!   .+�51      �� $)��#/MeiMei;component/Assets/Remove.png��6     52      �� 53   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��54   &   � $ Black��63   $ 0Q�6A   � 55   &   $ White��63   $ 1Q�6A   56   #   58      �� 59      $
��Auto��6$   
   
Delete_btn#��Z
 61   $��Center=�6\   5:      5;      5=      � 5A   
   $��0,52,0,0q�6    � RowDefinitions 5B      �� 5C      $	��85* �6    �� 5D      $	��92* �6     � ColumnDefinitions 5F      �� 5G      $
��141* �6#   �� 5H      $
��311* �6#   �� 5I      $
��159* �6#   .+�5L      �� $��4,0,0,0q�6e   $	��Top=�6v    �� 
IsEditable .  �� IsTextSearchEnabled .  �� SelectedItem 6   �� *SelectedTypeOfGoods+��6D   �� *
CompColl+6�   �� 5M       �� SelectedIndex$ 0��6   $��	4,28,0,10q�6�   $��2��6�    6(   �� *SelectedTypeOfGoods+��6U   �� *
CompColl+ �� UpdateSourceTrigger$ PropertyChanged=�6�   &   System.Windows.Controls.DataGrid  5N         
IsReadOnly . ���	#FFFAEBD8   AutoGenerateColumns .     HeadersVisibility$ Column=�6\      CanUserDeleteRows .     CanUserAddRows .  $��1��6�   $��10,0,7,2q�6  ���	#FF688CAF 6�   �� *SelectedGoods+��6�   �� *	GoodsColl+   Columns 5O      0  *System.Windows.Controls.DataGridTextColumn  5P      ,  &System.Windows.Controls.DataGridColumn   CanUserSort .     CanUserResize .     NameOfServices_text   Header# Z 6S      Width5  /System.Windows.Controls.DataGridLengthConverter$
 200* 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6�   �� *
GoodName+6�     5Q       .   .     PriceOfServices_text# Z 6S   $
 200* 6�    6�   �� *	GoodPrice+6�     5R       .   .     NumberGoods_text# Z 6S   $
 100* 6�    6�   �� *Count+6�   5T        5U       .  .  $ Column=�6F    .   .  $��1��6�   $��
10,3,10,10q�6�   $��2��6�   $��1��6�   ��6�   �� *GoodsHistoryColl+ 5V        5W       .   .  # Z 6S   $
 200* 6�    6�   �� *
GoodName+6�     5X       .   .  # Z 6S   $
 200* 6�    6�   �� *Price+6�     5Y       .   .      	Data_text# Z  6S   $
 200* 6�    6   �� *Data+6�     5Z       .   .  !   Customer_text# Z! 6S   $
 200* 6�    6�   �� *
Customer+6�   5\      �� 5]      $��2��6   $��
91,62,10,0q�6&   " �� TextWrapping$
" Wrap=�6:   $��23��6�   $	��Top=�6�   ��6N   �� *Count+# �� NotifyOnTargetUpdated# . $ PropertyChanged=�6�   �� 5^      $��2��6   $��7,63,0,0q�6(   $
��Wrap=�6:   #��Z 6N   $��16��6   $	��Top=�6�   $
��Left=�6�   $��67��6�   �� 5_      $��2��6   $��
7,90,113,0q�6(   $
��Wrap=�6<   #��Z 6P   $��16��6�   $	��Top=�6�   �� 5`      $��2��6   $��
80,90,10,0q�6(   $
��Wrap=�6<   $��16��6g   $	��Top=�6s   ��6P   �� *Price+6s   �� 5a      $��2��6�   $��	7,28,32,0q�6�    . $��22��6�   $	��Top=�6�   $ �� Text$ 6   �� *
Customer+% �� Mode$% TwoWay=� 6>   �� *SelectedCustomers+��6i   �� *CustomerColl+6�   �� 5b      $��2��6   $��7,7,94,0q�6(   $
��Wrap=�6:   &   MainWind_btn_Customer#��Z& 6N   $��16��6�   $	��Top=�6�   �� 5d      $��Button��63   $��
0,123,10,0q�6D   ���	#FFFAEBD8$��2��6�   $��Right=�6�   $��94��6�   $��37��6�   $	��Top=�6�   ��6   �� *	SellGoods+��6X   Z� ��5e      �� 5f      .R�5g      �� $ 
Horizontal=�6%   .+�5h      �� $)��#/MeiMei;component/Assets/Tovaru.png��6$    5i   "   �� 5j   &   $ 0.5,1&�6:   $ 0.5,0&�6K   .��5k   *   � $ Black��67   $ 0Q�6E   � 5l   *   $ White��67   $ 1Q�6E   5m   '   5o      �� 5p      $��50��6(   '   Sell_btn_text#��Z' 63   $��Center=�6a   5q      5r      5t      5u      5w      5x      