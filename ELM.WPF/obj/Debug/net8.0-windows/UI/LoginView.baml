   M S B A M L   `   `   `  ����B  >ELM.WPF, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ELM.WPF.ServicesELM.WPF.Services  5      'clr-namespace:ELM.WPF.UI
ELM.WPF.UI  5          ELM.WPF.UI.LoginView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3servicesclr-namespace:ELM.WPF.Services     5      *localclr-namespace:ELM.WPF.UI     5      .��5
      � 
�������$	��500��6"   $��20q�6.   $��Center=�6:   $��Center=�6W     � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      �� $��Username��6   $��0 0 0 5 q�6'   $��0��69   �� 5      $��1��6U   $	��300��6e   $��30��6q   ��6   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�6q   5      � 5   
   $��1��6   .+�5      �� $��Password��6   $��0 10 0 5q�6'   $��0��6:   G� 5      -   5         G�Name$ PasswordBox��5      $��1��61   $	��300��5   r   $��30��6~   (   "ELM.WPF.Services.PasswordBoxHelper   Password 6   �� *
Password+ �� Mode$ TwoWay=�$ PropertyChanged=�6~   5      �� 5   
   $��2��6   $��2��6   $��Right=�63   $��Login��6O   $
��0 20q�6�   $	��100��6�   $��35��6�   ��6_   �� *LoginCommand+6�   5       5!      