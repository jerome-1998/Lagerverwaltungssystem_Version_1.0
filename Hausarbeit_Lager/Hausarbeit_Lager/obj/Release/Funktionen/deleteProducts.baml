   M S B A M L   `   `   `  ���� K  GHausarbeit_Lager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Hausarbeit_Lager.FunktionenHausarbeit_Lager.Funktionen  0    *Hausarbeit_Lager.Funktionen.deleteProducts   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:Hausarbeit_Lager.Funktionen     -     N� Title$  deleteProducts�� N� FontSize$ 30(� N� 
Background �� .���  � Color$
 Gray�� � Offset$	 0.2Q�� $ DarkSlateGray��$	 0.8Q�.��� -   $��
ParentGrid�� � RowDefinitions �� $
��auto ��� $��* ��� $
��auto �.+��� $��Produkte löschen��$��40(�$��0��&   System.Windows.Controls.DataGrid  -   $��dgdeleteProductslist��$��1��   
IsReadOnly .    AutoGenerateColumns .  $��20(����� ���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 	ProduktID��
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *ProduktNummer+  $	 Produktname��$
 *  �� *ProduktName+  $	 Produktgruppe��$
 *  �� *ProduktGruppe+  $	 Produktwert��$
 *  �� *ProduktWert+� $��2�� � ColumnDefinitions �� ��  �� $
��auto ��� $��* ��� $
��auto �.+��� $��Suche:���� -   $��tbxdeleteProductssearch�� �� 	MaxLength$	 150��$��2��$��1��$
��0 10q�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��btndeleteproductsback��$��2��$��Zurück��$	��Top=����� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��btndeleteproductsdelete��$��2��$��1��$��Löschen��$	��Top=����� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�