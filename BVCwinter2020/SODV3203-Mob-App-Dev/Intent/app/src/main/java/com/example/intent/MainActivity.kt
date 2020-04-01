package com.example.intent

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val MyIntent = Intent(this, Main2Activity::class.java)

        button.setOnClickListener {
            Log.d("MAINACTIVITY","Button is clicked")
            startActivity(MyIntent)

        }


        val name = intent.getStringExtra("MyName")
        Log.d("MAINACTIVITY","$name")

        if(name != null){
            textView.setText("Welcome Back \n $name")
        }

    }
}
