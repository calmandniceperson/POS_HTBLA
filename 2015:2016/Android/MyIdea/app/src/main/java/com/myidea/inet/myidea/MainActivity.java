package com.myidea.inet.myidea;

import android.media.MediaPlayer;
import android.provider.MediaStore;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    MediaPlayer mp;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void onCowButtonClick(View view) {
        if (mp != null && mp.isPlaying()) {
            mp.stop();
        }
        mp = MediaPlayer.create(this, R.raw.cow);
        mp.start();
    }

    public void onChickenButtonClick(View view) {
        if (mp != null && mp.isPlaying()) {
            mp.stop();
        }
        mp = MediaPlayer.create(this, R.raw.chicken);
        mp.start();
    }

    public void onGoatButtonClick(View view) {
        if (mp != null && mp.isPlaying()) {
            mp.stop();
        }
        mp = MediaPlayer.create(this, R.raw.goat);
        mp.start();
    }

    public void onDonkeyButtonClick(View view) {
        if (mp != null && mp.isPlaying()) {
            mp.stop();
        }
        mp = MediaPlayer.create(this, R.raw.donkey);
        mp.start();
    }
}
