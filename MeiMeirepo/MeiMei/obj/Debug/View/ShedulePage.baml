   M S B A M L   `   `   `  ����A  =MeiMei, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MeiMei.PropertiesMeiMei.Properties  5   D   "    MeiMei.ViewModel.ShedulePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /resclr-namespace:MeiMei.Properties     6D     N� Title$  Shedule��5       N� 
Background �	#FFFAEBD8.��5      � -   5         �Name$ GridMain��5       � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5   
   �� $��Button��6>   $
��Left=�6O   $��
10,214,0,0q�6j   $	��Top=�6~   $	��130��6�   $��42��6�   ���	#FFFAEBD8��6   �� *OpenSheduleSettigCommand+��6�   Z� ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $+��%/MeiMei;component/Assets/rapidsvn.png��6     J� OpacityMask 5      �� 5   "    �� EndPoint$ 0.5,1&�66    �� 
StartPoint$ 0.5,0&�6G   .��5   &   �  � Color$ Black��63   	 � Offset$	 0Q�6A   � 5   &   $ White��63   $	 1Q�6A   5   #   5      �� 5      $
��Auto��6$   !   MeiMei.Properties.Resources
   Settings_btn#��Z
 61   $��Center=�6^   5      5      5       &   System.Windows.Controls.Calendar  5!   
   $��	10,10,0,0q�65   $	��Top=�6H   $
��Left=�6`   $	��184��6{      SelectedDate 6   �� *
ThisData+6{   �� 5$   
   -   5         ��Name$ ScrollViever��5$      $��1��6-   $
��Auto=�6=   $��Visible=�6b   $��Stretch=�6�   $��Stretch=�6�   .��5%      � -   5        $ gridShedule��5%      6*   5&      5'      5(      