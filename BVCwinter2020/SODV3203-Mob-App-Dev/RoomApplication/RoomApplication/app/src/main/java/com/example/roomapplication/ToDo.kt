package com.example.roomapplication

import androidx.room.Entity
import androidx.room.PrimaryKey

@Entity
data class ToDo(val title:String) {
    @PrimaryKey(autoGenerate = true) var id: Int = 0

}