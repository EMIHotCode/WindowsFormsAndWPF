   M S B A M L   `   `   `  ����t  pWPF_Lesson5_1ПланировщикМероприятий, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Gclr-namespace:WPF_Lesson5_1ПланировщикМероприятий9WPF_Lesson5_1ПланировщикМероприятий  5   	   U    OWPF_Lesson5_1ПланировщикМероприятий.WindowForChangeEvents   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   YlocalGclr-namespace:WPF_Lesson5_1ПланировщикМероприятий     5   	   -   5        $��
EditEvents��5   J     � Title$I  CОкно для редактирования мероприятий��6   $	��450��61   $	��800��6>    � WindowStartupLocation$ CenterScreen=�6w   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��4* �6   �� 5      $��6* �6   .+�5   
   �� .+�5      �� $7��1Наименование мероприятия: ��6   �� 5      -   5        $��comboBoxTitle��5      ��6,   ��  �� Path$ Clients� �� SelectedValue 6Q   �� *TextBoxTitle+�� 5      $/��)Описание мероприятия: ��6   �� 5      -   5        $��txtBoxDescription��5      ��6/   �� *TextBoxDescription+�� 5      $'��!Дата мероприятия: ��6   (  "System.Windows.Controls.DatePicker  5      -   5        $��datePickerEvent��5         IsDropDownOpen .     SelectedDateFormat$ Short=�6G      SelectedDate 6b   �� *Today+ �� Mode$ TwoWay=��� 5      $3��-Галочка если Выполнено : ��6   �� 5      -   5        $��checkBoxIsDone��5      	 d� 	IsChecked	 6-   �� *
IsComplete+�� 5      $��Добавить��6   $��0, 10q�6(   ��67   �� *AddEventCommand+��6[   �� 
 �� ElementName$
 
EditEvents���� 5      $��Удалить��6   $��0, 10q�6'   ��66   �� *RemoveEventCommand+��6]   �� $
 
EditEvents���� 5      $ ��Редактировать��6   $��0, 10q�6-   ��6<   �� *EditEventCommand+��6a   �� $
 
EditEvents���� 5      $��Сохранить��6   $��0, 10q�6)   ��68   �� *SaveEventCommand+��6]   �� $
 
EditEvents���� 5      -   5        $��
Выход��5      $��0, 10q�6%   64   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��	DG_Events��5         
IsReadOnly . $��1��6�   ��6$   �� *
myEvents+ �� SelectedIndex 6E   �� *SelectedIndex+ �� SelectedItem 6m   �� *MyItem+5#      5$      5%      