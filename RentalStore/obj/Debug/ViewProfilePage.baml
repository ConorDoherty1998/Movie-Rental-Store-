   M S B A M L   `   `   `  ����F  BRentalStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:RentalStoreRentalStore  5      !    RentalStore.ViewProfilePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:RentalStore     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5           MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5       N� 
Background �#5CDB95  MaterialDesignFont N� 
FontFamily# �  5       N� Title$ ViewProfilePage��5       � 	Resources 5        ListboxStyle �� 
TargetType �� 	Resources  Key �� Property	 �� Value
 �� 
TargetType ��Name J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName �Name � RowDefinitions ��Name �� LineUpCommand J� IsMouseOver ]�Name ]� DecreaseRepeatButton �� PageUpCommand ]� IncreaseRepeatButton �� PageDownCommand ]� Thumb  ScrollBarThumbVertical �� LineDownCommand ��Name �� CanContentScroll �� CanHorizontallyScroll  �� CanVerticallyScroll! ��Name4  .System.Windows.Automation.AutomationProperties"   AutomationId# � Cursor$ �� ScrollableHeight% � Maximum& � Minimum*' �� #ComputedVerticalScrollBarVisibility( �� ViewportHeight) �� ViewportSize* � Value+ �� Mode, �� RelativeSource  receiptsTemplate- �� DataType   RentalStore.Receipt. � ColumnDefinitions/ �� Orientation # MaterialDesignHeadlineTextBlock0 �� Path % !MaterialDesignSubheadingTextBlock  LoansTemplate   RentalStore.Loan��%  &	       7  &	 	    7  7  7  7  7  7  7  7  7  &	     7  7  7  7  7  7  7  �� 5   
   " ��6%    5      ���� 5      ScrollBarThumbVertical " n�67   .�5      ��  �@�OverridesDefaultStyle	 . 6>   �� 5       � ��	 .  62   �� 5       � ��	 5      �� 5      "
 n�6.   .R�5   "   �� $ 	rectangle��6,   ���#CDCDCD#��z��6N    . #��z��6�    5   "   P� 5   &    �@J�IsMouseOver . . �5   *   �� $ 	rectangle��6A    � ��	 �#A6A6A66X   5   '   P� 5    &    �@n�
IsDragging . . �5!   *   �� $ 	rectangle��6A    � ��	 �#6060606X   5"   '   5$      5&      5'      �� 5(      '��       " ��6   .�5)      ��  � ��	 5*      �� 5+      "
 ��6.   .R�5,   "   � .+�5-   &   �� 69   5.   #   5/      51      52      �� 53      '��       " ��6   .�54      ��  �@��IsPressAndHoldEnabled	 .  6E   �� 55       �@��IsFlicksEnabled	 .  6?   �� 56       � ��$		 1,0q�68   �� 57       � ��	 58      �� 59      "
 ��6.   .R�5:   "   � $ Bg��6'   $��8��63   $��	0,15,0,15q�6=   
������  .  5;   &   �� 5<   *   $��0��69   �� 5=   *   $��0.00001* �68   �� 5>   *   $��0 �68   .+�5@   &   �� #��z��6-   $��0q�6Y   
������ $��1��6�   �� 5A   &   $ PART_LineUpButton��6H   $��0��63   $��0��6>   #��Z 6c   #{�z 6�   ]� 5B   &   $ 
PART_Track��6,   ��. #{�z 6[   $��1��6�    5C   *   �� 5D   .   #��Z 6;   
������ 
������ $��0q�6�    5F   *   �� 5G   .   #��Z 6;   
������ 
������ $��0q�6�    5I   *   n� 5J   .   8��  64   5L   '   �� 5M   &   $ PART_LineDownButton��63   $��0��6P   $��0��6[   #��Z 6e   #{�z 6�   $��2��6�   5N   #   5O      5Q      5R      �� 5S      '��       " ��6   .�5T      ��  � ��	 5U      �� 5V      "
 ��6/   .R�5W   "   � $
 Grid��6'   $��Right=�66   .+�5X   &   �� $! PART_ScrollContentPresenter��6?   # z��6d    .    .  #��z��6�   #��z��6  #��z��6,  �� 5Y   &   $! PART_VerticalScrollBar��60   $��Right=�6P   $" VerticalScrollBar��6l   $# Arrow��6�   #% z$ 6�   $& 0Q�6�   #y�z' 6�   #) z( 6�  * 6.  �� *VerticalOffset+$+ OneWay=�, �� *TemplatedParent+6�  5Z   #   5[      5]      5^      5_      5`      �� 5a   
   "-  60   .R�5b      � . 5c      �� 5d      $	��200 �6'   �� 5e      $	��200 �6'    5g      �� 5h      $��30 �6$   �� 5i      $��20 �6$   .+�5k      �� $/ 
Horizontal=�6   $��2��66   .+�5l      �� ���#05386B8��  $��Purchased On ��6n   �� 5m      ���#05386B8�� ��6n   �� $0 DateIssued.Day�/6�   �� 5n      ���#05386B8�� ��6n   �� $0 DateIssued.Month�/6�   �� 5o      ���#05386B8�� ��6n   �� $0 DateIssued.Year�5p      �� 5q      $��1��6   $/ 
Horizontal=�6*   .+�5r      �� $��Total Cost: €��6    8�� 65   �� 5s      8�� ��6    �� $0 	TotalCost�6@   5t      �� 5u      $��1��6   $��1��6*   $/ 
Horizontal=�6:   $��Right=�6S   .+�5v      �� $��Loaned ��6    8�� 6/   �� 5w      8�� ��6    �� $0 MyLoans.Count�6�   �� 5x      $�� Movies��6    8�� 6/   5y      �� 5z      $��1��6   ���#05386B$��3��69   $��2��6F   $��Bottom=�6Z   5{      5|      �� 5}   
   "-  6-   .R�5~      � . 5      �� 5�      $	��200 �6'   �� 5�      $	��200 �6'    5�      �� 5�      $��30 �6$   �� 5�      $��20 �6$   .+�5�      �� 8��  ��6   �� $0 MyMovie.Title�6@   �� 5�      $��1��6   $��1��6*   $��Right=�6:   $/ 
Horizontal=�6V   .+�5�      �� $��Due: ��6    8�� ���#05386B6h   �� 5�      8�� ���#05386B$��5,0,0,0q�6�   ��6    �� $0 ReturnDate.Day�/6�   �� 5�      8�� ���#05386B��6    �� $0 ReturnDate.Month�/6�   �� 5�      8�� ���#05386B��6    �� $0 ReturnDate.Year�6�   5�      �� 5�      $��1��6   $/ 
Horizontal=�6*   .+�5�      �� $��	Cost: €��6    8�� ���#05386B6j   �� 5�      8�� ���#05386B��6    �� $0 Price�6w   5�      �� 5�      $��1��6   ���#05386B$��3��69   $��2��6F   $��Bottom=�6Z   5�      5�      5�      .��5�      � . 5�   
   �� 5�      �� 5�       5�   
   �� 5�      $��50 �6   �� 5�      $
��132* �6   �� 5�      $
��269* �6   .+�5�   
   �� $/ 
Horizontal=�6   $��10q�6.   .+�5�      �� -   5        1 ��Name$1 txtbxCustomer��5�      ���#05386B#��[ 6D   $��35,0,0,0q�6}   �� 5�      $��'s Receipts��6   ���#05386B#��[ 6@   5�      �� 5�   
   ���#05386B$��1��6&   $��Bottom=�61   $	��5,0q�6L   �� 5�   
   -   5        2 ��Name$2 lbxReceipts��5�      $��0q�6'   #��[ 6;   
������ #��[ 6z   $��1��6�   $��2��6�   �� 5�   
   $��1��6   $��3��6$   ���#8EE4AF65   �� 5�   
   $��Loans��6   $��1��6!   ���#05386B#��[ 6F   $��10q�6   �� 5�   
   ���#05386B$��1��6&   $��1��66   $��Bottom=�6A   $	��5,0q�6\   �� 5�   
   -   5        $2 lbxLoans��5�      $��0q�6$   #��[ 68   
������ #��[ 6w   $��1��6�   $��1��6�   $��2��6�   �� 5�   
   -   5        3 ��Name$3 btnBack��5�      $
��Left=�6"   $��
10,12,0,12q�6=    /	 +MaterialDesignFloatingActionMiniLightButton#��[	 6g   ���#379683���#379683���#EDF5E14 � ToolTip$
4 Back��6�   $��25��6�   $��25��6  +  %MaterialDesignThemes.Wpf.RippleAssist5   
IsDisabled5 .  .��5�      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]6   Kind$6 KeyboardBackspace=�6&   $��20��6?   $��20��6K   5�      5�      5�      