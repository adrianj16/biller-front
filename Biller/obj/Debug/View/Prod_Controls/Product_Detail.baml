   M S B A M L   `   `   `  ����A  =Biller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Biller.View.Prod_ControlsBiller.View.Prod_Controls  5      .    (Biller.View.Prod_Controls.Product_Detail   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Biller.View.Prod_Controls     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � 
�������.+�5   
   �� .+�5      �   � ColumnDefinitions  5      �� 5      $
��Auto �6'   �� 5      $
��Auto �6'   �� 5      $��* �6'   .+�5      ��  �� Orientation$ Vertical=�6   $��	20,20,0,0q�64   $	��300��6G   $	��100��6S   $	��Top=�6`   $
��Left=�6x   $��0��6�   .+�5      �� $ 
Horizontal=�6!   .+�5      �� -   5         ��Name$ id��5   "   $
��Left=�6B   $��22��6]   $	��180��6i   $��0,0,10,0q�6u    �� 
IsReadOnly . ��6.   �� *Id+6�   �� 5      $��Id��6    $
��Left=�6-   5      �� 5      $ 
Horizontal=�6!   .+�5      �� -   5        $ title��5   "   $
��Left=�6H   $��22��6c   $	��180��6o   $��0,0,10,0q�6{   ��61   �� *Title+6{   �� 5      $��Titulo��6    $
��Left=�61   5      �� 5      $ 
Horizontal=�6!   .+�5      �� -   5        $ description��5   "   $
��Left=�6T   $��23��6o   $	��180��6{   $��0,0,10,0q�6�   ��67   �� *Description+6�   �� 5      $��Descripcion��6    $
��Left=�66   5      �� 5      $ 
Horizontal=�6!   .+�5       �� -   5        $ barcode��5    "   $
��Left=�63   $��23��6N   $	��180��6s   $��0,0,10,0q�6   ��6Z   �� *	Barcode+6   �� 5!      $��Codigo de Barra��6    $
��Left=�6:   5"      5#      �� 5$      $��2��6   .+�5%      �� $	��100��6   $	��100��6)   $��Right=�65   $��10,10,20,10q�6Q   5&      5'      �� 5(      $��
20,20,20,0q�6   .+�5)      ��  �� TabStripPlacement$	 Top=�6   .@�5*      �� $��Tarifas��6   .��5+      �� $��Content goes here...��6    5,      �� 5-      $��	Ubicacion��6   �� 5.      $��	Adicional��6   $��22��61   $��Bottom=�6=   .��5/      �� $ 
Horizontal=�6%   .+�50      �� $��Multi-producto��6$   �� 51      -   5         ��Name$ multiproduct��51   '    d� 	IsChecked 6=   �� *Multi_Product+52      53      54      55      �� 56      $��Bottom=�6   $��70��64   $��20,20q�6@   .+�57      �� -   5         ��Name$
 Save��57       0  ,MaterialDesignFloatingActionMiniAccentButton#��[  6'   $��70��6m   $��70��6y   
���   �$��Right=�6�   ��6�   Z� ��6�   Z� .��58      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ Floppy=�6.   59      5:      5;      5<      5=      