   M S B A M L   `   `   `  ���� K  GHausarbeit_Lager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Hausarbeit_Lager.FunktionenHausarbeit_Lager.Funktionen  8    2Hausarbeit_Lager.Funktionen.customizeThisDeliverer   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:Hausarbeit_Lager.Funktionen       N� Title$  customizeThisDeliverer�� N� FontSize$ 30(� N� 
Background �� .���  � Color$
 Gray�� � Offset$	 0.2Q�� $ DarkSlateGray��$	 0.8Q�.��� -   $��
ParentGrid�� � ColumnDefinitions �� �� �� ��  � RowDefinitions �� �� �� �� �� �� �� �� �� �� �� .+��� $��
Bearbeite:��$��40(��� $��1��$��40(�$��2������ *LiefererName+�� $��Lieferer Daten��$
��Bold"�$��1��$��2���� $��Lieferernummer:*��$��2��$��Center=��� $��Firmenname:*��$��3��$��Center=��� $
��PLZ:��$��4��$��Center=��� $��Adresse:��$��5��$��Center=��� $
��Ort:��$��6��$��Center=��� $��Telefonnummer:��$��7��$��Center=��� $��Emailadresse:��$��8��$��Center=��� $��Website:��$��9��$��Center=��� -   $"��tblcustomizeDelivererDNummer��$��1��$��2��$��Center=� �� TextAlignment$ Justify=����� *
LiefererNR+���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $ ��tbxcustomizeDelivererDName�� �� 	MaxLength$	 250��$��1��$��3��$��Center=�	 �� TextAlignment$	 Justify=����� *LiefererName+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��tbxcustomizeDelivererDPLZ��$ 20��$��1��$��4��$��Center=�$	 Justify=����� *PLZ+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $$��tbxcustomizeDelivererDAddresse��$	 200��$��1��$��5��$��Center=�$	 Justify=����� *	Adresse+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��tbxcustomizeDelivererDOrt��$	 250��$��1��$��6��$��Center=�$	 Justify=����� *Ort+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $#��tbxcustomizeDelivererDTelefon��$ 18��$��1��$��7��$��Center=�$	 Justify=����� *Telefonnummer+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $!��tbxcustomizeDelivererDEmail��$	 250��$��1��$��8��$��Center=�$	 Justify=����� *EmailaddresseBetrieb+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -	   $#��tbxcustomizeDelivererDWebsite��$	 250��$��1��$��9��$��Center=�$	 Justify=����� *	Website+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� $��2��$��1��$	��0 0q�$��Ansprechpartner��$��2��$
��Bold"��� $��2��$��2��$��Center=�$��AnsprechpartnerID:*���� $��2��$��3��$��Center=�$��Anrede:���� $��2��$��4��$��Center=�$��Vorname:���� $��2��$��5��$��Center=�$��	Nachname:���� $��2��$��6��$��Center=�$��Handynummer:���� $��2��$��7��$��Center=�$��Emailadresse:���� $��2��$��8��$��Center=�$��Telefonnummer:���� -
   $"��tblcustomizeDelivererANummer��$��3��$��2��$��Center=�$ Justify=����� *'%LAnsprechpartner.AnprechPartnerNummer+���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $#��cobxcustomizeDelivererAAnrede��$��3��$��3��$��Center=����� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.@��� -   $$��cobxcustomizeDelivererAAnredeH��$
��Herr������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $$��cobxcustomizeDelivererAAnredeF��$
��Frau������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $$��cobxcustomizeDelivererAAnredeS��
 �� 
IsSelected
 . $��	Sonstiges������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $#��tbxcustomizeDelivererAVorname��$	 500��$��3��$��4��$��Center=�$	 Justify=����� *LAnsprechpartner.AnspVorname+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $$��tbxcustomizeDelivererANachname��$	 500��$��3��$��5��$��Center=�$	 Justify=����� *LAnsprechpartner.AnspNachname+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $'��!tbxcustomizeDelivererAHandynummer��$ 18��$��3��$��6��$��Center=�$	 Justify=����� *" LAnsprechpartner.AnpsHandyNummer+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $!��tbxcustomizeDelivererAEmail��$	 250��$��3��$��7��$��Center=�$	 Justify=����� *LAnsprechpartner.AnspEmail+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $%��tbxcustomizeDelivererATELNummer��$ 18��$��3��$��8��$��Center=�$	 Justify=����� *$"LAnsprechpartner.AnspTelefonnummer+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��btncustomizeDeliverer��$��Lieferer bearbeiten��$��2��$��2��$��10��$��Center=� � ToolTip$7 1Verändert die geänderten Daten in der Datenbank��{�.  ���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��btncustomizeDelivererback��$��Zurück��$��0��$��10��$��Center=�$��2������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�