   M S B A M L   `   `   `  ���� K  GHausarbeit_Lager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Hausarbeit_Lager.FunktionenHausarbeit_Lager.Funktionen  1    +Hausarbeit_Lager.Funktionen.deleteDeliverer   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:Hausarbeit_Lager.Funktionen     -     N� Title$  deleteDeliverer�� N� FontSize$ 30(� N� 
Background �� .���  � Color$
 Gray�� � Offset$	 0.2Q�� $ DarkSlateGray��$	 0.8Q�.��� -   $��
ParentGrid�� � RowDefinitions �� $
��auto ��� �� $
��auto �.+��� $��0��$��40(�$��Lieferer löschen��&   System.Windows.Controls.DataGrid  -   $��dgdeletedeliverlist��$��1��$��20(�   AutoGenerateColumns .     
IsReadOnly . ���� ���� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 Lieferer ID��
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
LiefererNR+  $	 Lieferer Name��$
 *  �� *LiefererName+  $	 Lieferer Website��$
 *  �� *	Website+  $	 Adresse��$
 *  �� *	Adresse+  $	 Lieferer Ansprechpartner��$
 *  �� *LAnsprechpartner.AnspNachname+� $��2�� � ColumnDefinitions �� ��  �� $
��auto ��� �� $
��auto �.+��� $��Suche:���� -   $��tbxdeletedeliverersearch�� �� 	MaxLength$	 150��$
��0 10q�$��1��$��2��.������ .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�.���� -   $��btndeletedelivererdelete��$��2��$��0��$��Löschen��$	��Top=����� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q��� -   $��btndeletedelivererback��$��2��$��1��$��Zurück��$	��Top=����� .��� $ Silver��$
 0.25Q�� $ Black��$
 1.35Q�