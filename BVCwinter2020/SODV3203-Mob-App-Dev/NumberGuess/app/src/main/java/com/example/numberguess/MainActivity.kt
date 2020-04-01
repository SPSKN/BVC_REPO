package com.example.numberguess

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Toast
import kotlinx.android.synthetic.main.activity_main.*
import kotlin.random.Random

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        startButton.setOnClickListener{
            Toast.makeText(this,"The Game has started",Toast.LENGTH_SHORT).show()
            val randomInt = java.util.Random().nextInt(100) + 1

            checkButton.setOnClickListener{
                if(numberInput.text.isEmpty()){
                    Toast.makeText(this,"Enter a Valid Number",Toast.LENGTH_SHORT).show()
                }
                else if(numberInput.text.toString().toInt()< randomInt){
                    Toast.makeText(this,"Go Higher",Toast.LENGTH_SHORT).show()
                }
                else if(numberInput.text.toString().toInt()> randomInt) {
                    Toast.makeText(this, "Go Lower", Toast.LENGTH_SHORT).show()
                }
                else{
                    Toast.makeText(this,"You Win",Toast.LENGTH_SHORT).show()
                }

            }

        }


    }
}
