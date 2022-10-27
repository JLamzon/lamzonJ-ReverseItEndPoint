//Jessie Lamzon
//10/26/22
//Reverse It End Point :  reverse a string, configured to complete Mini Challenge # 6
//Peer review: John Magpantay                      
//notes : Good job! clean code, works as intended, I like the added text of "Your number is:" and it shows the reveresed version. Good job overall! 

using Microsoft.AspNetCore.Mvc;

namespace lamzonJ_ReverseIt.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItController : ControllerBase
{
    [HttpGet]
    [Route("Reverse/{userPick}")]

    public string Reverse(string userPick)
    {
        char[] myString = userPick.ToCharArray();
        Array.Reverse(myString);
        string reversed = new string (myString);

        return ($"Your number is :{userPick}\nReversed is    :{reversed}");
    }
}
