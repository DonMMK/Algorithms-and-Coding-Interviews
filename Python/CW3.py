# You are going to be given a word. Your job is to return the middle character of the word. 
# If the word's length is odd, return the middle character. 
# If the word's length is even, return the middle 2 characters.

def get_middle(s):
    #your code here
    return s[(len(s)-1)//2:(len(s)+2)//2]