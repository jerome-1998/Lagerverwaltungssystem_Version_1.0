   M S B A M L   `   `   `  ���� K  GHausarbeit_Lager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Hausarbeit_Lager.FunktionenHausarbeit_Lager.Funktionen  7    1Hausarbeit_Lager.Funktionen.customizeThisCustomer   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:Hausarbeit_Lager.Funktionen       N� Title$  customizeThisCustomer�� N� FontSize$ 30(� N� 
Background �� .���  � Color$
 Gray�� � Offset$	 0.2Q�� $ DarkSlateGray��$	 0.8Q�.��� -   $��
ParentGrid�� � ColumnDefinitions �� �� �� ��  � RowDefinitions �� �� �� �� �� �� �� �� �� �� �� .+��� $��
Bearbeite:��$��40(��� $��1��$��40(�$��2������ *
KundenName+�� $��Kunden Daten��$
��Bold"�$��1��$��2���� $��Kundennummer:*��$��2��$��Center=��� $��Firmenname:*��$��3��$��Center=��� $
��PLZ:��$��4��$��Center=��� $��Adresse:��$��5��$��Center=��� $
��Ort:��$��6��$��Center=��� $��Telefonnummer:��$��7��$��Center=��� $��Emailadresse:��$��8��$��Center=��� $��Website:��$��9��$��Center=��� -   $!��tblcustomizeCustomerCNummer��$��1��$��2��$��Center=� �� TextAlignment$ Justify=����� *
KundenNr+���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��tbxcustomizeCustomerCName�� �� 	MaxLength$	 250��$��1��$��3��$��Center=�	 �� TextAlignment$	 Justify=����� *
KundenName+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��tbxcustomizeCustomerCPLZ��$ 20��$��1��$��4��$��Center=�$	 Justify=����� *PLZ+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $#��tbxcustomizeCustomerCAddresse��$	 200��$��1��$��5��$��Center=�$	 Justify=����� *	Adresse+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��tbxcustomizeCustomerCOrt��$	 250��$��1��$��6��$��Center=�$	 Justify=����� *Ort+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $"��tbxcustomizeCustomerCTelefon��$ 18��$��1��$��7��$��Center=�$	 Justify=����� *Telefonnummer+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $ ��tbxcustomizeCustomerCEmail��$	 250��$��1��$��8��$��Center=�$	 Justify=����� *EmailaddresseBetrieb+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -	   $"��tbxcustomizeCustomerCWebsite��$	 250��$��1��$��9��$��Center=�$	 Justify=����� *	Website+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� $��2��$��1��$��Ansprechpartner��$��2��$
��Bold"��� $��2��$��2��$��Center=�$��AnsprechpartnerID:*��
 � ToolTip$I
 CBitte geben Sie die eindeutige Nummer für den Ansprechpartner ein!���� $��2��$��3��$��Center=�$��Anrede:���� $��2��$��4��$��Center=�$��Vorname:���� $��2��$��5��$��Center=�$��	Nachname:���� $��2��$��6��$��Center=�$��Handynummer:���� $��2��$��7��$��Center=�$��Emailadresse:���� $��2��$��8��$��Center=�$��Telefonnummer:���� -
   $!��tblcustomizeCustomerANummer��$��3��$��2��$��Center=�$ Justify=����� *(&KAnsprechpartner.AnsprechPartnerNummer+���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $"��cobxcustomizeCustomerAAnrede��$��3��$��3��$��Center=����� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.@��� -   $#��cobxcustomizeCustomerAAnredeH��$
��Herr������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $#��cobxcustomizeCustomerAAnredeF��$
��Frau������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $#��cobxcustomizeCustomerAAnredeS�� �� 
IsSelected . $��	Sonstiges������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $"��tbxcustomizeCustomerAVorname��$	 500��$��3��$��4��$��Center=�$	 Justify=����� *KAnsprechpartner.AnspVorname+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $#��tbxcustomizeCustomerANachname��$	 500��$��3��$��5��$��Center=�$	 Justify=����� *KAnsprechpartner.AnspNachname+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $&�� tbxcustomizeCustomerAHandynummer��$ 18��$��3��$��6��$��Center=�$	 Justify=����� *" KAnsprechpartner.AnpsHandyNummer+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $ ��tbxcustomizeCustomerAEmail��$	 250��$��3��$��7��$��Center=�$	 Justify=����� *KAnsprechpartner.AnspEmail+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $$��tbxcustomizeCustomerATELNummer��$ 18��$��3��$��8��$��Center=�$	 Justify=����� *$"KAnsprechpartner.AnspTelefonnummer+.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��btncustomizeCustomer��$��Kunde bearbeiten��$��2��$��2��$��10��$��Center=�$7
 1Verändert die geänderten Daten in der Datenbank��{�.  ���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��btncustomizeCustomerback��$��Zurück��$��0��$��10��$��Center=�$��2������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�