   M S B A M L   `   `   `  ����F  BAoTTG-Tools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AoTTG_ToolsAoTTG_Tools  5   	       AoTTG_Tools.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AoTTG_Tools     5   	   -   5          �Name$  Window_��5   u    � Title$ I don't know :/��6	   $	��302��6!   $	��411��6.    � WindowStartupLocation$ CenterScreen=�6:    � 
ResizeMode$ NoResize=�6_    � Icon$ /Icon-AoTTG.png��6�   .��5	      �� .+�5
   
   �� -   5         ��Name$ TextBox_Input��5
       �� TextWrapping$
 Wrap=�6)   $	��185��6=   $	��130��6I   
 �� Top$ 10��6V    �� Left$ 10��6f   	 �� AcceptsReturn	 . 6w   �� 5   
   -   5        $ TextBox_Output��5      $
 Wrap=�6*   $	��185��6>   $	��130��6J   $	 200��6W   $ 10��6i   	 . 
 �� 
IsReadOnly
 . 6�   �� 5   
   -   5        $ TextBox_Transparency��5      $	 122��60   $	 166��6B   $
 Wrap=�6S   $	��120��6g   6s   �� 5   
   $��Transparency(0-100)��6   $ 10��6/   $	 166��6@   $
��Wrap=�6Q   �� 5   
   $��
Map Script��6   $ 10��6&   $	 145��67   $
��Wrap=�6H   �� 5   
   $��Output��6   $	 200��6"   $	 145��64   $
��Wrap=�6E   �� 5   
   -   5        $ TextBox_Red��5      $ 88��6'   $	 189��68   $
 Wrap=�6I   $	��120��6]   6i   �� 5   
   $��Red (0-255)��6   $ 22��6'   $	 189��68   $
��Wrap=�6I   �� 5   
   -   5        $ TextBox_Green��5      $ 88��6)   $	 212��6:   $
 Wrap=�6K   $	��120��6_   6k   �� 5   
   $��Green (0-255)��6   $ 10��6)   $	 212��6:   $
��Wrap=�6K   �� 5   
   -   5        $ TextBox_Blue��5      $ 88��6(   $	 235��69   $
 Wrap=�6J   $	��120��6^   6j   �� 5   
   $��Blue (0-255)��6   $ 20��6(   $	 235��69   $
��Wrap=�6J   �� 5   
   -   5         ��Name$ Button_Convert��5      $��Convert��6)   $	 247��6;   $	 189��6M   $��64��6^   $	��138��6j   6v   �� 5   
   -	   5        $��Clear��5      $	 354��6!   $	 143��63   6D   �� 5   
   -
   5        $��?��5      $	 365��6   $	 166��6/   $��20��6@   $��20��6K   6W   �� 5   
   -   5         ��Name$ ColorOut��5   K   $��64��6   $��25��6   $	 213��6(   $	 189��6:   6K   �� 5   
   -   5         ��Name$ TextBlock_Converting��5   `   $	 266��6   $	 145��6&   $��Converting...��67   $
��Wrap=�6L   $y�Hidden=�6~   5      5      