using System;
using System.IO;
using IG.Csharp.Api.Client;
using IG.Csharp.Api.Client.Rest;
using IG.Csharp.Api.Client.Rest.Model;
using Newtonsoft.Json;

namespace Playground
{
    public class DownloadDataExample
    {
        private readonly IgRestApiClient _igClient;

        public DownloadDataExample()
        {
            var personalSettings = JsonConvert.DeserializeObject<PersonalSettings>(File.ReadAllText("personalSettings.json"));
            _igClient = new IgRestApiClient(
                personalSettings.AccountType, personalSettings.Username, personalSettings.Password, personalSettings.AppKey);
            _igClient.Authenticate();
        }
        public void Run()
        {
            var resolution = (Resolution)Enum.Parse(typeof(Resolution), "HOUR");
            var prices = _igClient.GetHistoricalPrices("CS.D.EURGBP.TODAY.IP", resolution,
                new DateTime(2022, 02, 05, 0, 0, 0, DateTimeKind.Utc), new DateTime(2022, 02, 10, 0, 0, 0, DateTimeKind.Utc));
            Console.WriteLine(prices);
        }
    }
}
