package com.htl22.test04;

/**
 * Author(s): Michael Koeppl
 */

public class Main {

    private final static int MIN_TIMEFRAME = 10;
    private final static int MAX_TIMEFRAME = 40;

    public static void main(String[] args) {
	    simulateQueue();
    }

    private static void simulateQueue() {

        // Bisher maximale Laenge der Schlange.
        int maxLaenge = 10;
        int zeitPunktMitMaxLaenge = 0;

        // Anfaenglich 10 Kinder in die Warteschlange stellen.
        for (int i = 0; i < 10; i++) {
            Sprungturm.getInstance().fuegeKindHinzu(new Kind());
        }

        // Durchlaufe die Simulationsschritte so lange, bis 10 Minuten um sind.
        int currentChildIndex = 0;
        Kind currentChild = null;
        while ((Sprungturm.getInstance().getZeitInSekunden() / 60) < 20) {
            // Wenn momentan kein Kind unterwegs ist.
            if (!Sprungturm.getInstance().istKindUnterwegs()) {
                // Hol das aktuelle Kind
                currentChild = Sprungturm.getInstance().getKind(currentChildIndex);
                // Gib dem Kind eine zufaellige Dauer zwischen 10 und 40 Sekunden fuer den Durchlauf.
                currentChild.setTimeFrame(new TimeFrame(MIN_TIMEFRAME, MAX_TIMEFRAME));
                // Lass das Kind springen.
                Sprungturm.getInstance().lassKindSpringen();
            } else {
                Sprungturm.getInstance().machSimulationsSchritt();

                // Wenn die Zeit seit dem letzten Absprung der Durchlaufszeit des jeweiligen Kindes erreicht hat, dann
                // ist das Kind wieder am Turm angelangt und muss sich hinten anstellen.
                if (currentChild.getDurchlaufInSekunden() == (Sprungturm.getInstance().getZeitInSekunden() - Sprungturm.getInstance().getLetzterAbsprung())) {
                    Sprungturm.getInstance().hintenAnstellen(currentChild);
                }
            }

            // Nach 5 Minuten kommt 10 Minuten lang ein Kind hinzu.
            if ((Sprungturm.getInstance().getZeitInSekunden() / 60) >= 5 && (Sprungturm.getInstance().getZeitInSekunden() / 60) <= 15 &&
                    Sprungturm.getInstance().getZeitInSekunden() % 60 == 0) { // Wenn es sich um eine runde Minute handelt.
                Sprungturm.getInstance().fuegeKindHinzu(new Kind());
            }

            // Ab der 15. Minute geht jede Minute ein Kind.
            if ((Sprungturm.getInstance().getZeitInSekunden() / 60) >= 15 && (Sprungturm.getInstance().getZeitInSekunden() % 60) == 0) {
                Sprungturm.getInstance().entferneLetztesKind();
            }

            if (Sprungturm.getInstance().getAnzahlDerAnstehenden() > maxLaenge) {
                zeitPunktMitMaxLaenge = Sprungturm.getInstance().getZeitInSekunden();
                maxLaenge = Sprungturm.getInstance().getAnzahlDerAnstehenden();
            }
        }

        System.out.println(String.format("Der Zeitpunkt mit der maximalen Laenger liegt bei %d Minuten. Maximale Laenge: %d", zeitPunktMitMaxLaenge/60, maxLaenge));
    }
}
