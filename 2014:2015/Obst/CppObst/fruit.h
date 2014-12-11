#ifndef FRUIT_H
#define FRUIT_H

#include "product.h"
#include "string"

class Fruit:Product
{
public:
    Fruit();
private:
    // type of fruit (pome fruit)
    const std::string type;

    // most common unit types like kg, pcs, etc.
    enum unit_type{
        kg,
        pcs
    };

    unit_type ut;

    // can, bottle, etc.
    int packaging_type;

};

#endif // FRUIT_H
