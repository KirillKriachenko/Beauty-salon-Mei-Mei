   M S B A M L   `   `   `  ���� A  =MeiMei, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MeiMei.PropertiesMeiMei.Properties      MeiMei.View.Add_Goods   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     /resclr-namespace:MeiMei.Properties     !   MeiMei.Properties.Resources    AddingGoods_Title � Title# Z  $	��482��$	��522�����	#FFFAEBD8 � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$ 
ToolWindow=�.��� .+���  �� SelectedIndex$ 1��$
��Left=�$��	10,45,0,0q�$	��Top=�$	��156�� �� SelectedItem �� *SelectTypeOfGoods+���� *TypeOfGoodsCollection+�� $
��Left=�$��	10,10,0,0q�$
��Wrap=�"   AddGoodWind_TypeOfGood_text#��Z $	��Top=�$	��106��$��29��$��16(�&   System.Windows.Controls.DataGrid     HeadersVisibility$ Column=�$��10,220,10,0q�$	��Top=�$	��224��	   AutoGenerateColumns	 .   �� *SelectedService+���� *PriceGoodsCollection+
   Columns
 0  *System.Windows.Controls.DataGridTextColumn     NameOfServices_text,  &System.Windows.Controls.DataGridColumn   Header# Z    Width5  /System.Windows.Controls.DataGridLengthConverter$
 250* 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Name+     PriceOfServices_text# Z $
 250*  �� *Price+     NumberGoods_text# Z $
 250*  �� *Count+�� $
��Left=�$��23��$��
10,111,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��156������ *Name+�� $
��Left=�$��23��$��207,111,0,0q�$
 Wrap=�$	��Top=�$	��156������ *Price+�� $��Button��$
��Left=�$��380,182,0,0q�$	��Top=�$��92��$��23�����	#FFFAEBD8���� *
AddGoods+��Z� ���� .R���  �� Orientation$ 
Horizontal=�.+��� $&�� /MeiMei;component/Assets/Add.png���� $
��Auto��   Add_btn#��Z $��Center=��� $
��Left=�$��	10,82,0,0q�$
��Wrap=�   NameOfGood_text#��Z $	��Top=�$	��130��$��29��$��16(��� $
��Left=�$��
207,82,0,0q�$
��Wrap=�   PriceOfGood_text#��Z $	��Top=�$	��107��$��29��$��16(��� $
��Left=�$��
207,10,0,0q�$
��Wrap=�%   AddGoodWind_AddTypeOfGood_text#��Z $	��Top=�$	��156��$��29��$��16(��� $
��Left=�$��23��$��
207,44,0,0q�$
 Wrap=�$	��Top=�$	��156������ *	Company+�� $��Button��$
��Left=�$��
398,44,0,0q�$	��Top=�$��92��$��23������ *AddTypeOfGoods+��Z� ��Z� ���� .R��� $ 
Horizontal=�.+��� $'��!/MeiMei;component/Assets/Save.png���� $
��Auto��   
Create_btn#��Z $��Center=��� $
��Left=�$��23��$��140,182,0,0q�$
 Wrap=�$	��Top=�$	��156������ *Count+�� $
��Left=�$��140,153,0,0q�$
��Wrap=�#��Z $	��Top=�$	��107��$��29��$��16(�