   M S B A M L   `   `   `  ����U  QWPF_Multi_Threated_Counter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WPF_Multi_Threated_CounterWPF_Multi_Threated_Counter  5   	   +    %WPF_Multi_Threated_Counter.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:WPF_Multi_Threated_Counter     5   	     � Title$  Counter��5   	   $	��300��6   $	��300��6&    � WindowStartupLocation$ CenterScreen=�62    � 
ResizeMode$ CanMinimize=�6W   .��5	      � .+�5
   
   �� -   5         ��Name$ decrementBtn��5
      $��	Decrement��6'   $
��Left=�6;   $��
28,153,0,0q�6V   $	��Top=�6j   $��75��6�   {�.  6�   �� 5   
   -   5        $ incrementBtn��5      $��	Increment��6'   $
��Left=�6;   $��196,153,0,0q�6V   $	��Top=�6k   $��75��6�   {�.  6�   �� 5   
   -   5         ��Name$ label��5      $��0��6   $��Center=�6+   $��Center=�6O   $
��Left=�6q   $��	78,33,0,0q�6�   $	��Top=�6�   $	��143��6�   $��94��6�   $��50(�6�   $
��Bold"�6�   � 5   
   -   5         �Name$ progressBar��5      $
��Left=�6+   $��
0,229,0,17q�6F   $	��292��6Z   �� 5   
   -   5        $ startBtn��5      $��Start��6#   $
��Left=�63   $��112,178,0,0q�6N   $	��Top=�6c   $��75��6{   6�   �� 5   
   -   5        $ pauseBtn��5      $��Pause��6#   $
��Left=�63   $��112,153,0,0q�6N   $	��Top=�6c   $��75��6{   {�.  6�   5      5      