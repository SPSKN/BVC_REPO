package com.example.task1_scott_patterson

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Toast
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        button.setOnClickListener{
            editText.text.clear()
            editText2.text.clear()
            editText3.text.clear()
            Toast.makeText(this,"You have successfully submitted your application",Toast.LENGTH_LONG )

        }

    }
}
