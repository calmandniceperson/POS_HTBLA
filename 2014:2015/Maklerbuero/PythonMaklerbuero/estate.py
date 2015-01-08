__author__ = 'mko'

from objekt import Objekt #import Objekt class to inherit from it

class Estate(Objekt):
    def __init__(self, objnr, agent, typus_buyus_rentus, price, area_size, dedication, unit_value):
        Objekt.__init__(self, objnr, agent, typus_buyus_rentus, price, area_size)
        self.dedication = dedication
        self.unit_value = unit_value