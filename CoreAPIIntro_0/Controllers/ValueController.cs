using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPIIntro_0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {

        static List<string> sehirler = new List<string>
        {
            "Istanbul","İzmir","Eskişehir","Ankara"
        };


        //HttpStatusCodes 
        //100  ile baslayan kodlar => Information
        //200 ile baslayan kodlar => Basarılı
        //300 ile baslayan kodlar => Redirection
        //400 ile baslayan kodlar => Client errors
        //500 ile baslayan kodlar => Server errors


        //Get => Kullanıcının yeni bir istegi (Request mevcut durumda alınan response(varsa) ondan bagımsız bir şekilde taze bir haldedir )

        //Post => Gelen Response'un tekrar server'a gönderilmesidir...API'da sadece Creation işlemleri icin kullanılması saglıklı olan HTTP request tipidir

        //Put => API'da Update işlemleri icin kullanacagımız HTTP request tipidir

        //Delete => API'da  Delete işlemleri icin kullanacagımız HTTP request tipidir






        [HttpGet]
        public IActionResult GetCityInfo()
        {
            return Ok(sehirler);
        }

        [HttpGet("Id")]
        public IActionResult GetCity(int id)
        {
            return Ok(sehirler[id]);
        }


        [HttpPost]
        public IActionResult AddCity(string item)
        {
            sehirler.Add(item);
            return Ok(sehirler);
        }

        [HttpDelete]
        public IActionResult DeleteCity(int id)
        {
            sehirler.Remove(sehirler[id]);
            return Ok(sehirler);
        }

        [HttpPut]
        public IActionResult UpdateCity(int id,string newValue)
        {
            sehirler[id] = newValue;
            return Ok(sehirler);
        }




       
    }
}
