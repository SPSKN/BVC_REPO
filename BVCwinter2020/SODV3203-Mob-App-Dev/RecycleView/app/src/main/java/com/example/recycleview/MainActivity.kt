package com.example.recycleview

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.example.recycleview.databinding.ItemStudentBinding
import kotlinx.android.synthetic.main.activity_main.*
import kotlinx.android.synthetic.main.item_student.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)


        val students = arrayListOf<Student>()
        for(i in 1..20){
            students.add(Student("Scott $i",20))
        }

        review.apply {
            layoutManager = LinearLayoutManager(this@MainActivity)
            adapter = StudentAdapter(students)
        }
    }
}


class StudentAdapter(val items: List<Student>) : RecyclerView.Adapter<StudentAdapter.StudentViewHolder>(){
    class StudentViewHolder(val binding: ItemStudentBinding) : RecyclerView.ViewHolder(binding.root)

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): StudentViewHolder {
        TODO("not implemented") //To change body of created functions use File | Settings | File Templates.
        val view  = LayoutInflater.from(parent.context)
            .inflate(R.layout.item_student, parent, false)
        val viewHolder = StudentViewHolder(ItemStudentBinding.bind(view))
        return viewHolder


    }

    override fun getItemCount(): Int {
        TODO("not implemented") //To change body of created functions use File | Settings | File Templates.
        return items.size

    }

    override fun onBindViewHolder(holder: StudentViewHolder, position: Int) {
        TODO("not implemented") //To change body of created functions use File | Settings | File Templates.
        holder.binding.student = items[position]


    }


}