# Seven Segment Words
## Questions
1. What is the longest word in the English language? <br>
2. What is the longest word you can write on a seven-segment display? <br>
3. Are there other correct answers to question 2?

### Files
Program.cs contains the code. <br>
words.txt contains all English words. <br>
words_alpha.txt only contains words with alphabetic characters. <br>
*Eg:* 2D and 11-point appear in words.txt but not in words_alpha.txt.

## Answers
G, K, M, Q, V, W, X, and Z are not able to be displayed because of the diagonal lines.
1. pneumonoultramicroscopicsilicovolcanoconiosis
2. dichlorodiphenyltrichloroethane
3. There are no other eligible words of the same length.

I and O can be banned as well because they have the same appearance as 1 and 0 on the display. <br>
After adding *I* and *O* to the banned list of letters, we get different answers. <br>
2. supertranscendentness
3. three-and-a-halfpenny

## Context and Credits
This was a small personal project that took me a day and a half to complete.
During development, I learnt how to read files, catch exceptions, use lists, and write regular expressions to match words in C#. <br>
<br>
words.txt and words_alpha.txt are courtesy of https://github.com/dwyl/english-words. <br>
Project idea is courtesy of Tom Scott's video: [What's the Longest Word You can Write With Seven-Segment Displays?](https://www.youtube.com/watch?v=zp4BMR88260&list=PL96C35uN7xGIJfSACtrXjxKcatdThkuJh)
