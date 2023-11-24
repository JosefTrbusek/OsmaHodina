// See https://aka.ms/new-console-template for more information
using Hasicarna;

List<IUmiZapojitHadici> hasiciSHadici = new List<IUmiZapojitHadici>();
var hasiciSPilou = new List<IMuzeRezatStromy>();
HasicBezny jirka = new HasicBezny();
hasiciSHadici.Add(jirka);
//hasiciSPilou.Add(jirka); --nejde

HasicLepsi pepa = new HasicLepsi();
hasiciSHadici.Add(pepa);
hasiciSPilou.Add(pepa);

foreach(var hasic in hasiciSHadici)
{
    hasic.ZapojHadici(10);    
}

Console.ReadLine();



