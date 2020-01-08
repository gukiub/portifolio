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
		
		System.out.println("seu carro � um " + veiculo.getMarca());
		System.out.println("modelo: " + veiculo.getModelo());
		System.out.println("Placa: " + veiculo.getPlaca());
		System.out.println("seu carro �: " + veiculo.getCor());
		System.out.println("os kilemetros rodados s�o: " + veiculo.getKm());
		System.out.println("voc� possui " + veiculo.getLitrosCombustivel() + " litros de gasolina");
		System.out.println("voc� est� a " + veiculo.getVelocidade() + " km/h");
		System.out.println("o pre�o do veiculo �: " + veiculo.getPreco());
		veiculo.desligar();
	
	}

}
