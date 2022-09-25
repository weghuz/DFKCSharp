using DFK.API;
using DFK.W3;
using Nethereum.Web3.Accounts;

public class CSBot
{
    public readonly string KEYSTORE = $"{AppDomain.CurrentDomain.BaseDirectory}\\keystore.json";
    private Account account = null;
    public CSBot()
    {
        cmd.W("Welcome to C# bot CLI V1");
        cmd.W("-------------------------------------------------------------");
        string command = "";
        while (command != "exit")
        {
            cmd.W("Commands: setkey, runbot, query, help, exit");
            command = cmd.RN("Command: ");
            switch (command.ToLower().Trim())
            {
                case "setkey":
                    string password = cmd.RN("Password: ");
                    string encryptedKeyJson = Encrypt.CreateAccount(cmd.RN("Private Key: "), password);
                    account = Encrypt.GetAccount(password, encryptedKeyJson);
                    password = "";
                    File.WriteAllText(KEYSTORE, encryptedKeyJson);
                    break;
                case "getkey":
                    account = Encrypt.GetAccount(cmd.RN("Password: "), File.ReadAllText(KEYSTORE));
                    cmd.W(account.PrivateKey);
                    break;
                case "help":
                    cmd.W("Commands: list, help, run, exit");
                    break;
                case "query":
                    cmd.W("Query the DFK api!");
                    while (command != "back")
                    {
                        cmd.W("Commands: heroes, hero, back");
                        command = cmd.RN("Command: ");
                        switch (command)
                        {
                            case "heroes":
                                cmd.W("List for address");
                                cmd.W("Commands: All, Ids, Names");
                                command = cmd.RN("Command: ");
                                switch (command.ToLower().Trim())
                                {
                                    case "all":
                                        ListHeroesData().Wait();
                                        break;
                                    case "ids":
                                        ListHeroIds().Wait();
                                        break;
                                    default:
                                        ListHeroNames().Wait();
                                        break;
                                }
                                break;
                            case "hero":
                                GetHero().Wait();
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case "runbot":
                    Run().Wait();
                    break;
                default:
                    break;
            }
        }
    }

    public async Task GetHero()
    {
        string id = cmd.RN("Hero ID: ");
        var hero = await API.GetHero(id);
        cmd.W($"{hero.id}: {hero.FullName()}");
        cmd.W($"Profession: {hero.profession}");
        cmd.W($"Level: {hero.level}");
        cmd.W($"Stamina: {hero.StaminaCurrent()}/{hero.stamina}");
    }

    public async Task ListHeroesData()
    {
        Dictionary<HeroesArgument, string> args = new();
        args.Add(HeroesArgument.owner, cmd.RN("Address: "));
        var request = API.HeroesRequestBuilder(args);
        var heroes = await API.GetHeroes(request);
        foreach (Hero h in heroes)
        {
            cmd.W(h.ToString());
        }
    }

    public async Task ListHeroIds()
    {
        Dictionary<HeroesArgument, string> args = new();
        args.Add(HeroesArgument.owner, cmd.RN("Address: "));
        var request = API.HeroesRequestBuilder(args, "id");
        var heroes = await API.GetHeroes(request);
        foreach (Hero h in heroes)
        {
            cmd.W(h.id);
        }
    }

    public async Task ListHeroNames()
    {
        Dictionary<HeroesArgument, string> args = new();
        args.Add(HeroesArgument.owner, cmd.RN("Address: "));
        var request = API.HeroesRequestBuilder(args, "firstName lastName");
        var heroes = await API.GetHeroes(request);
        foreach (Hero h in heroes)
        {
            cmd.W(h.FullName());
        }
    }

    public async Task Run()
    {
        account = Encrypt.GetAccount(cmd.RN("Password: "), File.ReadAllText(KEYSTORE));
        await Task.Delay(1);
        return;
    }
}