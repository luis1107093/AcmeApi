# AcmeApi

## Breve descripción del proyecto.
Proyecto para la prueba tecnica Consultor BackEnd ASP.NET SETI

## Requisitos
Lenguaje de programación: C#
Framework utilizado: .NET Core
Herramientas necesarias: Visual Studio, Git

## *Uso*
Este proyecto expone una API REST para registrar un pedido y obtener la respuesta en formato JSON.

Para registrar un pedido, se debe hacer una petición POST a la siguiente URL:

***https://TU_DOMINIO/api/Pedido/RegistrarPedido***

La petición debe incluir en el cuerpo un objeto JSON con la siguiente estructura:

***{
		"numPedido": "75630275",
		"cantidadPedido": "1",
		"codigoEAN": "00110000765191002104587",
		"nombreProducto": "Armario INVAL",
		"numDocumento": "1113987400",
		"direccion": "CR 72B 45 12 APT 301"
	}***

El servidor recibirá el objeto JSON y lo transformará a un documento XML que será enviado a un servicio externo.(***https://run.mocky.io/v3/19217075-6d4e-4818-98bc-416d1feb7b84***) Luego, se obtendrá la respuesta del servicio externo en formato XML y se transformará a JSON para ser devuelta como respuesta a la petición original.

La respuesta tendrá la siguiente estructura:

***{"enviarPedidoRespuesta":{"codigoEnvio":"80375472","estado":"Entregado exitosamente al cliente"}}***

## Contribuciones
Este proyecto fue creado por Luis Ocampo, El dia 18/04/2023
