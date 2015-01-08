__author__ = 'mko'

class Objekt(object):
    def __init__(self, objnr, agent, typus_buyus_rentus, price, area_size):
        self.objnr = objnr
        self.agent = agent
        self.typus_buyus_rentus = typus_buyus_rentus
        self.price = price
        self.area_size = area_size

    def get_provision(self):
        return self.price
