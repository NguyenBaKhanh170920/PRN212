   M S B A M L   `   `   `  ����J  FSE1825_FirstWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SE1825_FirstWPFSE1825_FirstWPF  5   	   $    SE1825_FirstWPF.CategoryWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:SE1825_FirstWPF     5   	     � Title$  CategoryWindow��5   	   $	��450��6    $	��800��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      6   .+�5   
   �� $��0��6   
����ح�.+�5      �� $��Category��6   $��24(�6'   67   �� 5      $��Category id:��6   6-   �� 5      -   5         ��Name$ txtCategoryId��5      6/   �� 5      $��Category name:��6   6/   �� 5      -   5        $ txtCategoryName��5      61   �� 5       �� Orientation$ 
Horizontal=�6   $��20q�62   $��Center=�6>   .+�5      �� -   5         ��Name$ btnAdd��5      $	��Add��6+   $��50��69   6[   �� 5      -   5        $ btnEdit��5      $
��Edit��6+   $��50��6:   6]   �� 5      -   5        $ 	btnDelete��5      $��Delete��6-   $��50��6>   6c   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
lsCategory��5      $��1��6'      AutoGenerateColumns$ False��5         CanUserAddRows$ False��6/      CanUserDeleteRows$ False��6F   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Category id��6%      
IsReadOnly$
 True��6:   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6M   �� *
CategoryId+6n     5      $
 Category name��6%   $
 True��6<    6N   �� *CategoryName+6q   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 Action��6)      CellTemplate 5       �� 5!      .R�5"      �� $ 
Horizontal=�6)   .+�5#   "   �� $ btnEdit��6)   -   5        $
��Edit��5#   :   $��50��6_   $��20��6j   6x   �� 5$   "   $ 	btnDelete��6)   -   5        $��Delete��5$   <   $��50��6e   $��20��6p   6~   5%      5&      5(      5+      5,      5-      