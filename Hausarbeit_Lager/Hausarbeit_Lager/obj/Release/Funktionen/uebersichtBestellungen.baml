   M S B A M L   `   `   `  ���� K  GHausarbeit_Lager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Hausarbeit_Lager.FunktionenHausarbeit_Lager.Funktionen  8    2Hausarbeit_Lager.Funktionen.uebersichtBestellungen   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:Hausarbeit_Lager.Funktionen     -     N� Title$  uebersichtBestellungen�� N� FontSize$ 30(� N� 
Background �� .���  � Color$
 Gray�� � Offset$	 0.2Q�� $ DarkSlateGray��$	 0.8Q�.���  � RowDefinitions �� $
��auto ��� $
��auto ��� �� $
��auto ��� �� $
��auto �.+��� $��40(�$��
Übersicht���� $��1��$��Wareneingänge��&   System.Windows.Controls.DataGrid  -   $��dggoodsreceipt��$��2��$��20(�   
IsReadOnly .    AutoGenerateColumns .  ���� ���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�����  �� 
TargetType)  #System.Windows.Controls.DataGridRow"  .�-   	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *WareneingangID+  $
 Lieferer��$ *  �� *Lieferer1.LiefererName+  $
 Produkt��$ *  �� *Waren.Produkte.ProduktName+�� $��3��$��Warenausgänge��  -   $��dggoodsissue��$��4�� . $��20(� .  ���� ���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q����� "  .�-   	   $
 ID��$ *  �� *WarenausgangID+  $
 Kunde��$ *  �� *Kunde1.KundenName+  $
 Produkt��$ *  �� *Waren.Produkte.ProduktName+�� -   $��btnback��$��5��$��Zurück��$��Center=�$
��0 10q����� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�