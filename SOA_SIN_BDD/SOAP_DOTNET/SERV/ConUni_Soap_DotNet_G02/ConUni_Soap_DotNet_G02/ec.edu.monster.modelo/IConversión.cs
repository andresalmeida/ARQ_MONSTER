using System.ServiceModel;

namespace ConUni_Soap_DotNet_G02.ec.edu.monster.modelo
{
    [ServiceContract]
    public interface IConversión
    {
        [OperationContract]
        double CelsiusToFahrenheit(double celsius);
        [OperationContract]
        double FahrenheitToCelsius(double fahrenheit);
    }
}
