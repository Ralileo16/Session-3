package com.example.m14_tp2

import android.os.Bundle
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import com.example.m14_tp2.databinding.ActivityCurrencyBinding
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response
import android.util.Log
import androidx.lifecycle.lifecycleScope
import androidx.recyclerview.widget.LinearLayoutManager
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch


class ActivityCurrency : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        val binding = ActivityCurrencyBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val call  = ApiClient.apiService.getCurrencies()
        call.enqueue(object : Callback<CurrencyOverview> {
            override fun onResponse(call: Call<CurrencyOverview>, response: Response<CurrencyOverview>) {
                if (response.isSuccessful) {
                    val currencies = response.body()
                    lifecycleScope.launch(Dispatchers.IO){
                        this@ActivityCurrency.runOnUiThread{
                            val myAdapter = RvAdapter(currencies!!)
                            binding.rvCurrency.adapter = myAdapter
                            binding.rvCurrency.layoutManager = LinearLayoutManager(this@ActivityCurrency)
                    }
                    }
                } else {
                    // Handle error
                    Log.e("ApiService", "Error: ${response.code()} ${response.message()}")
                }
            }
            override fun onFailure(call: Call<CurrencyOverview>, t: Throwable) {
                // Handle failure
                Log.e("ApiService", "Network error: ${t.message}")

            }
        })
    }
}