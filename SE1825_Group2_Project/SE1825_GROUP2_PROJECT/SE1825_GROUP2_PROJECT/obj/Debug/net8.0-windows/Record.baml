   M S B A M L   `   `   `  ����P  LSE1825_GROUP2_PROJECT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SE1825_GROUP2_PROJECTSE1825_GROUP2_PROJECT  5   	   "    SE1825_GROUP2_PROJECT.Record   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SE1825_GROUP2_PROJECT     5   	   -   5          � Title$  Record��5   	   $	��450��6/   $	��900��6<   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��300 �6   6-   �� 5      $	��600 �6   6-   .+�5   
   �� $��0��6   $��0q�6%    �� Orientation$ Vertical=�60   .+�5      �� $��Request Form��6   $
��Bold"�6+   $��24(�6=   6M   �� 5      $ 
Horizontal=�6   $��10q�62   .+�5      �� $��	Book Name��6   $��80��6,   69   �� 5      -   5         ��Name$ cbBookRequest��5      $	��200��62    �� 
IsEditable$
 True��6>    �� IsTextSearchEnabled$
 True��6P    �� Text 5      ��  �� Path$ Id�5      5      �� 5      $ 
Horizontal=�6   $��10q�62   .+�5      �� $��Start Date:��6   $��80��6.   6;   �� 5      -   5         ��Name$ txtStart_date��5      $	��200��61   	 �� 
IsReadOnly$
	 True��6=   6Q   5      �� 5      $ 
Horizontal=�6   $��10q�62   .+�5      �� $��End Date��6   $��80��6+   68   (  "System.Windows.Controls.DatePicker  5      -   5        
  Name$
 
dpEnd_date��5      $	��200��61   6?   5      �� 5      $ 
Horizontal=�6   $��10q�62   .+�5       �� $��Quantity��6   $��80��6+   68   �� 5!      -   5        $ txtQuantity��5!      $	��200��6/   6=   5"      �� 5#      -   5         ��Name$ btnAddToList��5#      $��Request��6+   $��
90 10 10 0q�6=   6f   �� 5$      $��Return Form��6   $
��Bold"�6*   $��24(�6<   6L   �� 5%      $ 
Horizontal=�6   $��10q�62   .+�5&      �� $��	Book Name��6   $��80��6,   69   �� 5'      -   5        $ cbBookReturn��5'      $	��200��61   6?   5(      �� 5)      -   5        $ btnReturnBook��5)      $��Return��6,   $��
90 10 10 0q�6=   6e   5*      �� 5+   
   $��1��6   $
��Left=�6%   $	��590��6@   .+�5,      �� -	   5        $��lvData��5,   $   $��2��6   $	��599��62   $
��Auto��6>    �� View 5-      �� 5.      .P�5/      �� $��Book Id��6*    �� DisplayMemberBinding 50   !   �� $ BookId��� 51      $��User Id��6*    �� Width$ 70��6;    52   	   �� $ Borrower.FullName��� 53      $��	Book Name��6)   $	 120��6<    54   1   �� $ 
Book.Title��� 55      $��
Start Date��6)   $ 75��6=    56   1   �� $ 	StartDate� �� StringFormat$ 
dd/MM/yyyy���� 57      $��End Date��6)   $ 75��6;    58   1   �� $ EndDate�$ 
dd/MM/yyyy���� 59      $��Return Date��6)   $ 75��6>    5:   1   �� $ 
ReturnDate�$ 
dd/MM/yyyy���� 5;      $��Quantity��6)    5<   1   �� $ Quantity��� 5=      $��Status��6)   $
 Auto��69    5>   1   �� $ Status�5@      5C      5D      5E      5F      