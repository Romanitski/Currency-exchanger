   M S B A M L   `   `   `  ����L  HCurrencyExchanger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CurrencyExchangerCurrencyExchanger  5   	   *    $CurrencyExchanger.RegistrationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CurrencyExchanger     5   	     � Title$  Registration Window��5   	   $	��530��5	   	   $	��450��6    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$ ThreeDBorderWindow=�5   	   $��Times New Roman)�5   	   $��22(�6&    � 	Resources 5       �� 
TargetType   _baseLabelR �� Property �� Value  _baseButtonR �� 
TargetType	 �� Triggers
 P� Property P� Value��%  &	        &	     �� 5   
   " ��6   .�5      ��  � ��$	 Top=�62   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�69   �� 5       � ��$ Center=�6;   �� 5       � ��$ 45��6'   �� 5       � ��
 �����6+   5      �� 5   
   " ��6   .�5      ��  � ��$ 50��6'   �� 5       � ��$	 120��6&   �� 5       � ��$
 Left=�64   �� 5       � ��$ Center=�62   �� 5       � �� 5      �� 5       " ��6&   .R�5!      �� #��z��6!   ._�5"      �� $��Center=�6/   $��Center=�6L   5#      5$      5&      	 5'      P� 5(      
 �@J�IsMouseOver . . �5)      ��  � �� �#cccccc63   �� 5*       � ��
 �   �63   5+      5-      5.      .��51      �  � ColumnDefinitions 52   
   �� 53      $��1* �6   �� 54      $��2* �6    � RowDefinitions 56   
   �� 57      $��1* �6   �� 58      $��4* �6   ��5:   
   �� 5;       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5<      �  � Color$ 	#FF181599��6    � Offset$ 0Q�61   � 5=      $ 	#FFFA0101��6   $ 1Q�61   5>      .+�5A   
   �� $��Name:��6   $��	68,38,0,0q�6    #���   63   $��80��6Y   $��1��6d   �� 5B   
   $��	Password:��6   $��	37,88,0,0q�6$   #���   67   $	��111��6]   $��1��6i   �� 5C   
   $��Type:��6   $��
78,138,0,0q�6    #���   64   $��70��6Z   $��1��6e   �� 5E   
   -   5         ��Name$ operatorName��5E      $��Center=�6(   $��Center=�6L   $��1��6n   $��0,38,96.2,317q�6~   $��1��6�    �� 	MaxLength$ 16��6�   G� 5F   
   -   5         G�Name$ operatorPassword��5F      $��Center=�60   $��Center=�6T   $��1��6v   $��0,88,96.2,267q�6�   $��1��6�    G� 	MaxLength$ 13��6�   �� 5H   
   -   5        $��operatorType��5H      $��1��6'    �� 
IsReadOnly . $��0,138,96.2,217q�6I   $��1��6a   $��Center=�6n   $��Center=�6�   .@�5I      �� -   5         ��Name$ 
firstBlock��5I      $��Center=�6,   $��Center=�6I   Administrator6s   �� 5J      -   5        $ secondBlock��5J      $��Center=�6-   $��Center=�6J   Course operator6v   �� 5K      -   5        $ 
thirdBlock��5K      $��Center=�6,   $��Center=�6I   Operator-cashier6v   5L      �� 5N   
   -   5         ��Name$ registrationButton��5N      $��Registration!��6-   #���  6E   
����������	#FF695AC8 � Cursor$
 Hand��6�   $��1��6�   $��33,207,0,148q�6�   $��1��6�   $	��130��6�   $��45��6�   ��6l   Z� 6  5P      5Q      