   M S B A M L   `   `   `  ����O  KWPF_JurnalBoilerRoom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WPF_JurnalBoilerRoomWPF_JurnalBoilerRoom  5   	   %    WPF_JurnalBoilerRoom.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WPF_JurnalBoilerRoom     5   	     � Title$8  2Журнал оператора котельной��5   	   $	��850��6,   $
��1000��69   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��
Дата: ��6   $��Center=�6%   $��12(�6B   (  "System.Windows.Controls.DatePicker  5      -   5        $��
datePicker��5         IsDropDownOpen .     SelectedDateFormat$ Short=�6B   5      �� 5   
   $ 
Horizontal=�6   $��1��6.   .+�5      �� $��60��6   $	��100��6   $��5,0,0,0q�6,   .��5      �� $
��Wrap=�6   
Время67   5      �� 5      $��90��6   $	��100��6   .��5      �� $
��Wrap=�6   Температура6=   5      �� 5      $��50��6   $	��100��6   .��5      �� $
��Wrap=�6    № котла в работе6B   5      �� 5      $��60��6   $	��100��6   .��5       �� $
��Wrap=�6   20P газа на вводе в котельную6M   5!      �� 5"      $��60��6   $	��100��6   .��5#      �� $
��Wrap=�6   P газа после ГРУ6B   5$      �� 5%      $��60��6   $	��100��6   .��5&      �� $
��Wrap=�6   53P воды на входе в котел №1, №26P   5'      �� 5(      $��60��6   $	��100��6   .��5)      �� $
��Wrap=�6   86T℃ воды на входе в котел №1, №26Q   5*      �� 5+      $��60��6   $	��100��6   .��5,      �� $
��Wrap=�6   <:T℃ воды на выходе из котла №1, №26S   5-      �� 5.      $��80��6   $	��110��6   .��5/      �� $
��Wrap=�6   xvРезультаты проверки исправности действия приборов и автоматики6p   50      �� 51      $��50��6   $	��100��6   .��52      �� $
��Wrap=�6   %#Показания водомера6D   53      �� 54      $��60��6   $	��100��6   .��55      �� $
��Wrap=�6   /-P газа перед котлом №1, №26L   56      �� 57      $	��130��6   $	��100��6    .��58      �� $
��Wrap=�6   ��Обнаруженные технические неисправности во время приема смены и во время работы6�   59      �� 5:      $	��130��6   $	��100��6    .��5;      �� $
��Wrap=�6   ecЗамечания администрации. Подпись ответственного лица6f   5<      5=      &   System.Windows.Controls.DataGrid  5?   
   -   5        $��varibls��5?   E   $��2��68   ��6   �� *LogVariables+   Columns 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 6?   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6&   �� *Time+6?     5B      $ 90 6F    6&   �� *Temperature+6F   5E      �� 5F      $��3��6   .+�5G      �� $��Добавить��6   $��20(�6(   $��300,20,300,20q�66   ��6M   �� *OpenAddContactCommand+�� 5H      $��Удалить��6   $��20(�6'   $��300,20,300,20q�65   5I      5J      5K      