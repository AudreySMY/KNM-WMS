   M S B A M L   `   `   `  ����A  =KNMGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GuiGui  5          Gui.Home   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:Gui     5        � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ 
Style.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��150 �6   �� 5      $��50 �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��30 �6   �� 5       $��30 �6   �� 5!      $��30 �6   �� 5"      $��30 �6   �� 5#      $��30 �6   �� 5$      $��30 �6   �� 5%      $��* �6   �� 5&      $��* �6   .+�5+   
   ]� $��0��6   $��1��6!   $��7��61   .+�5-      ]� $	��800��6   $
��5000��6'   $
��Left=�67   $	��Top=�6R   .+�5.      �� $
��Home��6   $��0,5,0,0q�6(   $��Center=�69      
TitleStyle#��[  6T   $	��Top=�6x   �� 5/        Divider#��[ 6   $��0,5,0,0q�6>   $��2��6O   $��Bottom=�6Z    J� Opacity$	 100Q�6u   $��Bottom=�6�   50      ]� 52      $��0��6   $��1��6%   $	��800��65   $
��5000��6D   $
��Left=�6T   $	��Top=�6o   .+�53      o�   	MenuStyle#��[ 6   $��Stretch=�6:   $	��Top=�6X   .@�54      m� $��Update��6      
MenuButton#��[ 60    � FocusVisualStyle 6T   Z� m� 55      $��Detail��6   #��[ 6/   56      �� 57      #��[ 6   $��0,2,0,0q�6>   $��2��6O   $��Bottom=�6Z   $	 100Q�6u   $��Bottom=�6�   58      59      �� 5;   
   $��Count Cycle��6   $��2��6'   $��2��64   $��Center=�6D   $��Center=�6h   $��2��6�     	NameStyle#��[ 6�   �� 5<   
   $
��Bins��6   $��4��6    $��2��6-   $��Center=�6=   $��Center=�6a   #��[ 6   �� 5=   
   $��Models��6   $��5��6"   $��2��6/   $��Center=�6?   $��Center=�6c   #��[ 6�   �� 5>   
   $��Total(%)��6   $��6��6$   $��2��61   $��Center=�6A   $��Center=�6e   #��[ 6�   �� 5@   
   -   5        $��
Lbl_BinsCC��5@      $
��Bins��6"   $��4��62   $��3��6?   
�������$	��100��6g   
���   �$��Center=�6�   $��Center=�6�   #��[ 6�   �� 5A   
   -   5        $��Lbl_ModelsCC��5A      $��Models��6$   $��5��66   $��3��6C   
�������$	��100��6k   
���   �$��Center=�6�   $��Center=�6�   #��[ 6�   �� 5B   
   -   5        $��Lbl_TotalCC��5B      $��Total(%)��6#   $��6��67   $��3��6D   
�������$	��100��6l   
���   �$��Center=�6�   $��Center=�6�   #��[ 6�   �� 5D   
   $	��ILA��6   $��2��6   $��5��6,   $��Center=�6<   $��Center=�6`   $��2��6}   #��[ 6�   �� 5E   
   -   5        $��Lbl_TotalILA��5E      $��Total(%)��6$   $	��200��67   
�������
���   �$��4��6n   $��2��6{   $��3��6�   $��5��6�   $��Center=�6�   $��Center=�6�   #��[ 6�   5F      5G      