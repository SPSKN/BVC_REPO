package com.example.sodv3203_project_ui

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import kotlinx.android.synthetic.main.layout_item_view.view.*

class ItemAdapter(var items: ArrayList<Items>) : RecyclerView.Adapter<ItemViewHolder>(){
    override fun getItemCount(): Int {
       return items.size
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ItemViewHolder {
        lateinit var itemViewHolder: ItemViewHolder
        itemViewHolder =  ItemViewHolder(LayoutInflater.from(parent.context).inflate(R.layout.layout_item_view, parent, false))
        return itemViewHolder
    }

    override fun onBindViewHolder(holder: ItemViewHolder, position: Int) {
            holder.ItemName?.text = items.get(position).name
            holder.ItemDescription?.text = items.get(position).description
            holder.ItemImage.setImageResource(items.get(position).image)
        }
}


class ItemViewHolder(itemView:View) : RecyclerView.ViewHolder(itemView){
    var ItemName = itemView.itemName
    var ItemDescription = itemView.itemDescription
    var ItemImage = itemView.itemImage
}