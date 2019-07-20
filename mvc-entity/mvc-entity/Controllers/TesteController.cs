using System.Web.Mvc;

namespace mvc_entity.Controllers
{
    [RoutePrefix("teste")]
    [Route("{action=ActionInicialCustomizada}")]
    public class TesteController : Controller
    {
        [Route("minharota/{id:int}")]
        public string UmaAction(int id)
        {
            return "Retorno da Rota teste";
        }

        [Route("~/rotaignorada/{id:int}")]
        public string UmaAction2(int id)
        {
            return "Rota ignorada";
        }
       
        public string ActionInicialCustomizada()
        {
            return "Rota principal Customizada";
        }


        [Route("rotarestritiva/{categoria:maxlength(3)}")]
        public string UmaAction3(string categoria)
        {
            return "Retorna rota se parametro for string com no max 3 caracteres!   " + categoria;
        }


        [Route("rotaalfanumerico/{categoria:alpha:minlength(3)}")]
        public string UmaAction4(string categoria)
        {
            return "Retorna rota se parametro for alfanumerico com no min 3 caracteres!   " + categoria;
        }
    }
}