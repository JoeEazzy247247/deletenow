using AutoFixture;
using System.Net.Mail;


namespace deletenow.Support
{
    [Binding]
    public class Transform
    {
        [StepArgumentTransformation(@"(.*) email")]
        public string getDynamicEmail(string email) =>
            email.Split("@")[0]+ new Random().Next(1, 999) + "@" + GetRandomEmailDomain();

            private string GetRandomEmailDomain() =>
        new Fixture().Create<MailAddress>().Host;
    }
}
