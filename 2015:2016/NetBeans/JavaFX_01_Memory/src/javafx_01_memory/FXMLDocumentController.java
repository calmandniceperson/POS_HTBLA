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
package javafx_01_memory;

import java.util.Timer;
import java.util.TimerTask;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.GridPane;
import javafx.scene.paint.Color;
import javafx.stage.StageStyle;

import memory.Memory;
import memory.MemoryRectangle;

public class FXMLDocumentController {

    @FXML
    private AnchorPane rootpane;

    @FXML
    private GridPane buttongridpane;

    @FXML
    private Button startbutton;

    @FXML
    private AnchorPane buttonanchorpane;

    @FXML
    private AnchorPane controlsanchorpane;

    @FXML
    private Label scorelabel_p1;

    @FXML
    private TextField p2nametextfield;

    @FXML
    private Label scorelabel_p2;

    @FXML
    private TextField p1nametextfield;

    private Alert alert;

    private Memory mem;
    private MemoryRectangle rec /*variable for generating rectangles*/,
            sel1 /*first selected rectangle*/,
            sel2 /*second selected rectangle*/;
    /*
     * Holds the current user (1 or 2)
     */
    private int currentPlayer;

    /*
     * Method called by a startButton click
     * Initializes the playing field, players, colors, etc.
     * and starts the game.
     */
    @FXML
    void handleStartButtonClick(ActionEvent event) {
        // generate new object of
        // the Memory class with 2 players
        mem = new Memory(2 /*players*/);

        // set current player to 1
        currentPlayer = 1;

        // Since the first turn is player1's turn,
        // set the color of player1's name field to green and 
        // player2's field to white and
        // set both scores to 0
        p1nametextfield.setStyle("-fx-background-color: #00E676;");
        p2nametextfield.setStyle("-fx-background-color: white;");
        scorelabel_p1.setText(0 + "");
        scorelabel_p2.setText(0 + "");

        // Get number of columns and rows
        int numColumns = buttongridpane.getColumnConstraints().size();
        int numRows = buttongridpane.getRowConstraints().size();

        // Loop through the rows and in each row
        // through the columns
        for (int i = 0; i <= numRows - 1; i++) {
            for (int j = 0; j <= numColumns - 1; j++) {
                // Create a new rectangle with
                // grey fill (the color is only added
                // on button click
                rec = new MemoryRectangle();
                rec.setFill(Color.GREY);
                rec.setStroke(Color.BLACK);
                rec.setHeight(60);
                rec.setWidth(60);

                // Add an event listener to the rectangles
                rec.addEventHandler(MouseEvent.MOUSE_CLICKED, (MouseEvent e) -> {
                    MemoryRectangle source = (MemoryRectangle) e.getSource();
                    // On click set the fill of the rectangle to 
                    // the assigned color (from colorList)
                    source.setFill(mem.getColorForRect(source));

                    // If sel1 is null, assign the rectangle
                    // the user clicked on to it
                    // otherwise assign it to sel2
                    if (sel1 == null) {
                        sel1 = source;
                        // Check if the rectangle has already been
                        // used and has already been revealed
                        if (sel1.isUsed()) {
                            // Show a message to alert the user
                            alert = new Alert(Alert.AlertType.INFORMATION);
                            alert.initStyle(StageStyle.UTILITY);
                            alert.setTitle("Fehler!");
                            alert.setHeaderText("Feld wurde schon benutzt.");
                            alert.setContentText("Dieses Feld wurde bereits gewählt.");
                            alert.showAndWait();
                            sel1 = null;
                        }
                    } else { // if sel1 has already been set
                        // set sel2
                        sel2 = source;

                        // Check whether the second field has already
                        // been revealed
                        if (sel2.isUsed()) {
                            alert = new Alert(Alert.AlertType.INFORMATION);
                            alert.initStyle(StageStyle.UTILITY);
                            alert.setTitle("Fehler!");
                            alert.setContentText("Dieses Feld wurde bereits benutzt.");
                            alert.setHeaderText("Feld wurde schon benutzt.");
                            alert.showAndWait();
                            sel2 = null;
                        }

                        // Check whether the 2 buttons' colors match
                        // If they do, set both to used and
                        // then set the selected objects to null again
                        // to receive the next 2 cards.
                        // Also increase the current player's score on
                        // both the label and in the player object.
                        // Then check whether one player has already found more
                        // than half of the combinations. If he has, he has already won.
                        if ((!sel1.equals(sel2)) && mem.getColorForRect(sel1).equals(mem.getColorForRect(sel2))) {
                            sel1.setUsed(true);
                            sel2.setUsed(true);
                            sel1 = null;
                            sel2 = null;
                            mem.getPlayerById(currentPlayer).addScore(1);
                            if (currentPlayer == 1) {
                                scorelabel_p1.setText(mem.getPlayerById(currentPlayer).getScore() + "");
                            } else {
                                scorelabel_p2.setText(mem.getPlayerById(currentPlayer).getScore() + "");
                            }
                            if (mem.getPlayerById(currentPlayer).getScore() > ((numColumns * numRows) / 4)) {
                                // Player won found more than half
                                // of the combination --> won
                                alert = new Alert(Alert.AlertType.INFORMATION);
                                alert.initStyle(StageStyle.UTILITY);
                                alert.setTitle("Sieg!");
                                alert.setHeaderText("Herzlichen Glückwunsch!");
                                if (currentPlayer == 1) {
                                    alert.setContentText(p1nametextfield.getText() + " gewinnt!");
                                } else if (currentPlayer == 2) {
                                    alert.setContentText(p2nametextfield.getText() + " gewinnt!");
                                }
                                alert.showAndWait();
                            }
                            // If both scores match and the scores are ((numRows*numColumns)/2)/2)
                            // announce a tie!
                            if ((scorelabel_p1.getText().equals(scorelabel_p2.getText())) && Integer.parseInt(scorelabel_p1.getText()) == ((numRows * numColumns) / 4)) {
                                alert = new Alert(Alert.AlertType.INFORMATION);
                                alert.initStyle(StageStyle.UTILITY);
                                alert.setTitle("Sieg!");
                                alert.setHeaderText("2 glückliche Gewinner!");
                                alert.setContentText("Herzlichen Glückwunsch!");
                                alert.showAndWait();
                                sel2 = null;
                            }
                        } else if (sel1.equals(sel2)) { // if the same field has been selected twice (to punish "cheating")
                            alert = new Alert(Alert.AlertType.INFORMATION);
                            alert.initStyle(StageStyle.UTILITY);
                            alert.setTitle("Fehler");
                            alert.setContentText("Sie muessen ein anderes Feld waehlen!");
                            alert.showAndWait();
                            sel2 = null;
                        } else {
                            // If the colors did not match, 
                            // wait for 500ms and then reset the color
                            // of both fields
                            Timer t = new Timer();
                            t.schedule(
                                    new TimerTask() {
                                        @Override
                                        public void run() {
                                            sel1.setFill(Color.GREY);
                                            sel2.setFill(Color.GREY);
                                            sel1 = null;
                                            sel2 = null;
                                            if (currentPlayer == 1 /*number of players later*/) {
                                                currentPlayer = 2;
                                                p2nametextfield.setStyle("-fx-background-color: #00E676;");
                                                p1nametextfield.setStyle("-fx-background-color: white;");
                                            } else if (currentPlayer == 2) {
                                                currentPlayer = 1;
                                                p2nametextfield.setStyle("-fx-background-color: white;");
                                                p1nametextfield.setStyle("-fx-background-color: #00E676;");
                                            }
                                            t.cancel();
                                        }
                                    }, 500
                            );
                        }
                    }
                });
                buttongridpane.add(rec, i, j);
                mem.addToRectList(rec);
            }
        }
    }

}
