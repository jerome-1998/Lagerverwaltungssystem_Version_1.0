   M S B A M L   `   `   `  ���� K  GHausarbeit_Lager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Hausarbeit_LagerHausarbeit_Lager      Hausarbeit_Lager.Home   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:Hausarbeit_Lager       N� Title$
  Home�� N� FontSize$ 20(� N� 
Background �� .���  � Color$
 Gray�� � Offset$	 0.2Q�� $ DarkSlateGray��$	 0.8Q�.��� -   $��gridhome�� � RowDefinitions �� $
��auto ��� $
��auto ���  � ColumnDefinitions �� $��* �.+�o� -   $��menuhome��$��0��$��2��$��15(�.@�m� -   $��
mihomedata��$��Profil��.@�m� -   $��mihomechangePW��$��Passwort ändern��m� -   $��
mihomeexit��$��Abmelden��m� -   $��mihomeclose��$��Programm beenden���� -   $��
tblloginas��$��1��$y�	Collapsed=��� -   $��tabcontrolhome��$��2��$��0q����� .��� $
 Gray��$	 0.2Q�� $ DarkSlateGray��$	 0.8Q�.@��� -	   $��tihomecustomer��$��Kunden��.��� -
   $��ParentGridKunde��$	��400��$	��Top=� �� ��  �� �� .+��� -   $��btnhomeshowcustomer��$	��100��$	��400��$��0��$��0��$��Kunden anzeigen������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��btnhomenewcustomer��$	��100��$	��400��$��1��$��0��$��Kunde hinzufügen������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��btnhomedeletecustomer��$	��100��$	��400��$��0��$��1��$��Kundendaten löschen������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��btnhomechangecustomer��$	��100��$	��400��$��1��$��1��$��Kundendaten anpassen������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��tihomedeliverer��$��Lieferer��.��� -   $��gridhomedeliverer��$	��Top=�$	��400�� �� ��  �� �� .+��� -   $��btnhomedelieverer��$	��100��$	��400��$��0��$��0��$��Lieferanten anzeigen������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��btnhomenewdelieverer��$	��100��$	��400��$��0��$��1��$��Lieferant hinzufügen������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��btnhomedeletedeliverer��$	��100��$	��400��$��1��$��0��$��Liefererdaten löschen������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��btnhomechangedeliverer��$	��100��$	��400��$��1��$��1��$��Liefererdaten anpassen������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��tihomegoods��$��Waren��.��� -   $��gridhomegoods��$	��Top=�$	��600�� �� ��  �� �� �� .+��� -   $��btnhometotalstock��$	��100��$	��400��$��0��$��0��$$��gesamten Lagerbestand anzeigen������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��btnhomeaddnewgoods��$	��100��$	��400��$��0��$��1��$��Produkt hinzufügen������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��btnhomedeleteproducts��$	��100��$	��400��$��1��$��0��$��Produkte löschen������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��btnhomechangegoods��$	��100��$	��400��$��1��$��1��$��Produktdaten anpassen������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��btnhomeleastwas��$	��100��$	��400��$��2��$��0��$ ��Mindestbestände festlegen������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��
btnhomeabc��$	��100��$	��400��$��2��$��1��$��ABC-Analyse������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��tihomechangedata��$��Bestellungen��$	��Top=�.��� -   $��gridhomechangedata��$	��400��$	��Top=� �� ��  �� �� .+��� -   $��btnhomeorderdeliver��$	��100��$	��400��$��0��$��0��$��Wareneingang������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -    $��btnhomeordersend��$	��100��$	��400��$��0��$��1��$��Warenausgang������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -!   $��btnhomeuebersicht��$	��100��$	��400��$��1��$��0��$��2��$��
Übersicht������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�