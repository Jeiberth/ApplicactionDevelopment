   M S B A M L   `   `   `  ����F  BWpfAppMSSQL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfAppMSSQLWpfAppMSSQL  5   	       WpfAppMSSQL.Sales   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfAppMSSQL     5   	     � Title$  Sales��5   	   $	��450��6   $	��800��6$   .��5	      �  � RowDefinitions 5
   
   �� 5      .+�5   
   �� $��SALES��6   $��Center=�6    $��73��6=   $��0,10,0,0q�6I   $	��Top=�6[   $	��156��6s   $��50(�6   �� 5   
   $��Customer ID��6   $
��Left=�6&   $��29��6A   $��
86,103,0,0q�6M   $	��Top=�6a   $��96��6y   $��15(�6�   �� 5   
   $��Product Name��6   $��Center=�6'   $��29��6D   $��	0,103,0,0q�6P   $	��Top=�6c   $	��106��6{   $��15(�6�   �� 5   
   $��Amount��6   $
��Left=�6!   $��29��6<   $��632,103,0,0q�6H   $	��Top=�6]   $��68��6u   $��15(�6�   �� 5   
   -   5         ��Name$
 c_id��5      $
��Left=�6    $��30��6;   $��
10,140,0,0q�6G    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��248��6�   $��15(�6�   �� 5   
   -   5        $ p_name��5      $��Center=�6"   $��30��6?   $��	0,140,0,0q�6K   $
 Wrap=�6^   $	��Top=�6r   $	��248��6�   $��15(�6�   �� 5   
   -   5        $ p_amount��5      $��Right=�6$   $��30��6@   $��
0,140,10,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��248��6�   $��15(�6�   �� 5   
   -   5        $	��Buy��5      $��Center=�6   $��34��6<   $��	0,217,0,0q�6H   $	��Top=�6[   $	��132��6s   $��15(�6   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dbGridS��5      $��Center=�6$   $	��102��6A   $��	0,288,0,0q�6N   $	��Top=�6a   $	��682��6y   �� 5   
   -   5         ��Name$ admin��5      $��ADMIN��6    $
��Left=�60   $��32��6K   $��	26,24,0,0q�6W   $	��Top=�6j   $��97��6�   $��15(�6�   6�   5      5      