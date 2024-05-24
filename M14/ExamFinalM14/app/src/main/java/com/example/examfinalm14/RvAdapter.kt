package com.example.examfinalm14

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.google.android.material.snackbar.Snackbar
import com.squareup.picasso.Picasso

class RvAdapter(private val quotes:List<Quote> ) : RecyclerView.Adapter<RvAdapter.VH>() {

    inner class VH(itemView: View) : RecyclerView.ViewHolder(itemView)

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): VH {
        val view = LayoutInflater.from(parent.context).inflate(R.layout.rv_quotes, parent, false)
        return VH(view)
    }

    override fun onBindViewHolder(holder: VH, position: Int) {
        holder.itemView.apply {
            findViewById<TextView>(R.id.tvAuthor).text = quotes[position].author
            findViewById<TextView>(R.id.tvQuote).text = quotes[position].quote
            setOnClickListener {
                val context = holder.itemView.context
                Snackbar.make(holder.itemView, "Item ${position + 1} clicked", Snackbar.LENGTH_SHORT)
                    .show()
            }
        }
    }

    override fun getItemCount(): Int {
        return 10
    }
}