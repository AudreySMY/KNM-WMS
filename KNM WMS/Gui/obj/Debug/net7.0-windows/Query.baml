   M S B A M L   `   `   `  ����A  =KNMGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GuiGui  5          	Gui.Query   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:Gui     5        � 	Resources  5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ 
Style.xaml?�6%   %    5      .��5      � .+�5   
   ]� $	��474��6   $
��Auto��6$   $
��Auto��62   $	��636��6?   $��Stretch=�6N   $��Stretch=�6l   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��datagrid��5         EnableRowVirtualization$
 True��6'      AutoGenerateColumns$ False��6_      CanUserResizeColumns$
 True��6{      CanUserDeleteRows$ False��6�      CanUserAddRows$ False��6�      CanUserResizeRows$ False��6�   	   AreRowDetailsFrozen$
	 True��6�   
   
IsReadOnly$

 True��6�   $��Stretch=�6  ���#818181   RowBackground �#818181$	��Top=�6Z     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Material��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Model.ModelCod+6^     5      $
 Grid��6)   $	 100 6X    67   �� *Grid.GridCod+6X     5      $ UPC/EAN��6)   $	 150 6T    6:   �� *EanID+6T   5      5      5      5      