   M S B A M L   `   `   `  ����D  @Homework1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Homework1	Homework1  5   	       Homework1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Homework1     5   	     � Title$  
MainWindow��5   	   $	��800��6   $
��1200��6)    � WindowStartupLocation$ CenterScreen=�66    � Icon$ Resources/auchan-3.ico��6[    � 	Resources 5	       �� 
TargetType   ButtonTemplate �� CornerRadius��%�   &	        �� 5
   
   " ��6   .R�5      �� $ 25��6   #��z��5      #��z��5      #��z��5      $��30��5      #��z��5      ._�5      �� #��z��6!   #��z��5   !   #��z��5   !   #��z��5   !   5      5      5      .��5      � $��0,0,2,0q�6    � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��2 �6   �� 5      .+�5   
   �� .+�5      �  5       �� 5!      $	��83* �6'   �� 5"      $
��167* �6'   �� 5#      $��0* �6'    � RowDefinitions 5%      �� 5&      �� 5'      �� 5(      �� 5)      �� 5*      .+�5,      �� -   5         ��Name$ ProfileImage��5,      $��4��5-      $��Resources/manager.png��5.      �� 50      -   5        	 ��Name$	 
LoginLabel��50      $��Login��51      $��1��6%   $��Center=�65   �� 52      -   5        $	 SurNameLabel��52      $��Surname��53      $��1��6'   $��1��67   $��Center=�6D   �� 54      -   5        $	 	NameLabel��54      $��Center=�55      $
��Name��56      $��1��6'   $��2��67   �� 57      -   5        $	 	RoleLabel��57      $��Manager��58      $��1��6*   $��Center=�59      $��4��63   �� 5:      -   5        $	 LastNameLabel��5:      $��Center=�5;      $��Lastname��5<      $��1��6+   $��3��6;   5>      �� 5?      
���   �$��2��6+   �� 5@      $��Control panel��6   $��Center=�6,     
LabelStyle#��[ 6I   �� 5A      -   5        
 ��Name$
 CreateSaleButton��5A      $��Create Sale��5B        ButtonColorStyle#��[ 5C      #��[  5E      �� 5F      -   5        $
 
SaleButton��5F      $
��Sale��5G      #��[ 5H      #��[  5J      5K       � 5L   
   -	   5          �Name$ 
FrameTable��5L      $��2��6$   $	��769��64   $	��Top=�6A   �� 5M   
   
���   �$��1��6'   5N      5O      