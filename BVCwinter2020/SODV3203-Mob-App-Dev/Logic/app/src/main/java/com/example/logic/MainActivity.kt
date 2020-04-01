package com.example.logic

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        textView.text = "0"
        var x = 0
        var s = ""
/*
count 1 to 10
12345678910
 */
        for(i in 1..10) {
            s += i.toString()
            s += "  "
            textView.text = s



        }


        /*
        count to 13
        135791113
         */
        if(x != 0)
        {
            x = 0

        }else{
            s += "\n "
            while(x < 13) {
                if(x < 3)
                {
                    x = x + 1
                    s += x.toString()
                    x = x + 2
                }else {
                    x = x + 2
                    s += "  "
                    s += x.toString()
                    textView.text = s

                }
            }

        } // end of loop

        /*
        count to 20
        2 5 8 11 14 19 20
         */
        var j = 1
        s += "\n "
            while(j < 20) {

                if(j < 2)
                {

                    j = j + 1
                    s += j.toString()

                }else {
                    j = j + 3
                    s += "  "
                    s += j.toString()
                    textView.text = s
                }
            }
        var l = 1
        s += "\n "

            while(l < 21){
                s += "test"
                s += l.toString()
                l++
            }

    } // end of loop




}




