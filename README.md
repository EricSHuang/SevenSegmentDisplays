# Seven Segment Words
## Questions
1. What is the longest word in the English language? <br>
2. What is the longest word you can write on a seven-segment display? <br>
3. Are there other correct answers to question 2?

### Files
Program.cs contains the code. <br>
words.txt contains all the English words. <br>
words_alpha.txt only contains words with alphabetic characters. <br>
*Eg:* 2D and 11-point appear in words.txt but not in words_alpha.txt.

## Answers
G, K, M, Q, V, W, X, and Z are not able to be displayed because of the diagonal lines.
1. pneumonoultramicroscopicsilicovolcanoconiosis
2. dichlorodiphenyltrichloroethane
3. There are no other eligible words of the same length.

I and O can be banned as well because they have use the same lights as 1 and 0.
After adding *I* and *O* to the existing not acceptable words.
2. supertranscendentness
3. three-and-a-halfpenny

## Context and Credits
More C# and regex training.
words.txt and words_alpha.txt are courtesy of https://github.com/dwyl/english-words
Project idea and questions courtesy of Tom Scott's video: https://www.youtube.com/watch?v=zp4BMR88260&list=PL96C35uN7xGIJfSACtrXjxKcatdThkuJh
