   M S B A M L   `   `   `  ���� K  GHausarbeit_Lager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Hausarbeit_LagerHausarbeit_Lager      Hausarbeit_Lager.leastwas   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:Hausarbeit_Lager     -     N� Title$  leastwas�� N� FontSize$ 30(� N� 
Background �� .���  � Color$
 Gray�� � Offset$	 0.2Q�� $ DarkSlateGray��$	 0.8Q�.��� -   $��
parentGrid�� � ColumnDefinitions �� �� �� $��* � � RowDefinitions �� $
��auto ��� �� �� �� .+�&   System.Windows.Controls.DataGrid  -   $��
dgleastwas��$��20(�$��0��$��1��$��2��$��3��   AutoGenerateColumns .     
IsReadOnly . ���� ���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Header$
 Artikelnummer��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	ArtikelNr+  $
 Artikelbezeichnung��$ *  �� *Produkte.ProduktName+  $
 Mindestbestand��$ *  �� *Mindestbestand+�� $��0��$��0��$��3��$	��Top=�$��40(�$��Mindestbestand festlegen���� $��2��$��1��.+��� $��Mindestbestand:���� -   $��tbxleastwassetleastwas�� �� 	MaxLength$ 10��$
��0 10q�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� $��2��$��2��.+��� -   $��btnleastwassave��$
��0 10q�$��Anwenden������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� $��2��$��3��.+��� -   $��btnleastwasback��$
��0 10q�$��Zurück������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�� $��3��$��0��$��4�� �� $
��auto ���  �� �� �� .+��� .��Suche:�� -   $��tbxleastwassearch��$��0��$��3��$��1��$	��Top=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.��