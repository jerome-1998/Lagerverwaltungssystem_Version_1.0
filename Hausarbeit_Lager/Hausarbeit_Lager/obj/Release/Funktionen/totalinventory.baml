   M S B A M L   `   `   `  ���� K  GHausarbeit_Lager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Hausarbeit_Lager.FunktionenHausarbeit_Lager.Funktionen  0    *Hausarbeit_Lager.Funktionen.totalinventory   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:Hausarbeit_Lager.Funktionen     -     N� Title$  totalinventory�� N� FontSize$ 30(� N� 
Background �� .���  � Color$
 Gray�� � Offset$	 0.2Q�� $ DarkSlateGray��$	 0.8Q�.��� -   $��
parentGrid�� � RowDefinitions �� $
��auto ��� �� ��  � ColumnDefinitions �� �� �� .+��� $��2��$��Lagerbestand anzeigen��$��40(�&   System.Windows.Controls.DataGrid  -   $��dgtotalinventory��   
IsReadOnly . $��3��$��2��$��1��$ �� IsSynchronizedWithCurrentItem$
 TrueY�	   AutoGenerateColumns	 .  $��20(����� ���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Artikel Nummer��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	ArtikelNr+  $ Artikel Bezeichnung��$ *  �� *Produkte.ProduktName+  $ Aktueller Bestand��$ *  �� *
AktBestand+  $ Mindestbestand��$ *  �� *Mindestbestand+  $ Produkt Wert�� �� *Produkte.ProduktWert+  $	 ABC��$ *  �� *ABCGut+� $��0��$��3��$��3�� �� $
��auto ���  �� �� �� .+��� .��Suche:�� -   $��tbxtotalinventorysearch�� �� 	MaxLength$	 150��$��40��$��1��$��0��$	��Top=�$��2��.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��btntotalinvgoback��$��40��$��3��$��2��$	��Top=�$��Zurück������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�