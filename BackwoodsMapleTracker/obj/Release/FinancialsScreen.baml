   M S B A M L   `   `   `  ���� U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  P LBackwoodsMapleTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:BackwoodsMapleTrackerBackwoodsMapleTracker ,   &BackwoodsMapleTracker.FinancialsScreen   <lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5local#clr-namespace:BackwoodsMapleTracker       � WindowStartupLocation$  CenterScreen=� � Title$ 
Financials��$	��450��$	��800��.��� ����  �� EndPoint$ 0.5,1&� � MappingMode$ RelativeToBoundingBox=� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFA8EDFF�� � Offset$ 1Q�� $ White��.+��� -   $��
Production��$
��Left=�$��	42,80,0,0q�$	��Top=�$	��118��$��18(����	#FF155CFF
����������	#FF6E9AFF$��33���� $��
Financials��$
��Left=�$��
42,138,0,0q�$	��Top=�$	��118��$��18(�
����������	#FF155CFF���	#FF6E9AFF$��33�� J� Opacity$
 0.75Q�$��4,4,4,4q��� -   $��	Inventory��$
��Left=�$��
42,196,0,0q�$	��Top=�$	��118��$��18(�
����������	#FF155CFF���	#FF6E9AFF$��33��#   LiveCharts.Wpf.CartesianChart  -   $��Chart��$��260,48,10.333,157.667q�&    LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Right=�	   Series	 �� *
GraphLines+
   AxisY
    LiveCharts.Wpf.Axis     Title$ Dollar Amount��   LabelFormatter �� *
YFormatter+   AxisX   $
 Date��   Labels �� *Dates+�� -   $��NewEntryBtn��$��	New Entry��$
��Left=�$��
87,300,0,0q�$	��Top=�$	��118��$��18(����	#FF155CFF���	#FF155CFF
�������$��33�� J� RenderTransformOrigin$ 0.915,0.778&��� -   $��Toggle Graph��$
��Left=�$��
465,10,0,0q�$	��Top=�$	��118��$��18(����	#FF155CFF���	#FF155CFF
�������$��33��$ 0.915,0.778&��� $��55,10,648.333,355.667q�$%��backwoods maple syrup label.png��$
��Fill=�&   System.Windows.Controls.DataGrid  -   $��DataGrid��   AutoGenerateColumns .  $
��Left=�$	��132��$��260,263,0,0q�$	��Top=�$	��365������    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *date+ �� Mode$ OneWay=�  $
 Name�� �� *name+$ OneWay=�  $
 Cost�� �� *cost+$ OneWay=��� -   $��
ConfirmBtn��$��Confirm��$
��Left=�$��
87,374,0,0q�$	��Top=�$	��118��$��18(����	#FF155CFF���	#FF155CFF
�������$��33��$ 0.915,0.778&�$y�Hidden=��� -   $��	CancelBtn��$��Cancel��$
��Left=�$��221,374,0,0q�$	��Top=�$	��118��$��18(����	#FF155CFF���	#FF155CFF
�������$��33��$ 0.915,0.778&�$y�Hidden=��� -	   $��	LabelDate��$
��Date��$
��Left=�$��
65,284,0,0q�$	��Top=�$ 1.587,0.603&�$y�Hidden=��� -
   $��	LabelName��$
��Name��$
��Left=�$��164,284,0,0q�$	��Top=�$y�Hidden=��� -   $��	LabelCost��$
��Cost��$
��Left=�$��279,282,0,0q�$	��Top=�$y�Hidden=��� -   $��
DateTxtBox��$
��Left=�$��23��$��
65,310,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$��80��$y�Hidden=��� -   $��
NameTxtBox��$
��Left=�$��23��$��164,310,0,0q�$
 Wrap=�$�� ��$	��Top=�$��96��$y�Hidden=��� -   $��
CostTxtBox��$
��Left=�$��23��$��279,310,0,0q�$
 Wrap=�$�� ��$	��Top=�$��60��$y�Hidden=�