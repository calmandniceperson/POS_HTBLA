#ifndef FRUIT_PRODUCT_H
#define FRUIT_PRODUCT_H

class Fruit_Product
{
public:
    Fruit_Product();
private:
    enum type{
        concentrate,
        juice,
        jelly
    };

    const type t;

    enum unit_type{
        bottle,
        package
    };

    unit_type ut;

    bool own_testimony;
};

#endif // FRUIT_PRODUCT_H
