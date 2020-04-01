package com.example.gla21

//import android.app.Person
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.LayoutInflater
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {

        val Persons : ArrayList<Person> = arrayListOf<Person>()
        for(i in 3..21)
        {
            Persons.add(0,Person("Scott $i"))
            i+6
        }

        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)


        RView.apply{
            LayoutManager = LinearLayoutManager(this@MainActivity)
            adapter = PersonAdapter(Persons)
        }

    }


    fun getItemCount() : Int {
        return Person
    }

     fun onBindViewHolder(holder: PersonAdapter.PersonViewHolder, position : Int){
        holder.binding.person = items[position]
    }

}



public class PersonAdapter(val items: List<Person>) : RecyclerView.Adapter<PersonAdapter.PersonViewHolder>(){
    class PersonViewHolder(val binding : ItemPersonBinding) : RecyclerView.ViewHolder(binding.root)
}
data class Person (val name: String)
{

}