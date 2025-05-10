/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ec.edu.monster.controlador;

import ec.edu.monster.modelo.ConversionUnidadesCliCon_Monster_GR2_Modelo;
import ec.edu.monster.vista.ConversionUnidadesCliCon_Monster_GR2_Vista;
import java.io.IOException;
import java.util.Scanner;
import java.io.Console;

/**
 *
 * @author pspgo
 */
public class ConversionUnidadesCliCon_Monster_GR2_Controlador {
    private final ConversionUnidadesCliCon_Monster_GR2_Modelo model;
    private final ConversionUnidadesCliCon_Monster_GR2_Vista vista;
    private static final String USER = "monster";
    private static final String PASS = "gr2_2025";
    private static final Scanner scanner = new Scanner(System.in);

    public ConversionUnidadesCliCon_Monster_GR2_Controlador(ConversionUnidadesCliCon_Monster_GR2_Modelo model, ConversionUnidadesCliCon_Monster_GR2_Vista vista) {
        this.model = model;
        this.vista = vista;
    }

    public void iniciarAplicacion() {
        try {
            vista.limpiarPantalla();
            vista.mostrarLogo();
            vista.imagen();
            if (login()) {
                model.inicializarServicio();
                manejarMenu();
            }
        } catch (IOException e) {
            vista.mostrarError("Error de E/S: " + e.getMessage());
        }
    }

    private static boolean login() throws IOException {
        int intentos = 3;
        Console console = System.console();

        while (intentos > 0) {
            System.out.print("Usuario: ");
            String usuario = scanner.nextLine();

            System.out.print("Contraseña: ");
            String contrasena;
            
            if (console != null) {
                // En CMD de Windows, usar readPassword() para ocultar la entrada
                char[] passwordChars = console.readPassword();
                contrasena = new String(passwordChars);
            } else {
                // Fallback para entornos sin Console (como NetBeans)
                contrasena = leerContrasenaConAsteriscos();
            }

            if (usuario.equals(USER) && contrasena.equals(PASS)) {
                System.out.println("\n¡Acceso concedido!");
                return true;
            }

            intentos--;
            System.out.println("\nCredenciales incorrectas. Intentos restantes: " + intentos);
        }
        System.out.println("\nSistema bloqueado. Contacte al administrador.");
        return false;
    }

    
    private static String leerContrasenaConAsteriscos() {
        StringBuilder password = new StringBuilder();
        try {
            // Configuración para capturar teclas sin eco en Windows
            // Nota: esta solución usa System.in.read() que captura un byte a la vez
            int tecla;
            while ((tecla = System.in.read()) != -1) {
                // Enter (13 = CR en Windows, seguido por 10 = LF)
                if (tecla == 13 || tecla == 10) {
                    if (tecla == 13) {
                        // Consumir el LF que sigue al CR en Windows
                        System.in.read();
                    }
                    break;
                }
                
                // Backspace (8)
                if (tecla == 8) {
                    if (password.length() > 0) {
                        password.deleteCharAt(password.length() - 1);
                        // Borra el último asterisco (retroceso + espacio + retroceso)
                        System.out.print("\b \b");
                    }
                    continue;
                }
                
                // Caracteres normales (ignorar códigos de control)
                if (tecla >= 32 && tecla < 127) {
                    password.append((char) tecla);
                    System.out.print("*"); // Muestra un asterisco por cada carácter
                }
            }
            
            // Limpiar cualquier entrada adicional en el buffer
            while (System.in.available() > 0) {
                System.in.read();
            }
            
            System.out.println(); // Nueva línea después de terminar
        } catch (IOException e) {
            System.err.println("\nError al leer contraseña: " + e.getMessage());
        }
        return password.toString();
    }


    private void manejarMenu() {
        int opcion;
        do {
            vista.limpiarPantalla();
            vista.mostrarLogo();
            opcion = vista.mostrarMenu();
            
            switch (opcion) {
                case 1 -> convertirCentimetrosAPulgadas();
                case 2 -> convertirPulgadasACentimetros();
                case 3 -> vista.mostrarMensaje("\nSaliendo del sistema...");
                default -> vista.mostrarError("\nOpción no válida");
            }
        } while (opcion != 3);
        vista.mostrarMensajeContinuar();
    }

    private void convertirCentimetrosAPulgadas() {
        try {
            double cm = vista.getInputNumerico("\nIngrese los centímetros: ");
            double resultado = model.centimetrosAPulgadas(cm);
            vista.mostrarResultadoConversion(cm, resultado, "cm", "pulgadas");
            vista.mostrarMensajeContinuar();
        } catch (Exception e) {
            vista.mostrarErrorEntrada("Error en la conversión: " + e.getMessage());
        }
    }

    private void convertirPulgadasACentimetros() {
        try {
            double pulgadas = vista.getInputNumerico("\nIngrese las pulgadas: ");
            double resultado = model.pulgadasACentimetros(pulgadas);
            vista.mostrarResultadoConversion(pulgadas, resultado, "pulgadas", "cm");
            vista.mostrarMensajeContinuar();
        } catch (Exception e) {
            vista.mostrarErrorEntrada("Error en la conversión: " + e.getMessage());
        }
    }
    
}
