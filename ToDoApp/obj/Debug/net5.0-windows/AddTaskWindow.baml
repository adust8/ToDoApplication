   M S B A M L   `   `   `  ����B  >ToDoApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ToDoAppToDoApp  5   	       ToDoApp.AddTaskWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ToDoApp     5   	     � Title$  	AddToList��5   	   $	��300��6   $	��350��5	   	    � Left$	 700��5
   	   
 � Top$	 350��5   	    � 
ResizeMode$ NoResize=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��20��5      $	��100��5      $$��Название задачи:��5      $��Center=�5      $��30 0 0 0q�5      �� 5!   
   -   5         ��Name$ TaskNameTextBox��5&      $��20��5"      $	��100��5#      $��0��5$      $��1��5%      5&      �� 5)   
   $��1��5*      $��20��5+      $	��100��5,      $��Center=�5-      $��30 0 0 0q�5.      $��Описание:��5/      �� 52   
   -   5        $ DescriptionTextBlock��58      $��1��53      $��1��54       �� TextWrapping$
 Wrap=�55      " �� VerticalScrollBarVisibility$
 Auto=�56      $��5q�57      58      �� 5:   
   -   5        	 ��Name$	 AddTaskButton��5@      $��Добавить��5;      $��20��5<      $	��100��5=      $��2��5>      $��2��5?      5A      5E      5F      