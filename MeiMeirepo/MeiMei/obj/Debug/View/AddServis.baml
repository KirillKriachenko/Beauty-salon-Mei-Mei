   M S B A M L   `   `   `  ����A  =MeiMei, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MeiMei.PropertiesMeiMei.Properties  5   @        MeiMei.ViewModel.AddServis   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   /resclr-namespace:MeiMei.Properties     6@   !   MeiMei.Properties.Resources    AddingServices_title � Title# Z  5   	   $��423.5��6?   $	��522��6N   ���	#FFFAEBD8 � WindowStartupLocation$ CenterScreen=�6q    � 
ResizeMode$ NoResize=�6�    � WindowStyle$ 
ToolWindow=�6�   .��5      � .+�5   
   ��  �� SelectedIndex$ 1��6   $
��Left=�6�   $��	10,45,0,0q�6�   $	��Top=�6�   $	��156��6�    �� SelectedItem 6%   �� *SelectTypeOfService+��6R   �� *TypeServiceCollection+6�   �� 5   
   $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B      TypeService_text#��Z 6V   $	��Top=�6�   $	��106��6�   $��29��6�   $��16(�6�   &   System.Windows.Controls.DataGrid  5	   
      HeadersVisibility$ Column=�6<   $��10,148,10,0q�6z   $	��Top=�6�   $	��224��6�   	   AutoGenerateColumns	 .   6   �� *SelectedService+��6W   �� *
PricesColl+
   Columns
 5
      0  *System.Windows.Controls.DataGridTextColumn  5         NameOfServices_text,  &System.Windows.Controls.DataGridColumn   Header# Z 6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 250* 6z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6[   �� *
NameServis+6�     5         PriceOfServices_text# Z 6%   $
 250* 6{    6\   �� *
CostServis+6�   5      �� 5   
   -   5         ��Name$ NameService_tb��5      $
��Left=�6*   $��23��6E   $��
10,111,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6�   $	��156��6�   ��6y   �� *
NameServis+6�   �� 5   
   -   5        $ Price_tb��5      $
��Left=�6$   $��23��6?   $��207,111,0,0q�6K   $
 Wrap=�6`   $	��Top=�6�   $	��156��6�   ��6t   �� *
CostServis+6�   �� 5   
   $��Button��66   $
��Left=�6G   $��398,111,0,0q�6b   $	��Top=�6w   $��92��6�   $��23��6�   ���	#FFFAEBD8��6   �� *AddServisCommand+��6�   Z� ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $&�� /MeiMei;component/Assets/Add.png��6    6L   �� 5      $
��Auto��6$      Add_btn#��Z 61   $��Center=�6Y   6v   5      5      5      �� 5   
   $
��Left=�6   $��	10,82,0,0q�6/   $
��Wrap=�6B      NameOfService_text#��Z 6V   $	��Top=�6�   $	��130��6�   $��29��6�   $��16(�6�   �� 5   
   $
��Auto��6   $
��Left=�6!   $��
207,82,0,0q�6<   $
��Wrap=�6P      PriceOfService_text#��Z 6d   $	��Top=�6�   $��29��6�   $��16(�6�   �� 5   
   $
��Left=�6   $��
207,10,0,0q�6/   $
��Wrap=�6C      TypeService_add_text#��Z 6W   $	��Top=�6�   $	��156��6�   $��29��6�   $��16(�6�   �� 5    
   $
��Left=�6   $��23��6-   $��
207,44,0,0q�69   $
 Wrap=�6M   $	��Top=�6�   $	��156��6�   ��6a   �� *TypeOfService+6�   �� 5!   
   $��Button��6=   $
��Left=�6N   $��
398,44,0,0q�6i   $	��Top=�6}   $��92��6�   $��23��6�   ��6   �� *AddTypeOfServiceCommand+��6�   Z� ��6�   Z� ��5"      �� 5#      .R�5$      �� $ 
Horizontal=�6!   .+�5%      �� $'��!/MeiMei;component/Assets/Save.png��6    �� 5&      $
��Auto��6$      
Create_btn#��Z 61   $��Center=�6\   5'      5(      5*      5,      5-      