   M S B A M L   `   `   `  ����A  =Biller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Biller.ViewBiller.View  5   	       Biller.View.Main   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Biller.View     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$
  Main��5   	   $	��600��6   $
��1024��6#    � WindowStyle$
 None=�5
   	    � AllowsTransparency .    MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6   .+�5   
   � -   5         �Name$ HeadBar��5      $��1��6    
����  �.+�5      �� 	 �� Orientation$	 
Horizontal=�6   $��Right=�62   $
��10,0q�6N   .+�5       ��  0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6   $��35��6_   $��35��6k   
���������6v   Z� ��6�   Z� .��5!      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]
   Kind$
 Settings=�6.   5"      �� 5#      #��[ 6   $��35��6_   $��35��6k   
���������6v   Z� ��6�   Z� .��5$        $
 Account=�6.   5%      �� 5&      -   5         ��Name$ Shutdown��5&      #��[ 6+   $��25��6q   $��25��6}   
���������6�   Z� ��6�   Z� .��5'        $
 Power=�6.   5(      5)      5*      � 5+   
   -   5        $ SideBar��5+      $��2��6    $��0��61   ��5,      �� 5-       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5.      �  � Color$ 	#FF58789E��6#    � Offset$ 1Q�65   � 5/      $ White��6#   50       52      �� 53      $	��100 �6    �� 54      $��* �6    .+�57      � ��58      �� 59      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5:      � $ 	#FFE0E6ED��6'   $ 1Q�69   � 5;      $ DarkBlue��6'   $ 0.653Q�68   5<      .+�5>      �� $��Biller��6   
�������$��Center=�6=   $��Center=�6Z   $��30(�6u   $��Book Antiqua)�6�   5?      �� 5A      $��1��6   .+�5B      �� -   5        $ Dashboard_BTN��5B      $��10q�60   
����  �.��5C      � $	��150��6   .+�5D        $
 ViewDashboard=�62   �� 5E      $��	Dashboard��6$   $��Center=�65   5F      5G      �� 5H      -   5        $ 
Orders_BTN��5H      $��10q�6-   
����  �.��5I      � $	��150��6   .+�5J        $
 ContentPaste=�62   �� 5K      $��Pedidos��6$   $��Center=�63   5L      5M      �� 5N      -   5        $ Products_BTN��5N      $��10q�6/   
����  �.��5O      � $	��150��6   .+�5P        $
 
TshirtCrew=�62   �� 5Q      $��	Productos��6$   $��Center=�65   5R      5S      �� 5T      -   5        $ Inventory_BTN��5T      $��10q�60   
����  �.��5U      � $	��150��6   .+�5V        $
 FormatListChecks=�62   �� 5W      $��
Inventario��6$   $��Center=�66   5X      5Y      �� 5Z      -   5        $ Tracking_BTN��5Z      $��10q�6/   
����  �.��5[      � $	��150��6   .+�5\        $
 TruckDelivery=�62   �� 5]      $��Seguimiento��6$   $��Center=�67   5^      5_      �� 5`      -	   5        $ Reports_BTN��5`      $��10q�6.   
����  �.��5a      � $	��150��6   .+�5b        $
 Printer=�62   �� 5c      $��Reportes��6$   $��Center=�64   5d      5e      �� 5f      -
   5        $ Clients_BTN��5f      $��10q�6.   
����  �.��5g      � $	��150��6   .+�5h        $
 ClipboardPerson=�62   �� 5i      $��Clientes��6$   $��Center=�64   5j      5k      �� 5l      -   5        $ 	Users_BTN��5l      $��10q�6,   
����  �.��5m      � $	��150��6   .+�5n        $

 User=�62   �� 5o      $��Usuarios��6$   $��Center=�64   5p      5q      5r      5s      � 5t   
   -   5        $ 	Principal��5t      $��1��6"   $��2��62   5u      5v      