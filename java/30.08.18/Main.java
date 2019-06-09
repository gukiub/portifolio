class Main {
  public static void main(String[] args) throws java.lang.Exception {
    Elevador Elevador1 = new Elevador();
    Elevador ElevadorSocial = new Elevador();
    Elevador1.subir(6);
    Elevador1.subir(8);
    Elevador1.descer(2);
    ElevadorSocial.subir(3);
    ElevadorSocial.descer(10);
    ElevadorSocial.subir(2);
    //Elevador1.andar=9;
    System.out.println("Andar elevador1: " + Elevador1.getAndar());
    System.out.println("Andar Social: " + ElevadorSocial.getAndar());
  }
}
