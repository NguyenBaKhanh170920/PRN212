   M S B A M L   `   `   `  ����K  GSE1825_Group2_A2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:SE1825_Group2_A2.ViewsSE1825_Group2_A2.Views  5   	   "    SE1825_Group2_A2.Views.Login   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:SE1825_Group2_A2.Views     5   	     � Title$  Store Management��5   	   $	��400��6"   $	��600��6/    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�6   .��5
      � .+�5   
   �� $	��300��6   $	��400��5      
������� �� CornerRadius$ 6��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#      	Direction$	 -90Q�5         RenderingBias$ Quality=�5         ShadowDepth$ 2Q�5      	   Color$
	 Gray��5      ._�5      �� 
 �� Orientation$
 Vertical=�6   $��20q�5      .+�5      �� $��Login��6   $��25(�5      $��Center=�5      $	��Top=�5      $
��Bold"�5       �� Padding$ 10q�5      � 5      $��Center=�6    � RowDefinitions 5       �� 5!      $��* �6(   �� 5"      $��* �6(   �� 5#      $��* �6(   �� 5$      $��* �6(   .+�5&      �� $��	User Name��6   $��0��5'      $
��0,15q�5(      $
��Left=�5)      61   �� 5*      -   5        $��txtUsername��5*      $��	0,41,0,46q�61   $��3��6D   $	��0,5q�6U   $	��255��5+      $��0,0,0,1q�5,      $
��Left=�5-       J� RenderTransformOrigin$ 0.503,0.395&�60   6V   �� 5.      $��Password��6    $��2��5/      $
��0,15q�50      $
��Left=�51      G� 52      -   5        $��txtPassword��52   /   $��3��6"    G� Password$  ��53      $	��0,5q�54      $	��255��55      $��0,0,0,1q�56      $
��Left=�57      59      �� 5:      -   5         ��Name$ btnLogin��5:      $��Login��5;      
�������
���   �$
��0,25q�5>      $��35��5?      $	��250��5@      ��5A      �� 5B       �� 
TargetType" ��6    .�5C      ��  �� Property � �� �� Value 5D   "   �� 5E   &    �� 
TargetType" ��66   .R�5F   *   ��  ��Name$ LoginBorder��61   #��z��6F   $ 16��5G   -   ._�5H   .   �� $��Center=�6?   $��Center=�5I      5J   +    �� Triggers 5K   *   P� 5L   .    P� Property �@J�IsMouseOver P� Value$
 True��6M   . �5M   2   ��  �� 
TargetName$ LoginBorder��6a    � ��
 ������� 5N   2   $ LoginBorder��6h    � ��
 �   �5O   /   5Q   '   5S      5T      5V      5X      5Y      5Z      5[      