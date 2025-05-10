/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ec.edu.monster.modelo;

import ec.edu.monster.controlador.ConversionUnidades;
import ec.edu.monster.controlador.ConversionUnidades_Service;

/**
 *
 * @author joyta
 */
public class CliEsc_ConvUniModelo_Monster_GR2 {
    private ConversionUnidades_Service service;
    private ConversionUnidades port;
    
    public CliEsc_ConvUniModelo_Monster_GR2() {
        service = new ConversionUnidades_Service();
        port = service.getConversionUnidadesPort();
    }
    
    public double convCentimetroPulgada(double cm) {
        return port.centimetrosAPulgadas(cm);
    }

    public double convPulgadaCentimetro(double in) {
        return port.pulgadasACentimetros(in);
    }
}
