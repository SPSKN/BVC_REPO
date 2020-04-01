package com.example.room2

import androidx.room.*

@Dao
interface TodoDao {
    @Query("Select * FROM todo")
    fun getAll(): List<Todo>

    @Insert
    fun insert(todo: Todo)

    @Update
    fun update(todo: Todo)

    @Delete
    fun delete(todo: Todo)
}