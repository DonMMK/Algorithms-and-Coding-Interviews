# You will be given a number and you will need to return it as a string in Expanded Form. For example:
def expanded_form(num):
	n =1
	stringAnswer = [num[i:i+n] for i in range(0, len(num), n)]    
	return stringAnswer
