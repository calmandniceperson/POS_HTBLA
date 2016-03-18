/*
 * MICHAEL KOEPPL
 * 18.03.2016
 */

package test.inet.koeppltest_1;

import android.content.Context;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.inputmethod.InputMethodManager;
import android.widget.EditText;
import android.widget.Toast;

public class ActivityCalc extends AppCompatActivity {

    private EditText inputEditText;
    private EditText resultEditText;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_calc);
        inputEditText = (EditText) findViewById(R.id.inputEditText);
        resultEditText = (EditText) findViewById(R.id.resultEditText);
    }

    public void onPlusButtonClick(View view) {
        if (inputEditText.getText().toString().contains(" ")) {
            int result = Integer.parseInt(inputEditText.getText().toString().split(" ")[0]) +
                    Integer.parseInt(inputEditText.getText().toString().split(" ")[1]);
            resultEditText.setText(result + "");
        } else {
            Toast.makeText(this, "Sie muessen 2 Zahlen eingeben.", Toast.LENGTH_SHORT).show();
        }
        // Keyboard verstecken
        if (view != null) {
            InputMethodManager imm = (InputMethodManager) getSystemService(Context.INPUT_METHOD_SERVICE);
            imm.hideSoftInputFromWindow(view.getWindowToken(), 0);
        }
    }

    public void onBackButtonClick(View view) {
        this.finish();
    }
}
