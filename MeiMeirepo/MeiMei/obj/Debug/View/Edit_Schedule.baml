   M S B A M L   `   `   `  ����
  MeiMei    MeiMei.View.Edit_Schedule   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$-  'Редактировать запись��5   	   $	��315��6&   $	��403��63   ���	#FFFAEBD8 � WindowStartupLocation$ CenterScreen=�6V    � 
ResizeMode$ NoResize=�6{    � Icon$) #/MeiMei;component/Assets/MeiMei.ico��6�    � WindowStyle$ 
ToolWindow=�6�   .��5      � .+�5   
   �� $
��Left=�6   $��19,8,0,0q�6/   $
��Wrap=�6A   $��Клиент��6U   $	��Top=�6c   $��85��6{   �� 5   
   $
��Left=�6   $��	19,56,0,0q�6/   $
��Wrap=�6B   $��Мастер��6V   $	��Top=�6d   �� 5   
   $
��Left=�6   $��
19,104,0,0q�6/   $
��Wrap=�6C   $��Тип услуги��6W   $	��Top=�6i   �� 5	   
    �� 
IsEditable . $
��Left=�6�   $��	19,29,0,0q�6�   $	��Top=�6�   $	��120��6�    �� Text 6   �� *
ClientName+ �� Mode$ TwoWay=���6;   �� *AddCustomerCollection+ �� SelectedItem 6i   �� *SelectedItem+6�   �� 5
   
    . $
��Left=�6�   $��	19,77,0,0q�6�   $	��Top=�6�   $	��120��6�    6   �� *
Employye+$ TwoWay=���6:   �� *EmployeeCollection+ 6e   �� *SelectedEmployee+6�   �� 5   
    . $
��Left=�6{   $��
19,125,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6   �� *AddServiceCollection+ 6@   �� *SelectedService+6�   �� 5   
   $��Button��68   $��
0,211,27,0q�6I   ���	#FFFAEBD8$��Right=�6�   $	��117��6�   $��42��6�   $	��Top=�6�   ��6   �� *EditSheduleCommand+��6]   Z� ��5      �� 5      .R�5      �� 	 �� Orientation$	 
Horizontal=�6!   .+�5      �� $'��!/MeiMei;component/Assets/Save.png��6    $��56��6K   $��39��6V   
 J� OpacityMask
 5      �� 5   "    �� EndPoint$ 0.5,1&�66    �� 
StartPoint$ 0.5,0&�6G   .��5   &   �  � Color$ Black��63    � Offset$ 0Q�6A   � 5   &   $ White��63   $ 1Q�6A   5   #   5      �� 5      $
��Auto��6$   $��Изменить��61   $��Center=�6A   5      5      5      (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�65   $��
186,29,0,0q�6P   $	��Top=�6d   $	��131��6|      SelectedDate 6   �� *MyDate+6|   �� 5   
   $
��Left=�6   $��	186,8,0,0q�6/   $
��Wrap=�6B   $��Дата��6V   $	��Top=�6b   $��85��6z   �� 5   
   $
��Left=�6   $��
207,68,0,0q�6/   $
��Wrap=�6C   $��
Время��6W   $	��Top=�6d   $��85��6|   �� 5    
    . $
��Left=�6�   $��
207,89,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6   �� *SheduleTimeCollection+ 6A   �� *SelectedFirstTime+ 6l   �� *	FirstTime+$ TwoWay=�6�   �� 5!   
   $
��Left=�6   $��
184,89,0,0q�6/   $
��Wrap=�6C   $��С��6W   $	��Top=�6`   $��6��6x   �� 5"   
    . $
��Left=�6�   $��207,116,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6   �� *SheduleTimeCollection+ 6A   �� *SelectedSecondTime+ 6m   �� *
SecondTime+$ TwoWay=�6�   �� 5#   
   $
��Left=�6   $��184,116,0,0q�6/   $
��Wrap=�6D   $
��До��6X   $	��Top=�6b   $��23��6z   �� 5$   
   $
��Left=�6   $��186,158,0,0q�6/   $
��Wrap=�6D   $��Комната №��6X   $	��Top=�6i   �� 5%   
   $
��Left=�6   $��23��6-   $��186,179,0,0q�69    �� TextWrapping$
 Wrap=�6N   $	��Top=�6x   $	��120��6�   ��6b   �� *Room+6�   �� 5&   
   $
��Left=�6   $��
19,158,0,0q�6/   $
��Wrap=�6C   $��Услуга��6W   $	��Top=�6e   �� 5'   
    . $
��Left=�6�   $��
19,179,0,0q�6�   $	��Top=�6�   $	��120��6�    6   �� *	Service+$ TwoWay=���69   �� *ServiceCollection+ 6c   �� *SelectedThisService+6�   5(      5)      