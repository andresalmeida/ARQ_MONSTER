package ec.edu.monster.conversionunidadesclimov_monster_gr2;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import ec.edu.monster.controlador.CliMov_UsuarioControlador_Monster_GR2;
import ec.edu.monster.modelo.CliMov_UsuarioModelo_Monster_GR2;

public class MainActivity extends AppCompatActivity {

    private EditText etUsuario, etPassword;
    private Button btnLogin, btnSalir;
    CliMov_UsuarioControlador_Monster_GR2 controlador;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        // Vincular elementos de la vista
        etUsuario = findViewById(R.id.txtUsuario);
        etPassword = findViewById(R.id.txtContrasenia);
        btnLogin = findViewById(R.id.btnLogin);
        btnSalir = findViewById(R.id.btnSalir);
        controlador = new CliMov_UsuarioControlador_Monster_GR2();

        // Configurar listeners de botones
        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String user = etUsuario.getText().toString();
                String pass = etPassword.getText().toString();
                // Validación de ingreso usando el controlador
                if (!user.isEmpty() && !pass.isEmpty()) {
                    new Thread(new Runnable() {
                        @Override
                        public void run() {
                            String resultado = controlador.validarIngreso(user, pass);
                            runOnUiThread(() -> {
                                if (resultado != null && resultado.equals("Exitoso")) { // Cambia "success" al valor real de éxito
                                    // Abre MainActivity
                                    Intent intent = new Intent(MainActivity.this, ConversorActivity.class);
                                    startActivity(intent);
                                } else {
                                    Toast.makeText(MainActivity.this, "Denegado", Toast.LENGTH_SHORT).show();
                                }
                            });
                        }
                    }).start();
                } else {
                    Toast.makeText(MainActivity.this, "Ingrese username y password", Toast.LENGTH_SHORT).show();
                }

            }
        });

        btnSalir.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish(); // Cierra la aplicación
            }
        });
    }
}