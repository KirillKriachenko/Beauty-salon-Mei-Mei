   M S B A M L   `   `   `  ����A  =MeiMei, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MeiMei.PropertiesMeiMei.Properties  5   @       MeiMei.View.Add_Goods   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   /resclr-namespace:MeiMei.Properties     6@   !   MeiMei.Properties.Resources    AddingGoods_Title � Title# Z  5   	   $	��482��6<   $	��522��6I   ���	#FFFAEBD8 � WindowStartupLocation$ CenterScreen=�6l    � 
ResizeMode$ NoResize=�6�    � WindowStyle$ 
ToolWindow=�6�   .��5      � .+�5   
   ��  �� SelectedIndex$ 1��6   $
��Left=�6~   $��	10,45,0,0q�6�   $	��Top=�6�   $	��156��6�    �� SelectedItem 6%   �� *SelectTypeOfGoods+��6P   �� *TypeOfGoodsCollection+6�   �� 5   
   $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   "   AddGoodWind_TypeOfGood_text#��Z 6V   $	��Top=�6�   $	��106��6�   $��29��6�   $��16(�6�   &   System.Windows.Controls.DataGrid  5	   
      HeadersVisibility$ Column=�6<   $��10,220,10,0q�6�   $	��Top=�6�   $	��224��6�   	   AutoGenerateColumns	 .   6   �� *SelectedService+��6W   �� *PriceGoodsCollection+
   Columns
 5
      0  *System.Windows.Controls.DataGridTextColumn  5         NameOfServices_text,  &System.Windows.Controls.DataGridColumn   Header# Z 6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 250* 6t   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6[   �� *Name+6�     5         PriceOfServices_text# Z 6%   $
 250* 6v    6\   �� *Price+6�     5         NumberGoods_text# Z 6%   $
 250* 6r    6X   �� *Count+6�   5      �� 5   
   $
��Left=�6   $��23��6-   $��
10,111,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6w   $	��156��6�   ��6a   �� *Name+6�   �� 5   
   $
��Left=�6   $��23��6-   $��207,111,0,0q�69   $
 Wrap=�6N   $	��Top=�6y   $	��156��6�   ��6b   �� *Price+6�   �� 5   
   $��Button��6.   $
��Left=�6?   $��380,182,0,0q�6Z   $	��Top=�6o   $��92��6�   $��23��6�   ���	#FFFAEBD8��6   �� *
AddGoods+��6�   Z� ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $&�� /MeiMei;component/Assets/Add.png��6    6L   �� 5      $
��Auto��6$      Add_btn#��Z 61   $��Center=�6Y   6v   5      5      5      �� 5   
   $
��Left=�6   $��	10,82,0,0q�6/   $
��Wrap=�6B      NameOfGood_text#��Z 6V   $	��Top=�6�   $	��130��6�   $��29��6�   $��16(�6�   �� 5   
   $
��Left=�6   $��
207,82,0,0q�6/   $
��Wrap=�6C      PriceOfGood_text#��Z 6W   $	��Top=�6�   $	��107��6�   $��29��6�   $��16(�6�   �� 5    
   $
��Left=�6   $��
207,10,0,0q�6/   $
��Wrap=�6C   %   AddGoodWind_AddTypeOfGood_text#��Z 6W   $	��Top=�6�   $	��156��6�   $��29��6�   $��16(�6�   �� 5!   
   $
��Left=�6   $��23��6-   $��
207,44,0,0q�69   $
 Wrap=�6M   $	��Top=�6z   $	��156��6�   ��6a   �� *	Company+6�   �� 5"   
   $��Button��64   $
��Left=�6E   $��
398,44,0,0q�6`   $	��Top=�6t   $��92��6�   $��23��6�   ��6   �� *AddTypeOfGoods+��6�   Z� ��6�   Z� ��5#      �� 5$      .R�5%      �� $ 
Horizontal=�6!   .+�5&      �� $'��!/MeiMei;component/Assets/Save.png��6    �� 5'      $
��Auto��6$      
Create_btn#��Z 61   $��Center=�6\   5(      5)      5+      �� 5,   
   $
��Left=�6   $��23��6-   $��140,182,0,0q�69   $
 Wrap=�6N   $	��Top=�6y   $	��156��6�   ��6b   �� *Count+6�   �� 5-   
   $
��Left=�6   $��140,153,0,0q�6/   $
��Wrap=�6D   #��Z 6X   $	��Top=�6�   $	��107��6�   $��29��6�   $��16(�6�   5/      50      