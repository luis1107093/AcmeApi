using AcmeApi.Models;
using AcmeApi.Models.Clases;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace AcmeApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        
        [HttpPost]
        public async Task<IActionResult> RegistrarPedido([FromBody] Pedido pedidoJson)
        {

            JsonToXmlTransformer xmlTransformer = new JsonToXmlTransformer();
            
            string xmlPedido = xmlTransformer.TransformarToXml(pedidoJson);

            PeticionesWeb petiiones = new PeticionesWeb();
            string response = await petiiones.PeticionHttp(xmlPedido);

            string respuestaJsonString = xmlTransformer.TransformarToJson(response);

            return Ok(respuestaJsonString);
        }


        
    }
}
