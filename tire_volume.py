'''
Tire Volume Calculator                                                    

by Tomás Venegas Osses
'''

from datetime import datetime
import math

def calculate_volume(width, aspect_ratio, diameter):
    diameter_mm = diameter * 25.4
    volume = (math.pi * width * ((aspect_ratio / 100) * width) * (diameter_mm)) / 1000000
    return volume

width = float(input("Enter the width of the tire in mm (ex 205): "))
aspect_ratio = float(input("Enter the aspect ratio of the tire (ex 60): "))
diameter = float(input("Enter the diameter of the wheel in inches (ex 15): "))

volume = calculate_volume(width, aspect_ratio, diameter)

current_date = datetime.now().strftime("%Y-%m-%d")

print(f"The approximate volume is {volume:.2f} liters")

with open("volumes.txt", "at") as file:
    file.write(f"{current_date}, {width}, {aspect_ratio}, {diameter}, {volume:.2f}\n")











































