   M S B A M L   `   `   `  ����A  =Biller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BillerBiller  5   	       Biller.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Biller     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$  
MainWindow��5   	   $	��600��6   $
��1024��6)    � WindowStyle$
 None=�5
   	    � AllowsTransparency .    MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStartupLocation$ CenterScreen=�6;   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6   .+�5   
   � -   5         �Name$ GridBarraTitulo��5      $��2��6(   
����  �.+�5      �� 	 �� Orientation$	 
Horizontal=�6   $��Right=�62   $
��10,0q�6N   .+�5      ��  0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6   $��35��6_   $��35��6k   
���������6v   Z� ��6�   Z� .��5       '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]
   Kind$
 Settings=�6.   5!      �� 5"      #��[ 6   $��35��6_   $��35��6k   
���������6v   Z� ��6�   Z� .��5#        $
 Account=�6.   5$      �� 5%      -   5         ��Name$ Shutdown��5%      #��[ 6B   $��25��6�   $��25��6�   
���������6�   Z� ��6�   Z� .��5&        $
 Power=�6.   5'      5(      5)      � 5+   
   $��2��6   $��0��6    ��5,      �� 5-       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5.      �  � Color$ 	#FF58789E��6#    � Offset$ 1Q�65   � 5/      $ White��6#   50       52      �� 53      $	��100 �6    �� 54      $��* �6    .+�59      � ��5:      �� 5;      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5<      � $ 	#FFE0E6ED��6'   $ 1Q�69   � 5=      $ DarkBlue��6'   $ 0.653Q�68   5>      .+�5@      �� $��Biller��6   
�������$��Center=�6=   $��Center=�6Z   $��30(�6u   $��Book Antiqua)�6�   5A      �� 5C      $��1��6   .+�5D      �� $��10q�6   
����  �.��5E      � $	��150��6   .+�5F        $
 ViewDashboard=�62   �� 5G      $��	Dashboard��6$   $��Center=�65   5H      5I      �� 5J      $��10q�6   
����  �.��5K      � $	��150��6   .+�5L        $
 ContentPaste=�62   �� 5M      $��Pedidos��6$   $��Center=�63   5N      5O      �� 5P      $��10q�6   
����  �.��5Q      � $	��150��6   .+�5R        $
 
TshirtCrew=�62   �� 5S      $��	Productos��6$   $��Center=�65   5T      5U      �� 5V      $��10q�6   
����  �.��5W      � $	��150��6   .+�5X        $
 FormatListChecks=�62   �� 5Y      $��
Inventario��6$   $��Center=�66   5Z      5[      �� 5\      $��10q�6   
����  �.��5]      � $	��150��6   .+�5^        $
 TruckDelivery=�62   �� 5_      $��Seguimiento��6$   $��Center=�67   5`      5a      �� 5b      $��10q�6   
����  �.��5c      � $	��150��6   .+�5d        $
 Printer=�62   �� 5e      $��Reportes��6$   $��Center=�64   5f      5g      5h      5i      5k      5l      