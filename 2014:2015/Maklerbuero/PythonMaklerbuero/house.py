__author__ = 'mko'

from objekt import Objekt

class House(Objekt):
    def __init__(self, objnr, agent, typus_buyus_rentus, price, area_size, multifamily, count_floors, cellar):
        Objekt.__init__(self, objnr, agent, typus_buyus_rentus, price, area_size)
        self.multifamily = multifamily
        self.count_floors = count_floors
        self.cellar = cellar