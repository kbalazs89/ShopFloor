   M S B A M L   `   `   `  ����D  @ShopFloor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ShopFloor	ShopFloor  5   	   "    ShopFloor.ProductDetailsView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ShopFloor     5   	     � Title$  ProductDetailsView��5   	   $��469.003��6$   $��401.6��65   .��5	      � $��0,0,0.2,-0.8q�6   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FFCFC4EA��6   $ 1Q�61   5       � RowDefinitions 5   
   �� 5      $	��24* �6   �� 5      $
��245* �6   .+�5   
   �� $��Name:��6   $
��Left=�6    $��10,50.6,0,0q�6;   $	��Top=�6P   $��1��6h   $��Bookman Old Style)�6u   $	��101��6�   $
��Bold"�6�   $��0,0,2,0q�6�   �� 5   
   -   5         ��Name$ 	LabelName��5      $
��Left=�6N   $��25��6i   $��215,50.6,0,0q�6u   $	��Top=�6�   $	��166��6�   $��1��6�   $��Bookman Old Style)�6�   $
��Bold"�6�   $��0,0,2,0q�6�   ��6#   �� *SelectedProduct.Name+6�   �� 5   
   $��Price:��6   $
��Left=�6!   $��10,89.6,0,0q�6<   $	��Top=�6Q   $��1��6i   $��Bookman Old Style)�6v   $	��101��6�   $��0,0,2,0q�6�   �� 5   
   $
��Left=�6:   $��25��6U   $��215,91.8,0,0q�6a   $	��Top=�6w   $	��166��6�   $��1��6�   $��Bookman Old Style)�6�   $��0,0,2,0q�6�   ��6   �� *SelectedProduct.Price+6�   �� 5   
   $��	Quantity:��6   $
��Left=�6$   $��10,129.6,0,0q�6?   $	��Top=�6U   $��1��6m   $	��101��6z   $��Bookman Old Style)�6�   $��0,0,2,0q�6�   �� 5   
   $
��Left=�6=   $��25��6X   $��215,131.8,0,0q�6d   $	��Top=�6{   $	��166��6�   $��1��6�   $��Bookman Old Style)�6�   $��0,0,2,0q�6�   ��6   �� *SelectedProduct.Quantity+6�   �� 5   
   $��	Category:��6   $
��Left=�6$   $��10,169.6,0,0q�6?   $	��Top=�6U   $��1��6m   $	��101��6z   $��Bookman Old Style)�6�   $��0,0,2,0q�6�   �� 5   
   $
��Left=�6?   $��215,172.8,0,0q�6Z   $��1��6q   $	��Top=�6~   $	��166��6�   $��25��6�   $��Bookman Old Style)�6�   $��0,0,2,0q�6�   ��6   �� *SelectedProduct.Cathegory+6�   �� 5   
   $��Number of seats:��6   $
��Left=�6+   $��10,209.6,0,0q�6F   $	��Top=�6\   $��1��6t   $	��115��6�   $��Bookman Old Style)�6�   $��0,0,2,0q�6�   �� 5    
   $
��Left=�6>   $��25��6Y   $��215,211.8,0,0q�6e   $	��Top=�6}   $	��166��6�   $��1��6�   $��Bookman Old Style)�6�   $��0,0,2,0q�6�   ��6   �� *SelectedProduct.NrOfSeats+6�   �� 5!   
   $��Flight Range:��6   $
��Left=�6(   $��10,249.6,0,0q�6C   $	��Top=�6Y   $��1��6q   $	��101��6~   $��Bookman Old Style)�6�   $��0,0,2,0q�6�   �� 5"   
   $
��Left=�6@   $��25��6[   $��215,251.8,0,0q�6g   $	��Top=�6   $	��166��6�   $��1��6�   $��Bookman Old Style)�6�   $��0,0,2,0q�6�   ��6   �� *SelectedProduct.FlightRange+6�   �� 5#   
   $��Number of engines:��6   $
��Left=�6-   $��
10,290,0,0q�6H   $	��Top=�6\   $��1��6t   $��Bookman Old Style)�6�   $��0,0,2,0q�6�   �� 5$   
   $
��Left=�6@   $��25��6[   $��215,291.8,0,0q�6g   $	��Top=�6~   $	��166��6�   $��1��6�   $��Bookman Old Style)�6�   $��0,0,2,0q�6�   ��6   �� *SelectedProduct.NrOfEngines+6�   5)      5*      