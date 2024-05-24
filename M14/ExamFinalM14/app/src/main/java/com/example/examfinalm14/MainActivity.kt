package com.example.examfinalm14

import android.os.Bundle
import android.util.Log
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.lifecycle.lifecycleScope
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.examfinalm14.databinding.ActivityMainBinding
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        val binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val call  = ApiClient.apiService.getQuotes()
        call.enqueue(object : Callback<List<Quote>> {
            override fun onResponse(call: Call<List<Quote>>, response: Response<List<Quote>>) {
                if (response.isSuccessful) {
                    val quotes = response.body()
                    lifecycleScope.launch(Dispatchers.IO){
                        this@MainActivity.runOnUiThread{
                            val myAdapter = RvAdapter(quotes!!)
                            binding.rvQuotes.adapter = myAdapter
                            binding.rvQuotes.layoutManager = LinearLayoutManager(this@MainActivity)
                        }
                    }
                } else {
                    // Handle error
                    Log.e("ApiService", "Error: ${response.code()} ${response.message()}")
                }
            }
            override fun onFailure(call: Call<List<Quote>>, t: Throwable) {
                // Handle failure
                Log.e("ApiService", "Network error: ${t.message}")

            }
        })
    }
}