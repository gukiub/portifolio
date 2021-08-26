package br.com.gukiub.whitelabeltutorial.data.di

import br.com.gukiub.whitelabeltutorial.data.FirebaseProductDataSource
import br.com.gukiub.whitelabeltutorial.data.ProductDataSource
import dagger.Binds
import dagger.Module
import dagger.hilt.InstallIn
import dagger.hilt.components.SingletonComponent
import javax.inject.Singleton

@Module
@InstallIn(SingletonComponent::class)
interface DataSourceModule {

    @Singleton
    @Binds
    fun bindProductDataSource(dataSource: FirebaseProductDataSource): ProductDataSource
}