   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5   	       PL.SimulatorWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PL     5   	   -   5          � Title$  SimulatorWindow��5   	   $	��450��6!   $	��800��6.   .��5
      � .+�5   
   �� -   5        $
��SBar��5      $��0��6    $��5��60   $��Bottom=�6=   
�������.@�5      �� $��80��6   .��5      �� $��72��6   $��20(�6'   	Status:6>   5      5      �� 5   
      
classicLbl#��[  6   $��262,121,0,0q�64   $��	order ID:��6I   $	��119��6]   $��34��6i   �� 5   
   -   5         ��Name$ OrderIDText��5        classicText#��[ 6'   $
��Left=�6L   $��381,122,0,0q�6g    �� TextWrapping$
 Wrap=�6|   $	��Top=�6�   $	��179��6�   $��33��6�   ��6�   �� *
Item1.ID+ �� Mode$ OneWay=�6�   �� 5   
   #��[  6   $��261,193,0,0q�64   $��next state:��6I   $	��120��6_   $��31��6k   �� 5   
   -   5        $ nextStateTxt��5      #��[ 6(   $
��Left=�6M   $��381,198,0,0q�6h   $
 Wrap=�6}   $	��Top=�6�   $	��179��6�   $��31��6�   �� 5   
   #��[  6   $��262,155,0,0q�64   $��previous state��6I   $	��119��6b   $��38��6n   �� 5   
   -   5        $ prevStateTxt��5      #��[ 6(   $
��Left=�6M   $��381,160,0,0q�6h   $
 Wrap=�6}   $	��Top=�6�   $	��179��6�   $��33��6�   ��6�   �� *Item1.Status+$ OneWay=�6�   �� 5   
   #��[  6   $��262,229,0,0q�64   $&�� Estimated order processing time:��6I   $	��120��6t   $��31��6�   �� 5   
   -   5        $ estimatedTimeTxt��5      #��[ 6,   $
��Left=�6Q   $��381,234,0,0q�6l   $
 Wrap=�6�   $	��Top=�6�   $	��179��6�   $��26��6�   ��6�   ��  �� Path$ Item2�$ OneWay=�6�   �� 5   
   -   5         ��Name$ endOfSimulator��5        
classicBtn#��[ 6)   $	��End��6M   $��
638,38,0,0q�6x   $	��133��6�   $��62��6�   �� 5   
   -   5         ��Name$ timerTextBlock��5   4   #��[  6   $
��Left=�6L   $��	70,40,0,0q�6g   $��00:00:00��6{   $	��Top=�6�   $��52��6�   $	��232��6�   5      5      