   M S B A M L   `   `   `  ���� K  GHausarbeit_Lager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Hausarbeit_LagerHausarbeit_Lager  "    Hausarbeit_Lager.addnewGoods   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:Hausarbeit_Lager       N� Title$  addnewGoods�� N� FontSize$ 30(� N� 
Background �� .���  � Color$
 Gray�� � Offset$	 0.2Q�� $ DarkSlateGray��$	 0.8Q�.���  � ColumnDefinitions �� $
��auto ��� $��* ��� $��* � � RowDefinitions �� �� �� �� �� �� .+��� $��Neue Produkte hinzufügen��$��40(�$��3���� $��Artikelnummer:*��$��Center=�$��0��$��1���� $��Produktname:*��$��Center=�$��0��$��2���� $��Produktnummer:*��$��Center=�$��0��$��3���� $��Produktgruppe:��$��Center=�$��0��$��4���� $��Produktwert:��$��Center=�$��0��$��5���� -   $��tbxaddnewproductsANR�� �� 	MaxLength$ 9��$��Center=�$��1��$��1��.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��tbxaddnewproductsPN��$	 400��$��1��$��2��$��Center=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��tbxaddnewproductsPNR��$ 9��$��1��$��3��$��Center=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��cbxaddnewgood��$��1��$��4��$��Center=����� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.@��� -   $��cbxitemimport�� �� 
IsSelected . $��
Importiert������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��cbxitemproduce��$��
Produziert������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��tbxaddnewproductsvalue��$ 7��$��1��$��5��$��Center=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��btnaddnewgoods��$��Neues Produkt hinzufügen��$��2��$��1��$��Center=�{�.  ���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -	   $��btnaddnewgoodsback��$��Zurück��$��2��$��5��$��Center=����� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�