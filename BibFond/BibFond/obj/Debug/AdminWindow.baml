   M S B A M L   `   `   `  ����B  >BibFond, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BibFondBibFond  5   	       BibFond.AdminWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:BibFond     5   	     � Title$  AdminWindow��5   	   $	��720��6   $
��1280��6*   
������  � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � ��5   
   �� 5   
    �� ImageSource$ /images/auregfon.jpg��6   .+�5   
   � $
��1280��6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   $	��160��6+   $	��250��6:   �� 5      $
��Auto �6   �� 5      $��* �6   $	��300��6)   .+�5   
   �� $��0��6   $��2��6%   .+�5      �� $��0��6   $��BibiFond��6(      	SmallLogo#��[  68   $��Center=�6[   $��0, 20, 0, 20q�5      60   �� 5      $ ��Администратор��6   ���#fafafa$��Medium"�5      $��16(�6   $��Center=�6-   $��0, 0, 0, 10q�6Q   �� 5      -   5         ��Name$ 
BookButton��5      $��
Книги��6)     AdminButton#��[ 69   $��10, 5, 10, 5q�5      6+   �� 5      -   5        $ 	PubButton��5      $��Издательства��6,   #��[ 6C   $��10, 5, 10, 5q�6i   5      �� 5!      -   5        $ AuthorsButton��5!      $��Авторы��60   #��[ 6A   $��10, 5, 10, 5q�6g   5"      �� 5$      -   5        $ ClientButton��5$      $��Пользователи��6/   #��[ 6F   $��
10,5,10,20q�6k   5%      �� 5'      -   5        $ BackHomeButton��5'      $��Главное меню��6-     AdminButtonDark#��[ 6D   $��10, 5, 10, 5q�6m   5(      5)       � 5,   
   -   5          �Name$ Frame��5,      $��2��6   $��0��6/     � NavigationUIVisibility$ Hidden=�6<   5-      5.      5/      