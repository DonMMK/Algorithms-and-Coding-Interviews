# Take 2 strings s1 and s2 including only letters from ato z. 
# Return a new sorted string, the longest possible, containing distinct letters - 
# each taken only once - coming from s1 or s2.

def longest(a1, a2):
    # your code
    DistinctString = set(a1).union((a2))
    return ''.join(sorted(DistinctString))