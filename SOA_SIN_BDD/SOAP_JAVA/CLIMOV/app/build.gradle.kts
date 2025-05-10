plugins {
    alias(libs.plugins.android.application)
}

android {
    namespace = "ec.edu.monster.conversionunidadesclimov_monster_gr2"
    compileSdk = 35

    defaultConfig {
        applicationId = "ec.edu.monster.conversionunidadesclimov_monster_gr2"
        minSdk = 22
        targetSdk = 35
        versionCode = 1
        versionName = "1.0"

        testInstrumentationRunner = "androidx.test.runner.AndroidJUnitRunner"
    }

    buildTypes {
        release {
            isMinifyEnabled = false
            proguardFiles(
                getDefaultProguardFile("proguard-android-optimize.txt"),
                "proguard-rules.pro"
            )
        }
    }
    compileOptions {
        sourceCompatibility = JavaVersion.VERSION_11
        targetCompatibility = JavaVersion.VERSION_11
    }
}

dependencies {

    implementation(libs.appcompat)
    implementation(libs.material)
    implementation(libs.activity)
    implementation(libs.constraintlayout)

    // Para manejar XML
    implementation ("org.simpleframework:simple-xml:2.7.1")
    // Para realizar peticiones HTTP
    implementation ("com.squareup.okhttp3:okhttp:4.10.0")

    testImplementation(libs.junit)
    androidTestImplementation(libs.ext.junit)
    androidTestImplementation(libs.espresso.core)


}