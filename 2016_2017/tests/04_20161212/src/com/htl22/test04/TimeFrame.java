package com.htl22.test04;

/**
 * Author(s): Michael Koeppl
 */
public class TimeFrame {
    private int min;
    private int max;

    public TimeFrame(int min, int max) {
        this.min = min;
        this.max = max;
    }

    int getMin() {
        return this.min;
    }

    int getMax() {
        return this.max;
    }
}
