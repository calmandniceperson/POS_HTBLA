#ifndef VEGETABLE_H
#define VEGETABLE_H

#include <stdio.h>
#include <time.h>

class Vegetable
{
public:
    Vegetable();
private:
    enum trade_type{
        fresh,
        frozen,
        vacuum_packaged
    };

    const trade_type tt;

    time_t expiration_date;
};

#endif // VEGETABLE_H
