namespace AcmeApi.Models
{
    public class PeticionesWeb
    {

        public async Task<string> PeticionHttp(string xmlPedido)
        {
            string url = "https://run.mocky.io/v3/19217075-6d4e-4818-98bc-416d1feb7b84";
            string respuesta = "";
            using (HttpClient client = new HttpClient())
            {
                HttpContent content = new StringContent(xmlPedido, System.Text.Encoding.UTF8, "text/xml");

                HttpResponseMessage response = await client.PostAsync(url, content);

                respuesta = await response.Content.ReadAsStringAsync();
            }


            return respuesta;
        }
    }
}
