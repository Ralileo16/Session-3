package com.example.m14_tp2

import android.content.Intent
import android.os.Bundle
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.m14_tp2.databinding.ActivityLoginBinding
import com.google.android.material.snackbar.Snackbar
import java.util.Currency

class ActivityLogin : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        val binding = ActivityLoginBinding.inflate(layoutInflater)
        setContentView(binding.root)

        binding.buttonLogin.setOnClickListener() {
            if (binding.editTextUsername.text.isNullOrEmpty() && binding.editTextPassword.text.isNullOrEmpty()) {
                Snackbar.make(binding.root, "Veuillez remplir les champs requis", Snackbar.LENGTH_SHORT).show()
                return@setOnClickListener
            }

            val sp = getSharedPreferences("accounts", MODE_PRIVATE)
            val credentials = sp.getStringSet("accounts", HashSet()) ?: HashSet()
            val s = binding.editTextUsername.text.toString() + ";" + binding.editTextPassword.text.toString()

            if (!credentials.contains(s)) {
                Snackbar.make(binding.root, "Veuillez vérifier les informations saisis", Snackbar.LENGTH_SHORT).show()
                return@setOnClickListener
            }
            startActivity(Intent(this,ActivityCurrency::class.java))
        }
    }
}