   M S B A M L   `   `   `  ����K  GSE1825_Group2_A2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SE1825_Group2_A2SE1825_Group2_A2  5   	   $    SE1825_Group2_A2.ProductWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:SE1825_Group2_A2     5   	     � Title$  ProductWindow��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5   
   �� $��Product ID:��6   $
��Left=�6&   $��	10,10,0,0q�6A   $	��Top=�6T   �� 5   
   -   5         ��Name$ txtProductId��5       �� 
IsReadOnly$
 True��6(   $
��Left=�6:   $��
100,10,0,0q�6U   $	��Top=�6i   $	��200��6�   ��5      ��  �� Path$ 	ProductId� �� Mode$ OneWay=� � DataContext 5      ��  �� ElementName$ 
lvProducts��$ SelectedItem��� 5   
   $��Product Name:��6   $
��Left=�6(   $��	10,40,0,0q�6C   $	��Top=�6V   �� 5   
   -   5        $ txtProductName��5      $
��Left=�6*   $��
100,40,0,0q�6E   $	��Top=�6Y   $	��200��6q   ��5      �� $ ProductName�$ OneWay=� 5      �� $ 
lvProducts��$ SelectedItem��� 5   
   $��Category ID:��6   $
��Left=�6'   $��	10,70,0,0q�6B   $	��Top=�6U   �� 5   
   -   5         ��Name$ cbCategories��5      $
��Left=�6)   $��
100,70,0,0q�6D   $	��Top=�6X   $	��200��6p    �� DisplayMemberPath$ CategoryName��5      �� 5   
   $��Unit Price:��6   $
��Left=�6&   $��
10,100,0,0q�6A   $	��Top=�6U   �� 5   
   -   5        $ txtUnitPrice��5      $
��Left=�6(   $��100,100,0,0q�6C   $	��Top=�6X   $	��200��6p   ��5      �� $ 	UnitPrice�$ OneWay=� 5      �� $ 
lvProducts��$ SelectedItem��� 5    
   -   5        $��Create��5       $
��Left=�6"   $��
10,140,0,0q�6=   $	��Top=�6Q   $��75��6i   6t   �� 5!   
   -   5        $��Update��5!      $
��Left=�6"   $��
90,140,0,0q�6=   $	��Top=�6Q   $��75��6i   6t   �� 5"   
   -   5        $��Delete��5"      $
��Left=�6"   $��170,140,0,0q�6=   $	��Top=�6R   $��75��6j   6u   �� 5%   
   $��Unit Price:��6   $
��Left=�6&   $��
320,10,0,0q�6A   $	��Top=�6U   �� 5&   
   -   5        $ txtSearchUnitPrice��5&      $
��Left=�6.   $��
469,10,0,0q�6I   $	��Top=�6]   $	��200��6u   �� 5(   
   $��Product Name:��6   $
��Left=�6(   $��
320,40,0,0q�6C   $	��Top=�6W   �� 5)   
   -	   5        $ txtSearchName��5)      $
��Left=�6)   $��
469,40,0,0q�6D   $	��Top=�6X   $	��200��6p   �� 5+   
   -
   5        $��Search��5+      $
��Left=�6"   $��
469,81,0,0q�6=   $	��Top=�6Q   $��75��6i   6t   �� 5.   
   -   5        $��
lvProducts��5.      $��0,187,10,10q�6%   	 �� View	 5/      �� 50      .P�51      �� $��
Product ID��6%   
 �� Width$	
 100��6:    �� DisplayMemberBinding 52      �� $ 	ProductId��� 53      $��Product Name��6%   $	
 200��6;    54      �� $ ProductName��� 55      $��Category ID��6%   $	
 100��6:    56   %   �� $ 
CategoryId��� 57      $��
Unit Price��6%   $	
 100��69    58   %   �� $ 	UnitPrice�5:      5<      5=      5>      