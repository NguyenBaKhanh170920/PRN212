   M S B A M L   `   `   `  ����J  FSE1825_FirstWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SE1825_FirstWPFSE1825_FirstWPF  5   	        SE1825_FirstWPF.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:SE1825_FirstWPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         MyBrush �� Color  MyStyle �� 
TargetType �� Property �� Value  	YourBrush � Color � Offset��%�  &	        &	 )     &	 �     �� 5
   
   $ 
LightGreen��6+   6@   �� 5   
   " ��6    .�5      ��  � ��
 ��  �6:   �� 5       � ��$ 24(�6)   66   �� 5       � ��$
 Bold"�6+   6:   5      �� 5   
   .��5      � $
 Blue��6   $	 0.2Q�6(   67   � 5      $ Yellow��6   $	 0.4Q�6*   69   � 5      $	 Red��6   $	 0.6Q�6'   66   � 5      $ Brown��6   $	 0.8Q�6)   68   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��2* �6   6*   	 � ColumnDefinitions	 5   
   �� 5      $��* �6   6+   �� 5      $��2* �6   6,   .+�5!   
   �� $��Hello��6   $��50��6!   $��20��6,   $��0��68   $��0��6E   #��[  5"      5#      �� 5$   
   $��Welcome��6   $��50��6#   $��20��6.   $��1��6:   $��0��6G   #���   5%      6:   �� 5&   
   -   5        
 ��Name$
 btnColor��5&      $��Change color��6;   $	��100��6R   $��20��6^   $��2��6j   $��0��6w   6�   �� 5'   
   $��0��6   $��1��6"   .+�5(      �� #��[ 6   WPF6>   �� 5)      #��[ 6   .NET6?   �� 5*      $��30(�6   $
��Bold"�6&   C#6<   5+      �� 5,   
   $��1��6   $��1��6   #��[ 6.   6X   5-      5.      