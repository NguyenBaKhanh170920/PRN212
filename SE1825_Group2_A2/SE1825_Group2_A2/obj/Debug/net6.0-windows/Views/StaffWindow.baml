   M S B A M L   `   `   `  ����K  GSE1825_Group2_A2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:SE1825_Group2_A2.ViewsSE1825_Group2_A2.Views  5   	   (    "SE1825_Group2_A2.Views.StaffWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:SE1825_Group2_A2.Views     5   	     � Title$  
AdminStaff��5   	   $	��710��6   $	��658��6)    � 	Resources 5	      0  *SE1825_Group2_A2.Views.RoleToTextConverter   RoleToTextConverter��%   &	          5
   
   6$   5      .��5      ]� $	��Top=�6   $��10q�6(   .+�5   
   �  � ColumnDefinitions 5      �� 5      $	��25* �6#   �� 5      $
��249* �6#   �� 5      $
��326* �6#    � RowDefinitions 5      �� 5      $��* �6    �� 5      $��* �6    .+�5      �� 
����ح� �� Orientation$ Vertical=�60   $
��Left=�5      $	��620��6,   $��3��68   .+�5      �� -   5        $��lbInstruction��5      
����  �$��DemiBold"�6?   $��20(�5      $��Staff Information��6   �� 5      -   5        $��	lbStaffId��5      $��StaffId��6)   �� 5       -   5        $��
txtStaffId��5       $
��Left=�6,   $��25��5!      $	��500��6   ��5"      ��  �� Path$ StaffId� �� Mode$ OneWay=� � DataContext 5#      ��  �� ElementName$ lvStaff��$ SelectedItem�6R   �� 5%      -   5        $��lbStaffName��5%      $��
Staff Name��6+   �� 5&      -   5        $��txtStaffName��5&      $
��Left=�6.   $��25��5'      $	��500��6   ��6'   �� $ 	StaffName�$ OneWay=� 5(      �� $ lvStaff��$ SelectedItem�6M   �� 5+      -   5        $��
lbPassword��5+      $��Password��6*   �� 5,      -   5        $��txtPassword��5,      $
��Left=�6-   $��25��5-      $	��500��6   ��6'   �� $ Password�$ OneWay=� 5.      �� $ lvStaff��$ SelectedItem�6M   �� 50      -   5        $��lbRole��50      $
��Role��6&   �� 51      -	   5        $��txtRole��51      $
��Left=�6*   $��25��52      $	��500��6   	 �� SelectedItem	 53      �� $
 Role�$ TwoWay=� 54      �� $ lvStaff��$ SelectedItem�.@�55      �� $��Staff��6#   

 � Tag$
 0��63   �� 56      $��Admin��6#   $
 1��63   57      �� 5=      $ 
Horizontal=�6   $
��Left=�66   .+�5>      �� -
   5         ��Name$ 	btnInsert��5>      $��10q�60   $��70��6<   $��Insert��6G   6X   �� 5A      -   5        $ 	btnUpdate��5A      $��10q�60   $��70��6<   $��Update��6G   6X   �� 5D      -   5        $ 	btnDelete��5D      $��10q�60   $��70��6<   $��Delete��6G   6X   5F      �� 5G      $ 
Horizontal=�6   $
��Left=�66   .+�5H      �� -   5        $��txtSearchStaff��5H      $��25��64   $	��300��6@   $��	0,10,0,10q�6L   6_   �� 5I      -   5        $ 	btnSearch��5I      $��70��60   $��Search��6;   $��
10,10,0,10q�6L   6`   5J      5K      �� 5L      -   5         ��Name$ lvStaff��5L      $	��600��6I   $��3��6�   $��6,37,5,0q�6�   $	��304��6�   $	��Top=�6�   $��1��6�   ��6(   �� *
AllStaff+ �� View 5M      �� 5N      .P�5O      �� $��Staff ID��6)    �� Width$	 150��6;    �� DisplayMemberBinding 6G   �� *	StaffId+�� 5P      $��
Staff Name��6)   $	 150��6=    6I   �� *Name+�� 5Q      $��Password��6)   $	 150��6;    6G   �� *
Password+�� 5R      $
��Role��6)   $	 150��67    6C   �� *Role+ �� 	Converter# [  5T      5V      5X      5Y      5Z      