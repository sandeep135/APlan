   M S B A M L   `   `   `  ����@  <APLan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:APLan.ViewsAPLan.Views  5   	   3clr-namespace:APLan.ViewModelsAPLan.ViewModels  5   	       APLan.Views.ChooseProject   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:APLan.Views     5   	   5
viewModelsclr-namespace:APLan.ViewModels     5   	      mainMenuViewModel  � DataContext#  [  5   	    � 
ResizeMode$ NoResize=�5
   	    � Icon$ /Resources/Icons/new.png��5   	    � Title$ Model Choosing��5   	   $	��400��6    $	��300��6-    � 	Resources 5       �� 
TargetType �� Property �� Value  
themeColor �� 	Resources��%A  '��       7  �� 5   
   " ��6   .�5      ��  � ��$ Center=�62   �� 5       � ��$ 50q�6'   �� 5       � ��$ 50��6'   �� 5       � ��8   6+    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 10��65   6B   5      5      5      5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Eulynx Model��5       ��5!      �� 
 �� Source#
 [   �� Path$ 
NewProject���5"      ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" ��� 5&   
   $��1��6   $��
ERDM Model��5'      ��5(      �� #
 [  $
 ERDM���5)      ��  �� $ FindAncestor=�" �5-      5.      