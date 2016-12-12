package com.htl22.test04;

import java.util.ArrayList;
import java.util.List;

/**
 * Author(s): Michael Koeppl
 */
public class Sprungturm {
    private static Sprungturm ourInstance = new Sprungturm();

    public static Sprungturm getInstance() {
        return ourInstance;
    }

    private Sprungturm() {
    }

    // Die bisher vergangene Zeit in Sekunden.
    private int zeitInSekunden = 0;

    // Dauer eines Simulationsschritts in Sekunden.
    private int deltaT = 10;

    // Zeitpunkt des letzten Absprungs in Sekunden seit dem Start.
    private int letzterAbsprung = 0;

    // Beschreibt, ob momentan ein Kind nach dem Sprung unterwegs zurueck zum Turm ist.
    private boolean kindIstUnterwegs = false;

    // Warteschlange am Turm.
    private List<Kind> warteSchlange = new ArrayList<>();

    public int getAnzahlDerAnstehenden() {
        return this.warteSchlange.size();
    }

    // Add child to queue.
    void fuegeKindHinzu(Kind k) {
        this.warteSchlange.add(k);
    }

    // Remove child from queue.
    void entferneKind(Kind k) {
        this.warteSchlange.remove(k);
    }

    void entferneLetztesKind() {
        this.warteSchlange.remove(this.warteSchlange.size() - 1);
    }

    void hintenAnstellen(Kind k) {
        entferneKind(k);
        fuegeKindHinzu(k);
    }

    // Laesst das naechste Kind in der Warteschlange springen / naechster Simulationsschritt.
    void lassKindSpringen() {
        letzterAbsprung = zeitInSekunden;
        zeitInSekunden += deltaT;
    }

    boolean istKindUnterwegs() {
        return this.kindIstUnterwegs;
    }

    void machSimulationsSchritt() {
        zeitInSekunden += deltaT;
    }

    Kind getKind(int index) {
        return this.warteSchlange.get(index);
    }

    int getZeitInSekunden() {
        return this.zeitInSekunden;
    }

    int getLetzterAbsprung() {
        return this.letzterAbsprung;
    }
}
