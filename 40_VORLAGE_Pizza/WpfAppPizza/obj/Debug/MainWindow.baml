   M S B A M L   `   `   `  ����F  BWpfAppPizza, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfAppPizzaWpfAppPizza  5   	       WpfAppPizza.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfAppPizza     5   	     � Title$  Pizza Bestellservice��5   	   $	��700��6&   $	��550��63    � DataContext 5	         WpfAppPizza.Pizzeria  5
   
   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      6   �� 5      $��80 �6   6*   �� 5      $��80 �6   6*   �� 5      $��80 �6   6*   �� 5      $��80 �6   6+   �� 5      6   �� 5      6   �� 5      $��80 �6   6+    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� ��5      �� 5       �� DecodePixelWidth$	 800��6    �� 	UriSource$< 6H:\C#\40_VORLAGE_Pizza\WpfAppPizza\bin\Debug\logol.jpg?�65   5       �� 5!   
   $��2��6   ��5"      �� 5#      $	 800��6   $< 6H:\C#\40_VORLAGE_Pizza\WpfAppPizza\bin\Debug\logor.jpg?�65   5%      �� 5&   
   $��1��6   $��Unser Lieferservice��6$   $��14(�6?    �� TextAlignment$ Center=�6M   $��15q�6d   �� 5(   
   $��1��6   $��Kunden��6!   $��14(�6/   $ Right=�6=   $��10q�6S   �� 5)   
   -   5         ��Name$ 
comboKunde��5)      $��1��6'   $��1��64   $��2��6D   $��14(�6X   $��10q�6f   ��6r   �� *Kunden+�� 5*   
   -   5         ��Name$ lableKunden��5*      $��2��6)   ��66   �� *
Bestellung+6T   �� 5+   
   -   5        	 ��Name$	 	buttonAdd��5+      $��Neue Bestellung��6$   $��14(�6>   $��2��6L   $��2��6Y   $��10q�6i   6u   �� 5-   
   $��3��6   $��Unsere Pizzen��6!   $��14(�66   $ Right=�6D   $��10q�6Z   �� 5.   
   -   5        $ 
comboPizza��5.      $��3��6'   $��1��64   $��2��6D   $��14(�6X   $��10q�6f   ��6r   �� *Pizzen+�� 50   
   $��4��6   $��0��6!   $��Menge��61   $��14(�6>   $��10q�6L   $ Right=�6X   �� 51   
   -   5        
 ��Name$
 TextBoxMenge��51      $��4��6(   $��1��65   $��14(�6E   $��10q�6S    �� TextAlignment$
 Left=�6_   �� 52   
   -   5        $��4��52      $��2��6   $��Hinzufügen��6.   $��14(�6C   $��10q�6Q   6]   �� 54   
   -   5         ��Name$ listBoxBestellpositionen��54      $��5��64   $��3��6A   $��14(�6U   $��10q�6c   ��6o   �� *Bestellung.Lstpositionen+�� 56   
   $��6��6   $��
Gesamtwert��6!   $��14(�63   $��10q�6A   $ Right=�6M   �� 57   
   -   5        $
 txtBoxGesamtWert��57      $��6��6,   $��1��69   $��10q�6I   $��14(�6U   $��2��6c   �� 58   
   $��7��6   $��2��6   $��14(�6.   $��	bestellen��6<   $��10q�6P   59      5:      