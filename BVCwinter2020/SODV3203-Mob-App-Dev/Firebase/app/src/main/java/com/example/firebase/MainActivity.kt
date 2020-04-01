package com.example.firebase

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.TextView
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.google.firebase.database.FirebaseDatabase
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {
var database: FirebaseDatabase? = null
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val recyclerView = findViewById<RecyclerView>(R.id.reView)
        val coffeeList = arrayListOf<Coffee?>()

        recyclerView.LayoutManager = LinearLayoutManager(this)

        database = FirebaseDatabase.getInstance()



        class CoffeeAdapter(val item:ArrayList<Coffee?>) : RecyclerView.Adapter<CoffeeAdapter.CoffeeViewHolder>(){
                inner class CoffeeViewHolder(itemView: View) RecyclerView.ViewHolder(itemView){
                val coffeeName = itemView.coffee_name_text
                val coffeePrice = itemView.coffee_price_text
            }

            override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): CoffeeViewHolder {
                val view = LayoutInflater.from(parent.context)
                    .inflate(R.layout.coffee_item, parent,false)
                return CoffeeViewHolder(view)
            }
            override fun getItemCount(): Int {
                return item.size
            }

            override fun onBindViewHolder(holder: CoffeeViewHolder, position: Int) {
                holder.coffeeName.text = item[position]!!.name
                holder.coffeePrice.text = item[position]!!.price.toString()
            }
        }
    }
}
