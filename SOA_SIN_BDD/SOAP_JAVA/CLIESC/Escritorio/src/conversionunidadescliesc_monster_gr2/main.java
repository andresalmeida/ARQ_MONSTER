/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package conversionunidadescliesc_monster_gr2;


import ec.edu.monster.vista.LoginCliEsc_Monster_GR2;
import javax.swing.SwingUtilities;
/**
 *
 * @author pspgo
 */
public class main {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        /* Set Nimbus look and feel
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (Exception ex) {
            System.err.println("Error setting Nimbus look and feel: " + ex);
        }*/

        // Start the application with the Usuario_Vista for login
        SwingUtilities.invokeLater(() -> {
            LoginCliEsc_Monster_GR2 loginView = new LoginCliEsc_Monster_GR2();
            loginView.setVisible(true);
        });
        /*
        SwingUtilities.invokeLater(() -> {
            ConvUni_Vista conversor = new ConvUni_Vista();
            conversor.setVisible(true);
        });*/
    }
    
}
