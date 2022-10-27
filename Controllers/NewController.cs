/*
ARELY MARTINEZ 
OCT 25 2022, 10:51 AM 
SAY HELLO END POINT 
THIS PROGRAM WILL MAKE IT SO THAT THE 
USER CAN ENTER 10 INPUT DEPENDING ON 
WHATS ITS ASKING THEM. EXAMPLE A NOUN,
COLOR, ANIMAL, ETC.  AND IT REPSOND WITH
A SENTENCE WITH THIER INPUTS.

PEER REVIEW: Kenneth Fujimura -- What is there 
to say? Everything worked great. The MadLib was
very well organized and did everything it needed
to. All of the variables pointed in the right directions
that they needed to in order to populate the story 
accurately. The story itself as pretty cute too. All
in all, solid work. I also liked that the story 
outputted in capslocks so it was easy for me to
see where my words I inputted did. So great job,
keep up the good work Arely!
*/

using Microsoft.AspNetCore.Mvc;

namespace day2ApiInput.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{
    [HttpGet]
    [Route("Mad")]
    //localHost9000/Input/Name
    public string SayHello()
    {
        return "LETS CREATE A FUN STORY!! \nENTER A ADJECTIVE \nENTER A ANIMAL \nENTER A CAR \nENTER A CELEB \nENTER A COLOR \nENTER A FOOD \nENTER A HOBBY \nENTER A NAME \nENTER A RESTUARNT \nENTER A SPORT ";
    }

    [HttpGet]
    [Route("Mad/{adj}/{animal}/{car}/{celeb}/{color}/{food}/{hobby}/{name}/{restuarnt}/{sport}")]
    //localHost9000/Input/Name
    public string SayHello(string adj, string animal, string car, string celeb, string color, string food, string hobby, string name, string restuarnt, string sport)
    {
        return $"WHILE YOU WERE TAKING A BREAK FROM {sport} AND ABOUT TO DO YOUR FAV HOOBY OF {hobby} YOU SEE {celeb} ARRIVED IN A {color} {car}. AS IF THATS NOT {adj} ENOUGH YOU SEE UR BEST FRIEND {name} MUNCHING ON {food}. RIGHT NEXT TO HIM IS A RARE ONE OF A KIND {animal}. YOU GO UP TO {celeb} BECUASE YOU ARE HIS BIGGEST FAN AND END UP DINNING AT {restuarnt}";
    }
}