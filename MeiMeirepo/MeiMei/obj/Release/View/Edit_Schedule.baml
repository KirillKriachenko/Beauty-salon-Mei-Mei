   M S B A M L   `   `   `  ���� 
  MeiMei    MeiMei.View.Edit_Schedule   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$-  'Редактировать запись��$	��315��$	��403�����	#FFFAEBD8 � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � Icon$) #/MeiMei;component/Assets/MeiMei.ico�� � WindowStyle$ 
ToolWindow=�.��� .+��� $
��Left=�$��19,8,0,0q�$
��Wrap=�$��Клиент��$	��Top=�$��85���� $
��Left=�$��	19,56,0,0q�$
��Wrap=�$��Мастер��$	��Top=��� $
��Left=�$��
19,104,0,0q�$
��Wrap=�$��Тип услуги��$	��Top=���  �� 
IsEditable . $
��Left=�$��	19,29,0,0q�$	��Top=�$	��120�� �� Text �� *
ClientName+ �� Mode$ TwoWay=����� *AddCustomerCollection+ �� SelectedItem �� *SelectedItem+��  . $
��Left=�$��	19,77,0,0q�$	��Top=�$	��120�� �� *
Employye+$ TwoWay=����� *EmployeeCollection+ �� *SelectedEmployee+��  . $
��Left=�$��
19,125,0,0q�$	��Top=�$	��120������ *AddServiceCollection+ �� *SelectedService+�� $��Button��$��
0,211,27,0q����	#FFFAEBD8$��Right=�$	��117��$��42��$	��Top=����� *EditSheduleCommand+��Z� ���� .R��� 	 �� Orientation$	 
Horizontal=�.+��� $'��!/MeiMei;component/Assets/Save.png��$��56��$��39��
 J� OpacityMask
 ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ White��$ 1Q��� $
��Auto��$��Изменить��$��Center=�(  "System.Windows.Controls.DatePicker  $
��Left=�$��
186,29,0,0q�$	��Top=�$	��131��   SelectedDate �� *MyDate+�� $
��Left=�$��	186,8,0,0q�$
��Wrap=�$��Дата��$	��Top=�$��85���� $
��Left=�$��
207,68,0,0q�$
��Wrap=�$��
Время��$	��Top=�$��85����  . $
��Left=�$��
207,89,0,0q�$	��Top=�$	��120������ *SheduleTimeCollection+ �� *SelectedFirstTime+ �� *	FirstTime+$ TwoWay=��� $
��Left=�$��
184,89,0,0q�$
��Wrap=�$��С��$	��Top=�$��6����  . $
��Left=�$��207,116,0,0q�$	��Top=�$	��120������ *SheduleTimeCollection+ �� *SelectedSecondTime+ �� *
SecondTime+$ TwoWay=��� $
��Left=�$��184,116,0,0q�$
��Wrap=�$
��До��$	��Top=�$��23���� $
��Left=�$��186,158,0,0q�$
��Wrap=�$��Комната №��$	��Top=��� $
��Left=�$��23��$��186,179,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120������ *Room+�� $
��Left=�$��
19,158,0,0q�$
��Wrap=�$��Услуга��$	��Top=���  . $
��Left=�$��
19,179,0,0q�$	��Top=�$	��120�� �� *	Service+$ TwoWay=����� *ServiceCollection+ �� *SelectedThisService+