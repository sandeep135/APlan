   M S B A M L   `   `   `  ����@  <APLan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:APLan.ViewsAPLan.Views  5      3clr-namespace:APLan.ViewModelsAPLan.ViewModels  5          APLan.Views.MainMenu   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:APLan.Views     5      4	viewModelclr-namespace:APLan.ViewModels     5      -   5        
�������   mainMenuViewModel  � DataContext#  [  5
       J� InputBindings 5      �� 5   
   
 �� Key$ Z��5       �� 	Modifiers$ Controlf�5       �� Command 5      �� *Undo+5      �� 5   
   $ Y��5      $ Controlf�5       5      �� *Redo+5       � 	Resources 5       �� 
TargetType �� Property �� Value��%T   'm�       �� 5   
   " m�6   .�5      ��  � ��
 �����6;   5      5      .��5      � 	 � ColumnDefinitions	 5   
   �� 5      $��5* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   o� $��Stretch=�6   
�������.@�5       m� $��_File��6   .@�5!      m� $��_New project��6   
 m� Command
 5"      ��  �� Source# [   �� Path$ ChooseProjectType� m� CommandParameter 5#      ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" � m� Icon 5'      �� 5(      $��/Resources/Icons/new.png��6    5*      m� 5+      $��_Open��6   
 5,      ��   newProjectViewModel# [ $
 Open� 5-      �� 5.      $��/Resources/Icons/open.png��6    50      m� 57      $��_Save��6   {�58      �� # [ $ SaveButtonActive�
 59      �� *Save+ 5:      �� 5;      $��/Resources/Icons/save.png��6    5=      m� 5>      $��_Save as��6   {�5?      �� # [ $ SaveAsButtonActive�
 5@      �� *SaveAs+ 5A      �� 5B      $"��/Resources/Icons/save_as.png��6    5D      m� 5L      $��_Exit��6   
 5M      �� *ExitProgram+ 5N      ��  �� $ FindAncestor=�" � 5R      �� 5S      $��/Resources/Icons/exit.png��6    5U      5V      m� 5X      $��_Edit��6   .@�5Z      m� -   5        $
��undo��5Z      $��_Undo(Ctrl+Z)��6+    m� 	IsChecked$ False��5[      
 5Z   B   �� *Undo+5[   +   m� 5\      $��_Redo(Ctrl+Y)��6   $ False��5]      
 5\   .   �� *Redo+5^      m� 5_      $��Color��6   $ False��5`      
 5_   *   �� *ColorPicker+5a      m� 5e      $��_Canvas��6   .@�5f      m� -   5        $��
BlackTheme��5f      $ False��5g      5h   9   5i      5k      m� 5l      $��_View��6   .@�5n      m� -   5         m�Name$ visualizedDataItem��5n      $��_Visualized Data��5o      5p      m� 5q      -   5        $ canvasContentItem��5q      $��_Canvas Content��5r      5s      m� 5t      -   5        $ aplanCadViewerItem��5t      $��_Aplan CAD Viewer��5u      5v      m� 5w      -   5        $��_Planning/Canvas tabs��5w      $
 True��5x      5y      m� 5z      -   5        $��_Symbols/Selection tabs��5z      $
 True��5{      5|      m� 5~      -	   5        $��
SignalItem��5~      $��_Planned Signals info��5      5�      5�      m� 5�      $��_Tools��6   .@�5�      m� $��_EULYNX Validator��6   
 5�      �� *EulynxValidator+ 5�      �� 5�      $#��/Resources/Icons/validate.png��6    6I   5�      m� 5�      $��_ERDM Validator��6   
 5�      �� *ERDMvalidator+ 5�      �� 5�      $#��/Resources/Icons/validate.png��6    6I   5�      5�      m� 5�      $��_Help��6   .@�5�      m� $��
_About WPF��6   
 5�      �� *
AboutWPF+ 5�      �� 5�      $��/Resources/Icons/info.png��6    6E   5�      5�      5�      �� 5�   
   $��1��6   $��Center=�5�      $
��Bold"�5�      ��5�      �� # [ $ CurrentProjectNameBind�5�      � 5�   
   $��2��6   
�������.+�5�      � $��Center=�5�      $
��Left=�5�      y�5�      ��   globalLoading# [ $ LoadingVisibility�.+�5�      �� -
   5        $��myImage��5�      $&�� /Resources/Icons/eulynx-logo.png��6'   z�5�      �� 5�       �� Angle 6*   �� # [ $ LoadingIconAngle� �� CenterX 5�   *   ��  �� ElementName$ myImage��$ ActualWidth�  HalfLengthConverter �� 	Converter# [  �� CenterY 5�   *   �� $ myImage��$ ActualHeight�# [ 5�      5�      �� 5�      $��Center=�6   ��5�      �� # [ $ LoadingReport�5�      5�      5�      5�      