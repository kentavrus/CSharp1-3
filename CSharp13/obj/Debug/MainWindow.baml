   M S B A M L   `   `   `  ����C  ?CSharp13, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CSharp13CSharp13  5   	       CSharp13.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:CSharp13     5   	     � Title$  Person��5   	   $��289.357��6   $��212.097��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      6!   .+�5   
   �� $��0��6   $��Center=�6   $��Center=�6:   $��First name:��6U   �� 5   
   $��1��6   $��Stretch=�6   $��Center=�6>   $��23��6Y   $��4q�6e    �� TextWrapping$
 Wrap=�6p   ��6�   �� *	FirstName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��2��6   $��Center=�6   $��Center=�6:   $��
Last name:��6U   �� 5   
   $��3��6   $��Stretch=�6   $��Center=�6=   $��23��6Y   $��4q�6f   $
 Wrap=�6r   ��6�   �� *
LastName+$ TwoWay=�$ PropertyChanged=��� 5   
   $��4��6   $��Center=�6   $��Center=�6:   $��Email:��6V   �� 5   
   $��5��6   $��Stretch=�6   $��Center=�6>   $��23��6Z   $��4q�6g   $
 Wrap=�6r   ��6�   �� *Email+$ TwoWay=�$ PropertyChanged=��� 5   
   $��6��6   $��Center=�6   $��Center=�6:   $��Pick your birth date:��6V   (  "System.Windows.Controls.DatePicker  5    
   $��7��6   $��Stretch=�6#   $��Center=�6A   $��4q�6]      FirstDayOfWeek$ Monday=�6�      SelectedDate 6h   �� *DateOfBirth+$ TwoWay=�$ PropertyChanged=�6�   �� 5!   
   $��8��6   $��Stretch=�6   $��Center=�6=   $��Proceed��6X   y�6j   �� *ButtonVisibility+$ OneWay=�$ PropertyChanged=���6�   �� *ProceedCommand+5"      5#      