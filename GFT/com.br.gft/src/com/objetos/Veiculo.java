package com.objetos;

public class Veiculo {
	private String marca;
	private String modelo;
	private String placa;
	private String cor;
	private float km;
	private boolean isLigado;
	private int litrosCombustivel;
	private int velocidade;
	private double preco;

	public Veiculo(String marca, String modelo, String placa, String cor, float km, boolean isLigado,
			int litrosCombustivel, int velocidade, double preco) {
		this.marca = marca;
		this.modelo = modelo;
		this.placa = placa;
		this.cor = cor;
		this.km = km;
		this.isLigado = isLigado;
		this.litrosCombustivel = litrosCombustivel;
		this.velocidade = velocidade;
		this.preco = preco;
	}

	public String getMarca() {
		return marca;
	}

	public void setMarca(String marca) {
		this.marca = marca;
	}

	public String getModelo() {
		return modelo;
	}

	public void setModelo(String modelo) {
		this.modelo = modelo;
	}

	public String getPlaca() {
		return placa;
	}

	public void setPlaca(String placa) {
		this.placa = placa;
	}

	public String getCor() {
		return cor;
	}

	public void setCor(String cor) {
		this.cor = cor;
	}

	public float getKm() {
		return km;
	}

	public void setKm(float km) {
		this.km = km;
	}

	public boolean isLigado() {
		return isLigado;
	}

	public void setLigado(boolean isLigado) {
		this.isLigado = isLigado;
	}

	public int getLitrosCombustivel() {
		return litrosCombustivel;
	}

	public void setLitrosCombustivel(int litrosCombustivel) {
		this.litrosCombustivel = litrosCombustivel;
	}

	public int getVelocidade() {
		return velocidade;
	}

	public void setVelocidade(int velocidade) {
		this.velocidade = velocidade;
	}

	public double getPreco() {
		return preco;
	}

	public void setPreco(double preco) {
		this.preco = preco;
	}

	public void acelerar() {
		if (this.isLigado == true) {
			velocidade += 20;
			litrosCombustivel -= 1;
		} else if (this.litrosCombustivel < 1) {
			System.out.println("impossivel acelerar");
		} else {
			System.out.println("o carro está desligado");
		}
	}

	public void abastecer(int qtdLitros) {
		if (this.litrosCombustivel >= 100) {
			System.out.println("Combustivel cheio");
		} 
		else {
			if(this.litrosCombustivel + qtdLitros >= 100) {
				System.out.println("abastecido 100%");
				this.litrosCombustivel = 100;
			}else {
				this.litrosCombustivel += qtdLitros;
			}
			
		}
	}
	
	public void frear() {
		if (this.isLigado == true && this.velocidade > 0) {
			this.velocidade -= 10;
		}
		else {
			System.out.println("o carro está desligado");
		}
	}
	
	public void pintar(String cor) {
		this.cor = cor;
	}
	
	public void ligar() {
		if (this.isLigado == true) {
			System.out.println("o carro já está ligado");
		}
		else {
			this.isLigado = true;
			System.out.println("você ligou o carro");
		}
	}
	
	public void desligar() {
		if (this.isLigado == false) {
			System.out.println("o carro já está desligado");
		}
		else {
			this.isLigado = false;
			System.out.println("você desligou o carro");
		}
	}
	
	
	
}
