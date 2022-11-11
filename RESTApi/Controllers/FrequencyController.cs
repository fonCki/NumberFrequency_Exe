using ConsoleApp1;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace RESTApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FrequencyController : ControllerBase {


    [HttpPost]
    public async Task<ActionResult<Response>> GetFrequency([FromBody] int[] numbers) {
        Response response = new Response();
        response.Frequency = Tools.Solution(numbers);
        
        response.Number = new int[response.Frequency.Length];
        for (int i = 0; i < response.Frequency.Length; i++) {
            response.Number[i] = i;
        }
        return Ok(response);
    }
}