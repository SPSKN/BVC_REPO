package com.example.roomapplication

import androidx.room.Database
import androidx.room.RoomDatabase

@Database(entities = [ToDo::class], version = 1)
abstract class AppDatabase : RoomDatabase() {
    abstract fun todoDao(): ToDoDao
}