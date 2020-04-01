package com.example.sodv3203_project_ui

import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import androidx.databinding.DataBindingUtil
import androidx.recyclerview.widget.DividerItemDecoration
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.sodv3203_project_ui.databinding.ActivityPage2Binding
import kotlinx.android.synthetic.main.activity_page2.*

class SecondActivity: AppCompatActivity() {
    lateinit var binding: ActivityPage2Binding
    lateinit var itemlist: ArrayList<Items>

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = DataBindingUtil.setContentView(this, R.layout.activity_page2)
        itemlist = ArrayList()
        addItems()

        itemRecycler.layoutManager = LinearLayoutManager(this)
        itemRecycler.addItemDecoration(DividerItemDecoration(this, 1))
        itemRecycler.adapter = ItemAdapter(itemlist)
    }
    fun addItems(){
        itemlist.add(Items("milk", "10 days left",R.drawable.milk))
        itemlist.add(Items("juice", "15 days left",R.drawable.juice))
        itemlist.add(Items("broccoli", "4 days left",R.drawable.broccoli))
        itemlist.add(Items("kale", "10 days left",R.drawable.kale))
        itemlist.add(Items("butter", "10 days left",R.drawable.butter))
        itemlist.add(Items("meat", "10 days left",R.drawable.meat))
        itemlist.add(Items("mushrooms", "10 days left",R.drawable.mushrooms))
        itemlist.add(Items("yogurt", "10 days left",R.drawable.yogurt))
    }
}
