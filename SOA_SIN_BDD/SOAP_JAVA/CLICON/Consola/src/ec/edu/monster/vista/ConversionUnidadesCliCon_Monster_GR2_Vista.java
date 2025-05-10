/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ec.edu.monster.vista;
import java.io.IOException;
import java.util.InputMismatchException;
import java.util.Scanner;
/**
 *
 * @author pspgo
 */
public class ConversionUnidadesCliCon_Monster_GR2_Vista {
    public static final String CELESTE = "\033[38;5;51m";
    public static final String RESET = "\033[0m";
    private final Scanner scanner;

    public ConversionUnidadesCliCon_Monster_GR2_Vista() {
        scanner = new Scanner(System.in);
    }

    public void mostrarLogo() {
        System.out.println(
            "\n" +
            "\033[38;5;51m███╗   ███╗ ██████╗ ███╗   ██╗███████╗████████╗███████╗██████╗     ██████╗ ██████╗ ██████╗\033[0m\n" +
            "\033[38;5;51m████╗ ████║██╔═══██╗████╗  ██║██╔════╝╚══██╔══╝██╔════╝██╔══██╗   ██╔════╝ ██╔══██╗╚═══██╗\033[0m\n" +
            "\033[38;5;51m██╔████╔██║██║   ██║██╔██╗ ██║███████╗   ██║   █████╗  ██████╔╝   ██║  ███╗██████╔╝  ███╔╝\033[0m\n" +
            "\033[38;5;51m██║╚██╔╝██║██║   ██║██║╚██╗██║╚════██║   ██║   ██╔══╝  ██╔══██╗   ██║   ██║██╔══██╗ ███╔╝\033[0m\n" +
            "\033[38;5;51m██║ ╚═╝ ██║╚██████╔╝██║ ╚████║███████║   ██║   ███████╗██║  ██║   ╚██████╔╝██║  ██║██████╗\033[0m\n" +
            "\033[38;5;51m╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚═════╝\033[0m\n"
        );
    }

    public void imagen() {
        System.out.println("\033[38;5;51mMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\033[0m\n" +
                            "\033[38;5;51mMMMMMMMMMWNXXXWMMMMMMMMMMMMMMMMMMMMMMNXXNWWMMMMMMM\033[0m\n" +
                            "\033[38;5;51mMMMMMMMX0O0Ox0WMMMMMMMMWNXK0XMMMMMMMMXkxO00XWMMMMM\033[0m\n" +
                            "\033[38;5;51mMMMMMW0dx0KOKWMMMWX000Okxdolk0O0NMMMMMNOxO0kONMMMM\033[0m\n" +
                            "\033[38;5;51mMMMMM0clxOkkKNN0kdlclodddddooollxOOkOKXkldkkdkNMMM\033[0m\n" +
                            "\033[38;5;51mMMMMWd,;lodddoc:;:cloooddddooooooolllollodddoo0MMM\033[0m\n" +
                            "\033[38;5;51mMMMMWO;.',;;;,;::::::ccodddoc:::::ccllllllcc:dXMMM\033[0m\n" +
                            "\033[38;5;51mMMMMMWOc.....';;,,,,,,;cddo:,,,,;;;;:::;,',cxXMMMM\033[0m\n" +
                            "\033[38;5;51mMMMMMMMNO:........','',cddoc;,',,'.',,;:;;dKWMMMMM\033[0m\n" +
                            "\033[38;5;51mMMMMMMMXx;',',,:odlccc:coddocccclddl;;:looxKWMMMMM\033[0m\n" +
                            "\033[38;5;51mMMMMMMNx,.,;;;:kXd'..ldooddoll'..cOXdldddlcoKWMMMM\033[0m\n" +
                            "\033[38;5;51mMMMMMMXx;';;;;:xKk:',ldoooooooc',l0Kxodddoco0WMMMM\033[0m\n" +
                            "\033[38;5;51mMMMMMNOc,,;:ccccoxxddolcccccclddxkkdodddddolkXWMMM\033[0m\n" +
                            "\033[38;5;51mMMMWXd,',;;coddolllc;,',;;;;;;;cloooddddddddccONMM\033[0m\n" +
                            "\033[38;5;51mMMMNx;,;;;:ldddddddo;'.',,,;;,;cdddddddddddxdcl0WM\033[0m\n" +
                            "\033[38;5;51mMMMXl,,;;;codddddddddolc:::coddddddddddddddddockWM\033[0m\n" +
                            "\033[38;5;51mMMWOc,;;;;cllloddddddddddddddddddddddolodddddddxXM\033[0m\n" +
                            "\033[38;5;51mMMXo,,,;;;:loolokxdddddddddddddddodkdloddddddllo0W\033[0m\n" +
                            "\033[38;5;51mMMXl'',,;;:ldddodolooloooooooooolloddddddddddl;cOW\033[0m\n" +
                            "\033[38;5;51mMMNx:,;;;;;coddddoolllllooollloooddxdddddodddocl0M\033[0m\n" +
                            "\033[38;5;51mMMMXo;;,,,;:codddddolllllllloooodddddddddoddoooOWM\033[0m\n" +
                            "\033[38;5;51mMMMNd,',;;;;:lddddddddddddddddddddddddddddddlco0MM\033[0m\n" +
                            "\033[38;5;51mMMMWO:,,;;;;;:cldddddddddddddddddddddddddddoc:dXMM\033[0m\n" +
                            "\033[38;5;51mMMMMNKkc,',;;;;:clolcldddddddddooooollllool:dOXWMM\033[0m\n" +
                            "\033[38;5;51mMMMMMMW0l;;,,,,;;;:;;:ccclllccc:::::;;::::lxXMMMMM\033[0m\n" +
                            "\033[38;5;51mMMMMMMMMWXOl;,',,,,,;;;;;;;;;;;;,,,;,',:lkXWMMMMMM\033[0m\n" +
                            "\033[38;5;51mMMMMMMMMMMMWKxllxd:;::;;;;;,,,::;:dOkoxKWMMMMMMMMM\033[0m\n" +
                            "\033[38;5;51mMMMMMMMMMMMMMMNNWWNKXKkl;;:ldOKXKNWMWWMMMMMMMMMMMM\033[0m\n" +
                            "\033[38;5;51mMMMMMMMMMMMMMMMMMMMMMMMN00KWMMMMMMMMMMMMMMMMMMMMMM\033[0m\n" +
                            "\033[38;5;51mMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\033[0m"); 
    }

    public void limpiarPantalla() {
        try {
            if (System.getProperty("os.name").toLowerCase().contains("win")) {
                new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
            } else {
                System.out.print("\033[H\033[2J");
                System.out.flush();
                Thread.sleep(50); // Pequeña pausa para mejor efecto visual
            }
        } catch (Exception e) {
            // Animación de limpieza alternativa
            for (int i = 0; i < 5; i++) {
                System.out.println("\n".repeat(0));
                try { Thread.sleep(50); } catch (InterruptedException ex) {}
            }
        }
    }
    
    // Método mejorado para obtener entrada numérica con validación
    public double getInputNumerico(String mensaje) {
        while (true) {
            try {
                System.out.print(CELESTE + mensaje + RESET);
                double valor = scanner.nextDouble();
                scanner.nextLine(); // Limpiar buffer

                if (valor < 0) {
                    mostrarErrorEntrada("No se permiten valores negativos");
                    continue; // Reiniciar el bucle
                }

                return valor;
            } catch (InputMismatchException e) {
                scanner.nextLine(); // Limpiar entrada inválida
                mostrarErrorEntrada("Debe ingresar un valor numérico válido");
            }
        }
    }

    // Nuevo método para errores de entrada
    public void mostrarErrorEntrada(String mensaje) {
        System.out.println("\033[91m" + "✖ Error: " + mensaje + RESET);
    }
    
    public void mostrarMensajeContinuar() {
        System.out.print(CELESTE + "\nPresione Enter para continuar..." + RESET);
        scanner.nextLine(); // Limpiar buffer anterior
    }

    public int mostrarMenu() {
        System.out.println(CELESTE +"\n=== MENÚ PRINCIPAL ==="+ RESET);
        System.out.println(CELESTE +"1. Convertir centímetros a pulgadas"+ RESET);
        System.out.println(CELESTE +"2. Convertir pulgadas a centímetros"+ RESET);
        System.out.println(CELESTE +"3. Salir"+ RESET);
        System.out.print(CELESTE +"Seleccione una opción: "+ RESET);
        return scanner.nextInt();
    }

    public void mostrarMensaje(String mensaje) {
        System.out.println(CELESTE + mensaje + RESET);
    }

    public void mostrarError(String mensaje) {
        System.out.println("\033[91m" + mensaje + RESET);
    }

    public void mostrarResultadoConversion(double valor, double resultado, String unidadOrigen, String unidadDestino) {
        System.out.printf(CELESTE + "\nResultado: %.2f %s = %.2f %s\n" + RESET, 
                        valor, unidadOrigen, resultado, unidadDestino);
    }
}
