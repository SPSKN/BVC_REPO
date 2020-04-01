package com.example.assignment1

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import kotlinx.android.synthetic.main.activity_main2.*

class Main2Activity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main2)
        val MyIntent = Intent(this, Main3Activity::class.java)
        val name = intent.getStringExtra("name")
        val pswd = intent.getStringExtra("pswd")
        name_check.text = name
        pswd_check.text = pswd
        /**button.setOnClickListener {
            Log.d("MAINACTIVITY","Button is clicked")
            startActivity(MyIntent)
        */
        submit_button.setOnClickListener{
            val intent = Intent(this,Main3Activity::class.java)
            intent.putExtra("MyName","$name")
            startActivity(intent)
        }
    }



}
