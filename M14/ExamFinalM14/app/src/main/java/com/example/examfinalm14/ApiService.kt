package com.example.examfinalm14

import retrofit2.Call
import retrofit2.http.GET


interface ApiService {
    //https://strangerthings-quotes.vercel.app/api/quotes/10
    @GET("api/quotes/10")
    fun getQuotes(): Call<List<Quote>>
}