   M S B A M L   `   `   `  ���� A  =MeiMei, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MeiMei.PropertiesMeiMei.Properties       MeiMei.ViewModel.AddServis   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     /resclr-namespace:MeiMei.Properties     !   MeiMei.Properties.Resources    AddingServices_title � Title# Z  $��423.5��$	��522�����	#FFFAEBD8 � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$ 
ToolWindow=�.��� .+���  �� SelectedIndex$ 1��$
��Left=�$��	10,45,0,0q�$	��Top=�$	��156�� �� SelectedItem �� *SelectTypeOfService+���� *TypeServiceCollection+�� $
��Left=�$��	10,10,0,0q�$
��Wrap=�   TypeService_text#��Z $	��Top=�$	��106��$��29��$��16(�&   System.Windows.Controls.DataGrid     HeadersVisibility$ Column=�$��10,148,10,0q�$	��Top=�$	��224��	   AutoGenerateColumns	 .   �� *SelectedService+���� *
PricesColl+
   Columns
 0  *System.Windows.Controls.DataGridTextColumn     NameOfServices_text,  &System.Windows.Controls.DataGridColumn   Header# Z    Width5  /System.Windows.Controls.DataGridLengthConverter$
 250* 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
NameServis+     PriceOfServices_text# Z $
 250*  �� *
CostServis+�� -    ��Name$ NameService_tb��$
��Left=�$��23��$��
10,111,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��156������ *
NameServis+�� -   $ Price_tb��$
��Left=�$��23��$��207,111,0,0q�$
 Wrap=�$	��Top=�$	��156������ *
CostServis+�� $��Button��$
��Left=�$��398,111,0,0q�$	��Top=�$��92��$��23�����	#FFFAEBD8���� *AddServisCommand+��Z� ���� .R���  �� Orientation$ 
Horizontal=�.+��� $&�� /MeiMei;component/Assets/Add.png���� $
��Auto��   Add_btn#��Z $��Center=��� $
��Left=�$��	10,82,0,0q�$
��Wrap=�   NameOfService_text#��Z $	��Top=�$	��130��$��29��$��16(��� $
��Auto��$
��Left=�$��
207,82,0,0q�$
��Wrap=�   PriceOfService_text#��Z $	��Top=�$��29��$��16(��� $
��Left=�$��
207,10,0,0q�$
��Wrap=�   TypeService_add_text#��Z $	��Top=�$	��156��$��29��$��16(��� $
��Left=�$��23��$��
207,44,0,0q�$
 Wrap=�$	��Top=�$	��156������ *TypeOfService+�� $��Button��$
��Left=�$��
398,44,0,0q�$	��Top=�$��92��$��23������ *AddTypeOfServiceCommand+��Z� ��Z� ���� .R��� $ 
Horizontal=�.+��� $'��!/MeiMei;component/Assets/Save.png���� $
��Auto��   
Create_btn#��Z $��Center=�