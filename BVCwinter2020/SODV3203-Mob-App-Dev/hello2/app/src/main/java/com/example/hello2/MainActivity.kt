package com.example.hello2

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Toast
import kotlinx.android.synthetic.main.activity_main.*


class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
            ///editText.setText("Hello, World")

        button.setOnClickListener({
            //Toast.makeText(this,"Hello Nerd",Toast.LENGTH_LONG).show()
            editText.setText("You Pushed the button")
        })
    }



}
