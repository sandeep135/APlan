   M S B A M L   `   `   `  ����@  <APLan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:APLan.ViewsAPLan.Views  5          APLan.Views.PlanningTab   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:APLan.Views     5         planTabViewModel  � DataContext#  [  5       � 	Resources 5
       �� 
TargetType �� Property �� Value��%�  '��       '�� �     '�� I    �� 5   
   " ��6   .�5      ��  � ��$ 40��6&   �� 5       � ��$ 40��6'   �� 5       � ��$ 5q�6'   �� 5       � ��$ 0q�60   �� 5       � ��
 ���� 6A   5      �� 5   
   " ��6   .�5      ��  � ��$ Center=�64   �� 5       � ��$	 Top=�62   5      �� 5   
   " ��6   .�5      ��  � ��$	 100��6&   �� 5       � ��$ 5,0,0,0q�6'   5      5      .��5      �� $��Disabled=�6   .��5   
   � $��Center=�6   .+�5      �� .+�5      �� $��40��6   $��40��6$   $��1��5        � ToolTip$
 Plan��6%   ��5!      �� *
PlanButton+.��5"      �� $��/Resources/Icons/plan.png��6   $
��Fill=�6?   5#      �� 5$       �� SelectedItem 6   �� *
PlanType+ �� Mode$ TwoWay=�.@�5%      �� $
��ETCS��6#   5&      �� 5'      $
��Plan��6   $��Center=�6'   6F   5(      �� 5)      .+�5*      �� $��2��6   ��5+      �� *ExportButton+.��5,      �� $!��/Resources/Icons/export.png��6    $
��Fill=�6E   5-      �� 5.       6   �� *
ExportType+$ TwoWay=�.@�5/      �� $��Eulynx��6(   �� 50      $	��pdf��6'   �� 51      $	��dxf��6'   �� 52      $��Plan Pro��6'   ${�False��6:   �� 53      $��
JSON(ERDM)��6'   55      �� 56      $��Export��6   6/   57      �� 58      .+�59      �� $��3��6   ��5:      �� *ImportButton+.��5;      �� $!��/Resources/Icons/import.png��6   $
��Fill=�6A   5<      �� 5=       6   �� *
ImportType+$ TwoWay=�.@�5>      �� $��Image��6#   5@      �� 5A      $��Import��6   6+   5B      5E      5F      5G      