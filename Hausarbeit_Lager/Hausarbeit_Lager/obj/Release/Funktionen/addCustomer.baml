   M S B A M L   `   `   `  ���� K  GHausarbeit_Lager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Hausarbeit_Lager.FunktionenHausarbeit_Lager.Funktionen  -    'Hausarbeit_Lager.Funktionen.addCustomer   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:Hausarbeit_Lager.Funktionen       N� Title$  addCustomer�� N� FontSize$ 30(� N� 
Background �� .���  � Color$
 Gray�� � Offset$	 0.2Q�� $ DarkSlateGray��$	 0.8Q�.���  � ColumnDefinitions �� �� �� ��  � RowDefinitions �� �� �� �� �� �� �� �� �� �� �� .+��� $"��Kunde in System hinzufügen!��$��40(�$��4���� $��Kunden Daten��$
��Bold"�$��1��$��2���� $��Kundennummer:*��$��2��$��Center=��� $��Firmenname:*��$��3��$��Center=��� $
��PLZ:��$��4��$��Center=��� $��	Addresse:��$��5��$��Center=��� $
��Ort:��$��6��$��Center=��� $��Telefonnummer:��$��7��$��Center=��� $��Emailaddresse:��$��8��$��Center=��� $��Website:��$��9��$��Center=��� -   $��tbxaddCustomerKNummer�� �� 	MaxLength$ 9��$��1��$��2��$��Center=� �� TextAlignment$ Justify=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��tbxaddCustomerKName��$	 250��$��1��$��3��$��Center=�$ Justify=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��tbxaddCustomerKPLZ��$ 20��$��1��$��4��$��Center=�$ Justify=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��tbxaddCustomerKAddresse��$	 200��$��1��$��5��$��Center=�$ Justify=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��tbxaddCustomerKOrt��$	 250��$��1��$��6��$��Center=�$ Justify=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��tbxaddCustomerKTelefon��$ 18��$��1��$��7��$��Center=�$ Justify=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��tbxaddCustomerKEmail��$	 250��$��1��$��8��$��Center=�$ Justify=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��tbxaddCustomerKWebsite��$	 250��$��1��$��9��$��Center=�$ Justify=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� $��2��$��1��$��Ansprechpartner��$��2��$
��Bold"��� $��2��$��2��$��Center=�$��AnsprechpartnerID:*���� $��2��$��3��$��Center=�$��Anrede:���� $��2��$��4��$��Center=�$��Vorname:���� $��2��$��5��$��Center=�$��	Nachname:���� $��2��$��6��$��Center=�$��Handynummer:���� $��2��$��7��$��Center=�$��Emailaddresse:���� $��2��$��8��$��Center=�$��Telfonnummer:���� -	   $��tbxaddCustomerANummer��$ 9��$��3��$��2��$��Center=�$ Justify=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -
   $��cobxaddCustomerAAnrede��$��3��$��3��$��Center=����� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.@��� -   $��cobxaddCustomerAAnredeH��$
��Herr������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��cobxaddCustomerAAnredeF��$
��Frau������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��cobxaddCustomerAAnredeS��	 �� 
IsSelected	 . $��	Sonstiges������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��tbxaddCustomerAVorname��$	 500��$��3��$��4��$��Center=�$ Justify=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��tbxaddCustomerANachname��$	 500��$��3��$��5��$��Center=�$ Justify=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $ ��tbxaddCustomerAHandynummer��$ 18��$��3��$��6��$��Center=�$ Justify=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��tbxaddCustomerAEmail��$	 250��$��3��$��7��$��Center=�$ Justify=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��tbxaddCustomerATelNummer��$ 18��$��3��$��8��$��Center=�$ Justify=�.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��btnaddCustomeradd��$��Kunde hinzufügen��$��2��$��2��$��10��$��Center=�
 � ToolTip$R
 LFügt den Kunden in das System ein wenn alle PflichtFelder ausgefüllt sind!��{�.  ���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��btnaddCustomerback��$��Zurück��$��0��$��10��$��Center=�$��2������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�