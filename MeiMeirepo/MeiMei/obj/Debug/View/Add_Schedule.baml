   M S B A M L   `   `   `  ����A  =MeiMei, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MeiMei.PropertiesMeiMei.Properties  5   @   #    MeiMei.ViewModel.Add_Schedule   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   /resclr-namespace:MeiMei.Properties     6@   !   MeiMei.Properties.Resources    AddingSchedule_title � Title# Z  5   	   $	��322��6?   $	��429��6L   ���	#FFFAEBD8 � WindowStartupLocation$ CenterScreen=�6o    � 
ResizeMode$ NoResize=�6�    � WindowStyle$ 
ToolWindow=�6�   .��5      � .+�5   
   �� $
��Left=�6   $��32,8,0,0q�6/   $
��Wrap=�6A      Customer_text#��Z 6U   $	��Top=�6�   $��85��6�   �� 5   
   $
��Left=�6   $��	212,8,0,0q�6/   $
��Wrap=�6B      MainWind_btn_Employee#��Z 6V   $	��Top=�6�   �� 5   
   $
��Left=�6   $��	32,68,0,0q�6/   $
��Wrap=�6B      TypeService_text#��Z 6V   $	��Top=�6�   �� 5
   
   $
��Left=�6�   $��	31,29,0,0q�6�   $	��Top=�6�   $	��120��6�    �� 
IsEditable . 	 �� IsTextSearchEnabled	 . 
 �� Text
 6   �� *
Customer+ �� Mode$ TwoWay=� �� SelectedItem 69   �� *SelectedItem+��6_   �� *AddCustomerCollection+6�   �� 5   
    . 	 . $
��Left=�6�   $��
212,29,0,0q�6�   $	��Top=�6�   $	��120��6�    6@   �� *SelectedEmployee+��6j   �� *EmployeeCollection+6�   �� 5   
    . 	 . $
��Left=�6�   $��	31,89,0,0q�6�   $	��Top=�6�   $	��120��6�    6@   �� *SelectedService+��6j   �� *AddServiceCollection+6�   �� 5   
   $��Button��67   $��274,232,0,0q�6H   $	��Top=�6]   $��42��6u   ���	#FFFAEBD8$
��Left=�6�   $	��117��6�   ��6   �� *AddSheduleCommand+��6�   Z� ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $&�� /MeiMei;component/Assets/Add.png��6    $��56��6J   $��39��6U    J� OpacityMask 5      �� 5   "    �� EndPoint$ 0.5,1&�66    �� 
StartPoint$ 0.5,0&�6G   .��5   &   �  � Color$ Black��63    � Offset$ 0Q�6A   � 5   &   $ White��63   $ 1Q�6A   5   #   5      �� 5      $
��Auto��6$      Add_btn#��Z 61   $��Center=�6Y   5      5      5      �� 5    
    . 	 . $
��Left=�6�   $��
212,89,0,0q�6�   $	��Top=�6�   $	��120��6�    6@   �� *SelectedThisService+��6n   �� *ServiceCollection+6�   �� 5!   
   $
��Left=�6   $��
212,68,0,0q�6/   $
��Wrap=�6C      NameOfService_text#��Z 6W   $	��Top=�6�   �� 5"   
   $
��Left=�6   $��
30,187,0,0q�6/   $
��Wrap=�6C      PriceOfServices_text#��Z 6W   $	��Top=�6�   $��17��6�   �� 5#   
   $
��Left=�6   $��
96,187,0,0q�6/   $
��Wrap=�6C   $	��Top=�6�   $��17��6�   ��6W   �� *Price+ �� UpdateSourceTrigger$ PropertyChanged=�6�   (  "System.Windows.Controls.DatePicker  5$   
   -   5          Name$ 
DataPicker��5$      $
��Left=�6I   $��212,187,0,0q�6d   $	��Top=�6y      SelectedDateFormat$ Short=�6�   $	��120��6�      SelectedDate 6)   �� *MyDate+6�   �� 5%   
    �� SelectedIndex$ 0��6   $
��Left=�6   $��
31,148,0,0q�6�   $	��Top=�6�   $	��120��6�    6%   �� *SelectedFirstTime+��6Q   �� *SheduleTimeCollection+6�   �� 5&   
   $ 0��6   $
��Left=�6�   $��212,148,0,0q�6�   $	��Top=�6�   $	��120��6�    6%   �� *SelectedSecondTime+��6R   �� *SheduleTimeCollection+6�   �� 5'   
   $
��Left=�6   $��
30,126,0,0q�6/   $
��Wrap=�6C      Time_txt#��Z 6W   $	��Top=�6�   $��17��6�   �� 5(   
   $
��Left=�6   $��	0,148,0,0q�6/   $
��Wrap=�6B      From_txt#��Z 6V   $	��Top=�6   $��17��6�   �� 5)   
   $
��Left=�6   $��192,148,0,0q�6/   $
��Wrap=�6D      To_txt#��Z 6X   $	��Top=�6   $��17��6�   �� 5*   
   $
��Left=�6   $��
30,245,0,0q�6/   $
��Wrap=�6C      Additionally_text#��Z 6W   $	��Top=�6�   �� 5+   
   $
��Left=�6   $��23��6-   $��112,245,0,0q�69    �� TextWrapping$
 Wrap=�6N   $	��Top=�6x   $	��120��6�   ��6b   �� *Room+6�   5,      5-      