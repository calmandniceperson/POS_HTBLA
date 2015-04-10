# "In this game a group of children sit around in a group and say each number in sequence, 
# except if the number is a multiple of three (in which case they say “Fizz”) or five (when they say “Buzz”).
# If a number is a multiple of both three and five they have to say “Fizz-Buzz”.

# An example of a Fizz-Buzz question is the following:
# Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. 
#For numbers which are multiples of both three and five print “FizzBuzz”.
# Most good programmers should be able to write out on paper a program which does this in a under a couple of minutes."
for i in range(1,100):
	if i%3 == 0:
		print("Fizz")
	elif i%5 == 0:
		print("Fuzz")
	else:
		print(i)