#variables
global end_program
end_program = ""
global end_order
end_order = ""
global total_burger
total_burger = 0
global total_fry
total_fry = 0
global total_soda
total_soda = 0
global total
total = 0
global tax
tax = 0
global subtotal
subtotal = 0
global option
option = 0
global burger_count
burger_count = 0
global fry_count
fry_count = 0
global soda_count
soda_count = 0


def reset_variables():
    totalBurger = 0
    totalFry = 0
    totalSoda = 0
    total = 0
    tax = 0
    subtotal = 0
    
reset_variables()



def main():
    counter = 0
    end_program = "no"
    while end_program == "no":
        reset_variables()
       
       while end_order == "no":
            print("Enter 1 for Yum Yum Burger")
            print("Enter 2 for Grease Yum Fries")
            print("Enter 3 for Soda Yum")
            option = int(input())
            
            if (option == 1):
                get_burger()
            elif (option == 2):
                get_fry()
            elif (option == 3):
                get_soda()
        end_order == "yes"
            
            
            
main()