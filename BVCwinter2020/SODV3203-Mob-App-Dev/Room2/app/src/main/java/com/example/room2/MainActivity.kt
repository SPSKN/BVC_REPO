package com.example.room2

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.room.Room
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)


        val db = Room.databaseBuilder(
            applicationContext,
            AppDatabase::class.java,"database"
        )
            .allowMainThreadQueries()
            .build()

        todo_text.setText(db.TodoDao().getAll().toString())

        add_button.setOnClickListener{
            db.TodoDao().insert(Todo(todo_edit.text.toString()))
            todo_text.text = db.TodoDao().getAll().toString()
        }
    }
}
