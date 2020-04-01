package com.example.assignment1
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.widget.Toast
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val nameInput = name_text.text
        val pswdInput = pwd_text.text

        submit_button.setOnClickListener{
            Log.d("MAINACTIVITY","Button is clicked $nameInput  $pswdInput")
            val name:String = nameInput.toString()
            val pswd:String = pswdInput.toString()
            if(nameInput.toString().equals("scott")&&pswdInput.toString().equals("1234")){
                val intent = Intent(this,Main2Activity::class.java)
                intent.putExtra("name","$name")
                intent.putExtra("pswd","$pswd")
                startActivity(intent)
                //Toast.makeText(this,"Correct",Toast.LENGTH_SHORT).show()
            }else{
                Toast.makeText(this,"Wrong",Toast.LENGTH_SHORT).show()

            }

        }
    }
}
