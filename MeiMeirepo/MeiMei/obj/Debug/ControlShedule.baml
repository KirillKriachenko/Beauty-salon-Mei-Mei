   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5      
 MeiMei   MeiMei.ControlShedule   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      ���	#FFFAEBD8.��5	      �   � RowDefinitions  5
   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      $	��82* �6   �� 5      $	��34* �6   �� 5      $	��35* �6   6-   .+�5   
   �� -   5         ��Name$ Image��5      $��Assets/Add.png��6   $��4��67   $��Right=�6H   $��72��6d   $��2��6o   .   (System.Windows.Interactivity.Interaction   Triggers 5      /   )System.Windows.Interactivity.EventTrigger  5         	EventName$ 	MouseDown��6!   .   (System.Windows.Interactivity.TriggerBase   Actions. 5      6   0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *OpenAddCommand+6Q   5      ��5   
   �� 5        �� 
TargetType" ��6   .�5!      ��  �� Property �@J�Opacity	 �� Value$		 0.1Q�6,   6:   
 �� Triggers
 5"      P� 5$       P� Property �@J�IsMouseOver P� Value . . �5%      ��  �@J�Opacity$	 1Q�68   6D   5&      5(      5,      �� 5.   
   -   5        $ ImageDelete��5.      $��Assets/Remove.png��6%   $��2��6@   $��2��6P   $��50��6a   $��50��6o    5/        50      $ 	MouseDown��6!   . 51         6,   �� *DeleteCommand+6P   52      ��54      �� 55      " ��6   .�56      ��  �@J�Opacity$		 0.5Q�60   6>   
 57      P� 59       �@J�IsMouseOver . . �5:      ��  �@J�Opacity$	 1Q�68   6D   5;      5=      5A      �� 5C   
   -   5        $ 	ImageEdit��5C      $��Assets/Edit.png��6#   $��2��6<   $��2��6L   $��50��6]   $��50��6k   $��3��6z    5D        5E      $ 	MouseDown��6!   . 5F         6,   �� *OpeenEditCommand+6S   5G      ��5I      �� 5J      " ��6   .�5K      ��  �@J�Opacity$		 0.5Q�60   6>   
 5L      P� 5N       �@J�IsMouseOver . . �5O      ��  �@J�Opacity$	 1Q�68   6D   5P      5R      5V      �� 5W   
   -   5         ��Name$ CustomerText��5W      $
��Wrap=�6*   $��10,0,0,0q�6�   ��6>   �� *
Customer+ �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5X   
   -   5        $ ServiceText��5X      $
��Wrap=�6*   $��1��6�   $��10,0,0,0q�6�   ��6>   �� *	Service+$ OneWay=�$ PropertyChanged=�6�   �� 5Y   
   -   5        $ 	PriceText��5Y      $
��Wrap=�6(   $��2��6S   $��10,0,0,0q�6`   ��6<   �� *Price+6`   �� 5Z   
   -   5        $ EmployeeText��5Z      $
��Wrap=�6+   $��3��6Y   $��10,0,0,0q�6f   ��6?   �� *
Employee+6f   �� 5[   
   -   5        $ RoomText��5[      $
��Wrap=�6'   $��4��6Q   $��10,0,0,0q�6^   ��6;   �� *Room+6^   5\      5]      