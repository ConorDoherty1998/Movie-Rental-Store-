   M S B A M L   `   `   `  ����F  BRentalStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:RentalStoreRentalStore  5          RentalStore.LoanPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:RentalStore     5      -   5          N� 
Background
  ����� N� Title$ LoanPage��5
       � 	Resources 5         moviesTemplate �� Orientation �� Path��%�   &	        �� 5   
   .R�5      �� $ 
Horizontal=�6   .+�5      �� ��6   �� $ Title�(6;   �� 5      ��6   �� $ Copies�)6<   5      5      5      .��5      � -   5         �Name$ loanGrid��5      .+�5   
   �� -   5         ��Name$ lbxStock��5      #��[  6$   $
��Left=�6S   $	��307��6n   $��	99,51,0,0q�6{   $	��Top=�6�   $	��240��6�   6�   �� 5   
   -   5         ��Name$ 	btnCreate��5      $	��Add��6$   $
��Left=�62   $��385,333,0,0q�6M   $	��Top=�6b   $��75��6z   6�   �� 5   
   -   5        $ btnIncrease��5      $��^��6&   $
��Left=�62   $��705,338,0,0q�6M   $	��Top=�6b   $��58��6z   6�   �� 5   
   -   5        $ btnDecrease��5      $��v��6&   $
��Left=�62   $��705,372,0,0q�6M   $	��Top=�6b   $��58��6z   6�   �� 5   
   -   5         ��Name$ tblkDays��5      $��20(�6'   $
��Left=�65   $��641,338,0,0q�6P   $
��Wrap=�6e   $	��Top=�6y   $��57��6�   	 J� RenderTransformOrigin$	 1.515,0.499&�6�   $��34��6�   �� 5   
   -   5        $ tblkDescription��5      $
��Left=�6\   $��
433,86,0,0q�6w   $
��Wrap=�6�   $	��Top=�6�   $	��172��6�   $	��242��6�   ��6-   �� $ Description�
 �� Mode$
 OneWay=�6�   �� 5   
   -	   5        $ 	tblkTitle��5      $
��Left=�6P   $��
433,45,0,0q�6k   $��16(�6   $
��Wrap=�6�   $	��Top=�6�   $��36��6�   $	��242��6�   $	 
0.51,0.081&�6�   ��6'   �� $ Title�$
 OneWay=�6�   �� 5   
   $
��Days��6   $
��Left=�6   $��641,296,0,0q�6:   $	��Top=�6O   $��71��6g   $��20(�6r   �� 5   
   $��Movies��6   $
��Left=�6!   $��
188,12,0,0q�6<   $	��Top=�6P   $��20(�6h   5      5      