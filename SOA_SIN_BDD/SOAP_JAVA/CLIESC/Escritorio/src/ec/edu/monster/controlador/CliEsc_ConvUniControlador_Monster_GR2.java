/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ec.edu.monster.controlador;

import ec.edu.monster.modelo.CliEsc_ConvUniModelo_Monster_GR2;

/**
 *
 * @author joyta
 */
public class CliEsc_ConvUniControlador_Monster_GR2 {
   
    private CliEsc_ConvUniModelo_Monster_GR2 modelo;
    
    public CliEsc_ConvUniControlador_Monster_GR2() {
        modelo = new CliEsc_ConvUniModelo_Monster_GR2();
    }

    public double convertirCentimetrosAPulgadas(double cm) {
        return modelo.convCentimetroPulgada(cm);
    }

    public double convertirPulgadasACentimetros(double in) {
        return modelo.convPulgadaCentimetro(in);
    }
}
