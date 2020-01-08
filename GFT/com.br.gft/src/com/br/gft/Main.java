package com.br.gft;

import com.objetos.Veiculo;

public class Main {

	public static void main(String[] args) {
		Veiculo veiculo = new Veiculo("mitsubish", "lancer", "gat3199", "vermelho", 200, false, 8, 0, 500000.89 );
		veiculo.ligar();
		veiculo.acelerar();
		veiculo.frear();
		veiculo.abastecer(100);
		veiculo.pintar("amarelo");
		
		System.out.println("seu carro é um " + veiculo.getMarca());
		System.out.println("modelo: " + veiculo.getModelo());
		System.out.println("Placa: " + veiculo.getPlaca());
		System.out.println("seu carro é: " + veiculo.getCor());
		System.out.println("os kilemetros rodados são: " + veiculo.getKm());
		System.out.println("você possui " + veiculo.getLitrosCombustivel() + " litros de gasolina");
		System.out.println("você está a " + veiculo.getVelocidade() + " km/h");
		System.out.println("o preço do veiculo é: " + veiculo.getPreco());
		veiculo.desligar();
	
	}

}
