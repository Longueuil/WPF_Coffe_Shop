   M S B A M L   `   `   `  ����D  @CoffeShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CoffeShop.ViewCoffeShop.View  5      9!clr-namespace:CoffeShop.ConverterCoffeShop.Converter  69   "    CoffeShop.View.CustomersView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:CoffeShop.View     5      BAlternationConverter!clr-namespace:CoffeShop.Converter     69   -   5          � 	Resources  5	      =   7CoffeShop.Converter.NavigationSideToGridColumnConverter '  #NavigationSideToGridColumnConverter  CustomerDataTemplate �� Orientation" �� ValidatesOnNotifyDataErrors��%�   &	        &	        5
   
   6C   �� 5   
   .R�5      �� $ 
Horizontal=�6   .+�5      �� $
��Bold"�6Z   ��6   �� *	FirstName+$ False��6Z   �� 5      $��5 0 0 0q�66   ��6   �� *
LastName+66   5      5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   � ���#777$	��260��6�   ��6   �� *NavigationSide+ �� 	Converter# [   � RowDefinitions 5      �� 5      $
��auto �6    �� 5      .+�5      �� .+�5       �� $ 
Horizontal=�6   .+�5!      �� -   5         ��Name$ btnAddCustomer��5!      $��10q�65   $��75��6A   ��6L   �� *
AddCommand+��5"      �� 5#      $ 
Horizontal=�6)   .+�5$   "   �� $��/Images/plus.png��6(   $��18��6B   $��0 0 5 0q�6N   �� 5%   "   $	��Add��6,   5&      5(      �� 5)      $��Delete��6   $��75��6.   $��
0 10 10 10q�69   ��6M   �� *DeleteCommand+�� 5*      $�� 0 10 10 10q�6   ��62   �� *MoveNavigationCommand+.��5+      �� $��/Images/move.jpg��6    $��18��6:   5,      5-      �� 5.      $��1��6   #��[ 6�   $��
10 0 10 10q�6�   ��6(   �� *	Customers+ �� SelectedItem 6J   �� *SelectedCustomer+ �� Mode$ TwoWay=�6�   5/      50      �� 54   
   $��1��6   $��10q�6%   y�61   �� *IsCustomerSelected+   BooleanToVisibilityConverter# [ .+�55      �� .��6   
First Name6    �� 56      ��6   �� *SelectedCustomer.FirstName+$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=��� 57      .��6   	Last Name6   �� 58      ��6   �� *SelectedCustomer.LastName+$ TwoWay=�$	 PropertyChanged=��� 59      $��0 20 0 0q�6|   
 d� 	IsChecked
 6   �� *SelectedCustomer.IsDeveloper+$ TwoWay=�$	 PropertyChanged=�.��6�   Is developer5;      5<      5=      5>      