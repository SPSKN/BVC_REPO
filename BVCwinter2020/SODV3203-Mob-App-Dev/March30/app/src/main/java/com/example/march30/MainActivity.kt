package com.example.march30

import android.content.DialogInterface
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.appcompat.app.AlertDialog
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        login.setOnClickListener {
            if(userLogin.text.toString()== "scott" && passLogin.text.toString() == "123456"){
                val myIntent = Intent(this, Main2Activity::class.java)
            }else{
                var alertDialog = AlertDialog.Builder(this)
                    .setTitle("Error")
                    .setMessage("Invalid ID or Password")
                    .setPositiveButton("Okay",{dialogInterface, i -> })
                alertDialog.show()
            }
        }
    }
}
