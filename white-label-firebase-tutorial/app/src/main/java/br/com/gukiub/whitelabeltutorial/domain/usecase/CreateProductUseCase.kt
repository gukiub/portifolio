package br.com.gukiub.whitelabeltutorial.domain.usecase

import android.net.Uri
import br.com.gukiub.whitelabeltutorial.domain.model.Product

interface CreateProductUseCase {
    suspend operator fun invoke(description: String, price: Double, imageUri: Uri): Product
}