   M S B A M L   `   `   `  ���� D  @WinReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WinReader	WinReader      WinReader.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:WinReader       � Title$  	WinReader��$	��450��$	��800��.��� ���	#FFD2EDF7 � RowDefinitions �� $��28 ���  � ColumnDefinitions �� $	��150 �$	��120���� $	��120��.+�o� $��0��$��4q�$��2�����	#FFC0E1F9.@�m� $��文件��.@�m� -   $��close��$��关闭��m� -   $
��read��$��朗读��m� -   $��pause��$��暂停��{�.  m� -   $
��stop��$��停止��{�.  m� -   $��export��$��导出声音���� -   $��option��$��1��$��4q�.+��� 语音选择：�� -   $��voiceBox��$��20�� �� DisplayMemberPath$ Value�� �� SelectedValuePath$	 Key�� �� SelectedIndex$ 0��$��0,4,0,0q�����  �� Path$ Voices��� .+���  �� Orientation$ 
Horizontal=�$��0,8,0,0q�.+��� 	速率：�� -   $
��rate��$��50������ $
 Rate� �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=��� 
 � Minimum$	
 -10Q�$��0,8,0,0q� � Maximum$ 10Q� �� TickPlacement$ TopLeft=����	#FF6EA890 �� IsSnapToTickEnabled .  � Value ��  �� ElementName$
 rate��$
 Text��� .+��� $ 
Horizontal=�$��0,8,0,0q�.+��� 	音量：�� -	   $��volume��$��50������ $ Volume�$ TwoWay=�$	 PropertyChanged=��� $
 0Q�$��0,8,0,0q�$	 100Q� � SmallChange$ 1Q� . $ TopLeft=����	#FF8FC216 �� $ volume��$
 Text��� $��0��$��1��$��4�����	#FF97E8B2�� -
   $	��txt��$��1��$��1��$��4q� �� TextWrapping$
 Wrap=� �� AcceptsReturn .  �� 
AcceptsTab . " �� VerticalScrollBarVisibility$
 Auto=�$��14(� �� 
LineHeight$ 24��$��2,4,4,4q�