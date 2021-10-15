# CMPS378 Assignment #4: Birthday Date Meaning Generator
### Submitted By: J-Zach Loke

# Description
Mimicks a POS system for the Rigby Restaurant by gathering orders and calculating the bill's total on a per-party basis.

# Features
Stores orders in an array and then uses an algorithm to print the order back to the customer and calculate the total. Also randomly generates a fortune cookie quote.

# How to Run
Compile `main.cs` using a C# compiler (preferrably Visual Studio's compiler). I specificually used `Microsoft (R) Visual C# Compiler version 2.6.0.62329`.

# Test Inputs & Outputs

### Basic Order
```
Welcome to Rigby Restaurant
----------------------Food----------------------
Pizza   Chicken Spaghetti
$20     $15     $25

----------------------Drinks----------------------
Sprite  Coke    Mountain Dew
$5      $4      $3

----------------------Desserts----------------------
Ice Cream       Pie     Cinnamon Roll
$10             $12     $8

Choose your Food P
Choose your Drink S
Do you want Desserts? N
Another Order? N


Your order was:
Pizza for $20
Sprite for $5
Your total is $25

Now, your fortune cookie quote is "The early bird gets the worm, but the second mouse gets the cheese."

Thanks for dining with us.
```

### Complex Order
```
Welcome to Rigby Restaurant
----------------------Food----------------------
Pizza   Chicken Spaghetti
$20     $15     $25

----------------------Drinks----------------------
Sprite  Coke    Mountain Dew
$5      $4      $3

----------------------Desserts----------------------
Ice Cream       Pie     Cinnamon Roll
$10             $12     $8

Choose your Food P
Choose your Drink S
Do you want Desserts? Y
Choose your Dessert I
Another Order? Y


Choose your Food S
Choose your Drink M
Do you want Desserts? N
Another Order? Y


Choose your Food C
Choose your Drink C
Do you want Desserts? Y
Choose your Dessert C
Another Order? N


Your order was:
Pizza for $20
Sprite for $5
Ice Cream for $10
Spaghetti for $25
Mountain Dew for $3
Chicken for $15
Coke for $4
Cinnamon Roll for $8
Your total is $90

Now, your fortune cookie quote is "Courage is not the absence of fear; it is the conquest of it."

Thanks for dining with us.
```