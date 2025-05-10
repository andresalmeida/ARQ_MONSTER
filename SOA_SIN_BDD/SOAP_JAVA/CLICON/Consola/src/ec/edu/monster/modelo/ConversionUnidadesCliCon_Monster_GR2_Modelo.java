/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ec.edu.monster.modelo;
import ec.edu.monster.controlador.ConversionUnidades;
import ec.edu.monster.controlador.ConversionUnidades_Service;

/**
 *
 * @author pspgo
 */
public class ConversionUnidadesCliCon_Monster_GR2_Modelo {
    private ConversionUnidades port;
    
    public void inicializarServicio() {
        ConversionUnidades_Service service = new ConversionUnidades_Service();
        port = service.getConversionUnidadesPort();
    }
    
    public double centimetrosAPulgadas(double cm) {
        return port.centimetrosAPulgadas(cm);
    }
    
    public double pulgadasACentimetros(double pulgadas) {
        return port.pulgadasACentimetros(pulgadas);
    }
    
}
