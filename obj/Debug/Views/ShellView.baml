   M S B A M L   `   `   `  ����G  CCateringGuru, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CateringGuru.ViewsCateringGuru.Views  5   	   "    CateringGuru.Views.ShellView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CateringGuru.Views     5   	     � Title$  	ShellView��5   	   $	��450��6   $	��800��6(   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5       $��* �6   �� 5!      $��20 �6   .+�5%   
   �� $��4��6   $��1��6   $	��100��6/   �� 5&   
   -   5         ��Name$ FoodMenu��5&   0   $��4��6   $��2��6    $	��200��6B    �� DisplayMemberPath$ ItemName��5(       �� SelectedItem 5'      ��  �� Path$ SelectedItem� �� Mode$ OneWayToSource=�5(      �� 5)   
   -   5         ��Name$ SelectedItem_ItemPrice��5)   1   $��4��6   $��3��6!   $��50��6Q   �� 5,   
   -   5        	 ��Name$	 LoadQuoteForm��5,      $��5��6(   $��1��65   $	��100��6E   $��20��6Q   .��6]   
Quote Form5.      �� 5/   
   -   5        $	 LoadInvoiceForm��5/      $��5��6*   $��2��67   $	��100��6G   $��20��6S   .��6_   Invoice Form51      �� 54   
   -   5        
 ��Name$
 
ActiveItem��55      $��6��54      $��1��6&   $��5��66   55      57      58      