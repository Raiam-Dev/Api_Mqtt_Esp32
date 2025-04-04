using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mqtt_Api_Esp32.CallbacksMqtt;
using Mqtt_Api_Esp32.Models;
using MQTTnet;
using System.Reflection;

namespace Mqtt_Api_Esp32.Controller
{
    [Route("api/mqtt")]
    [ApiController]
    public class MqttController : ControllerBase
    {
        [Route("host-config")]
        [HttpPost]
        public async Task<IActionResult> ConfiguracaoMqtt([FromBody] MqttConfigBroker broker_conf) 
        {
            if (ModelState.IsValid)
            {
                MqttCallback mqttConnect = new 
                (
                    host:broker_conf.Host,
                    port:broker_conf.Port,
                    keepalive:broker_conf.keepalive,
                    clientId:broker_conf.clientId
                );
                bool retorno = await mqttConnect.connect();
                if(retorno == true){return Ok(new {sucess=true});}
                else{return Ok(new { sucess = true });}
            }
            else 
            {
                return NotFound("Error Json invalido");
            }
        }
    }
}
