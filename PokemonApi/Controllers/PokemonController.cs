using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace PokemonApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
       
        
        [HttpGet]
        public ActionResult<List<Caracteristicas>> Get()
        {
            Caracteristicas caracteristicas = new Caracteristicas();
            
            string url = "https://pokeapi.co/api/v2/pokemon";
            try
            {
                
                using (var client = new HttpClient())
                {
                                       

                    var resposta = client.GetStringAsync(url);
                    resposta.Wait();

                    var retorno = JsonConvert.DeserializeObject<Caracteristicas[]>(resposta.Result);

                }


            }catch (Exception ex)
            {

            }
            


            return Ok(caracteristicas);

        }

        [HttpPost]
        public ActionResult<List<Caracteristicas>> Post([FromBody] Caracteristicas nome)
        {
            Caracteristicas caracteristicas = new Caracteristicas();

            string url = $"https://pokeapi.co/api/v2/pokemon/{nome.name}";
            try
            {

                using (var client = new HttpClient())
                {


                    var resposta = client.GetStringAsync(url);
                    resposta.Wait();
                    var retorno = JsonConvert.DeserializeObject<List<BaseEntity[]>>(resposta.Result);

                }


            }
            catch (Exception ex)
            {

            }

            return Ok(caracteristicas);

        }


       
    }
}