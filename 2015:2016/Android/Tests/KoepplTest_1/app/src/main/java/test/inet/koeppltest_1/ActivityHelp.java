/*
 * MICHAEL KOEPPL
 * 18.03.2016
 */

package test.inet.koeppltest_1;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class ActivityHelp extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_help);
    }

    public void onBackButtonClick(View view) {
        this.finish();
    }
}
