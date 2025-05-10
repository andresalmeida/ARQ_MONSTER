package ec.edu.monster.controlador;

import ec.edu.monster.modelo.CliMov_UsuarioModelo_Monster_GR2;

public class CliMov_UsuarioControlador_Monster_GR2 {
    private CliMov_UsuarioModelo_Monster_GR2 modelo;
    public CliMov_UsuarioControlador_Monster_GR2(){
        modelo = new CliMov_UsuarioModelo_Monster_GR2();
    }
    public String validarIngreso(String usuario, String password) {
        if(usuario.equals("monster") || password.equals("gr2_2025")){
            return "Exitoso";
        }
        return "Fail";
    }
}
