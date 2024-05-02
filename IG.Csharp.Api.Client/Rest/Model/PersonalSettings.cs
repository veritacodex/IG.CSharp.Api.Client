using Newtonsoft.Json;

namespace IG.Csharp.Api.Client.Rest.Model
{
    public class PersonalSettings
    {
        public string AccountType { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string AppKey { get; set; }
    }
}