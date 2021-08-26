package br.com.gukiub.whitelabeltutorial.domain.usecase

import br.com.gukiub.whitelabeltutorial.data.ProductRepository
import br.com.gukiub.whitelabeltutorial.domain.model.Product

class GetProductUseCaseImpl(private val productRepository: ProductRepository) : GetProductsUseCase {
    override suspend fun invoke(): List<Product> {
        return productRepository.getProducts()
    }
}