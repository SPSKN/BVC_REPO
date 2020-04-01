package com.example.roomapplication

import androidx.lifecycle.LiveData
import androidx.room.*

@Dao
interface ToDoDao {
    @Query("SELECT * FROM ToDo")
    fun getAll(): List<ToDo>

    @Insert
    fun insert(toDo: ToDo)

    @Update
    fun update(toDo: ToDo)

    @Delete
    fun delete(toDo: ToDo)
}