package com.example.exam_m14

import android.content.Intent
import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import com.example.exam_m14.databinding.ActivityMainBinding
import com.google.android.material.snackbar.Snackbar

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        val binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        binding.buttonDecompose.setOnClickListener {
            if (!binding.editTextDecompose.text.isNullOrBlank()) {
                val text = binding.editTextDecompose.text.toString()
                startActivity(Intent(this, MainActivity2::class.java).putExtra("mot", text))
            }
            else {
                Snackbar.make(binding.root, "Veuillez inscrire une valeur",Snackbar.LENGTH_SHORT).show()
            }
        }
    }
}