   M S B A M L   `   `   `  ���� K  GHausarbeit_Lager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Hausarbeit_Lager.FunktionenHausarbeit_Lager.Funktionen  ,    &Hausarbeit_Lager.Funktionen.ABCAnalyse   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:Hausarbeit_Lager.Funktionen     -     N� Title$  
ABCAnalyse�� N� FontSize$ 30(� N� 
Background �� .���  � Color$
 Gray�� � Offset$	 0.2Q�� $ DarkSlateGray��$	 0.8Q�.��� -   $��	parenGrid�� � ColumnDefinitions �� ��  � RowDefinitions �� $
��auto ��� $��* ��� $
��auto �.+��� $��40(�$��0��$��0��$��ABC Analyse��&   System.Windows.Controls.DataGrid  -   $��dgabc��$��1��$��20(�   AutoGenerateColumns .     
IsReadOnly . $
��auto������ ���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 *    Header$ Artikelnummer��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	ArtikelNr+  $
 * $ Artikelbezeichnung�� �� *Produkte.ProduktName+  $
 * $	 ABC�� �� *ABCGut+� $��1��$��1�� �� ��  �� $��* ��� $��2* ��� $��* �.+��� -   $��btnabcmanuell��$��0��$��0��$��Manuell einstellen��$��Center=�{�.  ���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��btnabcautomatic��$��1��$��0��$��Automatisch einstellen��$��Center=����� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� 
���   �$��0��$��2��$��1��$��Gütereinteilung��.���  � ToolTip$< 6Ab welcher Grenze handelt es sich um ein A oder B Gut!�� �� ��  �� �� .+��� $��0��$��0��$��A-Produkte: ��$��Center=��� $��0��$��1��$��B-Produkte: ��$��Center=��� -   $��tbxabcagood�� �� 	MaxLength$ 2��$��1��$��0��$��Center=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��tbxabcbgood��$ 2��$��1��$��1��$��Center=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��
btnabcback��$��1��$��2��$��Zurück��$��Center=����� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�