# You will be given a number and you will need to return it as a string in Expanded Form. For example:
def expanded_form(num):
	n =1
	stringAnswer = [line[i:i+n] for i in range(0, len(line), n)]    
	return stringAnswer
