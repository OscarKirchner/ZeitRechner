   M S B A M L   `   `   `  ���� J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1       WpfApplication1.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:WpfApplication1     -     � WindowStartupLocation$  CenterScreen=� � Icon$0 *./Resources/Icon/icons8-timezone-+2-40.png�� � Title$ ZeitRechner��$��503.091��$��890.102�� � 
ResizeMode$ NoResize=�.���  � ColumnDefinitions �� $	��77* ��� $
��365* �.+��� -    ��Name$ canvas��$��Stretch=�$��Stretch=�$��2���� -    ��Name$ button1�� � ToolTip$	 ESC��$��
Schließen��$
��Left=�$��
574,41,0,0q�$	��Top=�$��99��$	��352��$��1���� -    ��Name$ Boarder2��
���   �$��1q�$
��Left=�$	��352��$��	26,41,0,0q�$	��Top=�$	��664��$��2��._��� -   $ Boarder1��
���   �$��1q�$
��Left=�$	��293��$��
375,32,0,0q�$	��Top=�$	��270���� -   	 ��Name$	 textBox1��$
��Left=�$��23��$��	60,83,0,0q�
 �� TextWrapping$

 Wrap=�$
��0,00��$	��Top=�$��69���� -    ��Name$ label2��$��	Ergebnis:��$
��Left=�$��
252,83,0,0q�$	��Top=�$��1���� -   $	 textBox2�� �� 	MaxLength$ 2��$
��Left=�$��23��$��
60,147,0,0q�$

 Wrap=�$��08��$	��Top=�$��23�� J� RenderTransformOrigin$ -0.277,0.502&��� -	   $ label3��$ zB. 08 : 30 oder 07 : 48��$��Beginn heute��$
��Left=�$��
40,120,0,0q�$	��Top=��� -
   $	 textBox3��$ 2��$
��Left=�$��23��$��106,147,0,0q�$

 Wrap=�$��00��$	��Top=�$��23���� -   $ label4��$��:��$
��Left=�$��
88,143,0,0q�$	��Top=��� -   $ label5��$S M= Faktor, wie im inesCRM unter Tagespräsenzzeiten -> GL-Saldo std. angegeben��$6��0Zeitguthaben wie angegeben (zb. 1,93 oder -0,83)��$
��Left=�$��	40,56,0,0q�$	��Top=�$	��286��$��2���� -   $ label6��$ zB. 30 oder 50��$��Pause heute in Minuten��$
��Left=�$��
40,179,0,0q�$	��Top=�$��2���� -   $	 textBox4��$
��Left=�$��23��$��
60,206,0,0q�$

 Wrap=�$��30��$	��Top=�$��69���� -   $ label7��$����Durch kleine Rundungsfehler kann es zu Verschiebungen kommen, weswegen manchmal eine Minute auf das Ergebnis aufgeschlagen wird.��$��8(�$
��Left=�$��
64,411,0,0q�$	��Top=�$��2���� -   $ label99��$w��qEs kann zu minimalen Ungenauigkeiten von max. +1 Minute kommen. Genaueres unter Info*. Alle Angaben ohne Gewähr.��$��8(�$
��Left=�$��
64,424,0,0q�$	��Top=�$��2���� -   $ label8��$m��gZeitrechner, um geringe Überstunden( bis max. 4h) oder geringe Minusstunden( bis max. -4h) zu checken:��$
��Left=�$��	10,10,0,0q�$	��Top=�$��2���� -   $ label9��$ zB. 16 : 45��$ ��Wann magst du heute gehen?��$
��Left=�$��
40,264,0,0q�$	��Top=�$��2���� -   $	 textBox5��$ 2��$
��Left=�$��23��$��
60,291,0,0q�$

 Wrap=�$��17��$	��Top=�$��23���� -   $	 textBox6��$ 2��$
��Left=�$��23��$��106,291,0,0q�$

 Wrap=�$��00��$	��Top=�$��23���� -   $	 textBox5_Copy1��$
��Left=�$��23��$��
60,350,0,0q�$

 Wrap=�$	��2,5��$	��Top=�$��69���� -   $ button2��$ Enter��$
��Left=�$��
172,78,0,0q�$	��Top=�$��65��$	��284��$��1��.���� 	Auswerten�� ( Enter ↩ )�� -   $ label10��$��:��$
��Left=�$��
88,287,0,0q�$	��Top=��� -   $ label11��$/��)-----------------------------------------��$
��Left=�$��
40,234,0,0q�$	��Top=�$��2���� -   $ button��$ I��$	��⚙��$��20(�$
��Left=�$��
26,411,0,0q�$	��Top=�$��38��$��40��$ 	0.3,2.909&��� -   $ label9_Copy��$* $= WuschZeitguthaben, zB. 0 oder 2,75��$ ��Was ist dein Wunschfaktor?��$
��Left=�$��
40,323,0,0q�$	��Top=�$��2���� -   $ label9_Copy1��$	��Uhr��$
��Left=�$��134,143,0,0q�$	��Top=�$��41��$��2���� -   $ label9_Copy2��$	��Uhr��$
��Left=�$��134,287,0,0q�$	��Top=�$��41��$��2��