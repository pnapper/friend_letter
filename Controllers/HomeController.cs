using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }
    [Route("/")]
    public ActionResult Hello()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient("Eric");
      myLetterVariable.SetSender("John");
      myLetterVariable.SetLocation("Buenos Aires");
      myLetterVariable.SetSouvenir("bombilla");
      return View(myLetterVariable);
    }
    [Route("/favorite_photos")]
    public ActionResult FavoritePhotos()
    {
      return View();
    }
    [Route("/greeting_card")]
    public ActionResult GreetingCard()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient(Request.Query["recipient"]);
      myLetterVariable.SetSender(Request.Query["sender"]);
      myLetterVariable.SetLocation(Request.Query["location"]);
      myLetterVariable.SetSouvenir(Request.Query["souvenir"]);
      return View("Hello", myLetterVariable);
    }
  }
}
