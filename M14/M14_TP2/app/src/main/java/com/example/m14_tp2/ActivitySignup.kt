package com.example.m14_tp2

import android.content.SharedPreferences
import android.os.Bundle
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import com.example.m14_tp2.databinding.ActivitySignupBinding
import com.google.android.material.snackbar.Snackbar


class ActivitySignup : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        val binding = ActivitySignupBinding.inflate(layoutInflater)
        setContentView(binding.root)

        binding.buttonSignup.setOnClickListener {
            if (binding.editTextUsername.text.isNullOrEmpty() && binding.editTextPassword.text.isNullOrEmpty()) {
                Snackbar.make(binding.root, "Veuillez remplir les champs requis", Snackbar.LENGTH_SHORT).show()
                return@setOnClickListener
            }

            val sp = getSharedPreferences("accounts", MODE_PRIVATE)
            val credentials = sp.getStringSet("accounts", HashSet()) ?: HashSet()
            val newSet = HashSet<String>(credentials)
            val s = binding.editTextUsername.text.toString() + ";" + binding.editTextPassword.text.toString()

            if(!newSet.add(s)) {
                Snackbar.make(binding.root, "Un compte avec ce nom d'utilisateur existe déjà", Snackbar.LENGTH_SHORT).show()
                return@setOnClickListener
            }

            sp.edit().putStringSet("accounts",newSet).apply()

            this.finish()
        }
    }
}