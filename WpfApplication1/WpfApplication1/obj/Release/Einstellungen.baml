   M S B A M L   `   `   `  ���� J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  #    WpfApplication1.Einstellungen   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:WpfApplication1       � WindowStartupLocation$  CenterScreen=����	#FFE5E5E5 � Title$  Einstellungen Version1_5_2��$	��404��$	��430�� � 
ResizeMode$ NoResize=� � WindowStyle$ 
ToolWindow=�.��� .+��� -    ��Name$ 
tabControl��$	��320��$	��Top=� �� SelectedIndex$ 0��.@��� $��	Allgemein��.��� -    �Name$ Grid1�����	#FFFFD1F5{�. .+��� -    ��Name$ checkBox�� � ToolTip$8 2Für dauerhafte Änderung muss gespeichert werden!��{�. $��	Aktiviert��$
��Left=�$��241,192,0,0q�$	��Top=��� -   	 ��Name$	 label��{�. $��Winterspecial:��$
��Left=�$��
18,186,0,0q�$	��Top=��� -   $	 label2��$��Default Zeitguthaben: ��$
��Left=�$��	18,45,0,0q�$	��Top=��� -   $	 label3��$��Default 'Beginn heute': ��$
��Left=�$��	18,73,0,0q�$	��Top=��� -   $	 label3_Copy��$��Default Pausenzeit: ��$
��Left=�$��
18,101,0,0q�$	��Top=��� -   $	 label3_Copy1��$%��Default 'Wann magst du gehen': ��$
��Left=�$��
18,129,0,0q�$	��Top=��� -	   $	 label3_Copy2��$��Default Wunschfaktor: ��$
��Left=�$��
18,157,0,0q�$	��Top=��� -
   
 ��Name$
 textBox��$
��Left=�$��23��$��
241,49,0,0q� �� TextWrapping$
 Wrap=�$
��0,00��$	��Top=�$	��120���� -   $
 textBox_Copy��$
��Left=�$��23��$��
241,77,0,0q�$
 Wrap=� �� 	MaxLength$ 2��$��08��$	��Top=�$��27���� -   $
 textBox_Copy1��$
��Left=�$��23��$��
289,77,0,0q�$
 Wrap=�$ 2��$��00��$	��Top=�$��27���� -   $
 textBox_Copy2��$
��Left=�$��23��$��241,105,0,0q�$
 Wrap=�$��30��$	��Top=�$	��120���� -   $
 textBox_Copy3��$
��Left=�$��23��$��241,133,0,0q�$
 Wrap=�$��17��$ 2��$	��Top=�$��27���� -   $
 textBox_Copy4��$
��Left=�$��23��$��289,133,0,0q�$
 Wrap=�$��00��$ 2��$	��Top=�$��27���� -   $
 textBox_Copy5��$
��Left=�$��23��$��241,161,0,0q�$
 Wrap=�$	��2,5��$	��Top=�$	��120���� -   $	 label4��$��:��$
��Left=�$��
273,73,0,0q�$	��Top=��� -   $	 label4_Copy��$��:��$
��Left=�$��271,130,0,0q�$	��Top=��� -   $	 label4_Copy1��$	��Uhr��$
��Left=�$��
321,73,0,0q�$	��Top=��� -   $	 label4_Copy2��$	��Uhr��$
��Left=�$��321,130,0,0q�$	��Top=��� -    ��Name$ button1��$&  Neue Werte als Default festlegen��$��	Speichern��$
��Left=�$��25��$��241,257,0,0q�$	��Top=�$	��120���� -   $	 label5��{�.  $��Sprache:��$
��Left=�$��
18,215,0,0q�$	��Top=�	� -    	�Name$ radioButton��{�.  $��DE�� d� 	IsChecked$
 TrueY�$
��Left=�$��241,221,0,0q�$	��Top=�	� -   $ radioButton_Copy��{�.  $��EN��$
��Left=�$��289,221,0,0q�$	��Top=��� -   $ button2��$% Auf Standartwerte zurücksetzen��$��Reset��$
��Left=�$��
18,257,0,0q�$	��Top=�$��70��$��25���� -    ��Name$ comboBox�� �� SelectedValuePath$ Content��{�. $
��Left=�$��23��$��
241,21,0,0q�$	��Top=�$	��120��.@��� -    ��Name$ WhiteB��.����  �� Orientation$ 
Horizontal=�.+��� 
�������
�������---�� $�� Weiß (Default)���� -   $ GreenB��.���� $ 
Horizontal=�.+��� 
������
������---�� $�� Grün���� -   $ 
LightBlueB��.���� $ 
Horizontal=�.+��� 
����ح�
����ح�---�� $�� Blau���� -   $ RosaB��.���� $ 
Horizontal=�.+��� 
�������
�������---�� $�� Rosa���� -   $ LightCoralB��.���� $ 
Horizontal=�.+��� 
�������
�������---�� $
�� Rot���� -    $ LightYellowB��.���� $ 
Horizontal=�.+��� 
�������
�������---�� $�� Gelb���� -!   $ BuntB��.���� $ 
Horizontal=�.+��� 
��� ���
��� ���.�� 
���  ��
���  ��.�� 
���� ��
���� ��.�� 
����  �
����  �.�� 
���2�2�
���2�2�.�� $�� Bunt���� -"   $ 	DarkGrayB��.���� $ 
Horizontal=�.+��� 
�������
�������---�� $�� Grau���� -#   $ BlackB��.���� $ 
Horizontal=�.+��� 
���iii�
���iii�---�� $�� Dunkelgrau���� -$   $ 
RealBlackB��.���� $ 
Horizontal=�.+��� 
���   �
���   �---�� $�� Schwarz���� -%   $	 label2_Copy��{�. $ ��Default Hintergrundfarbe: ��$
��Left=�$��	18,18,0,0q�$	��Top=��� $��Tipps & Tricks��.��� ���	#FFADE2E3.+��� $
��Left=�$	��277��$��5,5,0,0q�$	��Top=�$	��403��.���� -&    ��Name$ 
textBlock3��$
��Wrap=�$��TippsNTricks���� $��Updates��.��� ���	#FFBAE3BB.+��� $
��Left=�$	��277��$��10,5,0,0q�$	��Top=�$	��398��.���� -'   $ 	textBlock��$
��Left=�$
��Wrap=�$��
UpdateText��$	��Top=��� $��	Über uns��.��� ���	#FFE5E5E5.+��� -(   $ 
textBlock1��$
��Left=�$	��162��$��	10,24,0,0q�$
��Wrap=�$��UeberUns��$	��Top=�$	��396���� -)   $ 
textBlock2��$  Emailprogramm öffnet sich��$
��Left=�$��20��$��
27,262,0,0q�$
��Wrap=�$	��Top=�$��91���� -*   $Z��Tmailto:kirchner.oscar@googlemail.com?subject=AnfrageZeitrechnerApp&body=Hallo Oscar,?�.�Email Schreiben�� -+   $ 
textBlock4��$  Emailprogramm öffnet sich��$
��Left=�$��20��$��229,262,0,0q�$
��Wrap=�$	��Top=�$��42���� -,   $2��,https://github.com/OscarKirchner/ZeitRechner?�.�GitHub�� --   $ button��$��Fertig��$ Einstellungen Schließen��$
��Left=�$��
10,325,0,0q�$	��Top=�$��34��$	��392��