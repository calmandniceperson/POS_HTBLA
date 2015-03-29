# this is my solution for the following problem from /r/beginnerprojects:
# http://www.reddit.com/r/beginnerprojects/comments/29aqox/project_magic_8_ball/
#
# Copyright (c) Michael Koeppl
# 29 March 2015

import time
import random
import sys

def main():
	repeat = True
	arr = ["Yes", "Maybe", "NO!", "Only if you need to.", "I can't decide that.", "Trust your instincts.", "Don't even think about it!", 
	"I don't like this question.", "I didn't have enough time to think about it.", "It depends on the circumstances.", "Oh god, no!", "Absolutely, yes!", 
	"The 8 Ball doesn't know.", "I can't tell if you're being serious or not.", "That's a tough question, but I think yes!", "That's a tough question, but I think no!",
	"Did you really just ask that?", "I think you should get a new 8 Ball because I don't know.", "I honestly don't know.", "I'm the worst 8 Ball ever, I can't answer anything."]

	while True:
		question = input("What's your question?\n")

		print("Let me think...")
		time.sleep(random.randint(1,3))

		print(arr[random.randint(0,len(arr)-1)])

		ans = input("Do you wish to ask another question? (y/n)")

		if ans.lower().startswith("y"):
			repeat = True
		else:
			repeat = False
			sys.exit(0)

main()