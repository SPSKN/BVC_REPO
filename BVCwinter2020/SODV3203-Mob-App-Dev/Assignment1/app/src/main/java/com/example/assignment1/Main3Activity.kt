package com.example.assignment1

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_main3.*

class Main3Activity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main3)
        val name = intent.getStringExtra("MyName")
        text_view3.setText("Welcome \n $name")
    }
   

}
