   M S B A M L   `   `   `  ����  Supermarche#    Supermarche.InterfaceCheckout   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      T PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5      .��5	      � .+�5
   
   �� -   5        $��Re��5
      $
��Left=�6   $��	10,10,0,0q�69   $	��Top=�6L   $��50��6d   $��50��6o      MetroCircleButtonStyle#���   6{   6�   &   System.Windows.Controls.DataGrid  5   
   $��0��5          AutoGenerateColumns  .  $��10,65,400,0q�5   /   ��5      ��  �� Path$ Albums�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Genre��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *
Genre.Name+8  2MahApps.Metro.Controls.DataGridNumericUpDownColumn  5      $ Price��67      StringFormat$ C��5   7      Minimum$ 0Q�5   7    5   7   �� *Price+5   7   5      �� 5   
   $��Employee Responsible :��6   $
��Left=�61   $��
470,76,0,0q�6L   $	��Top=�6`   +  %MahApps.Metro.Controls.DropDownButton  5   
   $��Center=�5   
   $��Right=�5   
      Content$, &                              Employee��5   
    �� DisplayMemberPath$ Title��5   
   $��610,76,50,460q�5   )   ��6
   �� *Albums+6)   �� 5   
   $��Enregiste Employee��6   $
��Left=�6.   $��460,240,0,0q�6I   $	��Top=�6^   $	��145��6v   $��35��6�   �� 5   
   $��Compute��6   $
��Left=�6#   $��460,500,0,0q�6>   $	��Top=�6S   $	��145��6k   $��35��6w   5       5!      