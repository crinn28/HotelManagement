   M S B A M L   `   `   `  ����  Multi-Login1    +Multi_Login.ViewModels.RezervationViewModel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Reserva��5      $	��420��6   $	��340��6#    � 
ResizeMode$ NoResize=�6/    � WindowStartupLocation$ CenterScreen=�6E    � WindowStyle$
 None=�6j   .��5	      � .+�5
   
   � -   5        $
��Left=�5
      $��20��6*   $	��Top=�66   $	��340��6N   $��0,0,0,0q�6�   ���	#FFF1F1F1.+�5      �� -   5        $
��Left=�5      $��16��6/   $��	317,2,0,0q�6;   $	��Top=�6N   $��16��6f   $4��./GestaoHoteleira;component/icons/fechar-16.png��6q   6�   �� 5      -   5        $
��Left=�5      $��16��6/   $��	297,2,0,0q�6;   $	��Top=�6N   $��16��6f   $6��0/GestaoHoteleira;component/icons/minimize-16.png��6q   6�   5      �� 5   
   $��Reserva��6   $
��Left=�6"   $��	10,20,0,0q�6=   $	��Top=�6P   $	��162��6h   $��16(�6t   $��Century Gothic)�6�   
���   �$
��Bold"�6�   �� 5   
   $��Quarto��6   $
��Left=�6!   $��	10,67,0,0q�6<   $	��Top=�6O   $��57��6g   $��14(�6r   $��Century Gothic)�6�   
���   �$
��Bold"�6�    J� RenderTransformOrigin$ 0.632,0.481&�6�   �� 5   
   -   5        $��
tipoQuarto��5       $��Basic��6   $
��Left=�62   $��	67,67,0,0q�6M   $	��Top=�6`   $	��140��6x   $��14(�6�   $��Century Gothic)�6�   
���   �$
��Bold"�6�   $ 0.5,0.5&�6�   �� 5   
   $��Numero do Quarto:��6   $
��Left=�6,   $��	10,94,0,0q�6G   $	��Top=�6Z   �� 5   
   -   5        $��numero��5   &   $��12312312312��6   $
��Left=�64   $��
145,94,0,0q�6O   $	��Top=�6c   $ 0.529,0.962&�6{   �� 5   
   $��Piso:��6   $
��Left=�6    $��
10,125,0,0q�6;   $	��Top=�6O   $ 0.529,0.962&�6g   �� 5   
   -   5        $
��piso��5      $��1��6   $
��Left=�6(   $��145,125,0,0q�6C   $	��Top=�6X   $ 0.529,0.962&�6p   �� 5   
   -   5        $��	_designer��5   $   $��	Designer:��6   $
��Left=�65   $��
10,156,0,0q�6P   $	��Top=�6d   $ 0.529,0.962&�6|   �� 5   
   -   5        $��designer��5   '   $��Rui Pinheiro��6   $
��Left=�67   $��145,156,0,0q�6R   $	��Top=�6g   �� 5   
   $��Cliente:��6   $
��Left=�6#   $��
10,195,0,0q�6>   $	��Top=�6R   $��75��6j   $��14(�6u   $��Century Gothic)�6�   
���   �$
��Bold"�6�   �� 5   
   -	   5        $��comboboxListaClientes��5      $
��Left=�60   $��
10,227,0,0q�6K   $	��Top=�6_   $	��300��6w   .@�5      �� ��6   �� *Nome+66   5      �� 5   
   $��Data de Inicio��6   $
��Left=�6)   $��
10,282,0,0q�6D   $	��Top=�6X   $	��114��6p   $��14(�6|   $��Century Gothic)�6�   
���   �$
��Bold"�6�   (  "System.Windows.Controls.DatePicker  5   
   -
   5        $��
dataInicio��5      $
��Left=�6'   $��
10,314,0,0q�6B   $	��Top=�6V   $	��114��6n   �� 5    
   $��Data de Fim��6   $
��Left=�6&   $��212,282,0,0q�6A   $	��Top=�6V   $	��114��6n   $��14(�6z   $��Century Gothic)�6�   
���   �$
��Bold"�6�     5!   
   -   5        $��dataFim��5!      $
��Left=�6$   $��212,314,0,0q�6?   $	��Top=�6T   $	��114��6l   �� 5#   
   $��Reserva��6   $
��Left=�6#   $��244,381,0,0q�6>   $	��Top=�6S   $��82��6k   $��26��6v   5%      5'      