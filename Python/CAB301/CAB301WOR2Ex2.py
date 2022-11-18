# Sequential Search

# Search for a value in a guiven array by sequentially checking each element

def SequentialSearch(ArrayA , K):
    i = 0
    while i < len(ArrayA) and ArrayA[i] != K:
        i = i + 1
    if i < len(ArrayA):
        print("Found at position " , i)
        return i
    else :
        print("Not found")
        return -1


SequentialSearch([10 , 9 , 15 , -10 , 1 , 5, 7], 15)    
    