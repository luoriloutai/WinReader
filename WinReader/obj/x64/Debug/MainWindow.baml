   M S B A M L   `   `   `  ����D  @WinReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WinReader	WinReader  5   	       WinReader.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WinReader     5   	     � Title$  	WinReader��5   	   $	��450��6   $	��800��6(   .��5	      � ���	#FFD2EDF7 � RowDefinitions 5
   
   �� 5      $��28 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $	��150 �6   $	��120��6+   �� 5      $	��120��6   .+�5   
   o� $��0��6   $��4q�6   $��2��6(   ���	#FFC0E1F9.@�5      m� $��文件��6   .@�5      m� -   5        $��close��5      $��关闭��6(   64   5      m� 5      -   5        $
��read��5      $��朗读��6#   6/   m� 5      -   5        $��pause��5      $��暂停��6$   {�.  6D   m� 5      -   5        $
��stop��5      $��停止��6#   {�.  6B   m� 5      -   5        $��export��5      $��导出声音��6%   63   5      �� 5   
   -   5        $��option��5      $��1��6#   $��4q�60   .+�5      �� 语音选择：6   �� 5      -   5        $��voiceBox��5      $��20��6'    �� DisplayMemberPath$ Value��64    �� SelectedValuePath$	 Key��6N    �� SelectedIndex$ 0��6�   $��0,4,0,0q�6�   ��6f   ��  �� Path$ Voices�5      �� 5       .+�5!      ��  �� Orientation$ 
Horizontal=�6   $��0,8,0,0q�66   .+�5"      �� 	速率：6&   �� 5#      -   5        $
��rate��5#      $��50��6*   ��65   �� $
 Rate� �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   5$      �� 5&      
 � Minimum$	
 -10Q�6   $��0,8,0,0q�6U    � Maximum$ 10Q�6f    �� TickPlacement$ TopLeft=�6s   ���	#FF6EA890 �� IsSnapToTickEnabled .  � Value 6'   ��  �� ElementName$
 rate��$
 Text�6�   5'      �� 5(      .+�5)      �� $ 
Horizontal=�6   $��0,8,0,0q�66   .+�5*      �� 	音量：6&   �� 5+      -	   5        $��volume��5+      $��50��6,   ��67   �� $ Volume�$ TwoWay=�$	 PropertyChanged=�6�   5,      �� 5.      $
 0Q�6   $��0,8,0,0q�6&   $	 100Q�67    � SmallChange$ 1Q�6E    . $ TopLeft=�6p   ���	#FF8FC216 6�   �� $ volume��$
 Text�6�   5/      51      �� 54   
   $��0��6   $��1��6'   $��4��64   ���	#FF97E8B26X   �� 56   
   -
   5        $	��txt��56      $��1��6   $��1��6*   $��4q�6:    �� TextWrapping$
 Wrap=�6F    �� AcceptsReturn .  �� 
AcceptsTab . " �� VerticalScrollBarVisibility$
 Auto=�6�   $��14(�6�    �� 
LineHeight$ 24��6�   $��2,4,4,4q�6�   58      59      