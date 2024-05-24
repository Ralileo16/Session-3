package com.example.m14_tp2

import android.util.Log
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.squareup.picasso.Picasso

class RvAdapter(private val currencies:CurrencyOverview ) : RecyclerView.Adapter<RvAdapter.VH>() {

    inner class VH(itemView: View) : RecyclerView.ViewHolder(itemView)

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): VH {
        val view = LayoutInflater.from(parent.context).inflate(R.layout.rv_currency, parent, false)
        return VH(view)
    }

    override fun onBindViewHolder(holder: VH, position: Int) {
        holder.itemView.apply {
            findViewById<TextView>(R.id.tvName).text = currencies.lines[position].currencyTypeName
            findViewById<TextView>(R.id.tvPrice).text = currencies.lines[position].chaosEquivalent.toString()
            val imgIcon = findViewById<ImageView>(R.id.imageViewIcon)
            val imgPrice = findViewById<ImageView>(R.id.imageViewPrice)
            var imgUrlIcon = ""
            val imgUrlPrice = "https://web.poecdn.com/gen/image/WzI1LDE0LHsiZiI6IjJESXRlbXMvQ3VycmVuY3kvQ3VycmVuY3lSZXJvbGxSYXJlIiwidyI6MSwiaCI6MSwic2NhbGUiOjF9XQ/d119a0d734/CurrencyRerollRare.png"

            for (cd in currencies.currencyDetails) {
                if (cd.name == currencies.lines[position].currencyTypeName)
                    imgUrlIcon = cd.icon
            }
            Picasso.get().load(imgUrlIcon).into(imgIcon)
            Picasso.get().load(imgUrlPrice).into(imgPrice)
        }
    }

    override fun getItemCount(): Int {
        return currencies.lines.size
    }
}