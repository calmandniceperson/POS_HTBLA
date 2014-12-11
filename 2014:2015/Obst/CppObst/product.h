#ifndef PRODUCT_H
#define PRODUCT_H

#include <string>

class Product
{
public:
    Product();

private:
    // country code of product's origin
    std::string country_code;

    // products description --> 'Apple', 'Pear'
    std::string description;

    // s.e.
    double price_per_unit;
};

#endif // PRODUCT_H
