   M S B A M L   `   `   `  ����S  OTirePressureSensorWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:TirePressureSensorWpfAppTirePressureSensorWpfApp  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   )    #TirePressureSensorWpfApp.PlotWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Y UDynamicDataDisplay, Version=0.4.0.0, Culture=neutral, PublicKeyToken=5b7d744a7263923f^ ZDynamicDataDisplay.Maps, Version=0.1.0.0, Culture=neutral, PublicKeyToken=5b7d744a7263923fa ]DynamicDataDisplay.Markers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=5b7d744a7263923fAd34http://research.microsoft.com/DynamicDataDisplay/1.0    5   	   6local&clr-namespace:TirePressureSensorWpfApp    5   	   NControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro    5   	   -   5        (  "MahApps.Metro.Controls.MetroWindow    WindowTransitionsEnabled  .   � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ 曲线显示��5   	   $	��470��6   $	��600��6#    � 	Resources 5         ChartPlotterBrush 
� GradientOrigin � Offset � Color�� 5   
   %�   &	        
� 5      $ 0.6,0.5&�6<   .��5      � $ 0Q�6   $ White��6*   � 5      $ 1Q�6   $ 	#FFEDFFFB��6*   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   8  2Microsoft.Research.DynamicDataDisplay.ChartPlotter  -   5        	  Name$	 
templotter��5       $��0��5!      $��0��5"      #��[  5#      3  -Microsoft.Research.DynamicDataDisplay.Plotter
   Children.
 5$      2  ,Microsoft.Research.DynamicDataDisplay.Header  $��温度��6   
���   �6%   =  7Microsoft.Research.DynamicDataDisplay.VerticalAxisTitle  5%      $	��值��6#   
���   �6/   ?  9Microsoft.Research.DynamicDataDisplay.HorizontalAxisTitle  5&      $��时间��6%   
���   �62   5'        5(   
   -   5        $	 
preplotter��5)      $��0��5*      $��1��5+      #��[  5,      .
 5-        $��压力��6   
���   �6%     5.      $	��值��6#   
���   �6/     5/      $��时间��6%   
���   �62   50        51   
   -   5        $	 
freplotter��52      $��1��53      $��0��54      #��[  55      .
 56        $��频率��6   
���   �6%     57      $	��值��6#   
���   �6/     58      $��时间��6%   
���   �62   59        5:   
   -   5        $	 
ampplotter��5;      $��1��5<      $��1��5=      #��[  5>      .
 5?        $��增益��6   
���   �6%     5@      $	��值��6#   
���   �6/     5A      $��时间��6%   
���   �62   5B      5C      5D      