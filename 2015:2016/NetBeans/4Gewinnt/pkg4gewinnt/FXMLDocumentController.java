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

import javafx.animation.TranslateTransition;
import javafx.fxml.FXML;
import javafx.scene.control.Alert;
import javafx.scene.control.Label;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.AnchorPane;
import javafx.stage.StageStyle;
import javafx.util.Duration;

public class FXMLDocumentController {

    @FXML
    private Label aboutlabel;

    @FXML
    private Label playerlabel;

    @FXML
    private AnchorPane mainanchorpane;
    public static final int STARTX = 110, STARTY = 360, TOPBUTTONLINEX = 50;
    public static int currentPlayer = 0;

    public void initialize() {
        playerlabel.setText("Spieler " + currentPlayer + " ist am Zug.");
        TokenButton newBtn;
        int xcoord;
        for (int i = 0; i < 7; i++) {
            xcoord = STARTX + (i * 70);
            newBtn = new TokenButton(i, xcoord);
            newBtn.setLayoutX(xcoord);
            newBtn.setLayoutY(TOPBUTTONLINEX);
            newBtn.addEventHandler(MouseEvent.MOUSE_CLICKED, (MouseEvent e) -> {
                TokenButton pressedButton = (TokenButton) e.getSource();
                insertToken(pressedButton);
            });
            mainanchorpane.getChildren().add(newBtn);
        }
    }

    private void insertToken(TokenButton pressedButton) {
        Token newToken = new Token(currentPlayer);
        newToken.setLayoutX(pressedButton.getLayoutX());

        int columnCoord = pressedButton.getTButtonId();
        int usedFields = Field.countUsedFields(columnCoord);
        int rowCoord = (Field.ROWNUM - 1) - usedFields;
        Field.add(rowCoord, columnCoord, newToken);
        if (rowCoord == 0) {
            pressedButton.setDisable(true);
        }
        int ycoord = STARTY - 45 * (usedFields);
        newToken.setLayoutY(TOPBUTTONLINEX);
        newToken.setText(Integer.toString(Field.getFieldArray()[rowCoord][columnCoord].getTokenCode()));
        mainanchorpane.getChildren().add(newToken);

        TranslateTransition tt = new TranslateTransition(Duration.millis(1000), newToken);
        tt.setToY(ycoord - TOPBUTTONLINEX);
        tt.play();

        if (TokenChecker.checkCombinations(rowCoord, columnCoord, currentPlayer)) {
            Field.reset();
            setCurrentPlayer(0);
            mainanchorpane.getChildren().clear();
            initialize();
            return;
        }

        if (currentPlayer == 0) {
            currentPlayer++;
        } else if (currentPlayer == 1) {
            currentPlayer = 0;
        }
        setCurrentPlayer(currentPlayer);
    }

    public void handleAboutClick() {
        Alert alert = new Alert(Alert.AlertType.INFORMATION);
        alert.initStyle(StageStyle.UTILITY);
        alert.setTitle("About!");
        alert.setHeaderText("Made by Bruno Kovacevic & Michael Köppl");
        alert.setContentText("4AHIF");
        alert.showAndWait();
    }

    public void setCurrentPlayer(int player) {
        currentPlayer = player;
        playerlabel.setText("Spieler " + currentPlayer + " ist am Zug.");
    }
}
