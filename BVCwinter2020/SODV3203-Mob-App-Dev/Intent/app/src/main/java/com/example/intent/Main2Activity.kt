package com.example.intent

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.widget.Toast
import kotlinx.android.synthetic.main.activity_main2.*

class Main2Activity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main2)


button3.setOnClickListener {
    val name:String = name_Input.text.toString()
        if (name_Input.text.isNotEmpty())
        {

            val intent = Intent(this,MainActivity::class.java)

            intent.putExtra("MyName","$name")

            Log.d("MAINACTIVITY","$name")

            startActivity(intent)
        }else{
            Toast.makeText(this,"Please enter a valid name",Toast.LENGTH_SHORT)
        }

}
    }
}
