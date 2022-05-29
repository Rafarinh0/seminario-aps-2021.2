public class Contexto {
    
    private Strategy estrategia;
    
    public void setEstrategia(Strategy estrategia){

        this.estrategia = estrategia;

    }

    public String executarEstrategia(){

        return estrategia.meioDeTransporte();

    }

}
