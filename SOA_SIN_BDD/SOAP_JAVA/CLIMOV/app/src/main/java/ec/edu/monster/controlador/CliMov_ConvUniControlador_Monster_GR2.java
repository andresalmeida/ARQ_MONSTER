package ec.edu.monster.controlador;

import ec.edu.monster.modelo.CliMov_ConvUniModelo_Monster_GR2;

public class CliMov_ConvUniControlador_Monster_GR2 {
    private CliMov_ConvUniModelo_Monster_GR2 modelo;

    public CliMov_ConvUniControlador_Monster_GR2() {
        modelo = new CliMov_ConvUniModelo_Monster_GR2();
    }

    public String convertirCentimetrosAPulgadas(double centimetros) {
        return modelo.convertirCentimetrosAPulgadas(centimetros);
    }

    public String convertirPulgadasACentimetros(double pulgadas) {
        return modelo.convertirPulgadasACentimetros(pulgadas);
    }
}