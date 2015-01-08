__author__ = 'mko'

from objekt import Objekt
from house import House
from flat import Flat
from estate import Estate

class Management(object):
    def __init__(self, obj_list, objnr = 0, agent_name = "", tbr = False, price = 0, area_size = 0, count_rooms = 0, bathtub_showerc = False, multifam = False):
        self.obj_list = obj_list

    def new_objekt(self):
        try:
            if not self.obj_list:
                self.objnr = 1
            else:
                #get the last element with -1 and add +1 to its objnr to always increase the number
                self.objnr = self.obj_list[-1].objnr + 1 

            vname = input("What's the responsible agent's name? ")
            nname = input("And what's his surname?")

            self.agent_name = vname + nname


            temp = input("Is the property to sell (1) or rent (2)?")

            if temp == 1:
                self.tbr = True
            elif temp == 2:
                self.tbr = False
            else:
                self.tbr = False #for now

            #get the property's price
            self.price = input("What's the property's price?")

            #get the property's area size
            self.area_size = input("What's the property's size in m^2?")

            temp = input("Is your property a house (1), a flat (2), or an estate (3)?")

            if temp == 1: #property is a house
                temp = input("Is your property a multi family house? (y/n)").lower()
                if temp == "y":
                    self.multifam = True
                elif temp == "n":
                    self.multifam = False
            elif temp == 2: #property is a flat
                self.count_rooms = input("How many rooms does your house have?")
                temp = input("Does your house have a bathtub (1) or a shower cabin? (2)")
                if temp == 1:
                    self.bathtub_showerc = True
                elif temp == 2:
                    self.bathtub_showerc = False

                self.obj_list.app(Flat(self.objnr, self.agent_name, self.tbr, self.price, self.area_size, self.count_rooms, self.bathtub_showerc))
            elif temp == 3: #property is an estate
                #to do

        except Exception:
            print "Error!"