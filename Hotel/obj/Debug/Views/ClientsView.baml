   M S B A M L   `   `   `  ����  Multi-Login#    Multi_Login.Views.ClientsView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $	��800��5      $
��1000��6,     � 
ResizeMode$  NoResize=�69    � WindowStartupLocation$ CenterScreen=�6O    � WindowStyle$
 None=�6t   .��5      � .+�5   
   �� $��Clienti��6   $
��Left=�6"   $��
484,30,0,0q�6=   $	��Top=�6Q   $	��188��6i   $��30(�6u   $��Century Gothic)�6�   
���   �$
��Bold"�6�   $��41��6�   &   System.Windows.Controls.DataGrid  5	   
   -   5        $
��grid��5	   '   $��
0,103,0,10q�6      AutoGenerateColumns .     
IsReadOnly . 
���������63   �� *	Clienti+ �� SelectedItem 6S   �� *CurrentClient+   Columns 5
      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 300 6%      Header$ Nume           ��61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6J   �� *Name+  5      $	 300 6%   $ 	Email    ��61   	 6D   �� *Email+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Stergere��6)   
   CellTemplate
 5      �� 5      .R�5      �� ��6%   ��  �� RelativeSource ��  �� AncestorType"   �� Path$' !DataContext.StergereClientCommand�.��5   "   �� $��/Images/trash.png��6(   6E   5      5      5      5      5      5      