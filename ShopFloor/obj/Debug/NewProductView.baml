   M S B A M L   `   `   `  ����D  @ShopFloor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ShopFloor	ShopFloor  5   	       ShopFloor.NewProductView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ShopFloor     5   	     � Title$  Product Form��5   	   $��501.998��6   $��419.417��6/   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FF9CE89A��6   $ 1Q�61   5       � RowDefinitions 5   
   �� 5      $	��24* �6   �� 5      $
��245* �6   .+�5   
   �� $��Name:��6   $
��Left=�6!   $��20,59.8,0,0q�6<   $	��Top=�6Q   $��1��6i   $��Bookman Old Style)�6v   $
��Bold"�6�   $��1,0,0,0q�6�   �� 5   
   -   5         ��Name$ NameText��5      $
��Left=�6%   $��23��6@   $��225,58.8,0,0q�6L    �� TextWrapping$
 Wrap=�6b   $	��Top=�6�   $	��166��6�   $��1��6�   
�������$��0,0,1,0q�6�   ��6v   �� *Product.Name+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��Price:��6   $
��Left=�6!   $��20,98.8,0,0q�6<   $	��Top=�6Q   $��1��6i   $��Bookman Old Style)�6v   �� 5   
   -   5        $
��Left=�5      $��23��6.   $��225,100.8,0,0q�6:   $
 Wrap=�6Q   $	��Top=�6�   $	��166��6�   $��1��6�   ��6e   �� *Product.Price+$ PropertyChanged=�6�   �� 5   
   $��	Quantity:��6   $
��Left=�6$   $��20,138.8,0,0q�6?   $	��Top=�6U   $��1��6m   $��Bookman Old Style)�6z   �� 5   
   -   5        $
��Left=�5      $��23��6-   $��225,140.8,0,0q�69   $
 Wrap=�6P   $	��Top=�6�   $	��166��6�   $��1��6�   ��6d   �� *Product.Quantity+$ PropertyChanged=�6�   �� 5   
   $��	Category:��6   $
��Left=�6$   $��20,178.8,0,0q�6?   $	��Top=�6U   $��1��6m   $��Bookman Old Style)�6z   �� 5   
   $
��Left=�6Z   $��225,180.8,0,0q�6u   $��1��6�   $	��Top=�6�   $	��166��6�   	 �� Text	 6   �� *Product.Cathegory+$ PropertyChanged=�.@�5      �� $��AIRBUS��6   6.   �� 5      $��BOEING��6   6.   �� 5      $��McDONNELL DOUGLAS��6   69   �� 5      $��TUPOLJEV��6   60   �� 5       $��LOCKHEED��6   60   �� 5!      $��RSK MiG��6   6/   5"      �� 5#   
   $��Number of seats:��6   $
��Left=�6+   $��20,218.8,0,0q�6F   $	��Top=�6\   $��1��6t   $��Bookman Old Style)�6�   �� 5$   
   -   5        $
��Left=�5$      $��23��6-   $��225,220.8,0,0q�69   $
 Wrap=�6P   $	��Top=�6�   $	��166��6�   $��1��6�   ��6d   �� *Product.NrOfSeats+$ PropertyChanged=�6�   �� 5%   
   $��Flight Range:��6   $
��Left=�6(   $��20,258.8,0,0q�6C   $	��Top=�6Y   $��1��6q   $��Bookman Old Style)�6~   �� 5&   
   -   5        $
��Left=�5&      $��23��6-   $��225,260.8,0,0q�69   $
 Wrap=�6P   $	��Top=�6�   $	��166��6�   $��1��6�   ��6d   �� *Product.FlightRange+$ PropertyChanged=�6�   �� 5'   
   $��Number of engines:��6   $
��Left=�6-   $��20,298.8,0,0q�6H   $	��Top=�6^   $��1��6v   $��Bookman Old Style)�6�   �� 5(   
   -   5        $
��Left=�5(      $��23��6-   $��225,300.8,0,0q�69   $
 Wrap=�6P   $	��Top=�6�   $	��166��6�   $��1��6�   ��6d   �� *Product.NrOfEngines+$ PropertyChanged=�6�   �� 5)   
   -   5        $
��Save��5)      $
��Left=�6    $��265,381.8,0,0q�6;   $��1��6R   $	��Top=�6_   $��75��6w   6�   5,      5-      