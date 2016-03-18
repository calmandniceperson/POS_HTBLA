/*
 * MICHAEL KOEPPL
 * 18.03.2016
 */

package test.inet.koeppltest_1;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class Activity1 extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void onCalcButtonClick(View view) {
        Intent calcIntent = new Intent(Activity1.this, ActivityCalc.class);
        this.startActivity(calcIntent);
    }

    public void onHelpButtonClick(View view) {
        Intent helpIntent = new Intent(Activity1.this, ActivityHelp.class);
        this.startActivity(helpIntent);
    }

    public void onEndButtonClick(View view) {
        //super.finish();

        // schliesst die java vm, die mit
        // der ausfuehrung der app beauftragt ist
        System.exit(0);
    }
}
