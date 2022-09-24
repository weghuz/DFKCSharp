using System.Net.Http.Json;
using System.Text;
using DFKAPI;
using Newtonsoft.Json;

public class CSBot
{
    public CSBot()
    {
        cmd.W("Welcome to C# bot CLI V1");
        cmd.W("-------------------------------------------------------------");
        cmd.W("Commands: gethero, listheroes, help, run, exit");
        string command = "";
        while (command != "exit")
        {
            command = cmd.RN("Command: ");
            switch (command.ToLower().Trim())
            {
                case "exit":
                    return;
                case "help":
                    cmd.W("Commands: gethero, listheroes, help, run, exit");
                    break;
                case "listheroes":
                    cmd.W(API.GetHeroesAddress(cmd.R("List for Address: ")).Result.FirstOrDefault().ToString());
                    break;
                case "gethero":
                    cmd.W(API.GetHero(cmd.RN("Hero ID: ")).Result.ToString());
                    break;
                case "run":
                    Run().Wait();
                    break;
            }
        }
    }

    public async Task Run()
    {
        return;
    }
}