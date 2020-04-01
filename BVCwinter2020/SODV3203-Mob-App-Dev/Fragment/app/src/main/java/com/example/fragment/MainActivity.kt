package com.example.fragment

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        button1.setOnClickListener{
            supportFragmentManager.beginTransaction().replace(R.id.frame_layout,Fragment1()).commit()
        }
        button2.setOnClickListener{
            supportFragmentManager.beginTransaction().replace(R.id.frame_layout,Fragment2()).commit()
        }
        button3.setOnClickListener{
            supportFragmentManager.beginTransaction().replace(R.id.frame_layout,Fragment3()).commit()
        }
    }
}
