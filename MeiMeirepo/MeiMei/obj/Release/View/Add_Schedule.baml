   M S B A M L   `   `   `  ���� A  =MeiMei, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MeiMei.PropertiesMeiMei.Properties  #    MeiMei.ViewModel.Add_Schedule   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     /resclr-namespace:MeiMei.Properties     !   MeiMei.Properties.Resources    AddingSchedule_title � Title# Z  $	��322��$	��429�����	#FFFAEBD8 � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$ 
ToolWindow=�.��� .+��� $
��Left=�$��32,8,0,0q�$
��Wrap=�   Customer_text#��Z $	��Top=�$��85���� $
��Left=�$��	212,8,0,0q�$
��Wrap=�   MainWind_btn_Employee#��Z $	��Top=��� $
��Left=�$��	32,68,0,0q�$
��Wrap=�   TypeService_text#��Z $	��Top=��� $
��Left=�$��	31,29,0,0q�$	��Top=�$	��120�� �� 
IsEditable . 	 �� IsTextSearchEnabled	 . 
 �� Text
 �� *
Customer+ �� Mode$ TwoWay=� �� SelectedItem �� *SelectedItem+���� *AddCustomerCollection+��  . 	 . $
��Left=�$��
212,29,0,0q�$	��Top=�$	��120�� �� *SelectedEmployee+���� *EmployeeCollection+��  . 	 . $
��Left=�$��	31,89,0,0q�$	��Top=�$	��120�� �� *SelectedService+���� *AddServiceCollection+�� $��Button��$��274,232,0,0q�$	��Top=�$��42�����	#FFFAEBD8$
��Left=�$	��117������ *AddSheduleCommand+��Z� ���� .R���  �� Orientation$ 
Horizontal=�.+��� $&�� /MeiMei;component/Assets/Add.png��$��56��$��39�� J� OpacityMask ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ White��$ 1Q��� $
��Auto��   Add_btn#��Z $��Center=���  . 	 . $
��Left=�$��
212,89,0,0q�$	��Top=�$	��120�� �� *SelectedThisService+���� *ServiceCollection+�� $
��Left=�$��
212,68,0,0q�$
��Wrap=�   NameOfService_text#��Z $	��Top=��� $
��Left=�$��
30,187,0,0q�$
��Wrap=�   PriceOfServices_text#��Z $	��Top=�$��17���� $
��Left=�$��
96,187,0,0q�$
��Wrap=�$	��Top=�$��17������ *Price+ �� UpdateSourceTrigger$ PropertyChanged=�(  "System.Windows.Controls.DatePicker  -     Name$ 
DataPicker��$
��Left=�$��212,187,0,0q�$	��Top=�   SelectedDateFormat$ Short=�$	��120��   SelectedDate �� *MyDate+��  �� SelectedIndex$ 0��$
��Left=�$��
31,148,0,0q�$	��Top=�$	��120�� �� *SelectedFirstTime+���� *SheduleTimeCollection+�� $ 0��$
��Left=�$��212,148,0,0q�$	��Top=�$	��120�� �� *SelectedSecondTime+���� *SheduleTimeCollection+�� $
��Left=�$��
30,126,0,0q�$
��Wrap=�   Time_txt#��Z $	��Top=�$��17���� $
��Left=�$��	0,148,0,0q�$
��Wrap=�   From_txt#��Z $	��Top=�$��17���� $
��Left=�$��192,148,0,0q�$
��Wrap=�   To_txt#��Z $	��Top=�$��17���� $
��Left=�$��
30,245,0,0q�$
��Wrap=�   Additionally_text#��Z $	��Top=��� $
��Left=�$��23��$��112,245,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120������ *Room+