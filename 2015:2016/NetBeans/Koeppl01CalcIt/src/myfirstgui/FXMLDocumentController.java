package myfirstgui;

import java.util.Random;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.paint.Color;
 
public class FXMLDocumentController {

    @FXML
    private Button checkbutton;

    @FXML
    private Button generateButton;

    @FXML
    private Label calclabel;
    
    @FXML
    private Label resultlabel;

    @FXML
    private Label label;

    @FXML
    private TextField calctextarea;
    
    private int n1, n2;

    @FXML
    void handleGenerateOnClick(ActionEvent event) {
        Random r = new Random();
        n1 = r.nextInt(100-1) + 1;
        n2 = r.nextInt(100-1) + 1;
        calclabel.setText(n1 + " + " + n2 + "= ");
        calctextarea.setText(null);
    }

    @FXML
    void handleCheckOnClick(ActionEvent event) {
        if(calctextarea.getText().equals("")) {
            calclabel.setText("Sie muessen einen Wert eingeben. Druecken Sie erneut auf Generate");
            return;
        }
        if((n1+n2) == Integer.parseInt(calctextarea.getText())) {
            resultlabel.setText("Richtig!");
            resultlabel.setTextFill(Color.GREEN);
        } else {
            resultlabel.setText("Falsch!");
            resultlabel.setTextFill(Color.RED);
        }
    }

}
