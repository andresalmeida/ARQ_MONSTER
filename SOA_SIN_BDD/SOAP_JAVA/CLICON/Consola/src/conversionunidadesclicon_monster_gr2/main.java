/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package conversionunidadesclicon_monster_gr2;
import ec.edu.monster.controlador.ConversionUnidadesCliCon_Monster_GR2_Controlador;
import ec.edu.monster.modelo.ConversionUnidadesCliCon_Monster_GR2_Modelo;
import ec.edu.monster.vista.ConversionUnidadesCliCon_Monster_GR2_Vista;

/**
 *
 * @author pspgo
 */
public class main {
     public static void main(String[] args) {
        ConversionUnidadesCliCon_Monster_GR2_Modelo model = new ConversionUnidadesCliCon_Monster_GR2_Modelo();
        ConversionUnidadesCliCon_Monster_GR2_Vista vista = new ConversionUnidadesCliCon_Monster_GR2_Vista();
        ConversionUnidadesCliCon_Monster_GR2_Controlador controller = new ConversionUnidadesCliCon_Monster_GR2_Controlador(model, vista);
        
        controller.iniciarAplicacion();
    }
    
}
