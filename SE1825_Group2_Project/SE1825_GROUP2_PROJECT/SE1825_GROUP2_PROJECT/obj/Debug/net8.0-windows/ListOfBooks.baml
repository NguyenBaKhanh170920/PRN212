   M S B A M L   `   `   `  ����P  LSE1825_GROUP2_PROJECT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SE1852_GROUP2_PROJECTSE1852_GROUP2_PROJECT  5   	   '    !SE1852_GROUP2_PROJECT.ListOfBooks   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SE1852_GROUP2_PROJECT     5   	     � Title$  ListOfBooks��5   	   $	��450��6   $	��800��6*   .��5	      �  � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��3* �6   6*   .+�5   
   � $��1��6   .+�5      ]� .+�5      �� -   5        $��lvBook��5      $	��315��6)   $	��797��67    �� View 5      �� 5      .P�5      �� $��Id��6-    �� Width$ 50��69    �� DisplayMemberBinding 6D   ��  �� Path$ Id��� 5      $��Title��6-   $	 110��6<    6H   �� $ Title��� 5      $��Quantity��6-   $ 70��6?    6J   �� $ Quantity��� 5      $��	Publisher��6-   $	 110��6@    6L   �� $ 	Publisher��� 5      $��Price��6-   $ 70��6<    6G   �� $ Price��� 5      $��Category��6-   $	 110��6?    6K   �� $ CategoryName�5      5       5!      5"      �� 5#   
   $
��Left=�6   $��
187,23,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��	Search By��6o    J� RenderTransformOrigin$ 1.952,0.692&�6�   �� 5$   
    �� Orientation$ 
Horizontal=�6   $��187,44,264,37q�6.   .+�5%      	� -   5         	�Name$ rbtitle��5%      $��Title��6+   	 d� 	IsChecked$
	 TrueY�6;   	� 5&      -   5        $ rbPublisher��5&      $��	Publisher��6/   	� 5'      -   5        $ rbPrice��5'      $��Price��6+   	� 5(      -   5        $ 
rbCategory��5(      $��Category��6.   5*      �� 5+   
   -   5        
 ��Name$
 
txtKeyword��5+      $
��Left=�6&   $��
416,44,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��120��6�   6�   51      52      