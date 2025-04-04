using System.ComponentModel.DataAnnotations;

namespace Mqtt_Api_Esp32.Models
{
    public class MqttConfigBroker
    {
        [Required(ErrorMessage ="Campo Vazio")]
        public string Host { get; set; } = null!;
        [Required(ErrorMessage = "Campo Vazio")]
        public int Port{ get; set; }
        [Required(ErrorMessage = "Campo Vazio")]
        public int keepalive { get; set; }
        [Required(ErrorMessage = "Campo Vazio")]
        public string clientId { get; set; } = null!;
    }
}
