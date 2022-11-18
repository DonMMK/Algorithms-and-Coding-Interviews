# Given a string of words, you need to find the highest scoring word.
# Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.
# You need to return the highest scoring word as a string.
# If two words score the same, return the word that appears earliest in the original string.
# All letters will be lowercase and all inputs will be valid

def high(x):
    y = x.split()
    z = []
    for i in y:
        z.append(score(i))
    return y[z.index(max(z))]

def score(x):
    s = 0
    for i in range(len(x)):
        s += ord(x[i]) - 96
    return s