   M S B A M L   `   `   `  ���� K  GHausarbeit_Lager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Hausarbeit_Lager.FunktionenHausarbeit_Lager.Funktionen  .    (Hausarbeit_Lager.Funktionen.showCustomer   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:Hausarbeit_Lager.Funktionen     -     N� Title$  showCustomer�� N� FontSize$ 30(� N� 
Background �� .���  � Color$
 Gray�� � Offset$	 0.2Q�� $ DarkSlateGray��$	 0.8Q�.��� -   $��
ParentGrid�� � ColumnDefinitions �� �� ��  � RowDefinitions �� $
��auto ��� �� �� .+��� $��Alle Kunden anzeigen��$��40(�$��2��&   System.Windows.Controls.DataGrid  -   $��dgshowcustomer��$��20(�$��3��$��1��$��2��   AutoGenerateColumns .     
IsReadOnly . $	 �� IsSynchronizedWithCurrentItem$
	 TrueY����� ���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q����� 
 �� 
TargetType)  #System.Windows.Controls.DataGridRow"
  .�-      Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto    Header$ 	Kunden ID��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
KundenNr+  $ * $ Kunden Name�� �� *
KundenName+  $ * $	 PLZ�� �� *PLZ+  $ * $ Adresse�� �� *	Adresse+  $ * $	 Ort�� �� *Ort+  $ * $ Telefonnummer�� �� *Telefonnummer+  $ * $ Emailadresse�� �� *EmailaddresseBetrieb+  $ * $ Website�� �� *	Website+  $
 auto $ Ansprechpartner Nachname��   FontSize$ 15Q� �� *KAnsprechpartner.AnspNachname+� $��0��$��3��$��3�� �� �� ��  �� $
��auto ��� .+��� .��Suche:�� -   $��tbxshowcustomersearch�� �� 	MaxLength$	 150��$��40��$	��Top=�$��1��$��0��$��2��.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��btnshowcustomerback��$��40��$	��Top=�$��1��$��2��$��Zurück������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�