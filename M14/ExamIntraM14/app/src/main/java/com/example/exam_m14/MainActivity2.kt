package com.example.exam_m14

import android.content.Intent
import android.content.SharedPreferences
import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import com.example.exam_m14.databinding.ActivityMain2Binding
import com.google.android.material.snackbar.Snackbar


class MainActivity2 : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        val binding = ActivityMain2Binding.inflate(layoutInflater)
        setContentView(binding.root)

        val mot = intent.getStringExtra("mot")
        val chars = mot!!.toList().joinToString("\n\r")

        binding.textView.text = chars
        val (v,c) = countVowelsAndConsonants(mot)
        binding.textViewVowel.text = "Voyelle : $v"
        binding.textViewConsonant.text = "Consonne : $c"

        val motStorage = getSharedPreferences("mot", MODE_PRIVATE)
        writeSharedPreferences(motStorage, mot)

        binding.buttonBack.setOnClickListener {
            this.finish()
        }
    }
}

fun countVowelsAndConsonants(mot: String): Pair<Int, Int> {
    val vowels = setOf('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U')
    val consonants = ('a'..'z').toSet() - vowels + ('A'..'Z').toSet() - vowels

    var vowelCount = 0
    var consonantCount = 0

    for (char in mot) {
        if (char in vowels)
            vowelCount++
        else if (char in consonants)
            consonantCount++
    }
    return Pair(vowelCount, consonantCount)
}

private fun writeSharedPreferences(motStorage: SharedPreferences, mot: String) {
    motStorage.edit().putString("mot", mot).apply()
}