   M S B A M L   `   `   `  ���� K  GHausarbeit_Lager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Hausarbeit_Lager.FunktionenHausarbeit_Lager.Funktionen  /    )Hausarbeit_Lager.Funktionen.showDeliverer   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:Hausarbeit_Lager.Funktionen     -     N� Title$  showDeliverer�� N� FontSize$ 30(� N� 
Background �� .���  � Color$
 Gray�� � Offset$	 0.2Q�� $ DarkSlateGray��$	 0.8Q�.��� -   $��
ParentGrid�� � ColumnDefinitions �� �� ��  � RowDefinitions �� $
��auto ��� �� �� .+��� $��Alle Lieferer anzeigen��$��2��$��40(�&   System.Windows.Controls.DataGrid  -   $��dgshowdeliverer��$��20(�$��3��$��2��$��1��   AutoGenerateColumns .     
IsReadOnly . $	 �� IsSynchronizedWithCurrentItem$
	 TrueY����� ���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q����� 
 �� 
TargetType)  #System.Windows.Controls.DataGridRow"
  .�-      Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Lieferer ID��   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto    FontSize$ 15Q�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
LiefererNR+  $ Lieferer Name��$ 15Q� �� *LiefererName+  $	 PLZ��$ 15Q� �� *PLZ+  $ Adresse��$ 15Q� �� *	Adresse+  $	 Ort��$ 15Q� �� *Ort+  $ Telefonnummer��$ 15Q� �� *Telefonnummer+  $ Emailadresse��$ 15Q� �� *EmailaddresseBetrieb+  $ Website��$ 15Q� �� *	Website+  $ Ansprechpartner Nachname��$ 15Q� �� *LAnsprechpartner.AnspNachname+� $��0��$��3��$��3�� �� $
��auto ���  �� �� �� .+��� .��Suche:�� -   $��tbxshowdeliverersearch�� �� 	MaxLength$	 150��$��40��$	��Top=�$��1��$��0��$��2��.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��btnshowdelivererback��$��40��$	��Top=�$��1��$��2��$��Zurück������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�