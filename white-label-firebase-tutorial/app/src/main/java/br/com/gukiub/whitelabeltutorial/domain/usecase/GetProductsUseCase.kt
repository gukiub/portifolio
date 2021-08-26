package br.com.gukiub.whitelabeltutorial.domain.usecase

import br.com.gukiub.whitelabeltutorial.domain.model.Product

interface GetProductsUseCase {
    suspend operator fun invoke(): List<Product>
}