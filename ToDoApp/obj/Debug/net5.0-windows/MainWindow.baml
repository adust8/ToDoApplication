   M S B A M L   `   `   `  ����B  >ToDoApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ToDoAppToDoApp  5   	       ToDoApp.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ToDoApp     5   	   -   5        $��MainWindowName��5   *     � Title$  
MainWindow��5   	    � Left$	 600��5	   	   
 � Top$	 300��5
   	    � 
ResizeMode$ NoResize=�5   	   $	��300��5   	   $	��650��6    � DataContext$ MainWindow.xaml.cs��5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      �� 5      �� 5      $��30 �6   .+�5   
   �� $K��EДобро пожаловать в планировщик задач ��6   $�� 0 5 0 0q�6A   $��Center=�6S   $��2��6p   �� 5   
   -   5         ��Name$ dateComboBox��5      $
��Left=�5      $��20��5       $��1��5!      $	��130��5"      $��	120,5,0,5q�5#      .@�5%      �� -   5         ��Name$ today��5%   1   $��на сегодня��6   6A   �� 5&      -   5        $ 	yesterday��5&   .   $��на вчера��6   6A   �� 5'      -   5        $ lastWeek��5'   X   $*��$за последнюю неделю��6   6X   5(      �� 5,   
   $��Мои планы:��6   $��1��6&   $��Center=�63   �� 5-   
   -   5        	 ��Name$	 MyPlansListView��53      $��1��5/      $��0,19,0,1q�50      $	��300��51      
 � ContextMenu
 55      �� 56      .@�57      m� -   5         m�Name$ 
DeleteTask��57   0   $��Удалить��6   6D   58      5;      �� 5=   
   $��Описание��5>      $��0 5 0 0q�5?      $��Center=�5@      $��2��5A      $��1��5B      $��1��5C      �� 5E   
   -   5         ��Name$ DescriptionTextBlock��5F       �� TextWrapping$
 Wrap=�5E      $��1��5G      $��1��5H      $��0,19,0,1q�5I      $	��300��5J      $y�Hidden=�5K      " �� VerticalScrollBarVisibility$
 Auto=�5L       �� 
IsReadOnly$
 True��5M      �� 5Q   
   -	   5         ��Name$ AddToDoButton��5Q      $��3��6   $��20��6S   $��80��6_   $��Добавить��6j   5S      5T      