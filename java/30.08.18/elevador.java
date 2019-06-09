class Elevador {
  private int Andar = 0;

  public void subir(int sobe){
   Andar = Andar+sobe;
   if (Andar >10){
     Andar = 10;
   }
  }

  public void descer(int desce){
    Andar = Andar-desce;
    if (Andar <-2){
      Andar = -2;
    }
  }
  public int getAndar(){
    return Andar;
  }

}