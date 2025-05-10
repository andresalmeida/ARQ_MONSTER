/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JFrame.java to edit this template
 */
package ec.edu.monster.vista;

import ec.edu.monster.controlador.CliEsc_ConvUniControlador_Monster_GR2;
import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.RenderingHints;
import javax.swing.JOptionPane;

/**
 *
 * @author joyta
 */
public class ConversionUnidadesCliCon_Monster_GR2 extends javax.swing.JFrame {

    /**
     * Creates new form ConversionUnidadesCliCon_Monster_GR2
     */
    private CliEsc_ConvUniControlador_Monster_GR2 convControlador;
    
    public ConversionUnidadesCliCon_Monster_GR2() {
        convControlador = new CliEsc_ConvUniControlador_Monster_GR2();
        initComponents();
        // Configurar btnCmaIn
        btnCmaIn = new javax.swing.JButton() {
            private Color hoverColor = new Color(56, 182, 255, 50);
            private Color pressedColor = new Color(56, 182, 255, 100);

            @Override
            protected void paintComponent(Graphics g) {
                Graphics2D g2 = (Graphics2D) g.create();
                g2.setRenderingHint(RenderingHints.KEY_ANTIALIASING, RenderingHints.VALUE_ANTIALIAS_ON);

                // Fondo transparente
                g2.setColor(new Color(0, 0, 0, 0));
                g2.fillRect(0, 0, getWidth(), getHeight());

                // Efectos de estado
                if (getModel().isPressed()) {
                    g2.setColor(pressedColor);
                    g2.fillRoundRect(0, 0, getWidth(), getHeight(), 25, 25);
                } else if (getModel().isRollover()) {
                    g2.setColor(hoverColor);
                    g2.fillRoundRect(0, 0, getWidth(), getHeight(), 25, 25);
                }

                // Borde
                g2.setColor(new Color(56, 182, 255));
                g2.drawRoundRect(0, 0, getWidth()-1, getHeight()-1, 25, 25);

                // Texto
                super.paintComponent(g2);
                g2.dispose();
            }
        };
        btnCmaIn.setText("CM a PUL");
        btnCmaIn.setFont(new java.awt.Font("Segoe UI", Font.BOLD, 14));
        btnCmaIn.setForeground(new Color(56, 182, 255));
        btnCmaIn.setContentAreaFilled(false);
        btnCmaIn.setBorderPainted(false);
        btnCmaIn.setFocusPainted(false);
        btnCmaIn.setOpaque(false);
        btnCmaIn.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseEntered(java.awt.event.MouseEvent evt) {
                btnCmaIn.setForeground(Color.WHITE);
            }
            public void mouseExited(java.awt.event.MouseEvent evt) {
                btnCmaIn.setForeground(new Color(56, 182, 255));
            }
        });

        // Configurar btnInaCm (mismo estilo)
        btnInaCm = new javax.swing.JButton() {
            private Color hoverColor = new Color(56, 182, 255, 50);
            private Color pressedColor = new Color(56, 182, 255, 100);

            @Override
            protected void paintComponent(Graphics g) {
                Graphics2D g2 = (Graphics2D) g.create();
                g2.setRenderingHint(RenderingHints.KEY_ANTIALIASING, RenderingHints.VALUE_ANTIALIAS_ON);

                // Fondo transparente
                g2.setColor(new Color(0, 0, 0, 0));
                g2.fillRect(0, 0, getWidth(), getHeight());

                // Efectos de estado
                if (getModel().isPressed()) {
                    g2.setColor(pressedColor);
                    g2.fillRoundRect(0, 0, getWidth(), getHeight(), 25, 25);
                } else if (getModel().isRollover()) {
                    g2.setColor(hoverColor);
                    g2.fillRoundRect(0, 0, getWidth(), getHeight(), 25, 25);
                }

                // Borde
                g2.setColor(new Color(56, 182, 255));
                g2.drawRoundRect(0, 0, getWidth()-1, getHeight()-1, 25, 25);

                // Texto
                super.paintComponent(g2);
                g2.dispose();
            }
        };
        btnInaCm.setText("PUL a CM");
        btnInaCm.setFont(new java.awt.Font("Segoe UI", Font.BOLD, 14));
        btnInaCm.setForeground(new Color(56, 182, 255));
        btnInaCm.setContentAreaFilled(false);
        btnInaCm.setBorderPainted(false);
        btnInaCm.setFocusPainted(false);
        btnInaCm.setOpaque(false);
        btnInaCm.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseEntered(java.awt.event.MouseEvent evt) {
                btnInaCm.setForeground(Color.WHITE);
            }
            public void mouseExited(java.awt.event.MouseEvent evt) {
                btnInaCm.setForeground(new Color(56, 182, 255));
            }
        });

        this.txtResultado.setEditable(false);
    }
    

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        txtResultado = new javax.swing.JTextField();
        txtNumero = new javax.swing.JTextField();
        btnCmaIn = new javax.swing.JButton();
        btnInaCm = new javax.swing.JButton();
        btnSalir = new javax.swing.JButton();
        jLabel2 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Conversor Monster GR2");
        setBackground(new java.awt.Color(204, 204, 204));
        setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        setFocusTraversalPolicyProvider(true);
        setName("JFrame"); // NOI18N
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jPanel1.setBackground(new java.awt.Color(255, 255, 255));
        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        txtResultado.setBackground(new java.awt.Color(166, 166, 166));
        txtResultado.setFont(new java.awt.Font("Tempus Sans ITC", 3, 48)); // NOI18N
        txtResultado.setForeground(new java.awt.Color(56, 182, 255));
        txtResultado.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtResultadoActionPerformed(evt);
            }
        });
        jPanel1.add(txtResultado, new org.netbeans.lib.awtextra.AbsoluteConstraints(340, 470, 800, 60));

        txtNumero.setFont(new java.awt.Font("Tempus Sans ITC", 3, 48)); // NOI18N
        txtNumero.setForeground(new java.awt.Color(56, 182, 255));
        txtNumero.setToolTipText("");
        txtNumero.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtNumeroActionPerformed(evt);
            }
        });
        jPanel1.add(txtNumero, new org.netbeans.lib.awtextra.AbsoluteConstraints(840, 350, 300, 50));

        btnCmaIn.setForeground(new java.awt.Color(0, 204, 255));
        btnCmaIn.setIcon(new javax.swing.ImageIcon(getClass().getResource("/ec/edu/monster/vista/boton1 (1).png"))); // NOI18N
        btnCmaIn.setText("jButton1");
        btnCmaIn.setBorder(null);
        btnCmaIn.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCmaInActionPerformed(evt);
            }
        });
        jPanel1.add(btnCmaIn, new org.netbeans.lib.awtextra.AbsoluteConstraints(80, 590, 380, 80));

        btnInaCm.setForeground(new java.awt.Color(0, 204, 255));
        btnInaCm.setIcon(new javax.swing.ImageIcon(getClass().getResource("/ec/edu/monster/vista/boton2 (1).png"))); // NOI18N
        btnInaCm.setText("jButton2");
        btnInaCm.setBorder(null);
        btnInaCm.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnInaCmActionPerformed(evt);
            }
        });
        jPanel1.add(btnInaCm, new org.netbeans.lib.awtextra.AbsoluteConstraints(620, 590, 380, 80));

        btnSalir.setForeground(new java.awt.Color(0, 204, 255));
        btnSalir.setIcon(new javax.swing.ImageIcon(getClass().getResource("/ec/edu/monster/vista/logout.png"))); // NOI18N
        btnSalir.setBorder(javax.swing.BorderFactory.createBevelBorder(javax.swing.border.BevelBorder.RAISED));
        btnSalir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSalirActionPerformed(evt);
            }
        });
        jPanel1.add(btnSalir, new org.netbeans.lib.awtextra.AbsoluteConstraints(1280, 140, 70, 70));

        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/ec/edu/monster/vista/menu (2) (1).png"))); // NOI18N
        jPanel1.add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, -10, 1600, 870));

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 1920, 1080));

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void txtNumeroActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtNumeroActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtNumeroActionPerformed

    private void txtResultadoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtResultadoActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtResultadoActionPerformed

    private void btnCmaInActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCmaInActionPerformed
        // TODO add your handling code here:
        realizarConversion();
    }//GEN-LAST:event_btnCmaInActionPerformed

    private void btnInaCmActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnInaCmActionPerformed
        // TODO add your handling code here:
        realizarConversionInversa();
    }//GEN-LAST:event_btnInaCmActionPerformed

    private void btnSalirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSalirActionPerformed
        // TODO add your handling code here:
        int confirm = JOptionPane.showConfirmDialog(
                this, 
                "¿Estás seguro de que deseas cerrar sesión?", 
                "Cerrar Sesión", 
                JOptionPane.YES_NO_OPTION
        );

        if (confirm == JOptionPane.YES_OPTION) {
            // Cerrar la ventana actual
            this.dispose();
            this.setVisible(false);
            LoginCliEsc_Monster_GR2 login = new LoginCliEsc_Monster_GR2();
            login.setVisible(true);
           //System.exit(0); // Salir del sistema
        }
        
    }//GEN-LAST:event_btnSalirActionPerformed

    private void realizarConversion() {
        try {
            String input = txtNumero.getText().trim();

            if(input.isEmpty()) {
                mostrarError("Debe ingresar un valor numérico");
                return;
            }

            double centimetros = Double.parseDouble(input);

            if(centimetros < 0) {
                mostrarError("No se permiten valores negativos");
                return;
            }
            double pulgadas = convControlador.convertirCentimetrosAPulgadas(centimetros);

            txtResultado.setText(String.format("%.2f" + " pulgadas", pulgadas));

        } catch(NumberFormatException ex) {
            mostrarError("Ingrese un valor numérico válido");
        } catch(Exception ex) {
            mostrarError("Error en el servicio: " + ex.getMessage());
        }
    }
    
    // Método auxiliar para conversión inversa (pulgadas a centímetros)
    private void realizarConversionInversa() {
        try {
            String input = txtNumero.getText().trim();

            if(input.isEmpty()) {
                mostrarError("Debe ingresar un valor numérico");
                return;
            }

            double pulgadas = Double.parseDouble(input);

            if(pulgadas < 0) {
                mostrarError("No se permiten valores negativos");
                return;
            }
            double centimetros = convControlador.convertirPulgadasACentimetros(pulgadas);

            txtResultado.setText(String.format("%.2f" + " centímetros", centimetros));

        } catch(NumberFormatException ex) {
            mostrarError("Ingrese un valor numérico válido");
        } catch(Exception ex) {
            mostrarError("Error en el servicio: " + ex.getMessage());
        }
    }

    // Método para mostrar errores
    private void mostrarError(String mensaje) {
        JOptionPane.showMessageDialog(this, 
                mensaje, 
                "Error", 
                JOptionPane.ERROR_MESSAGE);
        txtNumero.requestFocus();
        txtNumero.selectAll();
    }

    // Método para mostrar éxito
    private void mostrarMensajeExito(String mensaje) {
        JOptionPane.showMessageDialog(this, 
                mensaje, 
                "Éxito", 
                JOptionPane.INFORMATION_MESSAGE);
    }
    
    /**
     * @param args the command line arguments
     */

    // Variables declaration - do not modify//GEN-BEGIN:variables
    public javax.swing.JButton btnCmaIn;
    private javax.swing.JButton btnInaCm;
    private javax.swing.JButton btnSalir;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JTextField txtNumero;
    private javax.swing.JTextField txtResultado;
    // End of variables declaration//GEN-END:variables
}