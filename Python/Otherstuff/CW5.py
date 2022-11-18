# Input will consist of a list of pairs. Each pair contains information for a single potential member. 
# Information consists of an integer for the person's age and an integer for the person's handicap.

# To be a senior, a member must be at least 55 years old and have a handicap greater than 7. 
# In this croquet club, handicaps range from -2 to +26; the better the player the lower the handicap.

# Output will consist of a list of string values 
# (in Haskell: Open or Senior) stating whether the respective member is to be placed in the senior or open category.
from array import *

def openOrSenior(data):
      return ["Senior" if age >= 55 and handicap >= 8 else "Open" for (age, handicap) in data]
  
  # BOOOOO!!! :(())
    