   M S B A M L   `   `   `  ����H  DDisplayTweets, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DisplayTweetsDisplayTweets  5   	       DisplayTweets.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DisplayTweets     5   	     � Title$  Find Tweets��5   	   $	��714��6   $��961.8��6*   .��5	      � .+�5
   
   �� -   5         ��Name$ inputBox��5
      $
��Left=�6$   $��23��6?   $��	20,41,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��808��6�   �� 5   
   -   5         ��Name$ enterWordsLabel��5      $��Enter Words:��6)   $
��Left=�6@   $��	10,10,0,0q�6[   $	��Top=�6n   $	��235��6�   �� 5   
   -   5         ��Name$ searchButton��5      $��Search��6'   $
��Left=�68   $��
833,41,0,0q�6S   $	��Top=�6g   $��75��6   $��23��6�   6�   �� 5   
   -   5         ��Name$ 
tweetsList��5      $
��Left=�6'   $	��563��6B   $��	20,69,0,0q�6O   $	��Top=�6b   $	��888��6z    �� View 5      �� 5       �� ColumnHeaderContextMenu 5      �� 5      .P�5      �� $��Avatar��6%    �� Width$ 60��65   	 �� CellTemplate	 5      �� 5      .R�5   "   �� 
 �� Orientation$
 
Horizontal=�6-   .+�5   &   �� $��50��6,   $��50��67   ��6C   �� *AvatarSource+5   #   5      5      �� 5      $��Tweet��6%   $	 808��6_    �� DisplayMemberBinding 64   �� *	TweetText+6_   5      5      �� 5    
   -   5        $ 
saveButton��5       $��Save selected tweets��6%   $
��Left=�6D   $��779,637,0,0q�6_   $	��Top=�6t   $	��129��6�   $��23��6�   6�   �� 5!   
   -   5        $ fileNameBox��5!       �� 	MaxLength$ 30��6(   $
��Left=�67   $��23��6R   $��
92,637,0,0q�6^   $
 Wrap=�6r   $	��Top=�6�   $	��682��6�   �� 5"   
   -   5        $ 	nameLabel��5"      $��	Filename:��6#   $
��Left=�67   $��
20,637,0,0q�6R   $	��Top=�6f   $��67��6~   $��23��6�   5$      5%      