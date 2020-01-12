#Course code : SODV1101
#Semester/Year : Fall2017
#Assignment code: GLA2
#Author : Scott Patterson
#BVC username :s.patterson528@mybvc.ca
#Date created : 2017-10-18
#Description : 

def user_input(number_of_rows):
    count = 1
    while count <= number_of_rows:
        print(count)
        count = count +1
    
def user_count(number_of_rows):
    count = 1
    while count <= number_of_rows:
        print(count)
        count = count +1
       
    
#def userRightA(number_of_rows):
    
    
#def userUnD(number_of_rows):
    #print("userUnD")
    
def spacer():
    print("========")#Spacers for loop
    
    

number_of_rows = int(input("Please enter a number"))
while number_of_rows > 0 and number_of_rows <10:
    spacer()
    user_input(number_of_rows)
    spacer()
    user_count(number_of_rows)
    spacer()    
    break

    
    






