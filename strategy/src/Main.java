import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws Exception {
        
        Contexto contexto = new Contexto();

        Scanner scanner = new Scanner(System.in);

        System.out.println("Digite sua situacao:\n");
        System.out.println("1 - Liso");
        System.out.println("2 - Apressado");
        System.out.println("3 - Querendo economizar");
        System.out.println();

        int situacao = scanner.nextInt();

        switch(situacao){

            case 1:

            contexto.setEstrategia(new Andando());

            break;

            case 2:

            contexto.setEstrategia(new Carro());

            break;

            case 3:

            contexto.setEstrategia(new Onibus());

            break;
            
        }

        String resultado = contexto.executarEstrategia();

        System.out.print("\n" + resultado);
        System.out.println();

    }

}
