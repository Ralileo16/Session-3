package com.example.myapplication

import android.app.DatePickerDialog
import android.content.Intent
import android.os.Bundle
import android.text.Editable
import android.text.TextWatcher
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import com.example.myapplication.databinding.ActivityMainBinding
import com.google.android.material.snackbar.Snackbar
import java.util.Calendar


class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        val binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        var date: String = ""

        binding.buttonSubmit.setOnClickListener {
            if(binding.editTextFirstName.text.isNullOrEmpty() ||
                binding.editTextLastName.text.isNullOrEmpty() ||
                binding.editTextNumberCats.text.isNullOrEmpty() ||
                binding.editTextNumberDogs.text.isNullOrEmpty() ||
                date.isEmpty()) {
                Snackbar.make(binding.root, "Veuillez remplir les champs", Snackbar.LENGTH_SHORT).show()
            } else {
                startActivity(Intent(this, MainActivity2::class.java).apply {
                    putExtra("first", binding.editTextFirstName.text.toString())
                    putExtra("last", binding.editTextLastName.text.toString())
                    putExtra("cat", binding.editTextNumberCats.text.toString())
                    putExtra("dog", binding.editTextNumberDogs.text.toString())
                    putExtra("date", date)
                })
            }
        }

        binding.buttonClear.setOnClickListener {
            date = ""
            binding.editTextFirstName.setText("")
            binding.editTextLastName.setText("")
            binding.editTextNumberCats.setText("")
            binding.editTextNumberDogs.setText("")
            binding.buttonClear.isEnabled = false
        }

        binding.buttonBirthdate.setOnClickListener {
            val c = Calendar.getInstance()
            val year = c.get(Calendar.YEAR)
            val month = c.get(Calendar.MONTH)
            val day = c.get(Calendar.DAY_OF_MONTH)

            val datePickerDialog = DatePickerDialog(this,
                { _, yearPicked, monthOfYearPicked, dayOfMonthPicked ->
                    date = dayOfMonthPicked.toString() + "-" + (monthOfYearPicked + 1) + "-" + yearPicked
                },
                year,
                month,
                day
            )
            datePickerDialog.show()
        }

        binding.editTextFirstName.addTextChangedListener(object : TextWatcher {
            override fun afterTextChanged(s: Editable) {}
            override fun beforeTextChanged(
                s: CharSequence, start: Int,
                count: Int, after: Int
            ) {
            }

            override fun onTextChanged(
                s: CharSequence, start: Int,
                before: Int, count: Int
            ) {
                if (s.isNotEmpty()) binding.buttonClear.isEnabled = true
            }
        })
        binding.editTextLastName.addTextChangedListener(object : TextWatcher {
            override fun afterTextChanged(s: Editable) {}
            override fun beforeTextChanged(
                s: CharSequence, start: Int,
                count: Int, after: Int
            ) {
            }

            override fun onTextChanged(
                s: CharSequence, start: Int,
                before: Int, count: Int
            ) {
                if (s.isNotEmpty()) binding.buttonClear.isEnabled = true
            }
        })
        binding.editTextNumberCats.addTextChangedListener(object : TextWatcher {
            override fun afterTextChanged(s: Editable) {}
            override fun beforeTextChanged(
                s: CharSequence, start: Int,
                count: Int, after: Int
            ) {
            }

            override fun onTextChanged(
                s: CharSequence, start: Int,
                before: Int, count: Int
            ) {
                if (s.isNotEmpty()) binding.buttonClear.isEnabled = true
            }
        })
        binding.editTextNumberDogs.addTextChangedListener(object : TextWatcher {
            override fun afterTextChanged(s: Editable) {}
            override fun beforeTextChanged(
                s: CharSequence, start: Int,
                count: Int, after: Int
            ) {
            }

            override fun onTextChanged(
                s: CharSequence, start: Int,
                before: Int, count: Int
            ) {
                if (s.isNotEmpty()) binding.buttonClear.isEnabled = true
            }
        })
    }
}