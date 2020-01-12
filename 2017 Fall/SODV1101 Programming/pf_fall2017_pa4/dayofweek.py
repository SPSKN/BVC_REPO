#Week 5 Ch 6 Ex 7:
#This program gets input for 5 tests scores, assigns grades, then uses functions to calculate the average and assign an overall grade.
#Written by Greg Lamb
#Last Modified on 04/27/2015

#Perform Function to assign letter grade
def letterGrade(testScore):
    if (testScore>=90):
        return "A"
    elif (testScore >=80 and testScore <90):
        return "B"
    elif (testScore >=70 and testScore <80):
    	return "C"
    elif (testScore >=60 and testScore <70):
        return "D"
    else: 
        return "F"
    
#Declare loop variables
testScoreTotal = 0 
numTests = 5 
    
#The loop iterates 5 times and stores the accumulated test scores for the 5 tests which are passed into the calcAverage function
for test in range(1,numTests+1):  
    testScore = float(input("Enter the numerical test score for test#{} ".format(test)))
    testScoreTotal = testScoreTotal + testScore
    print("is: {}. The letter grade is {} ".format(testScore,letterGrade(testScore)))
    
#Get Average test score and grade
def calcAverage(testScoreTotal):
    return testScoreTotal/5; 

#Result
print("The overall average is: {}".format(calcAverage(testScoreTotal)))
print("The overall average letter grade is: {} ".format(letterGrade(calcAverage(testScoreTotal)))) 