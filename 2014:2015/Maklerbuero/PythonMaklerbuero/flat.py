__author__ = 'mko'

from objekt import Objekt

class Flat(Objekt):
    def __init__(self, objnr, agent, typus_buyus_rentus, price, area_size, count_rooms, bathtub_showerc):
        Objekt.__init__(self, objnr, agent, typus_buyus_rentus, price, area_size)
        self.count_rooms = count_rooms
        self.bathtub_showerc = bathtub_showerc
