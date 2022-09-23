using System.Text;
using Newtonsoft.Json;

namespace DFKAPI
{
    public static class API
    {
        private static string GetArgument(Argument key, Dictionary<Argument, string> args)
        {
            KeyValuePair<Argument, string> pair = args.FirstOrDefault(pair => pair.Key == key);
            if (pair.Value is not null)
            {
                return $"{Enum.GetName(typeof(Argument), pair.Key)}:\"{pair.Value}\", ";
            }
            return "";
        }
        public static async Task<string> GetHeroesAddress(string address)
        {
            Dictionary<Argument, string> request = new();
            request.Add(Argument.owner, address);
            string query = API.requestBuilder(request);
            string heroes = await API.GetHeroes(query);
            return heroes;
        }

        public static async Task<string> GetHeroes(string request)
        {
            var data = new StringContent(request, Encoding.UTF8, "application/json");
            var response = await API.Client.PostAsync(API.URL, data);
            return await response.Content.ReadAsStringAsync();
        }

        public static string requestBuilder(Dictionary<Argument, string> args)
        {
            StringBuilder request = new();
            request.Append("{heroes(");
            request.Append(GetArgument(Argument.first, args));
            request.Append(GetArgument(Argument.orderBy, args));
            request.Append(GetArgument(Argument.first, args));
            request.Append("where: { ");
            request.Append(GetArgument(Argument.owner, args));
            request.Append(GetArgument(Argument.rarity, args));
            request.Append(GetArgument(Argument.active1, args));
            request.Append(GetArgument(Argument.active2, args));
            request.Append(GetArgument(Argument.passive1, args));
            request.Append(GetArgument(Argument.passive2, args));
            request.Append(GetArgument(Argument.strength, args));
            request.Append(GetArgument(Argument.dexterity, args));
            request.Append(GetArgument(Argument.agility, args));
            request.Append(GetArgument(Argument.vitality, args));
            request.Append(GetArgument(Argument.endurance, args));
            request.Append(GetArgument(Argument.intelligence, args));
            request.Append(GetArgument(Argument.wisdom, args));
            request.Append(GetArgument(Argument.luck, args));
            request.Append(GetArgument(Argument.mining, args));
            request.Append(GetArgument(Argument.gardening, args));
            request.Append(GetArgument(Argument.fishing, args));
            request.Append(GetArgument(Argument.foraging, args));
            request.Append("}) ");
            request.Append($"{{{HERO_FIELDS}}}}}");
            cmd.W(request.ToString());
            return JsonConvert.SerializeObject(
                new
                {
                    query = request.ToString()
                });
            // $"{{heroes(where: {{owner: \"0x7c28c3D867E324A7eEf25792817b93DB4f70bF9b\"}}){{{API.HERO_FIELDS}}}}}"
        }

        public static HttpClient Client = new();
        public static string URL = "https://defi-kingdoms-community-api-gateway-co06z8vi.uc.gateway.dev/graphql";
        public static string HERO_FIELDS = @"id numberId owner {id name} previousOwner {id name} creator {id name} statGenes visualGenes rarity shiny generation firstName lastName shinyStyle mainClass subClass summonedTime nextSummonTime summonerId { id } assistantId { id } summons maxSummons staminaFullAt hpFullAt mpFullAt level xp currentQuest sp status strength intelligence wisdom luck agility vitality endurance dexterity hp mp stamina strengthGrowthP intelligenceGrowthP wisdomGrowthP luckGrowthP agilityGrowthP vitalityGrowthP enduranceGrowthP dexterityGrowthP strengthGrowthS intelligenceGrowthS wisdomGrowthS luckGrowthS agilityGrowthS vitalityGrowthS enduranceGrowthS dexterityGrowthS hpSmGrowth hpRgGrowth hpLgGrowth mpSmGrowth mpRgGrowth mpLgGrowth mining gardening foraging fishing profession passive1 passive2 active1 active2 statBoost1 statBoost2 statsUnknown1 element statsUnknown2 gender headAppendage backAppendage background hairStyle hairColor visualUnknown1 eyeColor skinColor appendageColor backAppendageColor visualUnknown2 assistingAuction {id} assistingPrice saleAuction {id} salePrice privateAuctionProfile {id} summonsRemaining pjStatus pjLevel pjOwner {id} pjClaimStamp network originRealm";
    }
}