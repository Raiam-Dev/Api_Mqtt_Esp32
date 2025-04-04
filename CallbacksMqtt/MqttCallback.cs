using MQTTnet;
using System.Threading.Tasks;
namespace Mqtt_Api_Esp32.CallbacksMqtt
{
    public class MqttCallback
    {
        public MqttCallback(string host, int port, int keepalive, string clientId){}

        public async Task<bool> connect()
        {
            int erro = 0;
            await Task.Delay(1000);
            if (erro == 0){return true;}
            else { return false; }
            
        }
        
    }
}
