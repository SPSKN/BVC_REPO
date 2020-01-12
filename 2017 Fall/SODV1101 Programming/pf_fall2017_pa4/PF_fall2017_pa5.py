#main function to call all other functions
def main():
    student_name = str
    get_student_name()
    get_random_number()
    #get_equation()
    #get_answer()
    #get_results()
    #get_average()
    

    
#User enters a name, checks if name is more than 2 letters
def get_student_name():
    student_name = str(input(" Enter Student Name: "))
    if len(student_name) <= 2:
        print(" Please enter a valid name of more than 2 letters", end="")
        get_student_name()
        
#Generates two random numbers from 1 to 500
def get_random_number():
    import random
    number1 = random.radiant[1,500]
    number2 = random.radiant[1,500]
    answer = number1 + number2
    


        
main()