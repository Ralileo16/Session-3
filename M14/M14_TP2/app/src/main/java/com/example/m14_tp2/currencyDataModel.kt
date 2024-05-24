package com.example.m14_tp2

import com.google.gson.annotations.SerializedName

data class CurrencyOverview(
    @SerializedName("lines") val lines: List<Currency>,
    @SerializedName("currencyDetails") val currencyDetails: List<CurrencyDetails>
)

data class Currency(
    @SerializedName("currencyTypeName") val currencyTypeName: String,
    @SerializedName("chaosEquivalent") val chaosEquivalent: Double,
    @SerializedName("detailsId") val detailsId: String
)

data class CurrencyDetails(
    @SerializedName("id") val id: Int,
    @SerializedName("icon") val icon: String,
    @SerializedName("name") val name: String,
    @SerializedName("tradeId") val tradeId: String,
)
