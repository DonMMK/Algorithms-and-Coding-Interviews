# Implement a function that adds two numbers together and returns their sum in binary. The conversion can be done before, or after the addition.

# The binary number returned should be a string.



def add_binary(a = 10,b = 10):
    #your code here
    sum_numbers = a + b
    convertToBinary = bin(sum_numbers)
    print(convertToBinary[2:])


