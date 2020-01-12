#Main Method
#
#How many assignments
def main():
    assignments_total = int(input("How many assigments the student handed in:  "))
    if assignments_total <= 5:
        lessThan(assignments_total)
    if assignments_total > 5:
        moreThan(assignments_total)
    getScore()

#method for 5 or less
def lessThan(assignments_total):
    counter = 1
    while counter <= assignments_total:
        print("Enter assignment", counter, "Score: ", end="")
        getGrade()
        counter = counter +1
        
#method for more than 5        
def moreThan(assignments_total):
    counter = 1
    while counter <= assignments_total:
        print("Enter assignment", counter, "Score: ", end="")
#Add the scores together
        getGrade()
        counter = counter +1
        
#adding the marks here        
def getGrade():
    user_input=int(input())
    total_grade=0
    total_grade=user_input + total_grade
    print(total_grade)
    
#get the average  
  
  #main method
main()