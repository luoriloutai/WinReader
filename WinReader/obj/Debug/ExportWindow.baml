   M S B A M L   `   `   `  ����D  @WinReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WinReader	WinReader  5   	       WinReader.ExportWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WinReader     5   	     � Title$  导出��5   	   $	��190��6   $��389.6��6!    � WindowStartupLocation$ CenterOwner=�6/    � 
ResizeMode$ NoResize=�6S   .��5	      � $��4q�6    � RowDefinitions 5
   
   �� 5      $��5 �6   �� 5      $��24 �6   �� 5      �� 5      $��30 �6    � ColumnDefinitions 5   
   �� 5      $��80 �6   �� 5      $��4 �6   �� 5      .+�5   
   �� -   5        $��
selectPath��5      $��1��6   .��6I   选择保存位置6Q   �� 5   
   ���	#FF1E7CD4$��2��6(   $��1��68   ���	#FF09A866._�5      �� -   5        $
��path��5      ���	#FFAED5F06>   5      �� 5   
   -   5        $
��sure��5      $��2��6   $��3��6*   $��Center=�6>   $��Bottom=�6[   $��	10,4,10,4q�6v   .��6�   确定6�   �� 5   
   -   5        $��
exportTips��5      $��3��6&   ���	#FF139D91$��Center=�6J   $y�Hidden=�6e   正在导出...6�   5      5      