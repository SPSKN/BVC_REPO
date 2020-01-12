#Tip is range
#get_tax = 5%
meal_price =(float(input("Meal Price")))
disco_total = meal_price * 0.1



get_coupon = str(input("Does the customer hace a coupon"))
disco = 0.1#10%
if get_coupon == "yes":
    while True:
        if ask_disco =="BVC":
            disco_amount = meal_price + disco_total
            sub_total = meal_price - disco_total
            break
        else:
            print("Wrong code")
else:
    pass        
print(sub_total)
#if elif and tip %
if (meal_price <= 4.99):
    tip = 0.1 #10%
elif (meal_price >=5.00 and meal_price <= 10.00):
    tip =0.12 #12%
elif (meal_price >=10.01 and meal_price <= 15.00):
    tip = 0.15 #15%
elif (meal_price >=15.01 and meal_price <= 25.00):
    tip = 0.18 #18%
elif (meal_price >= 25.01):
    tip = 0.22 #22%





meal_tax = (meal_price * 0.05)
meal_tip = (meal_price * tip)
meal_amount=(meal_tax + meal_price)





print(meal_tax)
print(meal_amount)
print(meal_tip)

#Other Developers that I
#Nick Osing
#Adian Saunders

