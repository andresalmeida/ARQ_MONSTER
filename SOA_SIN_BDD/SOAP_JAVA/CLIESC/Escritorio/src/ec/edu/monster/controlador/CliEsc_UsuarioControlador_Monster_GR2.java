/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ec.edu.monster.controlador;

import ec.edu.monster.modelo.CliEsc_UsuarioModelo_Monster_GR2;

/**
 *
 * @author joyta
 */
public class CliEsc_UsuarioControlador_Monster_GR2 {
    
    private CliEsc_UsuarioModelo_Monster_GR2 modelo;
    
    public CliEsc_UsuarioControlador_Monster_GR2() {
        modelo = new CliEsc_UsuarioModelo_Monster_GR2();
    }

    public String validarIngreso(String usuario, String password) {
        if(usuario.equals("monster") || password.equals("gr2_2025")){
            return "Exitoso";
        }
        return "Fail";
    }
}
