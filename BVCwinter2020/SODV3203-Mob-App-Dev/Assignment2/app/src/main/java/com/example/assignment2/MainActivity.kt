package com.example.assignment2

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.content.Intent
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)


        button.setOnClickListener{
            //facebook
            val myIntent = Intent(this, Main2Activity::class.java)
            myIntent.putExtra("page","https://www.facebook.com")
            startActivity(myIntent)

        }


        button2.setOnClickListener{
            //youtube
            val myIntent = Intent(this, Main2Activity::class.java)
            myIntent.putExtra("page","https://www.youtube.com")
            startActivity(myIntent)

        }

        button3.setOnClickListener {
            //linkedin
            val myIntent = Intent(this, Main2Activity::class.java)
            myIntent.putExtra("page","https://www.linkedin.com")
            startActivity(myIntent)
        }
        button4.setOnClickListener {
            //twitter
            val myIntent = Intent(this, Main2Activity::class.java)
            myIntent.putExtra("page","https://www.twitter.com")
            startActivity(myIntent)

        }

    }
}
