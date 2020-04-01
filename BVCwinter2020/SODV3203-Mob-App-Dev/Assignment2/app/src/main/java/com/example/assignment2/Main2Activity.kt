package com.example.assignment2

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import kotlinx.android.synthetic.main.activity_main2.*

class Main2Activity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main2)



        val url = intent.getStringExtra("page")

        if(url != null)
        webView.loadUrl(url)
        else{
           webView.loadUrl("https://www.youtube.com/watch?v=oHg5SJYRHA0")
        }
    }
}
