   M S B A M L   `   `   `  ���� P  LBackwoodsMapleTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:BackwoodsMapleTrackerBackwoodsMapleTracker  +    %BackwoodsMapleTracker.InventoryScreen   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5local#clr-namespace:BackwoodsMapleTracker       � WindowStartupLocation$  CenterScreen=� � Title$ 	Inventory��$	��450��$	��800��.��� ����  �� EndPoint$ 0.5,1&� � MappingMode$ RelativeToBoundingBox=� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFA8EDFF�� � Offset$ 1Q�� $ White��.+��� -   $��
Production��$
��Left=�$��	42,80,0,0q�$	��Top=�$	��118��$��18(����	#FF155CFF
����������	#FF6E9AFF$��33���� -   $��
Financials��$
��Left=�$��
42,138,0,0q�$	��Top=�$	��118��$��18(�
����������	#FF155CFF���	#FF6E9AFF$��33���� $��	Inventory��$
��Left=�$��
42,196,0,0q�$	��Top=�$	��118��$��18(�
����������	#FF155CFF���	#FF6E9AFF$��33�� J� Opacity$
 0.75Q�$��4,4,4,4q��� $��55,10,648.333,355.667q�$%��backwoods maple syrup label.png��$
��Fill=��� $��50��$��247,26,83.333,0q�$��Empty Jars Available:��$	��Top=�$��Center=�$��36(�$��Arial Black)�$	��463��
��������� $��44��$��260,105,459.333,0q�$��Pints��$	��Top=�$��Center=�$��28(�$��Comic Sans MS)�
�������$��74���� $��44��$��405,105,283.333,0q�$��Quarts��$	��Top=�$��Center=�$��28(�$��Comic Sans MS)�
�������$	��105���� $��44��$��554,105,112.333,0q�$��	1/2 Pints��$	��Top=�$��Center=�$��28(�$��Comic Sans MS)�$	��127��
��������� -   $��
pintsLabel��$��44��$��277,171,459.333,0q�$	��Top=�$��Center=�$��28(�$��Segoe UI Light)�
�������$��57���� -   $��halfPintsLabel��$��44��$��594,171,142.333,0q�$	��Top=�$��Center=�$��28(�$��Segoe UI Light)�$��57��
��������� -   $��quartsLabel��$��44��$��432,171,304.333,0q�$	��Top=�$��Center=�$��28(�$��Segoe UI Light)�
�������$��57���� -   $��	EditPints��$
��Edit��$
��Left=�$��270,231,0,0q�$	��Top=�$��57��$��18(����	#FF155CFF���	#FF155CFF
�������$��33�� J� RenderTransformOrigin$ 0.915,0.778&��� -   $��
EditQuarts��$
��Edit��$
��Left=�$��425,231,0,0q�$	��Top=�$��57��$��18(����	#FF155CFF���	#FF155CFF
�������$��33��$ 0.915,0.778&��� -   $��EditHalfPints��$
��Edit��$
��Left=�$��587,231,0,0q�$	��Top=�$��57��$��18(����	#FF155CFF���	#FF155CFF
�������$��33��$ 0.915,0.778&��� -	   $	��+12��$
��Left=�$��230,273,0,0q�$	��Top=�$��41��$��18(����	#FF155CFF���	#FF155CFF
�������$��33��$ 0.915,0.778&��� -
   $��+1��$
��Left=�$��277,273,0,0q�$	��Top=�$��41��$��18(����	#FF155CFF���	#FF155CFF
�������$��33��$ 0.915,0.778&��� -   $��-1��$
��Left=�$��323,273,0,0q�$	��Top=�$��41��$��18(����	#FF155CFF���	#FF155CFF
�������$��33��$ 0.915,0.778&��� -   $	��+12��$
��Left=�$��385,273,0,0q�$	��Top=�$��41��$��18(����	#FF155CFF���	#FF155CFF
�������$��33��$ 0.915,0.778&��� -   $��+1��$
��Left=�$��432,273,0,0q�$	��Top=�$��41��$��18(����	#FF155CFF���	#FF155CFF
�������$��33��$ 0.915,0.778&��� -   $��-1��$
��Left=�$��478,273,0,0q�$	��Top=�$��41��$��18(����	#FF155CFF���	#FF155CFF
�������$��33��$ 0.915,0.778&��� -   $	��+12��$
��Left=�$��547,273,0,0q�$	��Top=�$��41��$��18(����	#FF155CFF���	#FF155CFF
�������$��33��$ 0.915,0.778&��� -   $��+1��$
��Left=�$��594,273,0,0q�$	��Top=�$��41��$��18(����	#FF155CFF���	#FF155CFF
�������$��33��$ 0.915,0.778&��� -   $��-1��$
��Left=�$��640,273,0,0q�$	��Top=�$��41��$��18(����	#FF155CFF���	#FF155CFF
�������$��33��$ 0.915,0.778&��� -   $��pintsEditTxtBox��$
��Left=�$��23��$��277,182,0,0q�	 �� TextWrapping$
	 Wrap=�$�� ��$	��Top=�$��57��$y�Hidden=��� -   $��quartsEditTxtBox��$
��Left=�$��23��$��432,182,0,0q�$
	 Wrap=�$�� ��$	��Top=�$��57��$y�Hidden=��� -   $��halfPintsEditTxtBox��$
��Left=�$��23��$��594,182,0,0q�$
	 Wrap=�$�� ��$	��Top=�$��57��$y�Hidden=�