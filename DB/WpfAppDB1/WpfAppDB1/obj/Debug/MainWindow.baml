   M S B A M L   `   `   `  ����D  @WpfAppDB1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WpfAppDB1	WpfAppDB1  5   	       WpfAppDB1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WpfAppDB1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5	      !   WpfAppDB1.ArtikelVerwaltung  5
   
   .��5      �  � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��5* �6   �� 5      $��1* �6   �� 5      $��5* �6   �� 5      $��1* �6   .+�5   
   �� -   5        $��1��5      $��0��6!   $��DB einlesen��6.   6D   �� 5    
   -   5         ��Name$ listBoxArtikel��5       $��1��6*   $��1��6:   $��6��6G   ��6X   �� *
Artikels+�� 5!   
   $��3��6   $��1��6    $��Artikel einfügen��6-   �� 5"   
   $��3��6   $��2��6    $��Name:��6-   �� 5#   
   -   5         ��Name$ txtName��5#      $��3��6#   $��3��63   �� 5$   
   -   5        $ txtPreis��5$      $��3��6$   $��5��64   �� 5%   
   $��3��6   $��4��6    $��Preis:��6-   �� 5&   
   -   5        $��3��5&      $��6��6!   $��Artikel aufnehmen��6.   6J   �� 5'   
   -   5        $��1��5'      $��7��6!   $��Artikel löschen��6.   6H   �� 5(   
   -   5        $��3��5(      $��7��6!   $��Artikel ändern��6.   6G   5)      5*      