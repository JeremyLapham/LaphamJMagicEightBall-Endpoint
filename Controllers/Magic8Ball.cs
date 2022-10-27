//Jeremy Lapham
//10-27-22
//Magic 8 Ball - Endpoint
//This program will have the user ask a question and then spiy out an answer for them
//Peer Review: 
using Microsoft.AspNetCore.Mvc;

namespace LaphamJMagicEightBall_Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class Magic8BallController : ControllerBase
{
    [HttpGet]
    [Route("Magic8/{question}")]

    public string Magic8Ball(string question)
    {
        string text = "";
        Random rndNum = new Random();
        int rndNum2 = rndNum.Next(1, 9);
        switch (rndNum2)
        {
            case 1: text = "Yes"; break;
            case 2: text = "No"; break;
            case 3: text = "Maybe"; break;
            case 4: text = "Absolutly"; break;
            case 5: text = "Perhaps"; break;
            case 6: text = "Ehh possibly"; break;
            case 7: text = "Nope Absolutly Not"; break;
            case 8: text = "Go for it"; break;
            case 9: text = "NO NO NO NO NO NO"; break;
        }
        return $"{question} \n {text}";
    }
}
