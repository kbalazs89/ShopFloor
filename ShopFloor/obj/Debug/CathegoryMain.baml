   M S B A M L   `   `   `  ����D  @ShopFloor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ShopFloor	ShopFloor  5   	   %clr-namespace:ShopFloor	ShopFloor  5   	       ShopFloor.CathegoryMain   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ShopFloor     5   	   (baseclr-namespace:ShopFloor     5   	     � Title$  Category��5	   	   $��534.149��6   $��382.842��6+   .��5
      � $��0,0,-0.2,0.8q�6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ Black��6    � Offset$ 1Q�6-   � 5      $ 	#FF99B4D1��6   $ 0.017Q�61   5       � ColumnDefinitions 5   
   �� 5      $
��178* �6   �� 5      $
��199* �6   .+�5   
   �� -   5        $
��Left=�5   �   $	��389��6�   $��	12,60,0,0q�6�   $	��Top=�6�   $	��235��6�   $��2��6�   $��0,0,3,0q�6`   �� SelectedItem 6   �� *SelectProduct+��69   �� *ProductList+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=���6J  Z� ��5      �� 5      .R�5      �� ��6!   Z� .+�5      �� $
��Bold"�69   $��14(�6K   $��Bookman Old Style)�6Y   ��6    �� *Name+6Y   �� 5      $��11(�6:   
 �� ContentStringFormat$
 0 M USD��6H   $��Bookman Old Style)�6f   ��6    �� *Price+6f   �� 5      $��11(�6=   $
 0 pcs��6K   $��Bookman Old Style)�6g   $��0q�6�   ��6    �� *
Quantity+6�   5      5      5       �� 5!   
   -   5        $��Add to cart��5!      $��1��6'   $
��Left=�67   $��96.4,65,0,0q�6R   $	��Top=�6g   $��75��6   $��0,0,3,0q�6�   ��6�   Z� 6�   �� 5"   
   -   5         ��Name$ DeleteButton��5"      $��Delete item��6'   $��1��6=   $
��Left=�6M   $��96.4,157,0,0q�6h   $	��Top=�6~   $��75��6�   $��0,0,3,0q�6�   ��6�   Z� 6�   �� 5#   
   -   5        $ ModifyButton��5#      $��Modify item��6'   $��1��6=   $
��Left=�6M   $��96.4,111,0,0q�6h   $	��Top=�6~   $��75��6�   $��0,0,3,0q�6�   ��6�   Z� 6�   5$      5%      