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
      return View("Hello", myLetterVariable);
    }
  }
}
