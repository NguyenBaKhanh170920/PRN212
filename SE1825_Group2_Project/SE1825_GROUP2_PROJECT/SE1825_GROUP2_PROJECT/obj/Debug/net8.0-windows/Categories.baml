   M S B A M L   `   `   `  ����P  LSE1825_GROUP2_PROJECT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SE1852_GROUP2_PROJECTSE1852_GROUP2_PROJECT  5   	   &     SE1852_GROUP2_PROJECT.Categories   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SE1852_GROUP2_PROJECT     5   	     � Title$  
Categories��5   	   $	��450��6   $	��800��6)   .��5	      � $��0,0,0,-6q�6    � ColumnDefinitions 5
   
   �� 5      $
��1.5* �6   6.   �� 5      $��1* �6   6,   .+�5   
   � $��1��6   $	��301��6    $	��Top=�6-   .+�5      �� $��2��6   
�������.+�5      �� $��Category��6   $��20(�6,   
���   �$
��Bold"�6M   �� 5      $	��ID:��6   �� 5      -   5         ��Name$ txtId��5       �� 
IsReadOnly$
 True��6*    �� TextWrapping$
 Wrap=�6<   $	��312��6Q   $��24��6]   �� 5      $��Name:��6   �� 5      -   5        $ txtName��5      $ False��6,   $
 Wrap=�6?   $	��312��6T   $��24��6`   �� 5       �� Orientation$ 
Horizontal=�6   $	��Top=�66   $
��0 20q�6K   .+�5      �� -   5         ��Name$ 
btnRefresh��5      $��Refresh��61   $��66��6C   $	��5 0q�6N   6[   �� 5      -   5        $ btnEdit��5      $
��Edit��6.   $��63��6=   $	��5 0q�6H   6U   �� 5      -   5        $ 	btnDelete��5      $��Delete��60   $��69��6A   $	��5 0q�6L   6Y   �� 5      -   5        $ btnAdd��5      $	��Add��6-   $��62��6;   $	��5 0q�6F   6S   5      5      5      ]� 5   
   .+�5!      �� -   5        $��
lvCategory��5!      $	��344��6)    �� View 5"      �� 5#      .P�5$      �� $��ID��6)    �� Width$	 100��65   	 �� DisplayMemberBinding	 6A   �� 
 �� Path$
 Id��� 5%      $��Category��6)   $	 110��6;   	 6G   �� $

 Name�5'      5)      5*      �� 5+   
   -   5        $ 
txtKeyWord��5+      $
��Left=�6&   $��
108,10,0,0q�6A   $
 Wrap=�6U   $	��Top=�6i   $	��173��6�   $��21��6�   5,      �� 5-   
   -	   5        $��Search��5-      $
��Left=�6"   $��
298,10,0,0q�6=   $	��Top=�6Q   $��21��6~   $��42��6�   50      51      