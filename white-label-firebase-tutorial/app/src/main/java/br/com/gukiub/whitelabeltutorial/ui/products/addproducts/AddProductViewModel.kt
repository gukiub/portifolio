package br.com.gukiub.whitelabeltutorial.ui.products.addproducts

import android.net.Uri
import android.util.Log
import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import br.com.douglasmotta.whitelabeltutorial.R
import br.com.gukiub.whitelabeltutorial.domain.usecase.CreateProductUseCase
import br.com.gukiub.whitelabeltutorial.util.fromCurrency
import kotlinx.coroutines.launch
import java.lang.Exception

class AddProductViewModel(
    private val createProductUseCase: CreateProductUseCase
) : ViewModel() {

    private val _imageUriErrorResId = MutableLiveData<Int>()
    val imageUriErrorResId: LiveData<Int> = _imageUriErrorResId

    private val _descriptionFieldErrorResId = MutableLiveData<Int?>()
    val descriptionFieldErrorResId: LiveData<Int?> = _descriptionFieldErrorResId

    private val _priceFieldErrorResId = MutableLiveData<Int?>()
    val priceFieldErrorResId: LiveData<Int?> = _priceFieldErrorResId

    private var isFormValid = false

    fun createProduct(description: String, price: String, imageUri: Uri?) = viewModelScope.launch {
        isFormValid = true

        _imageUriErrorResId.value = getDrawableResIdIfNull(imageUri)
        _descriptionFieldErrorResId.value = getErrorStringResIdIfEmpty(description)
        _priceFieldErrorResId.value = getErrorStringResIdIfEmpty(price)

        if (isFormValid) {
            try {
                val product = createProductUseCase(description, price.fromCurrency(), imageUri!!)
            } catch (e: Exception) {
                Log.d("CreateProduct", e.toString())
            }
        }
    }

    private fun getErrorStringResIdIfEmpty(value: String): Int? {
        return if (value.isEmpty()) {
            isFormValid = false
            R.string.add_product_field_error
        } else null
    }

    private fun getDrawableResIdIfNull(value: Uri?): Int {
        return if (value == null) {
            isFormValid = false
            R.drawable.background_product_image_error
        } else R.drawable.background_product_image
    }
}