    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using octdaily_task_01_backend.Models;
    using System.Xml.Serialization;

    namespace octdaily_task_01_backend.Controllers
    {
        [Route("FormApi/")]
        [ApiController]
        public class ContactUsController : ControllerBase
        {
        [HttpGet]
        public int Get()
        {
            return 9999;
        }

        [HttpPost("ContactUs")]    
        public IActionResult Post([FromBody] ContactUs FormContactUsData) {

                try
                {
                    Console.WriteLine(FormContactUsData);
                    string msg = "Data Received Successfully!";
                    return Ok(new { message = msg });
                }
                catch (Exception ex){
                    Console.WriteLine(ex.Message);
                    return StatusCode(500,new {ex.Message});
                }
            }
        
            [HttpPost("ScheduleDemo")]
            public IActionResult Post([FromBody] ScheduleDemo scheduleDemoObj)
            {
                try
                {
                    Console.WriteLine(scheduleDemoObj);
                    return Ok(new { message = "Data received Successfulyy!" });

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return StatusCode(500, new { ex.Message });
                }
            }

        }
    }
    