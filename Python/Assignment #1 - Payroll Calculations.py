# Payroll assignment
# Author: Yasin Habib
#       29-Jan-2020

# This program is desgined to help with payroll applications.
# This program uses given datas, such as hours worked, hourly wage and any deductables to evaluate the gross pay, deductables, and net pay.



# INPUT: Enter the employee name (name that appears on the slip)


employee_name = input("Please enter the employee's name that is on the slip: ")

        

# INPUT: Enter the total hours worked in that particular week

total_weekly_hours_worked = float(input("Please enter the total amount of hours worked by the employee over the week: "))
while (total_weekly_hours_worked < 0) or (total_weekly_hours_worked > 238): # 7 days a week * 24 hours a day = 238 hours.
        print("Please re-enter a positive value")
        total_weekly_hours_worked = float(input("Please enter the total amount of hours worked by the employee over the week: "))
        

# INPUT: Enter their hourly wage ($15+)

hourly_rate = float(input("Please enter the employee's hourly rate:$ "))
while (hourly_rate < 15):
    print("Please re-enter a value more than 15")
    hourly_rate = float(input("Please enter the employee's hourly rate:$ "))
          

# INPUT: Deduction

deduction = input("Please state whether the employee should have deduction removed or not from their gross pay (yes or no): ")
            

if (deduction == "yes"):
    deduction_rate = int(input("Enter the deduction %: ")) # Deduction is needed to calculate the deduction cut from gross pay
    while (deduction_rate < 0) or (deduction_rate > 100):
        print("Please re-enter the deduction rate from 1% - 100%")
        deduction_rate = int(input("Enter the deduction %: "))
        
else:
    deduction_rate = 0

    
# CALCULATION: Regular pay and Overtime pay
    
if (total_weekly_hours_worked > 40):
    overtime_worked = total_weekly_hours_worked - 40 # Total overtime hours worked
    overtime_pay = overtime_worked * (hourly_rate * 1.5)
    regular_pay = 40 * hourly_rate  # Regular hour is 40 because there are overtime.
else:
    regular_pay = total_weekly_hours_worked * hourly_rate
    overtime_worked = 0 
    overtime_pay = 0


# CALCULATION: Gross pay

gross_pay = regular_pay + overtime_pay

# CALCULATION: Deduction cut

deduction_cut = gross_pay * (deduction_rate/100)

# CALCULATION: Net pay

net_pay = gross_pay - deduction_cut

# Pay slip

print(  "Pay slip")
print(  "Employee's name: {:s}".format(employee_name))
print(  "total hours worked: {:.1f}".format(total_weekly_hours_worked))
print(  "Overtime worked: {:.1f}".format (overtime_worked))
print(  "Hourly rate: ${:,.2f}".format (hourly_rate))
print(  "Gross pay: ${:,.2f}".format(gross_pay))
print(  "Deduction: ${:,.2f}".format(deduction_cut))
print(  "Net pay: ${:,.2f}".format (net_pay))
