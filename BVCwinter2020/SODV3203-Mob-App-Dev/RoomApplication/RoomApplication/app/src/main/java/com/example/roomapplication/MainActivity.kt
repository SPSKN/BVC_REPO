package com.example.roomapplication

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import androidx.lifecycle.Observer
import androidx.lifecycle.lifecycleScope
import androidx.room.Room
import kotlinx.android.synthetic.main.activity_main.*
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val db = Room.databaseBuilder(
            applicationContext,
            AppDatabase::class.java, "database-name"

        )
            .allowMainThreadQueries()
            .build()
/*
        db.todoDao().getAll().observe(this, Observer {
            toDoText.text = it.toString()
        })
*/
        addButton.setOnClickListener {
            // lifecycleScope.launch(Dispatchers.IO) {
            db.todoDao().insert(ToDo(toDoEdit.text.toString()))
            db.todoDao().getAll().toString()
            toDoText.text = db.todoDao().getAll().toString()
        }
        clearButton.setOnClickListener{
            //db.todoDao().delete
            toDoText.text = ""
        }
    }
}

