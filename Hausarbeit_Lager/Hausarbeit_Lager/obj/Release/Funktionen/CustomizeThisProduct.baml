   M S B A M L   `   `   `  ���� K  GHausarbeit_Lager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Hausarbeit_Lager.FunktionenHausarbeit_Lager.Funktionen  6    0Hausarbeit_Lager.Funktionen.CustomizeThisProduct   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:Hausarbeit_Lager.Funktionen       N� Title$  CustomizeThisProduct�� N� FontSize$ 30(� N� 
Background �� .���  � Color$
 Gray�� � Offset$	 0.2Q�� $ DarkSlateGray��$	 0.8Q�.��� -   $��
ParentGrid�� � ColumnDefinitions �� ��  � RowDefinitions �� �� �� �� �� �� �� .+��� $��
Bearbeite:��$��40(��� $��1��$��40(�$��2������ *ProduktName+�� $��Produkt Daten��$
��Bold"�$��1��$��2���� $��Produktnummer:*��$��2��$��Center=��� $��Produktname:*��$��3��$��Center=��� $��Produktgruppe:��$��4��$��Center=��� $��Produktwert:��$��5��$��Center=��� -   $��tblcustomizeProductNummer��$��1��$��2��$��Center=� �� TextAlignment$ Justify=����� *ProduktNummer+���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��tbxcustomizeProductName�� �� 	MaxLength$	 400��$��1��$��3��$��Center=�	 �� TextAlignment$	 Justify=����� *ProduktName+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��cbxcustomizeProductGroup��$��1��$��4��$��Center=����� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.@��� $��
Importiert������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� $��
Produziert������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $$��tbxcustomizeDelivererDAddresse��$ 7��$��1��$��5��$��Center=�$	 Justify=����� *ProduktWert+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��btncustomizeProduct��$��Produkt bearbeiten��$��1��$��6��$��Center=�
 � ToolTip$7
 1Verändert die geänderten Daten in der Datenbank��{�.  ���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��btncustomizeProductback��$��Zurück��$��0��$��6��$��Center=����� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�