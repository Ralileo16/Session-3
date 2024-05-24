package com.example.myapplication

import android.os.Bundle
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.myapplication.databinding.ActivityMain2Binding
import java.text.SimpleDateFormat
import java.util.Calendar
import java.util.Date
import java.util.Locale

class MainActivity2 : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        val binding = ActivityMain2Binding.inflate(layoutInflater)
        setContentView(binding.root)

        val first = intent.getStringExtra("first")
        val last = intent.getStringExtra("last")
        val cat = intent.getStringExtra("cat")
        val dog = intent.getStringExtra("dog")
        val date = intent.getStringExtra("date")
        val dateFormat = SimpleDateFormat("dd-MM-yyyy", Locale.getDefault())
        val birthdate: Date = dateFormat.parse(date!!) ?: Date()
        val animal = if (cat!!.toInt() > dog!!.toInt()) "cat" else "dog"
        val greeting = "Hello, $first $last. You are ${calculateAge(birthdate)} years old and are a $animal person"

        binding.textView.text = greeting
    }

    private fun calculateAge(birthdate: Date): Int {
        val today = Calendar.getInstance()
        val birthDate = Calendar.getInstance().apply { time = birthdate }

        var age = today.get(Calendar.YEAR) - birthDate.get(Calendar.YEAR)
        if (today.get(Calendar.DAY_OF_YEAR) < birthDate.get(Calendar.DAY_OF_YEAR)) {
            age--
        }
        return age
    }
}