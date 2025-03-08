'''
Tire Volume Calculator                                                    

by Tomás Venegas Osses
'''


'''
The size of a car tire in the United States is represented with three numbers like this: 205/60R15. 
The first number is the width of the tire in millimeters. The second number is the aspect ratio. 
The third number is the diameter in inches of the wheel that the tire fits. 
The volume of space inside a tire can be approximated with this formula:



v is the volume in liters,
π is the constant PI, which is the ratio of the circumference of a circle divided by its diameter (use math.pi),
w is the width of the tire in millimeters,
a is the aspect ratio of the tire, and
d is the diameter of the wheel in inches.

> python tire_volume.py
Enter the width of the tire in mm (ex 205): 185
Enter the aspect ratio of the tire (ex 60): 50
Enter the diameter of the wheel in inches (ex 15): 14
The approximate volume is 24.09 liters
> python tire_volume.py
Enter the width of the tire in mm (ex 205): 205
Enter the aspect ratio of the tire (ex 60): 60
Enter the diameter of the wheel in inches (ex 15): 15
The approximate volume is 39.92 liters

'''

import math

width = float(input(f'Enter the width of the tire in mm (ex 205): '))

ratio = float(input(f'Enter the aspect ratio of the tire (ex 60): '))

diameter = float(input(f'Enter the diameter of the wheel in inches (ex 15): '))


# Make the calculations 

volume = math.pi * width**2 * ratio * (width * ratio + 2540 * diameter) /10000000000


# print output

volume_aprox = print(f'The approximate volume is "{volume:.2f}" liters')











































