using EasyAutomationFramework;
using TwoCaptcha;

const string link = "https://www.google.com/recaptcha/api2/demo";

var web = new Web();
web.StartBrowser();
web.Navigate(link);
web.WaitForLoad();

var catpcha_key = web.GetValue(TypeElement.Id, "recaptcha-demo").element.GetAttribute("data-sitekey");

var solver = new Solve();
var result = await solver.ReCaptchaV2Async(twoCaptchaKey: ReCaptcha.Key.API_KEY, catpcha_key, link);

web.ExecuteScript($"document.querySelector('#g-recaptcha-response').innerHTML = '{result.Request}';");
web.Click(TypeElement.Id, "recaptcha-demo-submit");