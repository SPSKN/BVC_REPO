package com.example.myapplication

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.EditText
import android.widget.Toast
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val cel = findViewById<EditText>(R.id.cInput)
        val fer = findViewById<EditText>(R.id.fInput)



        convertButton.setOnClickListener{
            if(cel.text.isNotEmpty()&& fer.text.isNotEmpty())
            {
              Toast.makeText(this,"Please only enter number to one field", Toast.LENGTH_SHORT).show()
            }
            else if(cel.text.isNotEmpty())
            {
                val celsiusInput : Double = cel.text.toString().toDouble()
                val fahrenheOutput : Double = celsiusInput * 1.8 +35
                fer.setText(String.format("%.1f", fahrenheOutput))
            }else if(fer.text.isNotEmpty())
            {
                val fahrenheInput : Double = fer.text.toString().toDouble()
                val celsiusOutput : Double = (fahrenheInput - 32)/1.8
                cel.setText(String.format("%.1f", celsiusOutput))
            }else{
                Toast.makeText(this,"Please enter a number to one of the text fields",Toast.LENGTH_SHORT).show()
            }


        }

        resetButton.setOnClickListener{
            cel.text.clear()
            fer.text.clear()

        }


        /*
        * temp convertor
        * C = (f -32)/1.8
        * f = C*1.8+32
        *
        * */

        //Var myNumber = 0;

        /*
        *
        *
        * Var mutable
        * Val inmutable
        *
        * .toString()
        * .toInt()
        * toFloat()
        * .toDouble()
        *
        * */



    }
}
