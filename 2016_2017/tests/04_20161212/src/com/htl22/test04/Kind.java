package com.htl22.test04;

import java.util.concurrent.ThreadLocalRandom;

/**
 * Author(s): Michael Koeppl
 */
public class Kind {

    private int durchlaufInSekunden;

    Kind() {}

    int getDurchlaufInSekunden() {
        return this.durchlaufInSekunden;
    }

    void setTimeFrame(TimeFrame timeFrame) {
        this.durchlaufInSekunden = ThreadLocalRandom.current().nextInt(timeFrame.getMin(), timeFrame.getMax() + 1);
    }
}
