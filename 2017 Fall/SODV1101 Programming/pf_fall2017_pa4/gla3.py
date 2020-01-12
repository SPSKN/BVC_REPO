
value=input("Enter a 'Yes' or 'No'")
while True:
    if value == "Yes" or value == "No" or value == "yes" or Value == "no":
        print("Thanks for your input")
        break
    elif value != "Yes" or value != "No":
        value=input("Please enter somthing valid")  