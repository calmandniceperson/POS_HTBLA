/*
 * Copyright (C) 2015 mko
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
 */
package pkg4gewinnt;

import javafx.scene.control.Alert;
import javafx.stage.StageStyle;

/**
 *
 * @author mko
 */
public class TokenChecker {

    public static boolean checkCombinations(int rowCoord, int columnCoord, int currentPlayer) {
        if(checkHorizontal(rowCoord, currentPlayer)) {
            return true;
        } else if (checkVertical(columnCoord, currentPlayer)) {
            return true;
        } else if (checkDiagonals(currentPlayer)) {
            return true;
        }
        return false;
    }

    private static boolean checkHorizontal(int rowCoord, int currentPlayer) {
        int horizontalCount = 0;
        for (int i = 0; i < Field.COLUMNNUM; i++) {
            Token currentField = Field.getFieldArray()[rowCoord][i];
            if (currentField != null) {
                if (currentField.getTokenCode() == currentPlayer) {
                    horizontalCount++;
                } else {
                    horizontalCount = 0;
                }
            } else {
                horizontalCount = 0;
            }
            if (horizontalCount >= 4) {
                Alert alert = new Alert(Alert.AlertType.INFORMATION);
                alert.initStyle(StageStyle.UTILITY);
                alert.setTitle("SIEG!");
                alert.setHeaderText("4 HORIZONTALE VON " + currentPlayer);
                alert.setContentText("Spieler " + currentPlayer + " hat gewonnen.");
                alert.showAndWait();
                return true;
            }
        }
        return false;
    }

    private static boolean checkVertical(int columnCoord, int currentPlayer) {
        int verticalCount = 0;
        for (int i = 0; i < Field.ROWNUM; i++) {
            Token currentField = Field.getFieldArray()[i][columnCoord];
            if (currentField != null) {
                if (currentField.getTokenCode() == currentPlayer) {
                    verticalCount++;
                } else {
                    verticalCount = 0;
                }
            } else {
                verticalCount = 0;
            }
            if (verticalCount >= 4) {
                Alert alert = new Alert(Alert.AlertType.INFORMATION);
                alert.initStyle(StageStyle.UTILITY);
                alert.setTitle("SIEG!");
                alert.setHeaderText("4 VERTIKALE VON " + (currentPlayer + 1));
                alert.setContentText("Spieler " + currentPlayer + " hat gewonnen.");
                alert.showAndWait();
                return true;
            }
        }
        return false;
    }

    private static boolean checkDiagonals(int currentPlayer) {
        int diagCount;
        for (int x = 0; x < Field.ROWNUM; x++) {
            for (int y = 0; y < Field.COLUMNNUM; y++) {
                diagCount = 0;
                for (int k = 0; k <= 3; k++) {
                    if (((x + k) < Field.ROWNUM) && ((y + k) < Field.COLUMNNUM) && Field.getFieldArray()[x + k][y + k] != null) {
                        if (Field.getFieldArray()[x + k][y + k].getTokenCode() == currentPlayer) {
                            diagCount++;
                        } else {
                            k = 4;
                        }
                    } else if (((x + k) < Field.ROWNUM) && ((y + k * (-1)) >= 0) && Field.getFieldArray()[x + k][y + k * (-1)] != null) {
                        if (Field.getFieldArray()[x + k][y + k * (-1)].getTokenCode() == currentPlayer) {
                            diagCount++;
                        } else {
                            k = 4;
                        }
                    }
                }
                if(diagCount >= 4) {
                    Alert alert = new Alert(Alert.AlertType.INFORMATION);
                    alert.initStyle(StageStyle.UTILITY);
                    alert.setTitle("SIEG!");
                    alert.setHeaderText("4 DIAGONALE VON " + currentPlayer);
                    alert.setContentText("Spieler " + currentPlayer + " hat gewonnen.");
                    alert.showAndWait();
                    return true;
                }
            }
        }
        return false;
    }
}
