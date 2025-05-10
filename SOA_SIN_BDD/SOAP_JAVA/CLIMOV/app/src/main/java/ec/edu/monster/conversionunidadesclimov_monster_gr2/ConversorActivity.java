package ec.edu.monster.conversionunidadesclimov_monster_gr2;

import android.content.DialogInterface;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ProgressBar;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import com.google.android.material.textfield.TextInputEditText;

import java.text.DecimalFormat;
import java.util.Locale;

import ec.edu.monster.controlador.CliMov_ConvUniControlador_Monster_GR2;
import ec.edu.monster.modelo.CliMov_ConvUniModelo_Monster_GR2;


public class ConversorActivity extends AppCompatActivity {

    private EditText txtValor;
    private TextView txtResult;
    private Button btncmP;
    private Button btnPcm;
    private Button btnSalir;
    private CliMov_ConvUniControlador_Monster_GR2 controlador;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_conversor);
        txtValor = findViewById(R.id.txtValor);
        txtResult = findViewById(R.id.txtResult);
        btncmP = findViewById(R.id.btncmP);
        btnPcm = findViewById(R.id.btnPcm);
        btnSalir = findViewById(R.id.btnSalir);
        controlador = new CliMov_ConvUniControlador_Monster_GR2();

        btncmP.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String centimetros = txtValor.getText().toString();
                if(!centimetros.isEmpty()){
                    new Thread(new Runnable() {
                        @Override
                        public void run() {
                            String resultado = controlador.convertirCentimetrosAPulgadas(Double.parseDouble(centimetros));
                            runOnUiThread(() -> {
                                if(resultado != null){
                                    // Convertir el String resultado a double
                                    double valorPulgadas = Double.parseDouble(resultado);

                                    // Formatear a 2 decimales
                                    String resultadoFormateado = String.format(Locale.US, "%.2f", valorPulgadas);
                                    txtResult.setText(resultadoFormateado + " pulgadas");
                                } else {
                                    Toast.makeText(ConversorActivity.this, "Error de conversión", Toast.LENGTH_SHORT).show();
                                }
                            });
                        }
                    }).start();
                } else {
                    Toast.makeText(ConversorActivity.this, "Ingrese un valor numérico", Toast.LENGTH_SHORT).show();
                }
            }
        });

        btnPcm.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String pulgadas = txtValor.getText().toString();
                if(!pulgadas.isEmpty()){
                    new Thread(new Runnable() {
                        @Override
                        public void run() {
                            String resultado = controlador.convertirPulgadasACentimetros(Double.parseDouble(pulgadas));
                            runOnUiThread(() -> {
                                if(resultado != null){
                                    double valorCentimetros = Double.parseDouble(resultado);

                                    // Formatear a 2 decimales
                                    String resultadoFormateado = String.format(Locale.US, "%.2f", valorCentimetros);
                                    txtResult.setText(resultadoFormateado + " centímetros");
                                } else {
                                    Toast.makeText(ConversorActivity.this, "Error de conversión", Toast.LENGTH_SHORT).show();
                                }
                            });
                        }
                    }).start();
                } else {
                    Toast.makeText(ConversorActivity.this, "Ingrese un valor numérico", Toast.LENGTH_SHORT).show();
                }

            }
        });

        btnSalir.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });

    }
}