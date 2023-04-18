using AcmeApi.Models.Clases;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace AcmeApi.Models
{
    public class JsonToXmlTransformer
    {


        public string TransformarToXml(Pedido pedido)
        {
            return $@"
                    <soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:env='http://WSDLs/EnvioPedidos/EnvioPedidosAcme'>
                        <soapenv:Header/>
                        <soapenv:Body>
                            <env:EnvioPedidoAcme>
                                <EnvioPedidoRequest>
                                    <pedido>{pedido.numPedido}</pedido>
                                    <Cantidad>{pedido.cantidadPedido}</Cantidad>
                                    <EAN>{pedido.codigoEAN}</EAN>
                                    <Producto>{pedido.nombreProducto}</Producto>
                                    <Cedula>{pedido.numDocumento}</Cedula>
                                    <Direccion>{pedido.direccion}</Direccion>
                                </EnvioPedidoRequest>
                            </env:EnvioPedidoAcme>
                        </soapenv:Body>
                    </soapenv:Envelope>";
        }

        public string TransformarToJson(string xml)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            XmlNode codigoNode = xmlDocument.SelectSingleNode("//Codigo");
            XmlNode mensajeNode = xmlDocument.SelectSingleNode("//Mensaje");

            var respuesta = new
            {
                enviarPedidoRespuesta = new
                {
                    codigoEnvio = codigoNode?.InnerText,
                    estado = mensajeNode?.InnerText
                }
            };

            string json = JsonConvert.SerializeObject(respuesta);

            return json;

        }
    }
}
