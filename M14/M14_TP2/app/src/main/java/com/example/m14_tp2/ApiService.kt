package com.example.m14_tp2

import retrofit2.Call
import retrofit2.http.GET


interface ApiService {
    @GET("currencyoverview?league=Necropolis&type=Currency")
    fun getCurrencies(): Call<CurrencyOverview>
}